using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Salmon : Animal, ISwimmable
    {
        public Salmon()
        {
            Console.WriteLine("A nice tasty fish.");
        }

        public void Swim()
        {
            Console.WriteLine("Just keep swimming.");
        }

        public override void Sing()
        {
            Console.WriteLine("Bubbles, bubbles, bubbles...");
        }

    }
}
