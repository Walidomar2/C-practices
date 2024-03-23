using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Migrations.Data.Configurations
{
    public class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();

            builder.Property(x => x.Name)
                .HasColumnType("VARCHAR")
                .HasMaxLength(255).IsRequired();

            builder.ToTable("Instructors");

            builder.HasData(LoadInstructors());
        }

        private List<Instructor> LoadInstructors()
        {
            return new List<Instructor>
            {
                new Instructor { Id = 1, Name = "Ahmed"},
                new Instructor { Id = 2, Name = "Yasmeen"},
                new Instructor { Id = 3, Name = "Khalid" },
                new Instructor { Id = 4, Name = "Nadia" },
                new Instructor { Id = 5, Name = "Ahmed" }
            };
        }
    }
}
