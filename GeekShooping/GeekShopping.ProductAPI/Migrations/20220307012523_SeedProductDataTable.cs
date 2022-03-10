using Microsoft.EntityFrameworkCore.Migrations;

namespace GeekShopping.ProductAPI.Migrations
{
    public partial class SeedProductDataTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "image_url", "name", "price" },
                values: new object[] { 3L, "T-Shirt", "Camiseta casual", "C:\\Users\\Rodolfo\\Pictures\\MicrosserviceImg\\camiseta-personalizada.jpg", "Camiseta G", 58.88m });

            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "image_url", "name", "price" },
                values: new object[] { 4L, "Eletroeletrônicos", "Ventilador de chão", "C:\\Users\\Rodolfo\\Pictures\\MicrosserviceImg\\ventilador.jpg", "Ventilador", 58.88m });

            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "image_url", "name", "price" },
                values: new object[] { 5L, "Shoew", "Tênis preto e amarelo", "C:\\Users\\Rodolfo\\Pictures\\MicrosserviceImg\\tenis.jpg", "Tênis", 58.88m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 5L);
        }
    }
}
