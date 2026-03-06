using System.ComponentModel.DataAnnotations;

namespace maxiflix_mvc.Models
{
    public class PeliculasPuntuacion
    {
        public Guid Id { get; set; }
        public Guid PeliculaId { get; set; }
        public Peliculas? Pelicula { get; set; }
        public Guid UsuarioId { get; set; }
        public Usuarios? Usuario { get; set; }
        [Range(1,5)]
        public byte Puntuacion { get; set; }
        public DateTime FechaPuntuacion { get; set; }

    }
}
