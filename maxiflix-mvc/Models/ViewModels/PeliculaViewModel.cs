namespace maxiflix_mvc.Models.ViewModels
{
    public class PeliculaViewModel
    {
        public Peliculas? Pelicula { get; set; }
        public List<Media>? Medias { get; set; }
        public List<PeliculasCategoria>? Categorias { get; set; }
        public List<PeliculasGeneros>? Generos { get; set; }
        public List<PeliculasReparto>? Reparto { get; set; }
        public PeliculasClasificaciones? Clasificacion { get; set; }
        public double Puntuacion { get; set; }
        public int CantidadPuntuaciones { get; set; }
    }
}
