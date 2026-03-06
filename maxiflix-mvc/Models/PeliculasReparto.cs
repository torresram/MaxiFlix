using Microsoft.AspNetCore.Components.Web;
using System.Reflection.Metadata.Ecma335;

namespace maxiflix_mvc.Models
{
    public class PeliculasReparto
    {
        public Guid Id { get; set; }
        public Guid RepartoId { get; set; }
        public Reparto? Reparto { get; set; }
        public Guid PeliculaId { get; set; }
        public Peliculas? Pelicula { get; set; }
        public bool Protagonista { get; set; }
    }
}
