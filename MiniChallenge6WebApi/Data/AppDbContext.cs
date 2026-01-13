using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MiniChallenge6WebApi.Models;


namespace MiniChallenge6WebApi.Data
{                               //Inherits from Microsoft EntitiyFramework Core
    public class AppDbContext : DbContext
    {   //needed to configure our database!
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }
        //When we call ef migrations, it will call the model Guess It and create a class called GuessIt and be able to get and set to write to our database!
        public DbSet<GuessIt> GuessIt {get; set;}
    }
}