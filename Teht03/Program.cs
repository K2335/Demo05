using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{
    class Program
    {
        static void Main(string[] args)
        {
            Team real = new Team();

            real.Name = "Real Madrid";
            real.Coach = "Zinedine Zidane";
            


            Player player1 = new Player("Marcelo", 32, 7);
            Player player2 = new Player("Gareth Bale", 14, 12);
            Player player3 = new Player("Cristiano Ronaldo", 38, 54);

            real.AddPlayer(player1);
            real.AddPlayer(player2);
            real.AddPlayer(player3);

            real.PrintData();
        }
    }
}     
