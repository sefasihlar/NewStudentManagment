using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NLayer.Core.Concreate;
using System.Reflection;

namespace NLayer.Repository.Concreate
{
    public class AppDbContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectEmployees> ProjectEmployees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<DepartmentEmployees> DepartmentEmployees { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<TodoList> TodoLists { get; set; }
        public DbSet<Day> Days { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Polling> Pollings { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentPolling> StudentPollings { get; set; }
    }



}
