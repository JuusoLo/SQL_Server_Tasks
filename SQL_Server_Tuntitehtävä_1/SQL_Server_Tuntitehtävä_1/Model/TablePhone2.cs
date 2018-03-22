using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SQL_Server_Tuntitehtävä_1.Model
{
    [Table("Table_Phone_2")]
    public partial class TablePhone2
    {
        public long Id { get; set; }
        [Column(TypeName = "nchar(20)")]
        public string Type { get; set; }
        [Column(TypeName = "nchar(10)")]
        public string Number { get; set; }
        public long? PersonId { get; set; }

        [ForeignKey("PersonId")]
        [InverseProperty("TablePhone2")]
        public TablePerson2 Person { get; set; }
    }
}
