using Newtonsoft.Json;
using System;
using AlbumCleanerLibrary;

namespace AlbumJsonUpdater
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            string jsonFilePath = @"C:\Users\Ryanw\OneDrive\Desktop\Programming\JJCopilot V1\JJCopilot V1\Albums.json";
            List<Album> albums = ReadAlbumsFromJson(jsonFilePath);

            Console.Write("Would you like to choose an album or clean the library (A or B): ");
            string input = Console.ReadLine()?.ToLower();

            while (input == "a" || input == "b")
            {
                if (input == "a")
                {
                    await HandleChooseAlbumOption(albums, jsonFilePath);
                }
                else if (input == "b")
                {
                    HandleCleanLibraryOption(jsonFilePath);
                }

                Console.Write("\nWould you like to choose an album or clean the library (A or B): ");
                input = Console.ReadLine()?.ToLower();
            }
        }

        private static async Task HandleChooseAlbumOption(List<Album> albums, string jsonFilePath)
        {
            Album randomAlbum = GetRandomAlbum(albums);

            if (!randomAlbum.chosenBefore)
            {
                DisplayAlbumInfo(randomAlbum);
                randomAlbum.chosenBefore = true;

                string youTubeAlbumSearch = $"{randomAlbum.album} by {randomAlbum.artist} Full Album HD";
                string apiKey = "SECRET";
                randomAlbum.youTubeLink = await GetYouTubeLinkAsync(youTubeAlbumSearch, apiKey);

                WriteAlbumsToJson(jsonFilePath, albums);

                Console.WriteLine("\nYouTube link updated and written back to the JSON file.");
                Console.WriteLine($"The updated YouTube link is: {randomAlbum.youTubeLink}");
            }
            else
            {
                Console.WriteLine($"Album chosen before: {randomAlbum.artist} - {randomAlbum.album} (Rank: {randomAlbum.rank})");
            }
        }

        private static void HandleCleanLibraryOption(string jsonFilePath)
        {
            Console.WriteLine("Cleaning up the library...");
            AlbumCleaner.Initialize(jsonFilePath);
            AlbumCleaner.CleanUp();
            Console.WriteLine("Library cleaned up.");
        }

        private static List<Album> ReadAlbumsFromJson(string filePath)
        {
            string jsonString = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<Album>>(jsonString);
        }

        private static void WriteAlbumsToJson(string filePath, List<Album> albums)
        {
            string jsonString = JsonConvert.SerializeObject(albums, Formatting.Indented);
            File.WriteAllText(filePath, jsonString);
        }

        private static Album GetRandomAlbum(List<Album> albums)
        {
            Random rand = new Random();
            return albums[rand.Next(albums.Count)];
        }

        private static void DisplayAlbumInfo(Album album)
        {
            Console.WriteLine("\nRandom Album:");
            Console.WriteLine($"Title: {album.album}");
            Console.WriteLine($"Artist: {album.artist}");
            Console.WriteLine($"Label: {album.label}");
            Console.WriteLine($"Year: {album.year}");
            Console.WriteLine($"Rank: {album.rank}");
            Console.WriteLine($"\nCurrent YouTube Link: {album.youTubeLink}");
            Console.WriteLine($"Chosen before? {album.chosenBefore}");
            Console.WriteLine($"Status updated: Chosen before = {album.chosenBefore}");
        }

        private static async Task<string> GetYouTubeLinkAsync(string albumQuery, string apiKey)
        {
            string url = $"https://www.googleapis.com/youtube/v3/search?part=snippet&q={Uri.EscapeDataString(albumQuery)}&maxResults=10&type=video&key={apiKey}";

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

        public class Album
        {
            public string album { get; set; }
            public string artist { get; set; }
            public string label { get; set; }
            public int year { get; set; }
            public int rank { get; set; }
            public bool chosenBefore { get; set; }
            public string youTubeLink { get; set; }
        }
    }
}
