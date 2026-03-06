using maxiflix_mvc.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace maxiflix_mvc.Data
{
    public class MaxiFlixDbContext : DbContext
    {
        public MaxiFlixDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Categorias> Categorias { get; set; }
        public DbSet<Clasificaciones> Clasificaciones { get; set; }
        public DbSet<Generos> Generos { get; set; }
        public DbSet<Media> Media { get; set; }
        public DbSet<MediaTipos> MediaTipos { get; set; }
        public DbSet<Paises> Paises { get; set; }
        public DbSet<Peliculas> Peliculas { get; set; }
        public DbSet<Plataformas> Plataformas { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<UsuariosFavoritos> UsuariosFavoritos { get; set; }
        public DbSet<Reparto> Reparto { get; set; }
        public DbSet<PeliculasCategoria> PeliculasCategorias { get; set; }
        public DbSet<PeliculasClasificaciones> PeliculasClasificaciones { get; set; }
        public DbSet<PeliculasGeneros> PeliculasGeneros { get; set; }
        public DbSet<PeliculasPlataformas>  PeliculasPlataformas { get; set; }
        public DbSet<PeliculasPuntuacion> PeliculasPuntuaciones { get; set; }
        public DbSet<PeliculasReparto> PeliculasReparto { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Esto modifica la propiedad precio en la tabla especificada
            modelBuilder.Entity<Plataformas>()
                .Property(p => p.Precio)
                .HasPrecision(18, 2);

            //Esto cambia el borrado de datos a Restrict en todas las tablas
            base.OnModelCreating(modelBuilder);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
    }
}
