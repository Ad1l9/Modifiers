using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modifiers.Models
{
    internal class Group
    {
        private string _groupName;

        public string GroupName
        {
            get { return _groupName; }
            set
            {
                if (value.Length > 3 && value.Length < 20)
                    _groupName = value;
                else Console.WriteLine("Length is incorrect");
            }
        }

        public Student[] Students;

        public Group(string groupName)
        {
            GroupName = groupName;
            Students = new Student[0];
        }

        public void AddStudent(Student student)
        {
            Student[] temp = new Student[Students.Length + 1];
            for (int i = 0; i < Students.Length; i++)
            {
                temp[i] = Students[i];
            }
            temp[Students.Length] = student;
            Students = temp;
        }

        public void GetALl()
        {
            for (int i = 0; i < Students.Length; i++)
            {
                Console.WriteLine($"{Students[i].Name} {Students[i].Surname}");
            }
        }

        public void GetOnlineStudents()
        {
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i].IsOnline)
                    Console.WriteLine($"{Students[i].Name} {Students[i].Surname}");
            }
        }
        public void GetOfflineStudents()
        {
            for (int i = 0; i < Students.Length; i++)
            {
                if (!Students[i].IsOnline)
                    Console.WriteLine($"{Students[i].Name} {Students[i].Surname}");
            }
        }

        public void ShowInfoOfGroup()
        {
            Console.WriteLine($@"========= GROUP: {GroupName} =========");
            Console.WriteLine("Students: ");
            for (int i = 0; i < Students.Length; i++)
            {
                Students[i].ShowInfo();
            }
        }
    }
}
