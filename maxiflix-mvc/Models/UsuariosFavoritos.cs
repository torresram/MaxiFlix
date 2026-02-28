namespace maxiflix_mvc.Models
{
    public class UsuariosFavoritos
    {
        public Guid Id { get; set; }
        public int PeliculaId { get; set; }
        public int UsuarioId { get; set; }
        public DateTime FechaFavorito { get; set; }
    }

}
