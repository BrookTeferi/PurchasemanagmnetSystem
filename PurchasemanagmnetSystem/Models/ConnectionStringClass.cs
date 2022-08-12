using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*using Microsoft.EntityFrameworkCore;
*/
namespace PurchasemanagmnetSystem.Models
{
    public class ConnectionStringClass: DbContext
    {
        public ConnectionStringClass(DbContextOptions<ConnectionStringClass> options) : base(options)
        {

        }
      

        public DbSet<Item>items { get; set; }
        public DbSet<Inssurance> inssurances { get; set; }
        public DbSet<Purchase>Products { get; set; }
        public DbSet<Vendor> vendors { get; set; }
        public DbSet<Employee> employees{ get; set; }


     }
}
