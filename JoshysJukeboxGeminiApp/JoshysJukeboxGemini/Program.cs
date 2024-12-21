using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using JoshysJukeboxGemini;

string filePath = @"C:\Users\Ryanw\OneDrive\Desktop\Programming\JoshysJukeboxGeminiApp\JoshysJukeboxGemini\albums.json";

// Read albums from JSON file
List<Album> albums = ReadAlbumsFromFile(filePath);

// Shuffle the albums
JoshysJukeboxGemini.ShuffleClass(albums);

// Fetch YouTube links for each album
await FetchYouTubeLinksAsync(albums);

// Write the shuffled albums back to the JSON file
object WriteJson = new JoshysJukeboxGemini.WriteAlbumsToFileClass(filePath, albums);

List<Album> ReadAlbumsFromFile(string filePath)
{
    string? json = File.ReadAllText(filePath);
    return JsonSerializer.Deserialize<List<Album>>(json);
}



async Task FetchYouTubeLinksAsync(List<Album> albums)
{
    using HttpClient client = new HttpClient();

    foreach (Album album in albums)
    {
        string searchQuery = $"{album.album} album";
        string youtubeUrl = await JoshysJukeboxGemini.SearchYouTube(client, searchQuery);
        album.YouTubeLink = youtubeUrl;
    }
}


