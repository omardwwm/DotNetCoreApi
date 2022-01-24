using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspNetProjetFinal.Migrations
{
    public partial class migrationv11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IngredientRecipes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IngredientRecipes",
                columns: table => new
                {
                    RecipeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IngredientId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientRecipes", x => new { x.RecipeId, x.IngredientId });
                    table.ForeignKey(
                        name: "FK_IngredientRecipes_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngredientRecipes_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IngredientRecipes_IngredientId",
                table: "IngredientRecipes",
                column: "IngredientId");
        }
    }
}
