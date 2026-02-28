namespace maxiflix_mvc.Models
{
    public class Usuarios
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Clave { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Activo { get; set; }
        public string UrlImgPerfil { get; set; }
    }
}
