using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Program
    {
        static void Main(string[] args)
        {
            CD avain = new CD();

            avain.Name = "Punainen Tiili";
            avain.Artist = "Avain";
            avain.Price = 17.99;


            Track track1 = new Track("Punainen Tiili", "4:35");
            Track track2 = new Track("Markus", "3:35");
            Track track3 = new Track("Haastattelu", "0:48");
            Track track4 = new Track("Roihuvuori", "3:21");
            Track track5 = new Track("Pullon Sisällä", "3:46");


            avain.AddTrack(track1);
            avain.AddTrack(track2);
            avain.AddTrack(track3);
            avain.AddTrack(track4);
            avain.AddTrack(track5);
          

            avain.PrintData();

            Console.ReadLine();
        }
    }
}