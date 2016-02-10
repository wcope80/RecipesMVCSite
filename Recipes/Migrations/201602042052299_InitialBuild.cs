namespace Recipes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialBuild : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ingredients",
                c => new
                    {
                        IngredientId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.IngredientId);
            
            CreateTable(
                "dbo.RecipeIngredients",
                c => new
                    {
                        RecipeId = c.Int(nullable: false),
                        IngredientId = c.Int(nullable: false),
                        Measurement = c.String(),
                        Unit = c.String(),
                    })
                .PrimaryKey(t => new { t.RecipeId, t.IngredientId });
            
            CreateTable(
                "dbo.Recipes",
                c => new
                    {
                        RecipeId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Category = c.String(),
                    })
                .PrimaryKey(t => t.RecipeId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Recipes");
            DropTable("dbo.RecipeIngredients");
            DropTable("dbo.Ingredients");
        }
    }
}
