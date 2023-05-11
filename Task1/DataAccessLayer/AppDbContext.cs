using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Task1.Models;

namespace Task1.DataAccessLayer
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Marka> Markas { get; set; }
        public DbSet<Modell> Models { get; set; }
        public DbSet<Car> Cars { get; set; }
    }
}
