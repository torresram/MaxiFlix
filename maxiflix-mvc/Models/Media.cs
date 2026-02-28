namespace maxiflix_mvc.Models
{
    public class Media
    {
        public Guid Id { get; set; }
        public string MediaUrl { get; set; }
        public List<Peliculas>? PeliculasMedia { get; set; }
        public List<MediaTipos>? TiposMedia { get; set; }
        public Guid PeliculaId { get; set; }

    }
}
