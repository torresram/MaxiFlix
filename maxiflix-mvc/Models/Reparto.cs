namespace maxiflix_mvc.Models
{
    public class Reparto
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Guid PaisId { get; set; }
        public Paises? Pais { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string ImagenUrl { get; set; }
        public bool Dirige { get; set; }
    }
}
