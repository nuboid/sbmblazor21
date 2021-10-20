using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyBlazorDbContext
{
    public class MyDbContext : DbContext
    {

        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceLine> InvoiceLines { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=DESKTOP-MH2BT9E\SQLEXPRESS19;Database=EFDemo2;Trusted_Connection=True");

            //optionsBuilder.LogTo(Console.WriteLine);
        }
    }
}
