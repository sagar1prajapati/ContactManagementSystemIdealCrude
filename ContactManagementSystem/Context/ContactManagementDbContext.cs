using ContactManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ContactManagementSystem.Context
{
    public class ContactManagementDbContext : DbContext
    {
        public ContactManagementDbContext() : base("DefaultConnection")
        {
            //Database.SetInitializer<WebBasedCMSContext>(null);
        }

        public DbSet<PersonContact> PersonContact { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}