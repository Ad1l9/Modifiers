using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Modifiers.Models
{
    internal class Dog : Animal
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length >= 3 && value.Length < 15)
                    _name = value;
                else Console.WriteLine("Duzgun deyil");
            }
        }

        private string _breed;

        public string Breed
        {
            get { return _breed; }
        }

        public Dog(string name, string breed, string gender) : base(gender)
        {
            Name = name;
            _breed = breed;
        }

        public void ShowInfo()
        {
            Console.WriteLine($@"
Name: {Name},
Breed: {Breed},
Gender: {Gender},
Birthday: {BirthDate}");
        }
    }
}
