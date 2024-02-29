using NetTopologySuite.Geometries;

namespace BasarSoftProject1_API.Entities
{
    public class Location
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public Geometry Geometry { get; set; }
    }
}
