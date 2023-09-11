namespace MusikWebApp.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        public int GenreId { get; set; }
        public int ArtistId { get; set; }
        public string title { get; set; }
        public decimal price { get; set; }
        public string AlbumArtUrl { get; set; }
        public Artist Artist { get; set; }
        public Genre Genre { get; set; }
    }
}
