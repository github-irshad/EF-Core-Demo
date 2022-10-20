using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;
using Microsoft.EntityFrameworkCore;


namespace DAL
{
    public class DatabaseContext:DbContext
    {
        Dbset<User>Users {get; set;}

        protected override void onConfiguring(DbContextOptionBuilder optionBuilder)
        {
            if(!optionBuilder.IsConfigured)
            {
                optionBuilder.UseNpgsql("Server=127.0.0.1;Port=5432;Database=myDataBase;User Id=myUsername;Password=myPassword");
            }
        }
    }
}