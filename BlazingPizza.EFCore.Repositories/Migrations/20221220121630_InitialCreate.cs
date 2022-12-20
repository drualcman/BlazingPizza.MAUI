using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazingPizza.EFCore.Repositories.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Specials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BasePrice = table.Column<decimal>(type: "decimal(8,2)", precision: 8, scale: 2, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specials", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Specials",
                columns: new[] { "Id", "BasePrice", "Description", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, 189.99m, "Es de queso y delicioso. Porque no querrias una?", "cheese.jpg", "Pizza clasica de queso" },
                    { 2, 227.99m, "Tiene TODO tipo de tocino", "bacon.jpg", "Tocinator" },
                    { 3, 199.50m, "Es la pizza con la que creciste, ¡pero ardientemente deliciosa!", "pepperoni.jpg", "Clásica de pepperoni" },
                    { 4, 228.75m, "Pollo picante, salsa picante y queso azul, garantizado que entrarás en calor", "meaty.jpg", "Pollo búfalo" },
                    { 5, 209.00m, "Tiene champiñones. ¿No es obvio?", "mushroom.jpg", "Amantes del champiñón" },
                    { 6, 190.25m, "De piña, jamón y queso...", "hawaiian.jpg", "Hawaiana" },
                    { 7, 218.50m, "Es como una ensalada, pero en una pizza", "salad.jpg", "Delicia vegetariana" },
                    { 8, 189.99m, "Pizza italiana tradicional con tomates y albahaca", "margherita.jpg", "Margarita" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Specials");
        }
    }
}
