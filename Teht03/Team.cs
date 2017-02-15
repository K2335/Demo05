using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{
    class Team
    {
        private string name;
        private string coach;
        private List<Player> players;

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
        public string Coach
        {
            get
            {
                return coach;
            }
            set
            {
                coach = value;
            }
        }


        public Team()
        {
            players = new List<Player>();
        }

        public void AddPlayer(Player player)
        {
            players.Add(player);
        }


        public void PrintData()
        {

            Console.WriteLine("Team info: ");
            Console.WriteLine("- name: " + name);
            Console.WriteLine("- coach: " + coach);
            Console.WriteLine("- players: ");

            foreach (Team players in players)
            {
                Console.WriteLine(players.ToString());
            }
        }

        public override string ToString()
        {
            return "    - ";
        }
    }
}
