using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http.Headers;
using System.Text;
using AlbumJsonUpdater;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AlbumCleanerLibrary
{
    public static class AlbumCleaner
    {
        public static async Task CleanUpAsync(
            IAlbumRepository albumRepository,
            ISpotifyService spotifyService
        )
        {
            if (albumRepository == null)
                throw new ArgumentNullException(nameof(albumRepository));
            if (spotifyService == null)
                throw new ArgumentNullException(nameof(spotifyService));

            var albums = albumRepository.ReadAlbums();
            var cleanedAlbums = new List<Album>();

            foreach (var album in albums)
            {
                var cleanedAlbum = await CleanAlbumAsync(album, spotifyService);
                cleanedAlbums.Add(cleanedAlbum);
            }

            albumRepository.WriteAlbums(cleanedAlbums);
        }

        private static async Task<Album> CleanAlbumAsync(
            Album album,
            ISpotifyService spotifyService
        )
        {
            var cleanedAlbum = new Album
            {
                album = album.album,
                artist = album.artist,
                label = album.label,
                year = album.year,
                rank = album.rank,
                chosenBefore = album.chosenBefore,
                youTubeLink = album.youTubeLink,
                spotifyLink = album.spotifyLink,
            };

            if (cleanedAlbum.youTubeLink == "https://www.youtube.com/watch?v=")
            {
                cleanedAlbum.youTubeLink = string.Empty;
                cleanedAlbum.chosenBefore = false;
            }

            if (string.IsNullOrEmpty(cleanedAlbum.spotifyLink))
            {
                try
                {
                    cleanedAlbum.spotifyLink = await spotifyService.GetSpotifyLinkAsync(
                        cleanedAlbum.album
                    );
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error fetching Spotify link: {ex.Message}");
                }
            }

            return cleanedAlbum;
        }
    }

    public static class AlbumStatistics
    {
        public static int CountInvalidYouTubeLinks(List<Album> albums)
        {
            var count = 0;
            foreach (var album in albums)
            {
                if (
                    string.IsNullOrEmpty(album.youTubeLink)
                    || album.youTubeLink == "https://www.youtube.com/watch?v="
                )
                {
                    count++;
                }
            }
            return count;
        }

        public static void DisplayAlbumStatistics(List<Album> albums)
        {
            var invalidYouTubeLinkCount = CountInvalidYouTubeLinks(albums);
            Console.WriteLine($"Albums without a valid YouTube link: {invalidYouTubeLinkCount}");
        }
    }

    public class SpotifyService : ISpotifyService
    {
        private const string ClientId = "8ccefa031b2944eca468232a158e9bcf";
        private const string ClientSecret = "7b066ee2e2324b6aa8456414fbc67d8f";

        public async Task<string> GetSpotifyLinkAsync(string albumQuery)
        {
            var token = await GetOAuthTokenAsync();
            if (string.IsNullOrEmpty(token))
            {
                return string.Empty;
            }

            var url =
                $"https://api.spotify.com/v1/search?q={Uri.EscapeDataString(albumQuery)}&type=album&limit=1";

            using var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
                "Bearer",
                token
            );

            var response = await client.GetAsync(url);
            if (!response.IsSuccessStatusCode)
            {
                Console.WriteLine($"Error: {response.StatusCode}");
                return string.Empty;
            }

            var jsonResponse = await response.Content.ReadAsStringAsync();
            var jsonResult = JObject.Parse(jsonResponse);

            var album = jsonResult["albums"]?["items"]?.First;
            if (album == null)
            {
                Console.WriteLine("No results found.");
                return string.Empty;
            }

            var spotifyLink = album["external_urls"]?["spotify"]?.ToString();
            return spotifyLink ?? string.Empty;
        }

        private async Task<string> GetOAuthTokenAsync()
        {
            var url = "https://accounts.spotify.com/api/token";
            var credentials = Convert.ToBase64String(
                Encoding.UTF8.GetBytes($"{ClientId}:{ClientSecret}")
            );

            using var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
                "Basic",
                credentials
            );

            var request = new HttpRequestMessage(HttpMethod.Post, url)
            {
                Content = new StringContent(
                    "grant_type=client_credentials",
                    Encoding.UTF8,
                    "application/x-www-form-urlencoded"
                ),
            };

            var response = await client.SendAsync(request);
            if (!response.IsSuccessStatusCode)
            {
                Console.WriteLine($"Error: {response.StatusCode}");
                return string.Empty;
            }

            var jsonResponse = await response.Content.ReadAsStringAsync();
            var jsonResult = JObject.Parse(jsonResponse);

            return jsonResult["access_token"]?.ToString() ?? string.Empty;
        }
    }

    public interface ISpotifyService
    {
        Task<string> GetSpotifyLinkAsync(string albumQuery);
    }

    public interface IAlbumRepository
    {
        List<Album> ReadAlbums();
        void WriteAlbums(List<Album> albums);
        void WriteAlbum(Album updatedAlbum);
    }
}
