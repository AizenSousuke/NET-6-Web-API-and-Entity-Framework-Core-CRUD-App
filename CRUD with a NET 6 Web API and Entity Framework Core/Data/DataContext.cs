using CRUD_with_a_NET_6_Web_API_and_Entity_Framework_Core.Enums;
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
        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Human> Humans { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SuperHero>().HasData(
                    new SuperHero() { Id = 1, FirstName = "Peter", LastName = "Parker", Name = "Spiderman", Place = "New York" },
                    new SuperHero() { Id = 2, FirstName = "Misaka", LastName = "Mikoto", Name = "Misaka Mikoto", Place = "Academy City" }
                );

            modelBuilder.Entity<Weapon>().HasData(
                    new Weapon() { Id = 1, Name = "Sword", Type = WeaponType.Melee, Damage = 1 },
                    new Weapon() { Id = 2, Name = "Gun", Type = WeaponType.Ranged, Damage = 1 }
                );

            modelBuilder.Entity<Role>().HasData(
                    new Role() { Id = 1, Name = "Admin" }
                );

            modelBuilder.Entity<User>().HasData(
                    new User() { Id = 1, Name = "Nik" }
                );

            //modelBuilder.Entity<User>().HasMany(c => c.Roles).WithOne(u => u.User);

            //modelBuilder.Entity<Human>()
            //    .HasMany(h => h.Parents)
            //    .WithMany(p => p.Childrens)
            //    .UsingEntity<Human>(
            //    "HumanHuman",
            //    r => r.HasOne<Human>().WithMany("Parents").HasForeignKey("ParentsId"),
            //    l => l.HasOne<Human>().WithMany("Children").HasForeignKey("ChildrensId"),
            //    je =>
            //    {
            //        je.HasKey("ParentId", "ChildrenId");
            //        je.HasData(new { ParentsId = 1, ChildrensId = 2 });
            //    });

            //modelBuilder.Entity<Human>(b =>
            //{
            //    b.HasData(
            //        new Human()
            //        {
            //            Id = Guid.NewGuid(),
            //            Name = "Peter Parker",
            //        }
            //    );
            //    b.OwnsMany(c => c.Childrens).HasData(
            //        new Human()
            //        {
            //            Id = Guid.NewGuid(),
            //            Name = "Mary Jane",
            //        }, new Human()
            //        {
            //            Id = Guid.NewGuid(),
            //            Name = "John Doe",
            //        });
            //});

            //modelBuilder.Entity<Human>().HasData(
            //    new Human()
            //    {
            //        Id = Guid.NewGuid(),
            //        Name = "Peter Parker"
            //    });

            //modelBuilder.Entity<Human>().HasData(
            //    new Human()
            //    {
            //        Id = Guid.NewGuid(),
            //        Name = "Mary Jane",
            //        Parents =
            //    });
        }
    }
}
