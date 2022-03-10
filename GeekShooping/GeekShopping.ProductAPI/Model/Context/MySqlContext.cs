using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class MySqlContext : DbContext
    {
        public MySqlContext() {}
        public MySqlContext(DbContextOptions <MySqlContext> options) : base(options) {}

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Camiseta G",
                Price = new decimal(58.88),
                Description = "Camiseta casual",
                ImageUrl = "C:\\Users\\Rodolfo\\Pictures\\MicrosserviceImg\\camiseta-personalizada.jpg",
                CategoryName = "T-Shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Ventilador",
                Price = new decimal(58.88),
                Description = "Ventilador de chão",
                ImageUrl = "C:\\Users\\Rodolfo\\Pictures\\MicrosserviceImg\\ventilador.jpg",
                CategoryName = "Eletroeletrônicos"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Tênis",
                Price = new decimal(58.88),
                Description = "Tênis preto e amarelo",
                ImageUrl = "C:\\Users\\Rodolfo\\Pictures\\MicrosserviceImg\\tenis.jpg",
                CategoryName = "Shoew"
            });
        }
    }
}
