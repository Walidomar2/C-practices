namespace ASP_Core_Middlewares.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(ProductsData());  
        }

        private List<Product> ProductsData()
        {
            return new List<Product>
            {
                new Product{Id=1, Name="Laptop", Description="Device1"},
                new Product{Id=2, Name="Mobile", Description="Device2"},
                new Product{Id=3, Name="Smart Watch", Description="Device3"}
            };
        }
    }
}
