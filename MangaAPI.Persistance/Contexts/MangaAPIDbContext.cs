using MangaAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangaAPI.Persistance.Contexts
{
    public class MangaAPIDbContext : DbContext
    {
        public MangaAPIDbContext(DbContextOptions options) : base(options)
        { }
        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<Manga> Mangas { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configure the connection string and other options
            optionsBuilder.UseNpgsql("User Id=postgres;Password=123456;Host=localhost;Port=5432;Database=postgres;");
        }
    }
}
