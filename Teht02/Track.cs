using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Track : CD
    {

        private string trackname;
        private string length;

        public string TrackName
        {
            get
            {
                return trackname;
            }
            set
            {
                trackname = value;
            }
        }

        public string Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }

        public Track(string name, string len)
        {
            trackname = name;
            length = len;
        }

        public override string ToString()
        {
            return base.ToString() + TrackName + ", " + Length;
        }


    }
}