using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SQL_Server_Tuntitehtävä_1.Model
{
    [Table("Table_Person_2")]
    public partial class TablePerson2
    {
        public TablePerson2()
        {
            TablePhone2 = new HashSet<TablePhone2>();
        }

        public TablePerson2(string name, short? age)
        {
            Name = name;
            Age = age;
        }

        public TablePerson2(string name, short? age, ICollection<TablePhone2> tablePhone2)
        {
            Name = name;
            Age = age;
            TablePhone2 = tablePhone2;
        }

        public long Id { get; set; }
        [Column(TypeName = "nchar(10)")]
        public string Name { get; set; }
        public short? Age { get; set; }

        [InverseProperty("Person")]
        public ICollection<TablePhone2> TablePhone2 { get; set; }
    }
}
