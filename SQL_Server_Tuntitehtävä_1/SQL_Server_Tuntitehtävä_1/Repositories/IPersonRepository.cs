using System;
using System.Collections.Generic;
using System.Text;
using SQL_Server_Tuntitehtävä_1.View;
using SQL_Server_Tuntitehtävä_1.Model;

namespace SQL_Server_Tuntitehtävä_1.Repositories
{
    interface IPersonRepository
    {
        /// <summary>
        /// Tänne kuvataan metodit, joita PersonRepositorin tulee toteuttaa
        /// Paluuarvo ja MetodinNimi(mahdolliset parametrit)
        /// </summary>
        ///     

        List<Person> Get();
        Person GetPersonById(int id);
        void Create(Person person);
        void Update(int id, Person person);
        void Delete(int id);


    }
}
