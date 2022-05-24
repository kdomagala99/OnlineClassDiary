using Microsoft.EntityFrameworkCore;
using OnlineClassDiaryWebAPI.Entities;

namespace OnlineClassDiaryWebAPI.Database
{
    public class OnlineClassDiaryDbContext : DbContext
    {
        public OnlineClassDiaryDbContext(DbContextOptions<OnlineClassDiaryDbContext> options) : base(options)
        {

        }
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
            modelBuilder.Entity<Attendance>()
                .Property(a => a.Student_Id)
                .IsRequired();
            modelBuilder.Entity<Attendance>()
                .Property(a => a.Teacher_Id)
                .IsRequired();
            modelBuilder.Entity<Attendance>()
                .Property(a => a.Student_Id)
                .IsRequired();

            //class
            modelBuilder.Entity<Class>()
                .Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(50);
            modelBuilder.Entity<Class>()
                .Property(c => c.Teacher_Id)
                .IsRequired();

            //grade
            modelBuilder.Entity<Grade>()
                .Property(g => g.Name)
                .IsRequired()
                .HasMaxLength(50);
            modelBuilder.Entity<Grade>()
                .Property(g => g.Value)
                .IsRequired();
            modelBuilder.Entity<Grade>()
                .Property(g => g.Student_Id)
                .IsRequired();
            modelBuilder.Entity<Grade>()
                .Property(g => g.Teacher_Id)
                .IsRequired();
            modelBuilder.Entity<Grade>()
                .Property(g => g.Date)
                .IsRequired();
            modelBuilder.Entity<Grade>()
                .Property(g => g.Subject_Id)
                .IsRequired();
            modelBuilder.Entity<Grade>()
                .Property(g => g.Semester_Id)
                .IsRequired();

            //role
            modelBuilder.Entity<Role>()
                .Property(r => r.Name)
                .IsRequired()
                .HasMaxLength(50);

            //semester
            modelBuilder.Entity<Semester>()
                .Property(s => s.Date_Begin)
                .IsRequired();
            modelBuilder.Entity<Semester>()
                .Property(s => s.Date_End)
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
        }
    }
}
