using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 1);

            migrationBuilder.AlterColumn<double>(
                name: "Age",
                table: "Pets",
                type: "double",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "PetId", "Age", "Breed", "Description", "Gender", "Name", "Type" },
                values: new object[,]
                {
                    { 3, 1.2, "Maine Coon", "Massive fat cat; looking to be ~25lbs when fully grown", "Female", "Mango", "Cat" },
                    { 4, 8.5, "Chiwawa", "Mi quero Taco Bell", "Female", "Taco", "Dog" },
                    { 5, 4.0, "Great Dane", "Long Haired; White/Orangish in color", "Male", "Sebashian", "Dog" },
                    { 6, 12.0, "Golden Retriever", "Golden in color; great with kids", "Male", "Doug", "Dog" },
                    { 7, 3.75, "Calico", "Long Haired; very fiesty; loves tuna treats", "Female", "Meow", "Cat" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 7);

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "Pets",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double");

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "PetId", "Age", "Breed", "Description", "Gender", "Name", "Type" },
                values: new object[] { 1, 3, "RagaMuffin", "Long Haired; White/Orangish in color", "Female", "Tiffany", "Cat" });
        }
    }
}
