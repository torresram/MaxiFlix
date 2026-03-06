namespace maxiflix_mvc.Models
{
    public class PeliculasPlataformas
    {
        public Guid Id { get; set; }
        public Guid PeliculaId { get; set; }
        public Peliculas? Pelicula { get; set; }
        public Guid PlataformaId { get; set; }
        public Plataformas? Plataforma { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaBaja { get; set; }
    }
}
