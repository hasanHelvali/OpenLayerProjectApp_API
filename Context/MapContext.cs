using BasarSoftProject1_API.Entities;
using Microsoft.EntityFrameworkCore;

namespace BasarSoftProject1_API.Context
{
    public class MapContext:DbContext
    {
        public DbSet<Location> Locations{ get; set; }
        public DbSet<User> Users{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=HASANHELVALI;Initial Catalog=BasarSoftProject1DB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False",
                x=>x.UseNetTopologySuite());
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<LocationAndUser>(entity =>
        //    {
        //        entity.Property(e => e.Location).HasColumnType("geometry");
        //    });
        //}
    }
}
