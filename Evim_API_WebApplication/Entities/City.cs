namespace Evim_API_WebApplication.Entities
{
    public class City
    {
        public int CityId { get; set; }
        public string? CityName { get; set; }

       public List<Nbhood>? Nbhoods { get; set; }
        public int CountryId { get; set; }
    }
}
