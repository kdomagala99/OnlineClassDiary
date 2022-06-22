using Microsoft.EntityFrameworkCore;
using OnlineClassDiaryWebAPI.Entities;

namespace OnlineClassDiaryWebAPI.Database
{
    public class OnlineClassDiaryDbContext : DbContext
    {
        private readonly string _connectionString = "Server=(localdb)\\mssqllocaldb;Database=OnlineClassDiaryDb2;Trusted_Connection=True;";

        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Semester> Semesters { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //attendance
            modelBuilder.Entity<Attendance>()
                .Property(a => a.Date)
                .IsRequired();

            //class
            modelBuilder.Entity<Class>()
                .Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(50);

            //grade
            modelBuilder.Entity<Grade>()
                .HasOne(g => g.Subject)
                .WithMany()
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Grade>()
                .Property(g => g.Name)
                .IsRequired()
                .HasMaxLength(50);
            modelBuilder.Entity<Grade>()
                .Property(g => g.Value)
                .IsRequired();
            modelBuilder.Entity<Grade>()
                .Property(g => g.Date)
                .IsRequired();

            //role
            modelBuilder.Entity<Role>()
                .Property(r => r.Name)
                .IsRequired()
                .HasMaxLength(50);

            //semester
            modelBuilder.Entity<Semester>()
                .Property(s => s.DateBegin)
                .IsRequired();
            modelBuilder.Entity<Semester>()
                .Property(s => s.DateEnd)
                .IsRequired();

            //status
            modelBuilder.Entity<Status>()
                .Property(r => r.Name)
                .IsRequired()
                .HasMaxLength(50);

            //subject
            modelBuilder.Entity<Subject>()
                .Property(r => r.Name)
                .IsRequired()
                .HasMaxLength(50);
                
            //user
            modelBuilder.Entity<User>()
                .Property(u => u.Name)
                .IsRequired()
                .HasMaxLength(50);
            modelBuilder.Entity<User>()
                .Property(u => u.Surname)
                .IsRequired()
                .HasMaxLength(50);
            modelBuilder.Entity<User>()
                .Property(u => u.PESEL)
                .IsRequired();
            modelBuilder.Entity<User>()
                .HasOne(u => u.Class)
                .WithMany(u => u.StudentsList);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
