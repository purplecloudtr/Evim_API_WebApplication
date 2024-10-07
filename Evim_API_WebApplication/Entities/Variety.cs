namespace Evim_API_WebApplication.Entities
{
    public class Variety
    {
        public int VarietyId { get; set; }
        public string? VarietyName { get; set; }
        public int SituationId { get; set; }

        public virtual Situation? Situation { get; set; }
    }
}
