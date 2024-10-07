namespace Evim_API_WebApplication.Entities
{
    public class Situation
    {
        public int SituationId { get; set; }
        public string? SituationName { get; set; }
        public List <Variety>? Varieties { get; set; }
    }
}
