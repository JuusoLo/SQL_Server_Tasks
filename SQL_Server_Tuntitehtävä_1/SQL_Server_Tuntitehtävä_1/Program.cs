using System;
using SQL_Server_Tuntitehtävä_1.Model;
using SQL_Server_Tuntitehtävä_1.Repositories;

namespace SQL_Server_Tuntitehtävä_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Database CRUD operations");
            //TablePerson2 person = new TablePerson2("Jukka", 53);
            //PersonRepository.Create(person);

            var persons = PersonRepository.Get();
            foreach (var p in persons)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("Press <Enter> to Exit");
            Console.ReadLine();
        }
    }
}
