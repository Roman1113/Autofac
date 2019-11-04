using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDI.Entities
{
    public class EFContext : DbContext
    {

        public EFContext() : this("DefaultConnection")
        {

        }
        public EFContext(string con) : base(con)
        {

        }

        public DbSet<DbUser> Users { get; set; }
    }
}
