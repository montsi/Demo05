using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Song song1 = new Song { Name = "Shudder Before the Beautiful", Length = "6:29" };
            Song song2 = new Song { Name = "Weak Fantasy", Length = "5:23" };
            Song song3 = new Song { Name = "Elan", Length = "4:45" };


            CD cd = new CD { Name = "Endless Forms Most Beautiful", Artist = "Nightwish", Price = "12€" };

            cd.AddSong(song1);
            cd.AddSong(song2);
            cd.AddSong(song3);
            
            cd.PrintData();
        }
    }
}
