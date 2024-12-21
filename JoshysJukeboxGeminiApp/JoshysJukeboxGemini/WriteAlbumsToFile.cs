using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace JoshysJukeboxGemini
{
    public class WriteAlbumsToFileClass
    {
        private void WriteAlbumsToFile(string filePath, List<Album> albums)
        {
            string? json = JsonSerializer.Serialize(albums, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }
    }
}
