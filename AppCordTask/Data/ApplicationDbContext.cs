using AppCordTask.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AppCordTask.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SingularizeTableNames(modelBuilder);
            base.OnModelCreating(modelBuilder);
            SeedData(modelBuilder);
        }
        private void SingularizeTableNames(ModelBuilder modelBuilder)
        {
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
                modelBuilder.Entity(entityType.ClrType).ToTable(entityType.ClrType.Name);
            EntityModelConfiguration(modelBuilder);
        }
        private void EntityModelConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PhoneNumber>(entity =>
            {
                entity.HasKey(t => t.Id);
                entity.Property(t => t.Id).ValueGeneratedOnAdd().HasColumnType("int");
                entity.Property(t => t.Number).HasColumnType("nvarchar(1024)").IsRequired();
            });
            modelBuilder.Entity<MessageLog>(entity =>
            {
                entity.HasKey(t => t.Id);
                entity.Property(t => t.Id).ValueGeneratedOnAdd().HasColumnType("int");
                entity.Property(t => t.Message).HasColumnType("nvarchar(1024)").IsRequired();
                entity.HasOne(t => t.PhoneNumber).WithMany(t => t.MessageLogs).HasForeignKey(t => t.PhoneNumberId).OnDelete(DeleteBehavior.Restrict);
            });
        }
        private void SeedData(ModelBuilder modelBuilder)
        {
            for (int i = 1; i < 101; i++)
            {
                modelBuilder.Entity<PhoneNumber>().HasData(new PhoneNumber
                {
                    Id = i,
                    Number = "Phone Number" + i
                });
            }
        }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }
        public DbSet<MessageLog> MessageLogs { get; set; }
    }
}
