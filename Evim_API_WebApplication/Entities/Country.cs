namespace Evim_API_WebApplication.Entities
{
    public class Country
    {
        public int CountryId { get; set; }
        public string? CountryName { get; set; }

        public virtual List<City>? Cities { get; set; }

    }
}
