using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SQL_Server_Tuntitehtävä_1.Model;

namespace SQL_Server_Tuntitehtävä_1.Repositories
{
    interface IRepository
    {
        List<TablePerson2> Get();
        TablePerson2 GetPersonById(int id);
        void Create(TablePerson2 person);
        void Update(int id, TablePerson2 person);
        void Delete(int id);

    }
}
