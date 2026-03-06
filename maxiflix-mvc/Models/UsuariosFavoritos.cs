namespace maxiflix_mvc.Models
{
    public class UsuariosFavoritos
    {
        public Guid Id { get; set; }
        public Guid PeliculaId { get; set; }
        public Peliculas? Pelicula { get; set; }
        public Guid UsuarioId { get; set; }
        public Usuarios? Usuario { get; set; }
        public DateTime FechaFavorito { get; set; }
    }

}
