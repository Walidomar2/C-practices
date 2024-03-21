using Microsoft.Extensions.Configuration;

namespace EF_MappingCode.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
       // public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderWithDetailsView> OrderWithDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .ToTable("Products", schema: "Inventory")
                .HasKey(x => x.Id);

            modelBuilder.Entity<Order>()
                .ToTable("Orders", schema: "Sales")
                .HasKey(x => x.Id);

            modelBuilder.Entity<OrderDetail>()
                .ToTable("OrderDetails", schema: "Sales")
                .HasKey(x => new {x.OrderId , x.ProductId});

            // The view has no keys 
            modelBuilder.Entity<OrderWithDetailsView>()
                .ToView("OrderWithDetailsView")
                .HasNoKey();

            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetSection("constr").Value;

            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
