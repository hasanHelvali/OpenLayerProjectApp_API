using BasarSoftProject1_API.Entities;
using Microsoft.EntityFrameworkCore;

namespace BasarSoftProject1_API.Context
{
    public class MapContext:DbContext
    {
        public DbSet<LocAndUser> LocationsAndUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=HASANHELVALI;Initial Catalog=BasarSoftProject1DB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False",
                x => x.UseNetTopologySuite());
        }
    }

}
