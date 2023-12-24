using MangaAPI.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace MangaAPI.Persistance
{
   public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<MangaAPIDbContext>
    {
       public MangaAPIDbContext CreateDbContext(string[] args)
    {
            DbContextOptionsBuilder<MangaAPIDbContext> dbContextOptionsBuilder = new();
           dbContextOptionsBuilder.UseNpgsql(Configuration.ConnectionString);
           return new(dbContextOptionsBuilder.Options);
        }
    }
}
