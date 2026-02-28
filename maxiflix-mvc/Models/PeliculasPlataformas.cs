namespace maxiflix_mvc.Models
{
    public class PeliculasPlataformas
    {
        public Guid Id { get; set; }
        public int PeliculaId { get; set; }
        public int PlataformaId { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaBaja { get; set; }
    }
}
