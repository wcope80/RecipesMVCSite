using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Recipes.Models;


namespace Recipes.DAL
{
    public class RecipeInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<RecipeContext>
    {
        protected override void Seed(RecipeContext context)
        {
            var recipes = new List<Recipe>
            {
                new Recipe {Name="Grilled Cheese", Category="Sandwich"  },
                new Recipe {Name="Spaghetti", Category="Dinner" },
                new Recipe {Name="Beer Bread", Category="Side" }
            };
            recipes.ForEach(r => context.Recipes.Add(r));
            context.SaveChanges();

            var ingredients = new List<Ingredient>
            {
                new Ingredient { Name="Bread"},
                new Ingredient {Name="Cheese"},
                new Ingredient {Name="Butter"},
                new Ingredient {Name="Spaghetti"},
                new Ingredient {Name="Ground Beef" },
                new Ingredient {Name="Spaghetti Sauce" },
                new Ingredient { Name="Flour" },
                new Ingredient { Name="Beer" }
            };
            ingredients.ForEach(i => context.Ingredients.Add(i));
            context.SaveChanges();

            var recipeIngredients = new List<RecipeIngredient>
            { 
                //Grilled Cheese Ingredients/amounts
                new RecipeIngredient { IngredientId=1, IngredientName="Bread", RecipeId=1, RecipeName="Grilled Cheese", Measurement="2", Unit="Slice" },
                new RecipeIngredient { IngredientId=2, IngredientName="Cheese", RecipeId=1,  RecipeName="Grilled Cheese", Measurement="1", Unit="Slice" },
                new RecipeIngredient { IngredientId=3, IngredientName="Butter", RecipeId=1, RecipeName="Grilled Cheese", Measurement="2", Unit="Tablespoon" },
                //Spaghetti
                new RecipeIngredient { IngredientId=4, IngredientName="Spaghetti", RecipeId=2, RecipeName="Spaghetti", Measurement="1", Unit="Box" },
                new RecipeIngredient { IngredientId=5, IngredientName="Ground Beef", RecipeId=2, RecipeName="Spaghetti", Measurement="1", Unit="Pound" },
                new RecipeIngredient { IngredientId=6, IngredientName="Spaghetti Sauce", RecipeId=2, RecipeName="Spaghetti", Measurement="1", Unit="Jar" },
                //Beer Bread
                new RecipeIngredient { IngredientId=7, IngredientName="Flour", RecipeId=3, RecipeName="Beer Bread", Measurement="4", Unit="Cup" },
                new RecipeIngredient { IngredientId=8, IngredientName="Beer",RecipeId=3, RecipeName="Beer Bread", Measurement="1", Unit="Can" }
            };

            recipeIngredients.ForEach(ri => context.RecipeIngredients.Add(ri));
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
