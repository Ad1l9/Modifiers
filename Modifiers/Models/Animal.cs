using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modifiers.Models
{
    internal class Animal
    {
        private string _gender;

        public string Gender
        {
            get { return _gender; }
            set
            {
                if (value == "Disi" || value == "Erkek" || value == "Undefined")
                    _gender = value;
                else 
                    Console.WriteLine("Duzgun gender deyil");
            }
        }
        private DateTime _birthdate;

        public DateTime BirthDate
        {
            get { return _birthdate; }
        }


        public Animal(string gender)
        {
            Gender = gender;
            _birthdate = DateTime.Now;
        }
    }
}