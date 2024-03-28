namespace Many_To_Many.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Post> Posts { get; set; }  
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            var configuration = new ConfigurationBuilder()
                .AddJsonFile(@"D:\courses\c# .net\C# .NET\practices\EF_Relationships\Many_To_Many\appsettings.json")
                .Build();

            var constr = configuration.GetSection("constr").Value;

            optionsBuilder.UseSqlServer("constr");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>()
                .HasMany(p => p.Tags)
                .WithMany(t => t.Posts)
                .UsingEntity<PostTags>(
                    j => j.HasOne(p => p.Tag)
                            .WithMany(t => t.PostTags)
                            .HasForeignKey(p => p.TagId),

                    j => j.HasOne(p => p.post)
                            .WithMany(t => t.PostTags)
                            .HasForeignKey(p => p.PostId),

                    j => { j.Property(p => p.AddOn).HasDefaultValueSql("GETDATE()");
                        j.HasKey(t => new { t.TagId, t.PostId });
                        }
                );
        }
    }
}
