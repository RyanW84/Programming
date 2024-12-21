using System;
using System.Collections.Generic;

namespace AlbumShuffler
{
    class Program
    {
        static void Main(string[] args)
        {
            // List of albums to shuffle
            List<string> albums = new List<string>
            {
                "Abbey Road - The Beatles",
                "The Dark Side of the Moon - Pink Floyd",
                "Thriller - Michael Jackson",
                "Back in Black - AC/DC",
                "Hotel California - Eagles",
                "Rumours - Fleetwood Mac",
                "The Wall - Pink Floyd",
                "Led Zeppelin IV - Led Zeppelin"
            };

            // Print original list
            Console.WriteLine("Original list:");
            PrintList(albums);

            // Perform Fisher-Yates shuffle
            Shuffle(albums);

            // Print shuffled list
            Console.WriteLine("Shuffled list:");
            PrintList(albums);
        }

        static void Shuffle<T>(List<T> list)
        {
            Random rand = new Random();
            for (int i = list.Count - 1; i > 0; i--)
            {
                int j = rand.Next(i + 1);
                T temp = list[i];
                list[i] = list[j];
                list[j] = temp;
            }
        }

        static void PrintList<T>(List<T> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
