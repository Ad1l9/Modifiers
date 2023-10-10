using Modifiers.Models;

namespace Modifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TASK 1
            //Dog dog = new Dog("Toplan", "Retriever", "Erkek");
            //dog.ShowInfo();




            //// TASK 2
            Group group = new("AB104");
            group.AddStudent(new Student("Adil", "Nasirli", 18, true));
            group.AddStudent(new Student("Leyla", "Shafiyeva", 19, false));
            group.AddStudent(new Student("Suleyman", "Karimli", 20, true));
            group.ShowInfoOfGroup();

            Console.WriteLine("All Student:");
            group.GetALl();
            Console.WriteLine("Offline Students:");
            group.GetOfflineStudents();
            Console.WriteLine("Online Students:");
            group.GetOnlineStudents();

        }
    }
}