namespace maxiflix_mvc.Models
{
    public class PeliculasCategoria
    {
        public Guid Id { get; set; }
        public Guid CategoriaId { get; set; }
        public Categorias? Categoria { get; set; }
        public Guid PeliculaId { get; set; }
        public Peliculas? Pelicula { get; set; }
    }
}
