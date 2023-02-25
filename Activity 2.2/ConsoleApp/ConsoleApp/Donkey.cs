using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Donkey : Animal, IRidable
    {
        public Donkey() 
        {
            Console.WriteLine("I got attitude.");
        }


        public void RideMe()
        {
            Console.WriteLine("Kick for a bit. Throws some attitude about being ridden. ");
        }

        public override void Sing()
        {
            Console.WriteLine("Hee-haw, Hee-haw, Hee-haw...");
        }
    }
}
