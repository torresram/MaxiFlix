using System.ComponentModel.DataAnnotations.Schema;

namespace maxiflix_mvc.Models
{
    public class Media
    {
        public Guid Id { get; set; }
        public Guid PeliculaId { get; set; }
        public Peliculas? Pelicula { get; set; }
        public string? MediaUrl { get; set; }
        public Guid TipoId { get; set; }
        public MediaTipos? Tipo { get; set; }
    }
}
