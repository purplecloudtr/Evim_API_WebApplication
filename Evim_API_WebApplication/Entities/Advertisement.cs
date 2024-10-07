namespace Evim_API_WebApplication.Entities
{
    public class Advertisement
    {
        public int AdvertisementId { get; set; }

        public string? Description { get; set; }

        public double Price { get; set; }

        public int Rooms { get; set; }

        public int Bathrooms { get; set; }

        public bool Loan { get; set; }

       public string? PhoneNumber { get; set; }

       public string? Address { get; set; }

        public string? UserName { get; set; }

        public int CityId { get; set; }

        public int NbhoodId {  get; set; }

        public int SituationId { get; set; }

        public int BuildingId { get; set; }

        public Building? Building { get; set; }

        public int VarietyId { get; set; }
        public Variety? Variety { get; set; }

        public List<Picture>? Picture { get; set; }
    }
}
