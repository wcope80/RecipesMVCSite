using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Recipes.Models;

namespace Recipes.DAL
{
    public class RecipeContext : DbContext
    {
        public RecipeContext() : base("RecipeContext")
        {
        }

        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<RecipeIngredient> RecipeIngredients { get; set; }




        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {   //Uncomment if you want table names singular(Recipe vs Recipes)
            //modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
        }
    }

    
}