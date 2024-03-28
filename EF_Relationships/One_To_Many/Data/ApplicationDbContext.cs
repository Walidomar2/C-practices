using Microsoft.Extensions.Configuration;

namespace One_To_Many.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            var configuration = new ConfigurationBuilder()
                .AddJsonFile(@"D:\courses\c# .net\C# .NET\practices\EF_Relationships\One_To_Many\appsettings.json")
                .Build();

            var constr = configuration.GetSection("constr").Value;

            optionsBuilder.UseSqlServer("constr");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>()
                 .HasOne(p => p.Blog)
                 .WithMany(b => b.Posts);

            // If i don't have Navigation Properties in Tables 

            //modelBuilder.Entity<Post>()
            //    .HasOne<Blog>()
            //    .WithMany()
            //    .HasForeignKey(p => p.BlogId)
            //    .HasConstraintName("FK_Key");


        }
    }
}
