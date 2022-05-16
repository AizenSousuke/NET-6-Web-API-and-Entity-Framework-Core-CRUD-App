using CRUD_with_a_NET_6_Web_API_and_Entity_Framework_Core.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_with_a_NET_6_Web_API_and_Entity_Framework_Core.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<SuperHero> SuperHeroes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SuperHero>().HasData(
                    new SuperHero() { Id = 1, FirstName = "Peter", LastName = "Parker", Name = "Spiderman", Place = "New York" },
                    new SuperHero() { Id = 2, FirstName = "Misaka", LastName = "Mikoto", Name = "Misaka Mikoto", Place = "Academy City" }
                );
        }
    }
}
