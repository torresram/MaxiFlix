using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace maxiflix_mvc.Models
{
    public class Peliculas
    {
        public Guid Id { get; set; }
        [DataType(DataType.Date)]
        public DateTime FechaEstreno { get; set; }
        public string? Titulo { get; set; }
        public int MinutosDuracion { get; set; }
        public string? Sinopsis { get; set; }
        public Guid? RepartoId { get; set; } //Este seria el director de la db
        public Reparto? Director { get; set; }
    }
}
