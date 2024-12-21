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
        bool isUpdated = false;

        foreach (var album in albums)
        {
            if (string.IsNullOrEmpty(album.youTubeLink) || album.youTubeLink == "https://www.youtube.com/watch?v=")
            {
                isUpdated |= UpdateChosenBefore(album, false);
            }
            else if (!album.chosenBefore)
            {
                Console.WriteLine($"\nYouTube Link Valid: {album.youTubeLink}");
                isUpdated |= UpdateChosenBefore(album, true);
            }
        }

        if (isUpdated)
        {
            WriteAlbumsToJson(jsonFilePath, albums);
            Console.WriteLine("JSON Updated");
        }
    }

    private static bool UpdateChosenBefore(Album album, bool status)
    {
        if (album.chosenBefore != status)
        {
            album.chosenBefore = status;
            return true;
        }
        return false;
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
