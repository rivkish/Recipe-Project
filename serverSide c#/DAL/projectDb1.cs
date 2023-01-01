using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
   public class projectDb1:DbContext
    {
        public projectDb1(DbContextOptions<projectDb1> options)
            :base(options)
        { 
        }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Layer> Layers { get; set; }

    }
}
