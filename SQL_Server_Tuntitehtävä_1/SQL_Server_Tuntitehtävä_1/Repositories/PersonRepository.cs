using System;
using System.Collections.Generic;
using System.Text;
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
    }
}
