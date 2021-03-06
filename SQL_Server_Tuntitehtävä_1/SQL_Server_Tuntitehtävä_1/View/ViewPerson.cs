﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using SQL_Server_Tuntitehtävä_1.Model;
using SQL_Server_Tuntitehtävä_1.Repositories;

namespace SQL_Server_Tuntitehtävä_1.View
{
    class ViewPerson
    {
        /// <summary>
        /// Print data to screen from list
        /// </summary>
        /// <param name="persons"></param>
        public static void PrintToScreen(List<Person> persons)
        {
            Console.WriteLine("Id, Name, Age\n" +
                              "-------------------\n");
            foreach (var p in persons)
            {
                Console.WriteLine(p.ShowData());
            }
        }

        /// <summary>
        /// Print only one record 
        /// </summary>
        /// <param name="person"></param>
        public static void PrintToScreen(Person person)
        {
            Console.WriteLine($"{person.Name}, {person.Age}");
            if (person.Phone.Count == 0)
                Console.WriteLine("Ei puhelinta!");
            foreach (var phnPhone in person.Phone)
            {
                Console.WriteLine($"\n   {phnPhone.ToString()}");
            }
            Console.WriteLine("\n-------------\n");

        }

        public static void AddPerson()
        {
            Console.Write("Type name:   ");
            string name = Console.ReadLine();
            Console.Write("Type age:   ");
            short age = short.Parse(Console.ReadLine());

            List<Phone> phones = new List<Phone>();
            string addAnother = "Y";
            Console.WriteLine("Add phones");
            do
            {
                Console.Write("Type phone number:   ");
                string phoneNumber = Console.ReadLine();

                Console.Write("Phone type <Home/Work>:  ");
                string phoneType = Console.ReadLine();

                Phone addPhone = new Phone(phoneType, phoneNumber);
                phones.Add(addPhone);

                Console.WriteLine("Add another phone <Y/N>:  ");
                addAnother = Console.ReadLine();

            } while (addAnother.ToUpper() !="N");

            phones.Add(new Phone("XXXX", "04073847621"));
            phones.Add(new Phone("Home", "04073847621"));

            var addPerson = new Person(name, age, phones);
            PersonRepository personRepository = new PersonRepository();
            personRepository.Create(addPerson);
        }
    }
}
