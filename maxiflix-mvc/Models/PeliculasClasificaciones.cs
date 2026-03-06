namespace maxiflix_mvc.Models
{
    public class PeliculasClasificaciones
    {
        public Guid Id { get; set; }
        public Guid PeliculaId { get; set; }
        public Peliculas? Pelicula { get; set; }
        public Guid ClasificacionId { get; set; }
        public Clasificaciones? Clasificacion { get; set; }
    }
}
