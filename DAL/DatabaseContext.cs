using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            
        }
        
            
        
        DbSet<User>Users{get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                if(!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseNpgsql("Host=localhost;Database=LearnAPSNet;Username=postgres;Password=Admin@123");
                }
                base.OnConfiguring(optionsBuilder);
            }
    }
}



// optionsBuilder.UseSqlServer(data source=Shailendra\SqlExpress; initial
//   catalog=LINQDemoDB;persist security info=True;user id=sa;password=dotnettricks;")





