using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection.Metadata.Ecma335;
using System.Text.Json;
using System.Threading.Channels;

namespace AlbumShuffler
{
    class Program
    {

        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Ryanw\OneDrive\Desktop\Programming\JJGeminiV1\JJGeminiV1\albums.json";

            // Read albums from JSON file
            List<Album> albums = ReadAlbumsFromFile(filePath);

            // Shuffle the albums
            Shuffle(albums);

            // Fetch YouTube links for each album
            async await static extern FetchYouTubeLinksAsync(albums);

            // Write the shuffled albums back to the JSON file
            WriteAlbumsToFile(filePath, albums);

            var Album = new Album();
            Album.album = "";
            Album.artist = "";
            Album.label = "";
            Album.year = 0;
            Album.rank = 0;
            Console.WriteLine($"{Album.album}");

        }

        static List<Album> ReadAlbumsFromFile(string filePath)
        {
            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Album>>(json);
        }

        static void Shuffle<T>(IList<T> list)
        {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        static async Task FetchYouTubeLinksAsync(List<Album> albums)
        {
            using HttpClient client = new HttpClient();

            foreach (Album album in albums)
            {
                string searchQuery = $"{album.album} album";
                string youtubeUrl = await SearchYouTubeAsync(client, searchQuery);
                album.YouTubeLink = youtubeUrl;
            }
        }

        static async Task<string> SearchYouTubeAsync(HttpClient client, string searchQuery)
        {
            // Replace with your actual YouTube Data API key and implementation
            // This is a simplified example to demonstrate the concept.
            string apiKey = "AIzaSyByhgO8HqPmLNG07MiIN_uPuivdZswKP7k";
            string youtubeSearchUrl = $"https://www.googleapis.com/youtube/v3/search?part=snippet&q={Uri.EscapeDataString(searchQuery)}&key={apiKey}";

            HttpResponseMessage response = await client.GetAsync(youtubeSearchUrl);
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();
            // Parse the JSON response to extract the first video ID
            // ... (Implement JSON parsing logic here)
            return "https://www.youtube.com/watch?v=VIDEO_ID"; // Replace with the extracted video ID
        }

        static void WriteAlbumsToFile(string filePath, List<Album> albums)
        {
            string json = JsonSerializer.Serialize(albums, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        class Album
        {
            public string? album { get; set; }
            public string? artist { get; set; }
            public string? label { get; set; }
            public int rank { get; set; }
            public int year { get; set; }
            public string YouTubeLink { get; set; }

        }
        Main();

    }
}
