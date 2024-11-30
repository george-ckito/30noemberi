using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30noemberi
{
    internal class ZooManager
    {
        private List<Mammal> _mammals;
        private List<Bird> _birds;
        public ZooManager()
        {
            _mammals = new List<Mammal>();
            _birds = new List<Bird>();
        }
        public void AddMammal(Mammal mammal)
        {
            _mammals.Add(mammal);
        }
        public void AddBird(Bird bird)
        {
            _birds.Add(bird);
        }
        public void ListMammal()
        {
            foreach (Mammal m in _mammals)
            {
                m.DescribeMammal();
            }
        }
        public void ListBird()
        {
            foreach (Bird bird in _birds) { bird.DescribeBird(); }
        }
        public Mammal FindHeaviestMammal()
        {
            Mammal ret = _mammals[0];
            foreach (Mammal m in _mammals)
            {
                if(m.Weight > ret.Weight) ret = m;
            }
            return ret;
        }
        public Bird FindHeaviestBird()
        {
            Bird ret = _birds[0];
            foreach (Bird b in _birds)
            {
                if (b.Weight > ret.Weight) ret = b;
            }
            return ret;
        }
    }
}
