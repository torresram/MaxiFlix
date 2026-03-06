namespace maxiflix_mvc.Models
{
    public class PeliculasGeneros
    {
        public Guid Id { get; set; }
        public Guid GeneroId { get; set; }
        public Generos? Genero { get; set; }
        public Guid PeliculaId { get; set; }
        public Peliculas? Pelicula { get; set; }
    }
}
