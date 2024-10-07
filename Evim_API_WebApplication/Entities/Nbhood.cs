namespace Evim_API_WebApplication.Entities
{
    public class Nbhood
    {
        public int NbhoodId { get; set; }
        public string? NbhoodName { get; set; }
        public int CityId { get; set; }
        public virtual City? City { get; set; }

        public List<Building>? Buildings { get; set; }
    }
}