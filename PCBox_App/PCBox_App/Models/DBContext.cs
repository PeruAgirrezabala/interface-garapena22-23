using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace PCBox_App
{
    internal class DBContext : DbContext
    {
        public DBContext() : base(nameOrConnectionString: "DbContext")
        { }
        public DbSet<Produktuak> Produktua { get; set; }
        public DbSet<Salmentak> Salmenta { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
