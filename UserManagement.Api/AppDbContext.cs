using Microsoft.EntityFrameworkCore;

namespace UserManagement.Api
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasData(
                new User() { Id = 1, Name = "Иван Иванов", Login ="ivan_admin", Password = "password123"},
                new User() { Id = 2, Name = "Василий Васильевич", Login = "Vasiliych_user", Password = "passwordqwe"},
                new User() { Id = 3, Name = "Петя Петрович", Login = "Petrovich_user", Password = "passwordwqe"},
                // Это будет мой новый юзер в проекте для реализации CURD c# 
                new User() { Id = 4, Name = "Роман Романович", Login = "Romanovich_user",Password = "passwordqqq"}
            );
        }

    }
}