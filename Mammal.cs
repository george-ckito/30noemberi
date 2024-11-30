using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30noemberi
{
    internal class Mammal : Animal
    {
        public string Habitat;
        public void DescribeMammal()
        {
            Describe();
            Console.WriteLine("Habitat: " + Habitat);
        }
        public void MoveMammal()
        {
            Console.WriteLine($"{Name} is walking");
        }
    }
}
