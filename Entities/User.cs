namespace BasarSoftProject1_API.Entities
{
    public class User
    {
        public int ID { get; set; }
        public string NameSurname { get; set; }
        public List<Location> Locations { get; set; }
    }
}
