using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modifiers.Models
{
    internal class Person
    {

        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length >= 3 && value.Length <= 17)
                    _name = value;
                else Console.WriteLine("Ad yanlisdir");
            }
        }

        private string _surname;

        public string Surname
        {
            get { return _surname; }
            set
            {
                if (value.Length > 5 && value.Length <= 20)
                    _surname = value;
                else Console.WriteLine("Soyad yanlisdir");
            }
        }


        private int _age;

        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 15 && value <= 150)
                    _age = value;
                else Console.WriteLine("Yas yanlisdir");
            }
        }

        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }


    }
}
