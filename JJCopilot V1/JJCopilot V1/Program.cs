using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using AlbumCleanerLibrary;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static AlbumCleanerLibrary.AlbumCleaner;

namespace AlbumJsonUpdater
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            string jsonFilePath =
                @"C:\Users\Ryan\OneDrive\Desktop\Programming\JJCopilot V1\JJCopilot V1\Albums.json";
            IAlbumRepository albumRepository = new JsonAlbumRepository(jsonFilePath);
            IYouTubeService youTubeService = new YouTubeService();
            ISpotifyService spotifyService = new SpotifyService();

            List<Album> albums = albumRepository.ReadAlbums();

            while (true)
            {
                Console.Write(
                    " *** Welcome to Joshy's Jukebox *** \n\n(A) Choose an album \n(B) Clean the library \n(C) Add new albums \n(D) Validate YouTube links (ETA 3mins) \n(E) Find all Spotify links \n\nPlease choose (A, B, C, D, or E): "
                );
                string input = Console.ReadLine()?.ToLower();

                if (input == "a")
                {
                    await HandleChooseAlbumOption(
                        albums,
                        albumRepository,
                        youTubeService,
                        spotifyService
                    );
                }
                else if (input == "b")
                {
                    HandleCleanLibraryOption(albumRepository);
                }
                else if (input == "c")
                {
                    HandleAddNewAlbumsOption(albumRepository);
                }
                else if (input == "d")
                {
                    await HandleValidateYouTubeLinksOption(albums, albumRepository, youTubeService);
                }
                else if (input == "e")
                {
                    await HandleFindAllSpotifyLinksOption(albums, albumRepository, spotifyService);
                }
                else
                {
                    break;
                }
            }
        }

        private static async Task HandleChooseAlbumOption(
            List<Album> albums,
            IAlbumRepository albumRepository,
            IYouTubeService youTubeService,
            ISpotifyService spotifyService
        )
        {
            Album randomAlbum = GetRandomUnchosenAlbum(albums);

            if (randomAlbum != null)
            {
                DisplayAlbumInfo(randomAlbum);
                randomAlbum.chosenBefore = true;

                if (string.IsNullOrEmpty(randomAlbum.youTubeLink))
                {
                    string youTubeAlbumSearch =
                        $"{randomAlbum.album} by {randomAlbum.artist} Full Album HD {randomAlbum.year} {randomAlbum.label}";
                    randomAlbum.youTubeLink = await youTubeService.GetYouTubeLinkAsync(
                        youTubeAlbumSearch
                    );
                    Console.WriteLine("\nYouTube link updated and written back to the JSON file.");
                }
                else
                {
                    Console.Write("\nYouTube link already present: ");
                }

                if (string.IsNullOrEmpty(randomAlbum.spotifyLink))
                {
                    string spotifyAlbumSearch =
                        $"{randomAlbum.album} by {randomAlbum.artist} {randomAlbum.year} {randomAlbum.label}";
                    randomAlbum.spotifyLink = await spotifyService.GetSpotifyLinkAsync(
                        spotifyAlbumSearch
                    );
                    Console.WriteLine("\nSpotify link updated and written back to the JSON file.");
                }
                else
                {
                    Console.Write("\nSpotify link already present: ");
                }

                albumRepository.WriteAlbum(randomAlbum);

                Console.WriteLine($"\nYouTube: {randomAlbum.youTubeLink}");
                Console.WriteLine($"\nSpotify: {randomAlbum.spotifyLink}");

                Console.Write("\nOpen the Album in YouTube? (Y or N): ");
                if (Console.ReadLine()?.ToLower() == "y")
                {
                    OpenYouTubeLink(randomAlbum.youTubeLink);
                }

                Console.Write("\nOpen the Album in Spotify? (Y or N): ");
                if (Console.ReadLine()?.ToLower() == "y")
                {
                    OpenSpotifyLink(randomAlbum.spotifyLink);
                }
            }
            else
            {
                Console.WriteLine("No unchosen albums available.");
            }
        }

        private static void HandleCleanLibraryOption(IAlbumRepository albumRepository)
        {
            Console.Clear();
            Console.WriteLine("Cleaning the library...\n");
            AlbumStatistics.DisplayAlbumStatistics(albumRepository.ReadAlbums());
            Console.WriteLine("\nLibrary cleaned. \n\nPress any key to continue");
            Console.ReadKey();
            Console.Clear();
        }

        private static void HandleAddNewAlbumsOption(IAlbumRepository albumRepository)
        {
            List<Album> newAlbums = GetNewAlbumsFromUser();
            List<Album> existingAlbums = albumRepository.ReadAlbums();

            foreach (var newAlbum in newAlbums)
            {
                if (!IsDuplicateAlbum(existingAlbums, newAlbum))
                {
                    existingAlbums.Add(newAlbum);
                }
                else
                {
                    Console.WriteLine(
                        $"Duplicate album found: {newAlbum.album} by {newAlbum.artist}. Skipping addition."
                    );
                }
            }

            albumRepository.WriteAlbums(existingAlbums);
            Console.WriteLine("New albums added to the JSON file.");
        }

        private static bool IsDuplicateAlbum(List<Album> existingAlbums, Album newAlbum)
        {
            return existingAlbums.Any(album =>
                album.album.Equals(newAlbum.album, StringComparison.OrdinalIgnoreCase)
                && album.artist.Equals(newAlbum.artist, StringComparison.OrdinalIgnoreCase)
            );
        }

        private static async Task HandleValidateYouTubeLinksOption(
            List<Album> albums,
            IAlbumRepository albumRepository,
            IYouTubeService youTubeService
        )
        {
            Console.WriteLine("Validating YouTube links...");
            foreach (var album in albums)
            {
                if (
                    !string.IsNullOrEmpty(album.youTubeLink)
                    && album.youTubeLink != "https://www.youtube.com/watch?v="
                )
                {
                    bool isValid = await youTubeService.ValidateYouTubeLinkAsync(album.youTubeLink);
                    if (!isValid)
                    {
                        Console.WriteLine(
                            $"Invalid YouTube link for album: {album.album} by {album.artist}"
                        );
                        album.youTubeLink = string.Empty;
                    }
                }
            }
            albumRepository.WriteAlbums(albums);
            Console.WriteLine("YouTube links validation completed.");
        }

        private static List<Album> GetNewAlbumsFromUser()
        {
            List<Album> newAlbums = new List<Album>();
            string addMore;

            do
            {
                Album newAlbum = new Album();

                Console.Write("Enter album title: ");
                newAlbum.album = Console.ReadLine();

                Console.Write("Enter artist name: ");
                newAlbum.artist = Console.ReadLine();

                Console.Write("Enter label: ");
                newAlbum.label = Console.ReadLine();

                Console.Write("Enter year: ");
                newAlbum.year = int.Parse(Console.ReadLine());

                Console.Write("Enter rank: ");
                newAlbum.rank = int.Parse(Console.ReadLine());

                newAlbum.chosenBefore = false;
                newAlbum.youTubeLink = string.Empty;
                newAlbum.spotifyLink = string.Empty;

                newAlbums.Add(newAlbum);

                Console.Write("Do you want to add another album? (yes or no): ");
                addMore = Console.ReadLine()?.ToLower();
            } while (addMore == "yes");

            return newAlbums;
        }

        private static Album GetRandomUnchosenAlbum(List<Album> albums)
        {
            List<Album> unchosenAlbums = albums.Where(album => !album.chosenBefore).ToList();
            if (unchosenAlbums.Count == 0)
            {
                return null;
            }

            Random rand = new Random();
            return unchosenAlbums[rand.Next(unchosenAlbums.Count)];
        }

        private static void DisplayAlbumInfo(Album album)
        {
            Console.Clear();
            Console.WriteLine("\nThe randomly chosen Album is: ");
            Console.WriteLine($"Title: {album.album}");
            Console.WriteLine($"Artist: {album.artist}");
            Console.WriteLine($"Label: {album.label}");
            Console.WriteLine($"Year: {album.year}");
            Console.WriteLine($"Rank: {album.rank}");
        }

        private static void OpenYouTubeLink(string youTubeLink)
        {
            try
            {
                Process.Start(
                    new ProcessStartInfo { FileName = youTubeLink, UseShellExecute = true }
                );
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to open YouTube link: {ex.Message}");
            }
        }

        private static void OpenSpotifyLink(string spotifyLink)
        {
            try
            {
                Process.Start(
                    new ProcessStartInfo { FileName = spotifyLink, UseShellExecute = true }
                );
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to open Spotify link: {ex.Message}");
            }
        }

        private static async Task HandleFindAllSpotifyLinksOption(
            List<Album> albums,
            IAlbumRepository albumRepository,
            ISpotifyService spotifyService
        )
        {
            Console.WriteLine("Finding all Spotify links...");
            foreach (var album in albums)
            {
                if (string.IsNullOrEmpty(album.spotifyLink))
                {
                    string spotifyAlbumSearch =
                        $"{album.album} by {album.artist} {album.year} {album.label}";
                    album.spotifyLink = await spotifyService.GetSpotifyLinkAsync(
                        spotifyAlbumSearch
                    );
                    Console.WriteLine(
                        $"Updated Spotify link for album: {album.album} by {album.artist}"
                    );
                }
            }
            albumRepository.WriteAlbums(albums);
            Console.WriteLine("All Spotify links have been updated.");
        }
    }

    public interface IAlbumRepository
    {
        List<Album> ReadAlbums();
        void WriteAlbums(List<Album> albums);
        void WriteAlbum(Album updatedAlbum);
    }

    public class JsonAlbumRepository : IAlbumRepository
    {
        private readonly string _filePath;

        public JsonAlbumRepository(string filePath)
        {
            _filePath = filePath;
        }

        public List<Album> ReadAlbums()
        {
            string jsonString = File.ReadAllText(_filePath);
            return JsonConvert.DeserializeObject<List<Album>>(jsonString);
        }

        public void WriteAlbums(List<Album> albums)
        {
            string jsonString = JsonConvert.SerializeObject(albums, Formatting.Indented);
            File.WriteAllText(_filePath, jsonString);
        }

        public void WriteAlbum(Album updatedAlbum)
        {
            List<Album> albums = ReadAlbums();
            for (int i = 0; i < albums.Count; i++)
            {
                if (
                    albums[i].album == updatedAlbum.album
                    && albums[i].artist == updatedAlbum.artist
                )
                {
                    albums[i] = updatedAlbum;
                    break;
                }
            }
            WriteAlbums(albums);
        }
    }

    public interface IYouTubeService
    {
        Task<string> GetYouTubeLinkAsync(string albumQuery);
        Task<bool> ValidateYouTubeLinkAsync(string youTubeLink);
    }

    public class YouTubeService : IYouTubeService
    {
        private const string ApiKey = "AIzaSyByhgO8HqPmLNG07MiIN_uPuivdZswKP7k";

        public async Task<string> GetYouTubeLinkAsync(string albumQuery)
        {
            string url =
                $"https://www.googleapis.com/youtube/v3/search?part=snippet&q={Uri.EscapeDataString(albumQuery)}&maxResults=1&type=video&key={ApiKey}";

            using HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(url);

            if (!response.IsSuccessStatusCode)
            {
                Console.WriteLine($"Error: {response.StatusCode}");
                return string.Empty;
            }

            string jsonResponse = await response.Content.ReadAsStringAsync();
            dynamic jsonResult = JsonConvert.DeserializeObject(jsonResponse);

            if (jsonResult.items == null || jsonResult.items.Count == 0)
            {
                Console.WriteLine("No results found.");
                return string.Empty;
            }

            foreach (var item in jsonResult.items)
            {
                string videoId = item.id?.videoId;
                if (!string.IsNullOrEmpty(videoId))
                {
                    return $"https://www.youtube.com/watch?v={videoId}";
                }
            }

            Console.WriteLine("No valid video ID found.");
            return string.Empty;
        }

        public async Task<bool> ValidateYouTubeLinkAsync(string youTubeLink)
        {
            using HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(youTubeLink);
            return response.IsSuccessStatusCode;
        }
    }

    public class SpotifyService : ISpotifyService
    {
        private const string ClientId = "8ccefa031b2944eca468232a158e9bcf";
        private const string ClientSecret = "7b066ee2e2324b6aa8456414fbc67d8f";
        private string _accessToken;
        private Timer _tokenRefreshTimer;

        public SpotifyService()
        {
            _tokenRefreshTimer = new Timer(
                async _ => await RefreshTokenAsync(),
                null,
                TimeSpan.Zero,
                TimeSpan.FromHours(1)
            );
        }

        public async Task<string> GetSpotifyLinkAsync(string albumQuery)
        {
            if (string.IsNullOrEmpty(_accessToken))
            {
                _accessToken = await GetOAuthTokenAsync();
            }

            string url =
                $"https://api.spotify.com/v1/search?q={Uri.EscapeDataString(albumQuery)}&type=album&limit=1";

            using HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
                "Bearer",
                _accessToken
            );

            HttpResponseMessage response = await client.GetAsync(url);
            if (!response.IsSuccessStatusCode)
            {
                string errorResponse = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Error: {response.StatusCode}, Details: {errorResponse}");
                return string.Empty;
            }

            string jsonResponse = await response.Content.ReadAsStringAsync();
            JObject jsonResult = JObject.Parse(jsonResponse);

            JToken album = jsonResult["albums"]?["items"]?.First;
            if (album == null)
            {
                Console.WriteLine("No results found.");
                return string.Empty;
            }

            string spotifyLink = album["external_urls"]?["spotify"]?.ToString();
            return spotifyLink ?? string.Empty;
        }

        private async Task<string> GetOAuthTokenAsync()
        {
            string url = "https://accounts.spotify.com/api/token";
            string credentials = Convert.ToBase64String(
                Encoding.UTF8.GetBytes($"{ClientId}:{ClientSecret}")
            );

            using HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
                "Basic",
                credentials
            );

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, url);
            request.Content = new StringContent(
                "grant_type=client_credentials",
                Encoding.UTF8,
                "application/x-www-form-urlencoded"
            );

            HttpResponseMessage response = await client.SendAsync(request);
            if (!response.IsSuccessStatusCode)
            {
                string errorResponse = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Error: {response.StatusCode}, Details: {errorResponse}");
                return string.Empty;
            }

            string jsonResponse = await response.Content.ReadAsStringAsync();
            JObject jsonResult = JObject.Parse(jsonResponse);

            return jsonResult["access_token"]?.ToString() ?? string.Empty;
        }

        private async Task RefreshTokenAsync()
        {
            _accessToken = await GetOAuthTokenAsync();
            Console.WriteLine("Spotify access token refreshed.");
        }
    }

    public class Album
    {
        public string album { get; set; } = string.Empty;
        public string artist { get; set; } = string.Empty;
        public string label { get; set; } = string.Empty;
        public int year { get; set; }
        public int rank { get; set; }
        public bool chosenBefore { get; set; }
        public string youTubeLink { get; set; } = string.Empty;
        public string spotifyLink { get; set; } = string.Empty;
    }

    public interface ISpotifyService
    {
        Task<string> GetSpotifyLinkAsync(string albumQuery);
    }
}
