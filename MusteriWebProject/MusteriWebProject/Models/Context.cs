using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusteriWebProject.Models
{
    public class Context : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {


            optionsBuilder.UseSqlServer("server=DESKTOP-TEHP7C8\\SQLEXPRESS; database=WebDbMusteri; integrated security = true;");


        }
        public DbSet<CustomerC> Customers_Information { get; set; }

        public DbSet<Admin> Admins_Information { get; set; }



    }
}
