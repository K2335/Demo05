using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{
    class Player : Team
    {


        private string playername;
        private int games;
        private int goals;

        public string PlayerName
        {
            get
            {
                return playername;
            }
            set
            {
                playername = value;
            }
        }

        public int Games
        {
            get
            {
                return games;
            }
            set
            {
                games = value;
            }
        }

        public int Goals
        {
            get
            {
                return goals;
            }
            set
            {
                goals = value;
            }
        }

        public Player(string name, int gamesplayed, int goles)
        {
            playername = name;
            games = gamesplayed;
            goals = goles;
        }

        public override string ToString()
        {
            return base.ToString() + PlayerName + ", Caps: " + Games + ", Goals: " + Goals;
        }
    }
}
