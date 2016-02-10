using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Recipes.Models
{
    public class Recipe
    {
        public int RecipeId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
       // public List<RecipeIngredient> Ingredients { get; set; }

    }

    public class RecipeInfo
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public List<IngredientsList> Ingredients { get; set; }
    }

    public class IngredientsList
    {
        public string IngredientName { get; set; }
        public string Measurement { get; set; }
        public string Unit { get; set; }
    }

}