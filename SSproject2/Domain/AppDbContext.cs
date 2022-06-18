using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SSproject2.Domain.Entities;

namespace SSproject2.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TextFiled> TextFields { get; set; }
        public DbSet<PostItem> PostItems { get; set; }

        public DbSet<Application> Applications { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)//объявление построения модели базы данных
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                Name = "admin",
                NormalizedName = "ADMIN"
            });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id= "11546e06-8719-4ad8-b88a-f271ae9d6eab",
                Name="otdelsmi",
                NormalizedName="OTDELSMI"
            });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "11546e06-8719-4ad8-b88a-f271ae9d7eab",
                Name = "curator",
                NormalizedName = "CURATOR"
            });
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "my@email.com",
                NormalizedEmail = "MY@EMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "superpassword"),
                SecurityStamp = string.Empty
            });
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "3b54472e-4f66-49fa-a20f-e7685b9565d8",
                UserName = "otdelsmi",
                NormalizedUserName = "OTDELSMI",
                Email = "otdelsmi@mail.com",
                NormalizedEmail = "OTDELSMI@mail.com",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "smipassword"),
                SecurityStamp = string.Empty
            });
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "3b54472e-4f66-49fa-a20f-e7685b9565d9",
                UserName = "curator",
                NormalizedUserName = "CURATOR",
                Email = "curator@mail.com",
                NormalizedEmail = "CURATOR@mail.com",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "curatorpassword"),
                SecurityStamp = string.Empty
            });
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                UserId = "3b62472e-4f66-49fa-a20f-e7685b9565d8"
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "11546e06-8719-4ad8-b88a-f271ae9d6eab",
                UserId = "3b54472e-4f66-49fa-a20f-e7685b9565d8"
            });
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "11546e06-8719-4ad8-b88a-f271ae9d7eab",
                UserId = "3b54472e-4f66-49fa-a20f-e7685b9565d9"
            });
            modelBuilder.Entity<TextFiled>().HasData(new TextFiled
            {
                ID = new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                CodeWord = "PageIndex",
                Title = "Главная"
            });
            modelBuilder.Entity<TextFiled>().HasData(new TextFiled
            {
                ID = new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                CodeWord = "PagePosts",
                Title = "Наши Посты"
            });
            modelBuilder.Entity<TextFiled>().HasData(new TextFiled
            {
                ID = new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                CodeWord = "PageContacts",
                Title = "Контакты"
            });
        }
    }

}
