namespace EF_Migrations.Data
{
    public class ApplicationDbContext :DbContext
    {
        public DbSet<Course> Courses { get; set; }  
        public DbSet<Instructor> Instructors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            var config = new ConfigurationBuilder()
                .AddJsonFile(@"D:\courses\c# .net\C# .NET\practices\EF_Migrations\appsettings.json")
                .Build();

            var constring = config.GetSection("constr").Value;

            optionsBuilder.UseSqlServer(constring); 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}
