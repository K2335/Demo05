
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class CD
    {
        private string name;
        private string artist;
        private double price;
        private List<Track> tracks;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        public string Artist
        {
            get
            {
                return artist;
            }
            set
            {
                artist = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public CD()
        {
            tracks = new List<Track>();
        }

        public void AddTrack(Track track)
        {
            tracks.Add(track);
        }


        public void PrintData()
        {

            Console.WriteLine("CD data: ");
            Console.WriteLine("- name: " + name);
            Console.WriteLine("- artist: " + artist);
            Console.WriteLine("- price: " + price);
            Console.WriteLine("- tracks: ");

            foreach (CD tracks in tracks)
            {
                Console.WriteLine(tracks.ToString());
            }
        }

        public override string ToString()
        {
            return "    - ";
        }
    }
}