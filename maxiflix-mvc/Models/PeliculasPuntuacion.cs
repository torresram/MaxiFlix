using System.ComponentModel.DataAnnotations;

namespace maxiflix_mvc.Models
{
    public class PeliculasPuntuacion
    {
        public Guid Id { get; set; }
        public int PeliculaId { get; set; }
        public int UsuarioId { get; set; }
        [Range(1,5)]
        public byte Puntuacion { get; set; }

    }
}
