using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30noemberi
{
    internal class Animal
    {
        private string _name;
        private int _age;
        private double _weight;
        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length < 3)
                {
                    throw new Exception("Name can't be under 3 charachters or empty.");
                }
                _name = value;
            }
        }
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new Exception("Age can't be negative or more than 100");
                }
                _age = value;
            }
        }
        public double Weight
        {
            get { return _weight; }
            set
            {
                if (value < 0.5)
                {
                    throw new Exception("Weight can't be less than 0.5kg");
                }
                _weight = value;
            }
        }
        protected void Describe()
        {
            Console.WriteLine($"Name: {_name}\nAge: {_age}\nWeight: {_weight}");
        }

    }
}
