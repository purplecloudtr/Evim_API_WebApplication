namespace Evim_API_WebApplication.Entities
{
    public class Building
    {
        public int BuildingId { get; set; }
        public string? BuildingName { get; set; }

        public int NbhoodId { get; set; }

        public virtual Nbhood? Nbhood { get; set; }
    }
}
