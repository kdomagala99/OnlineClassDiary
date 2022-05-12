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

        protected override void OnModelCreating(ModelBuilder modelBuilder) { }
    }
}
