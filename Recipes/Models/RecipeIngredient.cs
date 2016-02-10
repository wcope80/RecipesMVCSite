using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Recipes.Models
{
    public class RecipeIngredient
    {
        [Key, Column(Order=1)]
        public int RecipeId { get; set; }
        public string RecipeName { get; set; }
        [Key, Column(Order=2)]
        public int IngredientId { get; set; }
        public string IngredientName { get; set; }
        public string Measurement { get; set; }
        public string Unit { get; set; }

    }


}