namespace Recipes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedRecipeInfo : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.RecipeIngredients", "RecipeId", "dbo.Recipes");
            DropIndex("dbo.RecipeIngredients", new[] { "RecipeId" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.RecipeIngredients", "RecipeId");
            AddForeignKey("dbo.RecipeIngredients", "RecipeId", "dbo.Recipes", "RecipeId", cascadeDelete: true);
        }
    }
}
