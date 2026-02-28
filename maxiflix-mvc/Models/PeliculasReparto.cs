using Microsoft.AspNetCore.Components.Web;
using System.Reflection.Metadata.Ecma335;

namespace maxiflix_mvc.Models
{
    public class PeliculasReparto
    {
        public Guid Id { get; set; }
        public int RepartoId { get; set; }
        public int PeliculaId { get; set; }
        public bool Protagonista { get; set; }
    }
}
