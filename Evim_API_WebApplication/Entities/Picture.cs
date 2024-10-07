namespace Evim_API_WebApplication.Entities
{
    public class Picture
    {
        public int PictureId { get; set; }
        public string? PictureName { get; set; }
        public int AdvertisementId { get; set; }

        public virtual Advertisement? Advertisement { get; set; }
    }
}
