using Loja.Domain.DAO;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlProviderServices = System.Data.Entity.SqlServer.SqlProviderServices;

namespace Loja.Infrastruture.EF
{
    public class Context : DbContext
    {

        
        public Context() : base("LojaDB")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<Context, EF6Console.Migrations.Configuration>());
            
        }
       
        public DbSet<Test> Tests { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        }
    }
}
