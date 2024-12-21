using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace AlbumCleanerLibrary;

public static class AlbumCleaner
{
    private static List<Album> albums = new List<Album>(); // Initialize to avoid null
    private static string jsonFilePath = string.Empty; // Initialize to avoid null

    public static void Initialize(string filePath)
    {
        jsonFilePath = filePath;
        albums = ReadAlbumsFromJson(jsonFilePath) ?? new List<Album>(); // Handle possible null return
    }

    public static void CleanUp()
    {
        Random rand = new Random();

        for (int i = 0; i < albums.Count; i++)
        {
            int randomIndex = rand.Next(albums.Count);
            Album randomAlbum = albums[randomIndex];

            if (string.IsNullOrEmpty(randomAlbum.youTubeLink))
            {
                UpdateChosenBefore(randomAlbum, false, "Correcting Null Chosen before to False");
            }
            else if (randomAlbum.youTubeLink == "https://www.youtube.com/watch?v=")
            {
                UpdateChosenBefore(randomAlbum, false, "Correcting v = Chosen before to False");
            }
            else
            {
                if (!randomAlbum.chosenBefore)
                {
                    Console.WriteLine($"\nYouTube Link Valid: {randomAlbum.youTubeLink}");
                    UpdateChosenBefore(randomAlbum, true, "Valid link, setting chosenBefore to true");
                }
                else
                {
                    Console.WriteLine("Valid link already true");
                }
            }
        }
    }

    private static void UpdateChosenBefore(Album album, bool status, string message)
    {
        if (album.chosenBefore != status)
        {
            Console.WriteLine(album.chosenBefore);
            Console.WriteLine(message);
            Console.WriteLine($"The current status is: {album.chosenBefore}");
            album.chosenBefore = status;
            Console.WriteLine($"The updated status is: {album.chosenBefore}");
            WriteAlbumsToJson(jsonFilePath, albums);
            Console.WriteLine("JSON Updated");
        }
        else
        {
            Console.WriteLine($"{message} already {status}");
        }
    }

    private static List<Album> ReadAlbumsFromJson(string filePath)
    {
        string jsonString = File.ReadAllText(filePath);
        return JsonConvert.DeserializeObject<List<Album>>(jsonString) ?? new List<Album>(); // Handle possible null return
    }

    private static void WriteAlbumsToJson(string filePath, List<Album> albums)
    {
        string jsonString = JsonConvert.SerializeObject(albums, Formatting.Indented);
        File.WriteAllText(filePath, jsonString);
    }

    public class Album
    {
        public string album { get; set; } = string.Empty; // Initialize to avoid null
        public string artist { get; set; } = string.Empty; // Initialize to avoid null
        public string label { get; set; } = string.Empty; // Initialize to avoid null
        public int year { get; set; }
        public int rank { get; set; }
        public bool chosenBefore { get; set; }
        public string youTubeLink { get; set; } = string.Empty; // Initialize to avoid null
    }
}
