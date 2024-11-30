using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30noemberi
{
    internal class Bird : Animal
    {
        public bool CanFly;
        public void DescribeBird()
        {
            Describe();
            string print = CanFly ? "can" : "can't";
            Console.WriteLine($"Bird {print} fly");
        }
        public void MoveBird()
        {
            if (CanFly)
            {
                Console.WriteLine($"{Name} is flying");
            }
            else
            {
                Console.WriteLine($"{Name} is walking");
            }
        }
    }
}
