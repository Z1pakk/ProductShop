using ProductShopLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankomatLibrary.EFContext
{
    public class EFContext:DbContext
    {
        public EFContext():base("DbConnection")
        {

        }
        public DbSet<Products> Products { get; set; }
    }
}
