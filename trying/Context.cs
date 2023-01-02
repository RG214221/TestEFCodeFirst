using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trying;

namespace TestEFCodeFirst
{
    public class Context : DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<TaskToDo> TasksToDo { get; set; }
        public DbSet<ActivePartner> ActivePartners { get; set; }
        public DbSet<HouseholdManager> HouseholdManagers { get; set; }
        public DbSet<CyclicTask> CyclicTasks { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source =DESKTOP-B5S1T71; Initial Catalog = Person; Integrated Security = True; TrustServerCertificate=True");
        }
        //Convert DateOnly to Date
        protected override void ConfigureConventions(ModelConfigurationBuilder builder)
        {

            builder.Properties<DateOnly>()
                .HaveConversion<DateOnlyConverter>()
                .HaveColumnType("date");

            base.ConfigureConventions(builder);

        }
        //Option_2
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().UseTptMappingStrategy();
            modelBuilder.Entity<ActivePartner>().ToTable("ActivePartner");
            modelBuilder.Entity<HouseholdManager>().ToTable("HouseholdManager");
            modelBuilder.Entity<TaskToDo>().UseTpcMappingStrategy();
        }
    }
}
