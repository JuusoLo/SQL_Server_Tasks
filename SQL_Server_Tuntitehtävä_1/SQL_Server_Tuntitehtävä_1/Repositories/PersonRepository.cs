using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using SQL_Server_Tuntitehtävä_1.Model;

namespace SQL_Server_Tuntitehtävä_1.Repositories
{
    class PersonRepository
    {
        private static Tuntitehtävä_2Context _context = new Tuntitehtävä_2Context();

        public static void Create(TablePerson2 person)
        {
            _context.TablePerson2.Add(person);
            _context.SaveChanges();
        }

        public static List<TablePerson2> Get()
        {
            List<TablePerson2> persons = _context.TablePerson2.ToListAsync().Result;
            return persons;
        }
        public static TablePerson2 GetPersonById(int id)
        {
            var person = _context.TablePerson2.FirstOrDefault(p => p.Id == id);
            return person;

        }

        public static void Update(int id, TablePerson2 person)
        {
            var updateperson = GetPersonById(id);
            if (updateperson != null)
            {
                _context.TablePerson2.Update(person);
            }
            _context.SaveChanges();
        }

    }
}
