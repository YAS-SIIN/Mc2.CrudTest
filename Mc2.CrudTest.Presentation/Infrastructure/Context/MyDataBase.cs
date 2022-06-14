using System; 
using System.Linq;
using System.Threading.Tasks;

using Mc2.CrudTest.Presentation.Domain.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Mc2.CrudTest.Presentation.Infrastructure.Context
{

    public class MyDataBase : DbContext
    {
      
        public MyDataBase(DbContextOptions<MyDataBase> options) : base(options)
        { 
        }
        public DbSet<Customer> Customers { get; set; }       
        //
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
           .HasIndex(b => new { b.Firstname, b.Lastname, b.DateOfBirth }).IsUnique();

            modelBuilder.Entity<Customer>()
 .HasIndex(b => b.Email).IsUnique();

            base.OnModelCreating(modelBuilder);
        }
      

    }

}