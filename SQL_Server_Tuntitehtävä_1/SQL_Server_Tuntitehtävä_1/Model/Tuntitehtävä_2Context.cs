using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SQL_Server_Tuntitehtävä_1.Model
{
    public partial class Tuntitehtävä_2Context : DbContext
    {
        public virtual DbSet<TablePerson2> TablePerson2 { get; set; }
        public virtual DbSet<TablePhone2> TablePhone2 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-AJGJ9H8\SQLEXPRESS;Initial Catalog=Tuntitehtävä_2;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TablePhone2>(entity =>
            {
                entity.HasOne(d => d.Person)
                    .WithMany(p => p.TablePhone2)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK_Table_Phone_2_Table_Person_2");
            });
        }
    }
}
