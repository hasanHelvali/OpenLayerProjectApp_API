using BasarSoftProject1_API.Entities;
using NetTopologySuite.Geometries;

namespace BasarSoftProject1_API.DTOs
{
    public class LocationAndUser
    {
        public int? ID { get; set; }
        public string ?Name { get; set; }
        public string ?Type { get; set; }
        public List<object>? Coordinates { get; set; }
    }
}
