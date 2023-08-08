using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C__Sample
{
    internal class Song
    {
        public String title;
        public String artist;
        public int duration;
        public static int songCount = 0;

        public Song(string title,string artist,int duration) {
            this.title = title;
            this.artist = artist;
            this.duration = duration;
            songCount++;
        }

        public int getSongCount()
        {
            return songCount;
        }
    }
}
