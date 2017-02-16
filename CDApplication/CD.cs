using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDApplication
{
    class CD
    {
        public string Name { get; set; }
        public string Artist { get; set; }
        public string Price { get; set; }
        private List<Song> songs;

        public CD()
        {
            songs = new List<Song>();
        }

        public void AddSong(Song song)
        {
            songs.Add(song);
        }

        public void PrintData()
        {
            Console.WriteLine("CD: ");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Artist: " + Artist);
            Console.WriteLine("Songs: ");
            foreach (Song song in songs)
            {               
                Console.WriteLine(" - " + song.ToString());
            }
        }
    }
}
