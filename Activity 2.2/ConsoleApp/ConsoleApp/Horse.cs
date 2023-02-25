using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Horse : Animal, IRidable
    {
        public Horse()
        {
            Console.WriteLine("A sturdy steed.");
        }

        public void RideMe()
        {
            Console.WriteLine("Let's ride! Gity Up!");
        }

        public override void Sing()
        {
            Console.WriteLine("Neigh, Neigh, Neigh...");
        }
    }
}
