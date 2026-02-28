using System.ComponentModel;

namespace maxiflix_mvc.Models
{
    public class Peliculas
    {
        public Guid Id { get; set; }
        public DateTime FechaEstreno { get; set; }
        public string Titulo { get; set; }
        public int MinutosDuracion { get; set; }
        public string Sinopsis { get; set; }
        public int RepartoId { get; set; }
    }
}
