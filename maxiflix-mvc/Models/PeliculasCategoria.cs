namespace maxiflix_mvc.Models
{
    public class PeliculasCategoria
    {
        public Guid Id { get; set; }
        public int CategoriaId { get; set; }
        public int PeliculaId { get; set; }
    }
}
