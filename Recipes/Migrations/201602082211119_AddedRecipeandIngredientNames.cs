namespace Recipes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedRecipeandIngredientNames : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RecipeIngredients", "RecipeName", c => c.String());
            AddColumn("dbo.RecipeIngredients", "IngredientName", c => c.String());
            CreateIndex("dbo.RecipeIngredients", "RecipeId");
            AddForeignKey("dbo.RecipeIngredients", "RecipeId", "dbo.Recipes", "RecipeId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RecipeIngredients", "RecipeId", "dbo.Recipes");
            DropIndex("dbo.RecipeIngredients", new[] { "RecipeId" });
            DropColumn("dbo.RecipeIngredients", "IngredientName");
            DropColumn("dbo.RecipeIngredients", "RecipeName");
        }
    }
}
