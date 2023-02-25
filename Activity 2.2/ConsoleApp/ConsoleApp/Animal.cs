using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public abstract class Animal
    {

        public Animal()
        {
            Console.WriteLine("Animal constructor");
        }

        public void Greet()
        {
            Console.WriteLine("Animal says Hello");
        }

        public void Talk()
        {
            Console.WriteLine("Animal talking");
        }

        public virtual void Sing()
        {
            Console.WriteLine("Animal song");

        }

    }
}
