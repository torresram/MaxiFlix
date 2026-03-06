using maxiflix_mvc.Models;

namespace maxiflix_mvc.Data
{
    public static class DbSeeder
    {
        public static void Seed(MaxiFlixDbContext context)
        {
            if (context.Peliculas.Any())
                return;

            SeedPaises(context);
            SeedGeneros(context);
            SeedCategorias(context);
            SeedClasificaciones(context);
            SeedMediaTipos(context);
            SeedPlataformas(context);
            SeedReparto(context);
            SeedPeliculas(context);
            SeedPeliculasReparto(context);
            SeedPeliculasGeneros(context);
            SeedPeliculasCategorias(context);
            SeedPeliculasClasificaciones(context);
            SeedPeliculasPlataformas(context);
            SeedMedia(context);
            SeedUsuarios(context);
            SeedPeliculasPuntuacion(context);
            SeedUsuariosFavoritos(context);
        }

        private static void SeedPaises(MaxiFlixDbContext context)
        {
            var paises = new List<Paises>
        {
            new() { Id = Guid.NewGuid(), Nombre = "Estados Unidos" },
            new() { Id = Guid.NewGuid(), Nombre = "Reino Unido" },
            new() { Id = Guid.NewGuid(), Nombre = "Canadá" },
            new() { Id = Guid.NewGuid(), Nombre = "Australia" },
            new() { Id = Guid.NewGuid(), Nombre = "Nueva Zelanda" },
            new() { Id = Guid.NewGuid(), Nombre = "Irlanda" },
            new() { Id = Guid.NewGuid(), Nombre = "Alemania" },
            new() { Id = Guid.NewGuid(), Nombre = "Francia" },
            new() { Id = Guid.NewGuid(), Nombre = "Italia" },
            new() { Id = Guid.NewGuid(), Nombre = "Corea del Sur" }
        };
            context.Paises.AddRange(paises);
            context.SaveChanges();
        }

        private static void SeedGeneros(MaxiFlixDbContext context)
        {
            var generos = new List<Generos>
        {
            new() { Id = Guid.NewGuid(), Descripcion = "Drama" },
            new() { Id = Guid.NewGuid(), Descripcion = "Crimen" },
            new() { Id = Guid.NewGuid(), Descripcion = "Ciencia Ficción" },
            new() { Id = Guid.NewGuid(), Descripcion = "Acción" },
            new() { Id = Guid.NewGuid(), Descripcion = "Aventura" },
            new() { Id = Guid.NewGuid(), Descripcion = "Suspense" },
            new() { Id = Guid.NewGuid(), Descripcion = "Bélica" },
            new() { Id = Guid.NewGuid(), Descripcion = "Fantasía" },
            new() { Id = Guid.NewGuid(), Descripcion = "Romance" },
            new() { Id = Guid.NewGuid(), Descripcion = "Comedia" },
            new() { Id = Guid.NewGuid(), Descripcion = "Terror" },
            new() { Id = Guid.NewGuid(), Descripcion = "Misterio" },
            new() { Id = Guid.NewGuid(), Descripcion = "Histórica" },
            new() { Id = Guid.NewGuid(), Descripcion = "Western" },
            new() { Id = Guid.NewGuid(), Descripcion = "Animación" },
            new() { Id = Guid.NewGuid(), Descripcion = "Thriller" }
        };
            context.Generos.AddRange(generos);
            context.SaveChanges();
        }

        private static void SeedCategorias(MaxiFlixDbContext context)
        {
            var categorias = new List<Categorias>
        {
            new() { Id = Guid.NewGuid(), Descripcion = "Clásicos" },
            new() { Id = Guid.NewGuid(), Descripcion = "Modernos" },
            new() { Id = Guid.NewGuid(), Descripcion = "Premiados" },
            new() { Id = Guid.NewGuid(), Descripcion = "Populares" },
            new() { Id = Guid.NewGuid(), Descripcion = "Cine de Culto" },
            new() { Id = Guid.NewGuid(), Descripcion = "Blockbusters" }
        };
            context.Categorias.AddRange(categorias);
            context.SaveChanges();
        }

        private static void SeedClasificaciones(MaxiFlixDbContext context)
        {
            var clasificaciones = new List<Clasificaciones>
        {
            new() { Id = Guid.NewGuid(), Descripcion = "G - Apta para todos los públicos" },
            new() { Id = Guid.NewGuid(), Descripcion = "PG - Sugiere orientación parental" },
            new() { Id = Guid.NewGuid(), Descripcion = "PG-13 - Mayores de 13 años" },
            new() { Id = Guid.NewGuid(), Descripcion = "R - Mayores de 17 años" },
            new() { Id = Guid.NewGuid(), Descripcion = "NC-17 - Mayores de 18 años" }
        };
            context.Clasificaciones.AddRange(clasificaciones);
            context.SaveChanges();
        }

        private static void SeedMediaTipos(MaxiFlixDbContext context)
        {
            var tipos = new List<MediaTipos>
        {
            new() { Id = Guid.NewGuid(), Descripcion = "Poster" },
            new() { Id = Guid.NewGuid(), Descripcion = "Backdrop" },
            new() { Id = Guid.NewGuid(), Descripcion = "Trailer" },
            new() { Id = Guid.NewGuid(), Descripcion = "Imagen de Actor" }
        };
            context.MediaTipos.AddRange(tipos);
            context.SaveChanges();
        }

        private static void SeedPlataformas(MaxiFlixDbContext context)
        {
            var plataformas = new List<Plataformas>
        {
            new() { Id = Guid.NewGuid(), Nombre = "Netflix", Precio = 15.99m },
            new() { Id = Guid.NewGuid(), Nombre = "Amazon Prime Video", Precio = 12.99m },
            new() { Id = Guid.NewGuid(), Nombre = "Disney+", Precio = 10.99m },
            new() { Id = Guid.NewGuid(), Nombre = "HBO Max", Precio = 14.99m },
            new() { Id = Guid.NewGuid(), Nombre = "Hulu", Precio = 11.99m },
            new() { Id = Guid.NewGuid(), Nombre = "Apple TV+", Precio = 9.99m },
            new() { Id = Guid.NewGuid(), Nombre = "Paramount+", Precio = 8.99m }
        };
            context.Plataformas.AddRange(plataformas);
            context.SaveChanges();
        }

        private static void SeedReparto(MaxiFlixDbContext context)
        {
            var usa = context.Paises.First(p => p.Nombre == "Estados Unidos").Id;
            var uk = context.Paises.First(p => p.Nombre == "Reino Unido").Id;
            var canada = context.Paises.First(p => p.Nombre == "Canadá").Id;
            var australia = context.Paises.First(p => p.Nombre == "Australia").Id;
            var alemania = context.Paises.First(p => p.Nombre == "Alemania").Id;
            var francia = context.Paises.First(p => p.Nombre == "Francia").Id;
            var irlanda = context.Paises.First(p => p.Nombre == "Irlanda").Id;

            var reparto = new List<Reparto>
        {
            // Directores y Actores - The Godfather
            new() { Id = Guid.NewGuid(), Nombre = "Francis Ford", Apellido = "Coppola", PaisId = usa, FechaNacimiento = new DateTime(1939, 4, 7), ImagenUrl = "https://image.tmdb.org/t/p/w200/7gG0VvQ4F9l5Q8ZJ9Y3X1K2L4M.jpg", Dirige = true },
            new() { Id = Guid.NewGuid(), Nombre = "Marlon", Apellido = "Brando", PaisId = usa, FechaNacimiento = new DateTime(1924, 4, 3), ImagenUrl = "https://image.tmdb.org/t/p/w200/9e2E0w3s5t7y1u8i9o0p.jpg", Dirige = false },
            new() { Id = Guid.NewGuid(), Nombre = "Al", Apellido = "Pacino", PaisId = usa, FechaNacimiento = new DateTime(1940, 4, 25), ImagenUrl = "https://image.tmdb.org/t/p/w200/2fF4f5g6h7j8k9l0z1x2c.jpg", Dirige = false },
            new() { Id = Guid.NewGuid(), Nombre = "James", Apellido = "Caan", PaisId = usa, FechaNacimiento = new DateTime(1940, 3, 26), ImagenUrl = "https://image.tmdb.org/t/p/w200/3gH4j5k6l7z8x9c0v1b2n.jpg", Dirige = false },
            
            // Pulp Fiction
            new() { Id = Guid.NewGuid(), Nombre = "Quentin", Apellido = "Tarantino", PaisId = usa, FechaNacimiento = new DateTime(1963, 3, 27), ImagenUrl = "https://image.tmdb.org/t/p/w200/4hJ5k6l7z8x9c0v1b2n3m.jpg", Dirige = true },
            new() { Id = Guid.NewGuid(), Nombre = "John", Apellido = "Travolta", PaisId = usa, FechaNacimiento = new DateTime(1954, 2, 18), ImagenUrl = "https://image.tmdb.org/t/p/w200/5k6l7z8x9c0v1b2n3m4a.jpg", Dirige = false },
            new() { Id = Guid.NewGuid(), Nombre = "Samuel L.", Apellido = "Jackson", PaisId = usa, FechaNacimiento = new DateTime(1948, 12, 21), ImagenUrl = "https://image.tmdb.org/t/p/w200/6l7z8x9c0v1b2n3m4a5s.jpg", Dirige = false },
            new() { Id = Guid.NewGuid(), Nombre = "Uma", Apellido = "Thurman", PaisId = usa, FechaNacimiento = new DateTime(1970, 4, 29), ImagenUrl = "https://image.tmdb.org/t/p/w200/7z8x9c0v1b2n3m4a5s6d.jpg", Dirige = false },
            new() { Id = Guid.NewGuid(), Nombre = "Bruce", Apellido = "Willis", PaisId = usa, FechaNacimiento = new DateTime(1955, 3, 19), ImagenUrl = "https://image.tmdb.org/t/p/w200/8x9c0v1b2n3m4a5s6d7f.jpg", Dirige = false },
            
            // The Shawshank Redemption
            new() { Id = Guid.NewGuid(), Nombre = "Frank", Apellido = "Darabont", PaisId = usa, FechaNacimiento = new DateTime(1959, 1, 28), ImagenUrl = "https://image.tmdb.org/t/p/w200/9c0v1b2n3m4a5s6d7f8g.jpg", Dirige = true },
            new() { Id = Guid.NewGuid(), Nombre = "Tim", Apellido = "Robbins", PaisId = usa, FechaNacimiento = new DateTime(1958, 10, 16), ImagenUrl = "https://image.tmdb.org/t/p/w200/0v1b2n3m4a5s6d7f8g9h.jpg", Dirige = false },
            new() { Id = Guid.NewGuid(), Nombre = "Morgan", Apellido = "Freeman", PaisId = usa, FechaNacimiento = new DateTime(1937, 6, 1), ImagenUrl = "https://image.tmdb.org/t/p/w200/1b2n3m4a5s6d7f8g9h0j.jpg", Dirige = false },
            
            // Forrest Gump
            new() { Id = Guid.NewGuid(), Nombre = "Robert", Apellido = "Zemeckis", PaisId = usa, FechaNacimiento = new DateTime(1951, 5, 14), ImagenUrl = "https://image.tmdb.org/t/p/w200/2n3m4a5s6d7f8g9h0j1k.jpg", Dirige = true },
            new() { Id = Guid.NewGuid(), Nombre = "Tom", Apellido = "Hanks", PaisId = usa, FechaNacimiento = new DateTime(1956, 7, 9), ImagenUrl = "https://image.tmdb.org/t/p/w200/3m4a5s6d7f8g9h0j1k2l.jpg", Dirige = false },
            new() { Id = Guid.NewGuid(), Nombre = "Robin", Apellido = "Wright", PaisId = usa, FechaNacimiento = new DateTime(1966, 4, 8), ImagenUrl = "https://image.tmdb.org/t/p/w200/4a5s6d7f8g9h0j1k2l3z.jpg", Dirige = false },
            new() { Id = Guid.NewGuid(), Nombre = "Gary", Apellido = "Sinise", PaisId = usa, FechaNacimiento = new DateTime(1955, 3, 17), ImagenUrl = "https://image.tmdb.org/t/p/w200/5s6d7f8g9h0j1k2l3z4x.jpg", Dirige = false },
            
            // Inception
            new() { Id = Guid.NewGuid(), Nombre = "Christopher", Apellido = "Nolan", PaisId = uk, FechaNacimiento = new DateTime(1970, 7, 30), ImagenUrl = "https://image.tmdb.org/t/p/w200/6d7f8g9h0j1k2l3z4x5c.jpg", Dirige = true },
            new() { Id = Guid.NewGuid(), Nombre = "Leonardo", Apellido = "DiCaprio", PaisId = usa, FechaNacimiento = new DateTime(1974, 11, 11), ImagenUrl = "https://image.tmdb.org/t/p/w200/7f8g9h0j1k2l3z4x5c6v.jpg", Dirige = false },
            new() { Id = Guid.NewGuid(), Nombre = "Joseph Gordon-", Apellido = "Levitt", PaisId = usa, FechaNacimiento = new DateTime(1981, 2, 17), ImagenUrl = "https://image.tmdb.org/t/p/w200/8g9h0j1k2l3z4x5c6v7b.jpg", Dirige = false },
            new() { Id = Guid.NewGuid(), Nombre = "Tom", Apellido = "Hardy", PaisId = uk, FechaNacimiento = new DateTime(1977, 9, 15), ImagenUrl = "https://image.tmdb.org/t/p/w200/9h0j1k2l3z4x5c6v7b8n.jpg", Dirige = false },
            new() { Id = Guid.NewGuid(), Nombre = "Elliot", Apellido = "Page", PaisId = canada, FechaNacimiento = new DateTime(1987, 2, 21), ImagenUrl = "https://image.tmdb.org/t/p/w200/0j1k2l3z4x5c6v7b8n9m.jpg", Dirige = false },
            
            // The Dark Knight
            new() { Id = Guid.NewGuid(), Nombre = "Christian", Apellido = "Bale", PaisId = uk, FechaNacimiento = new DateTime(1974, 1, 30), ImagenUrl = "https://image.tmdb.org/t/p/w200/1k2l3z4x5c6v7b8n9m0a.jpg", Dirige = false },
            new() { Id = Guid.NewGuid(), Nombre = "Heath", Apellido = "Ledger", PaisId = australia, FechaNacimiento = new DateTime(1979, 4, 4), ImagenUrl = "https://image.tmdb.org/t/p/w200/2l3z4x5c6v7b8n9m0a1s.jpg", Dirige = false },
            new() { Id = Guid.NewGuid(), Nombre = "Aaron", Apellido = "Eckhart", PaisId = usa, FechaNacimiento = new DateTime(1968, 3, 12), ImagenUrl = "https://image.tmdb.org/t/p/w200/3z4x5c6v7b8n9m0a1s2d.jpg", Dirige = false },
            new() { Id = Guid.NewGuid(), Nombre = "Gary", Apellido = "Oldman", PaisId = uk, FechaNacimiento = new DateTime(1958, 3, 21), ImagenUrl = "https://image.tmdb.org/t/p/w200/4x5c6v7b8n9m0a1s2d3f.jpg", Dirige = false },
            
            // Fight Club
            new() { Id = Guid.NewGuid(), Nombre = "David", Apellido = "Fincher", PaisId = usa, FechaNacimiento = new DateTime(1962, 8, 28), ImagenUrl = "https://image.tmdb.org/t/p/w200/5c6v7b8n9m0a1s2d3f4g.jpg", Dirige = true },
            new() { Id = Guid.NewGuid(), Nombre = "Brad", Apellido = "Pitt", PaisId = usa, FechaNacimiento = new DateTime(1963, 12, 18), ImagenUrl = "https://image.tmdb.org/t/p/w200/6v7b8n9m0a1s2d3f4g5h.jpg", Dirige = false },
            new() { Id = Guid.NewGuid(), Nombre = "Edward", Apellido = "Norton", PaisId = usa, FechaNacimiento = new DateTime(1969, 8, 18), ImagenUrl = "https://image.tmdb.org/t/p/w200/7b8n9m0a1s2d3f4g5h6j.jpg", Dirige = false },
            new() { Id = Guid.NewGuid(), Nombre = "Helena Bonham", Apellido = "Carter", PaisId = uk, FechaNacimiento = new DateTime(1966, 5, 26), ImagenUrl = "https://image.tmdb.org/t/p/w200/8n9m0a1s2d3f4g5h6j7k.jpg", Dirige = false },
            
            // Goodfellas
            new() { Id = Guid.NewGuid(), Nombre = "Martin", Apellido = "Scorsese", PaisId = usa, FechaNacimiento = new DateTime(1942, 11, 17), ImagenUrl = "https://image.tmdb.org/t/p/w200/9m0a1s2d3f4g5h6j7k8l.jpg", Dirige = true },
            new() { Id = Guid.NewGuid(), Nombre = "Ray", Apellido = "Liotta", PaisId = usa, FechaNacimiento = new DateTime(1954, 12, 18), ImagenUrl = "https://image.tmdb.org/t/p/w200/0a1s2d3f4g5h6j7k8l9z.jpg", Dirige = false },
            new() { Id = Guid.NewGuid(), Nombre = "Robert", Apellido = "De Niro", PaisId = usa, FechaNacimiento = new DateTime(1943, 8, 17), ImagenUrl = "https://image.tmdb.org/t/p/w200/1s2d3f4g5h6j7k8l9z0x.jpg", Dirige = false },
            new() { Id = Guid.NewGuid(), Nombre = "Joe", Apellido = "Pesci", PaisId = usa, FechaNacimiento = new DateTime(1943, 2, 9), ImagenUrl = "https://image.tmdb.org/t/p/w200/2d3f4g5h6j7k8l9z0x1c.jpg", Dirige = false },
            new() { Id = Guid.NewGuid(), Nombre = "Lorraine", Apellido = "Bracco", PaisId = usa, FechaNacimiento = new DateTime(1954, 10, 2), ImagenUrl = "https://image.tmdb.org/t/p/w200/3f4g5h6j7k8l9z0x1c2v.jpg", Dirige = false },
            
            // The Matrix
            new() { Id = Guid.NewGuid(), Nombre = "Lana", Apellido = "Wachowski", PaisId = usa, FechaNacimiento = new DateTime(1965, 6, 21), ImagenUrl = "https://image.tmdb.org/t/p/w200/4g5h6j7k8l9z0x1c2v3b.jpg", Dirige = true },
            new() { Id = Guid.NewGuid(), Nombre = "Keanu", Apellido = "Reeves", PaisId = canada, FechaNacimiento = new DateTime(1964, 9, 2), ImagenUrl = "https://image.tmdb.org/t/p/w200/5h6j7k8l9z0x1c2v3b4n.jpg", Dirige = false },
            new() { Id = Guid.NewGuid(), Nombre = "Laurence", Apellido = "Fishburne", PaisId = usa, FechaNacimiento = new DateTime(1961, 7, 30), ImagenUrl = "https://image.tmdb.org/t/p/w200/6j7k8l9z0x1c2v3b4n5m.jpg", Dirige = false },
            new() { Id = Guid.NewGuid(), Nombre = "Carrie-Anne", Apellido = "Moss", PaisId = canada, FechaNacimiento = new DateTime(1967, 8, 21), ImagenUrl = "https://image.tmdb.org/t/p/w200/7k8l9z0x1c2v3b4n5m6a.jpg", Dirige = false },
            new() { Id = Guid.NewGuid(), Nombre = "Hugo", Apellido = "Weaving", PaisId = australia, FechaNacimiento = new DateTime(1960, 4, 4), ImagenUrl = "https://image.tmdb.org/t/p/w200/8l9z0x1c2v3b4n5m6a7s.jpg", Dirige = false },
            
            // Star Wars
            new() { Id = Guid.NewGuid(), Nombre = "George", Apellido = "Lucas", PaisId = usa, FechaNacimiento = new DateTime(1944, 5, 14), ImagenUrl = "https://image.tmdb.org/t/p/w200/9z0x1c2v3b4n5m6a7s8d.jpg", Dirige = true },
            new() { Id = Guid.NewGuid(), Nombre = "Mark", Apellido = "Hamill", PaisId = usa, FechaNacimiento = new DateTime(1951, 9, 25), ImagenUrl = "https://image.tmdb.org/t/p/w200/0x1c2v3b4n5m6a7s8d9f.jpg", Dirige = false },
            new() { Id = Guid.NewGuid(), Nombre = "Harrison", Apellido = "Ford", PaisId = usa, FechaNacimiento = new DateTime(1942, 7, 13), ImagenUrl = "https://image.tmdb.org/t/p/w200/1c2v3b4n5m6a7s8d9f0g.jpg", Dirige = false },
            new() { Id = Guid.NewGuid(), Nombre = "Carrie", Apellido = "Fisher", PaisId = usa, FechaNacimiento = new DateTime(1956, 10, 21), ImagenUrl = "https://image.tmdb.org/t/p/w200/2v3b4n5m6a7s8d9f0g1h.jpg", Dirige = false },
            
            // Titanic
            new() { Id = Guid.NewGuid(), Nombre = "James", Apellido = "Cameron", PaisId = canada, FechaNacimiento = new DateTime(1954, 8, 16), ImagenUrl = "https://image.tmdb.org/t/p/w200/3b4n5m6a7s8d9f0g1h2j.jpg", Dirige = true },
            new() { Id = Guid.NewGuid(), Nombre = "Kate", Apellido = "Winslet", PaisId = uk, FechaNacimiento = new DateTime(1975, 10, 5), ImagenUrl = "https://image.tmdb.org/t/p/w200/4n5m6a7s8d9f0g1h2j3k.jpg", Dirige = false },
            new() { Id = Guid.NewGuid(), Nombre = "Billy", Apellido = "Zane", PaisId = usa, FechaNacimiento = new DateTime(1966, 2, 24), ImagenUrl = "https://image.tmdb.org/t/p/w200/5m6a7s8d9f0g1h2j3k4l.jpg", Dirige = false },
            
            // Jurassic Park
            new() { Id = Guid.NewGuid(), Nombre = "Steven", Apellido = "Spielberg", PaisId = usa, FechaNacimiento = new DateTime(1946, 12, 18), ImagenUrl = "https://image.tmdb.org/t/p/w200/6a7s8d9f0g1h2j3k4l5z.jpg", Dirige = true },
            new() { Id = Guid.NewGuid(), Nombre = "Sam", Apellido = "Neill", PaisId = australia, FechaNacimiento = new DateTime(1947, 9, 14), ImagenUrl = "https://image.tmdb.org/t/p/w200/7s8d9f0g1h2j3k4l5z6x.jpg", Dirige = false },
            new() { Id = Guid.NewGuid(), Nombre = "Laura", Apellido = "Dern", PaisId = usa, FechaNacimiento = new DateTime(1967, 2, 10), ImagenUrl = "https://image.tmdb.org/t/p/w200/8d9f0g1h2j3k4l5z6x7c.jpg", Dirige = false },
            new() { Id = Guid.NewGuid(), Nombre = "Jeff", Apellido = "Goldblum", PaisId = usa, FechaNacimiento = new DateTime(1952, 10, 22), ImagenUrl = "https://image.tmdb.org/t/p/w200/9f0g1h2j3k4l5z6x7c8v.jpg", Dirige = false },
            new() { Id = Guid.NewGuid(), Nombre = "Richard", Apellido = "Attenborough", PaisId = uk, FechaNacimiento = new DateTime(1923, 8, 29), ImagenUrl = "https://image.tmdb.org/t/p/w200/0g1h2j3k4l5z6x7c8v9b.jpg", Dirige = false },
            
            // The Silence of the Lambs
            new() { Id = Guid.NewGuid(), Nombre = "Jonathan", Apellido = "Demme", PaisId = usa, FechaNacimiento = new DateTime(1944, 2, 22), ImagenUrl = "https://image.tmdb.org/t/p/w200/1h2j3k4l5z6x7c8v9b0n.jpg", Dirige = true },
            new() { Id = Guid.NewGuid(), Nombre = "Jodie", Apellido = "Foster", PaisId = usa, FechaNacimiento = new DateTime(1962, 11, 19), ImagenUrl = "https://image.tmdb.org/t/p/w200/2j3k4l5z6x7c8v9b0n1m.jpg", Dirige = false },
            new() { Id = Guid.NewGuid(), Nombre = "Anthony", Apellido = "Hopkins", PaisId = uk, FechaNacimiento = new DateTime(1937, 12, 31), ImagenUrl = "https://image.tmdb.org/t/p/w200/3k4l5z6x7c8v9b0n1m2a.jpg", Dirige = false },
            new() { Id = Guid.NewGuid(), Nombre = "Scott", Apellido = "Glenn", PaisId = usa, FechaNacimiento = new DateTime(1939, 1, 26), ImagenUrl = "https://image.tmdb.org/t/p/w200/4l5z6x7c8v9b0n1m2a3s.jpg", Dirige = false },
            
            // Schindler's List
            new() { Id = Guid.NewGuid(), Nombre = "Liam", Apellido = "Neeson", PaisId = irlanda, FechaNacimiento = new DateTime(1952, 6, 7), ImagenUrl = "https://image.tmdb.org/t/p/w200/5z6x7c8v9b0n1m2a3s4d.jpg", Dirige = false },
            new() { Id = Guid.NewGuid(), Nombre = "Ben", Apellido = "Kingsley", PaisId = uk, FechaNacimiento = new DateTime(1943, 12, 31), ImagenUrl = "https://image.tmdb.org/t/p/w200/6x7c8v9b0n1m2a3s4d5f.jpg", Dirige = false },
            new() { Id = Guid.NewGuid(), Nombre = "Ralph", Apellido = "Fiennes", PaisId = uk, FechaNacimiento = new DateTime(1962, 12, 22), ImagenUrl = "https://image.tmdb.org/t/p/w200/7c8v9b0n1m2a3s4d5f6g.jpg", Dirige = false },
            
            // Saving Private Ryan
            new() { Id = Guid.NewGuid(), Nombre = "Matt", Apellido = "Damon", PaisId = usa, FechaNacimiento = new DateTime(1970, 10, 8), ImagenUrl = "https://image.tmdb.org/t/p/w200/8v9b0n1m2a3s4d5f6g7h.jpg", Dirige = false },
            new() { Id = Guid.NewGuid(), Nombre = "Tom", Apellido = "Sizemore", PaisId = usa, FechaNacimiento = new DateTime(1961, 11, 29), ImagenUrl = "https://image.tmdb.org/t/p/w200/9b0n1m2a3s4d5f6g7h8j.jpg", Dirige = false },
            
            // Back to the Future
            new() { Id = Guid.NewGuid(), Nombre = "Michael J.", Apellido = "Fox", PaisId = canada, FechaNacimiento = new DateTime(1961, 6, 9), ImagenUrl = "https://image.tmdb.org/t/p/w200/0n1m2a3s4d5f6g7h8j9k.jpg", Dirige = false },
            new() { Id = Guid.NewGuid(), Nombre = "Christopher", Apellido = "Lloyd", PaisId = usa, FechaNacimiento = new DateTime(1938, 10, 22), ImagenUrl = "https://image.tmdb.org/t/p/w200/1m2a3s4d5f6g7h8j9k0l.jpg", Dirige = false },
            new() { Id = Guid.NewGuid(), Nombre = "Lea", Apellido = "Thompson", PaisId = usa, FechaNacimiento = new DateTime(1961, 5, 31), ImagenUrl = "https://image.tmdb.org/t/p/w200/2a3s4d5f6g7h8j9k0l1z.jpg", Dirige = false },
            
            // Gladiator
            new() { Id = Guid.NewGuid(), Nombre = "Ridley", Apellido = "Scott", PaisId = uk, FechaNacimiento = new DateTime(1937, 11, 30), ImagenUrl = "https://image.tmdb.org/t/p/w200/3s4d5f6g7h8j9k0l1z2x.jpg", Dirige = true },
            new() { Id = Guid.NewGuid(), Nombre = "Russell", Apellido = "Crowe", PaisId = australia, FechaNacimiento = new DateTime(1964, 4, 7), ImagenUrl = "https://image.tmdb.org/t/p/w200/4d5f6g7h8j9k0l1z2x3c.jpg", Dirige = false },
            new() { Id = Guid.NewGuid(), Nombre = "Joaquin", Apellido = "Phoenix", PaisId = usa, FechaNacimiento = new DateTime(1974, 10, 28), ImagenUrl = "https://image.tmdb.org/t/p/w200/5f6g7h8j9k0l1z2x3c4v.jpg", Dirige = false },
            new() { Id = Guid.NewGuid(), Nombre = "Connie", Apellido = "Nielsen", PaisId = francia, FechaNacimiento = new DateTime(1965, 7, 3), ImagenUrl = "https://image.tmdb.org/t/p/w200/6g7h8j9k0l1z2x3c4v5b.jpg", Dirige = false },
            
            // Braveheart
            new() { Id = Guid.NewGuid(), Nombre = "Mel", Apellido = "Gibson", PaisId = australia, FechaNacimiento = new DateTime(1956, 1, 3), ImagenUrl = "https://image.tmdb.org/t/p/w200/7h8j9k0l1z2x3c4v5b6n.jpg", Dirige = true },
            new() { Id = Guid.NewGuid(), Nombre = "Sophie", Apellido = "Marceau", PaisId = francia, FechaNacimiento = new DateTime(1966, 11, 17), ImagenUrl = "https://image.tmdb.org/t/p/w200/8j9k0l1z2x3c4v5b6n7m.jpg", Dirige = false },
            new() { Id = Guid.NewGuid(), Nombre = "Catherine", Apellido = "McCormack", PaisId = uk, FechaNacimiento = new DateTime(1972, 1, 1), ImagenUrl = "https://image.tmdb.org/t/p/w200/9k0l1z2x3c4v5b6n7m8a.jpg", Dirige = false },
            
            // Terminator 2
            new() { Id = Guid.NewGuid(), Nombre = "Arnold", Apellido = "Schwarzenegger", PaisId = alemania, FechaNacimiento = new DateTime(1947, 7, 30), ImagenUrl = "https://image.tmdb.org/t/p/w200/0l1z2x3c4v5b6n7m8a9s.jpg", Dirige = false },
            new() { Id = Guid.NewGuid(), Nombre = "Linda", Apellido = "Hamilton", PaisId = usa, FechaNacimiento = new DateTime(1956, 9, 26), ImagenUrl = "https://image.tmdb.org/t/p/w200/1z2x3c4v5b6n7m8a9s0d.jpg", Dirige = false },
            new() { Id = Guid.NewGuid(), Nombre = "Edward", Apellido = "Furlong", PaisId = usa, FechaNacimiento = new DateTime(1977, 8, 2), ImagenUrl = "https://image.tmdb.org/t/p/w200/2x3c4v5b6n7m8a9s0d1f.jpg", Dirige = false },
            
            // Alien
            new() { Id = Guid.NewGuid(), Nombre = "Sigourney", Apellido = "Weaver", PaisId = usa, FechaNacimiento = new DateTime(1949, 10, 8), ImagenUrl = "https://image.tmdb.org/t/p/w200/3c4v5b6n7m8a9s0d1f2g.jpg", Dirige = false },
            new() { Id = Guid.NewGuid(), Nombre = "Tom", Apellido = "Skerritt", PaisId = usa, FechaNacimiento = new DateTime(1933, 8, 25), ImagenUrl = "https://image.tmdb.org/t/p/w200/4v5b6n7m8a9s0d1f2g3h.jpg", Dirige = false },
            
            // Blade Runner
            new() { Id = Guid.NewGuid(), Nombre = "Rutger", Apellido = "Hauer", PaisId = francia, FechaNacimiento = new DateTime(1944, 1, 23), ImagenUrl = "https://image.tmdb.org/t/p/w200/5b6n7m8a9s0d1f2g3h4j.jpg", Dirige = false },
            new() { Id = Guid.NewGuid(), Nombre = "Sean", Apellido = "Young", PaisId = usa, FechaNacimiento = new DateTime(1959, 11, 20), ImagenUrl = "https://image.tmdb.org/t/p/w200/6n7m8a9s0d1f2g3h4j5k.jpg", Dirige = false },
            
            // The Green Mile
            new() { Id = Guid.NewGuid(), Nombre = "Michael Clarke", Apellido = "Duncan", PaisId = usa, FechaNacimiento = new DateTime(1957, 12, 10), ImagenUrl = "https://image.tmdb.org/t/p/w200/7m8a9s0d1f2g3h4j5k6l.jpg", Dirige = false },
            new() { Id = Guid.NewGuid(), Nombre = "David", Apellido = "Morse", PaisId = usa, FechaNacimiento = new DateTime(1953, 10, 11), ImagenUrl = "https://image.tmdb.org/t/p/w200/8a9s0d1f2g3h4j5k6l7z.jpg", Dirige = false },
            
            // Interstellar
            new() { Id = Guid.NewGuid(), Nombre = "Matthew", Apellido = "McConaughey", PaisId = usa, FechaNacimiento = new DateTime(1969, 11, 4), ImagenUrl = "https://image.tmdb.org/t/p/w200/9s0d1f2g3h4j5k6l7z8x.jpg", Dirige = false },
            new() { Id = Guid.NewGuid(), Nombre = "Anne", Apellido = "Hathaway", PaisId = usa, FechaNacimiento = new DateTime(1982, 11, 12), ImagenUrl = "https://image.tmdb.org/t/p/w200/0d1f2g3h4j5k6l7z8x9c.jpg", Dirige = false },
            new() { Id = Guid.NewGuid(), Nombre = "Jessica", Apellido = "Chastain", PaisId = usa, FechaNacimiento = new DateTime(1977, 3, 24), ImagenUrl = "https://image.tmdb.org/t/p/w200/1f2g3h4j5k6l7z8x9c0v.jpg", Dirige = false },
            
            // Parasite
            new() { Id = Guid.NewGuid(), Nombre = "Bong Joon-", Apellido = "ho", PaisId = context.Paises.First(p => p.Nombre == "Corea del Sur").Id, FechaNacimiento = new DateTime(1969, 9, 14), ImagenUrl = "https://image.tmdb.org/t/p/w200/2g3h4j5k6l7z8x9c0v1b.jpg", Dirige = true },
            new() { Id = Guid.NewGuid(), Nombre = "Song", Apellido = "Kang-ho", PaisId = context.Paises.First(p => p.Nombre == "Corea del Sur").Id, FechaNacimiento = new DateTime(1967, 1, 17), ImagenUrl = "https://image.tmdb.org/t/p/w200/3h4j5k6l7z8x9c0v1b2n.jpg", Dirige = false },
            new() { Id = Guid.NewGuid(), Nombre = "Lee Sun-", Apellido = "kyun", PaisId = context.Paises.First(p => p.Nombre == "Corea del Sur").Id, FechaNacimiento = new DateTime(1975, 3, 2), ImagenUrl = "https://image.tmdb.org/t/p/w200/4j5k6l7z8x9c0v1b2n3m.jpg", Dirige = false },
            new() { Id = Guid.NewGuid(), Nombre = "Cho Yeo-", Apellido = "jeong", PaisId = context.Paises.First(p => p.Nombre == "Corea del Sur").Id, FechaNacimiento = new DateTime(1981, 2, 10), ImagenUrl = "https://image.tmdb.org/t/p/w200/5k6l7z8x9c0v1b2n3m4a.jpg", Dirige = false }
        };

            context.Reparto.AddRange(reparto);
            context.SaveChanges();
        }

        private static void SeedPeliculas(MaxiFlixDbContext context)
        {
            var peliculas = new List<Peliculas>
        {
            new() {
                Id = Guid.NewGuid(),
                Titulo = "The Godfather",
                FechaEstreno = new DateTime(1972, 3, 24),
                MinutosDuracion = 175,
                Sinopsis = "El envejecido patriarca de una dinastía del crimen organizado transfiere el control de su imperio clandestino a su hijo reacio.",
                RepartoId = context.Reparto.First(r => r.Nombre == "Francis Ford" && r.Apellido == "Coppola").Id
            },
            new() {
                Id = Guid.NewGuid(),
                Titulo = "Pulp Fiction",
                FechaEstreno = new DateTime(1994, 10, 14),
                MinutosDuracion = 154,
                Sinopsis = "Las vidas de dos sicarios, un boxeador, la esposa de un gánster y un par de bandidos se entrelazan en cuatro historias de violencia y redención.",
                RepartoId = context.Reparto.First(r => r.Nombre == "Quentin" && r.Apellido == "Tarantino").Id
            },
            new() {
                Id = Guid.NewGuid(),
                Titulo = "The Shawshank Redemption",
                FechaEstreno = new DateTime(1994, 10, 14),
                MinutosDuracion = 142,
                Sinopsis = "Dos hombres encarcelados desarrollan una amistad a lo largo de varios años, encontrando consuelo y redención final a través de actos de decencia común.",
                RepartoId = context.Reparto.First(r => r.Nombre == "Frank" && r.Apellido == "Darabont").Id
            },
            new() {
                Id = Guid.NewGuid(),
                Titulo = "Forrest Gump",
                FechaEstreno = new DateTime(1994, 7, 6),
                MinutosDuracion = 142,
                Sinopsis = "La historia de Forrest Gump, un hombre con bajo coeficiente intelectual pero buen corazón, que presencia y participa en eventos históricos importantes.",
                RepartoId = context.Reparto.First(r => r.Nombre == "Robert" && r.Apellido == "Zemeckis").Id
            },
            new() {
                Id = Guid.NewGuid(),
                Titulo = "Inception",
                FechaEstreno = new DateTime(2010, 7, 16),
                MinutosDuracion = 148,
                Sinopsis = "Un ladrón que roba secretos corporativos a través del uso de tecnología de sueños es dado la tarea inversa de plantar una idea en la mente de un CEO.",
                RepartoId = context.Reparto.First(r => r.Nombre == "Christopher" && r.Apellido == "Nolan").Id
            },
            new() {
                Id = Guid.NewGuid(),
                Titulo = "The Dark Knight",
                FechaEstreno = new DateTime(2008, 7, 18),
                MinutosDuracion = 152,
                Sinopsis = "Cuando el Joker emerge como una nueva amenaza en Gotham City, Batman debe enfrentarse a pruebas físicas y psicológicas para proteger a la ciudad.",
                RepartoId = context.Reparto.First(r => r.Nombre == "Christopher" && r.Apellido == "Nolan").Id
            },
            new() {
                Id = Guid.NewGuid(),
                Titulo = "Fight Club",
                FechaEstreno = new DateTime(1999, 10, 15),
                MinutosDuracion = 139,
                Sinopsis = "Un empleado de oficina insomne y un fabricante de jabón desaliñado forman un club de lucha clandestino que evoluciona en algo mucho más grande.",
                RepartoId = context.Reparto.First(r => r.Nombre == "David" && r.Apellido == "Fincher").Id
            },
            new() {
                Id = Guid.NewGuid(),
                Titulo = "Goodfellas",
                FechaEstreno = new DateTime(1990, 9, 19),
                MinutosDuracion = 146,
                Sinopsis = "La historia de Henry Hill y su vida en la mafia, abarcando su relación con su esposa Karen y sus socios mafiosos Jimmy Conway y Tommy DeVito.",
                RepartoId = context.Reparto.First(r => r.Nombre == "Martin" && r.Apellido == "Scorsese").Id
            },
            new() {
                Id = Guid.NewGuid(),
                Titulo = "The Matrix",
                FechaEstreno = new DateTime(1999, 3, 31),
                MinutosDuracion = 136,
                Sinopsis = "Un hacker informático descubre la impactante verdad sobre su realidad y su papel en la guerra contra sus controladores.",
                RepartoId = context.Reparto.First(r => r.Nombre == "Lana" && r.Apellido == "Wachowski").Id
            },
            new() {
                Id = Guid.NewGuid(),
                Titulo = "Star Wars: Episode IV - A New Hope",
                FechaEstreno = new DateTime(1977, 5, 25),
                MinutosDuracion = 121,
                Sinopsis = "Luke Skywalker se une a un caballero Jedi, un piloto fanfarrón, un wookiee y dos droides para salvar la galaxia de la estación espacial del Imperio.",
                RepartoId = context.Reparto.First(r => r.Nombre == "George" && r.Apellido == "Lucas").Id
            },
            new() {
                Id = Guid.NewGuid(),
                Titulo = "Titanic",
                FechaEstreno = new DateTime(1997, 12, 19),
                MinutosDuracion = 194,
                Sinopsis = "Una aristócrata de diecisiete años se enamora de un artista pobre a bordo del lujoso y desafortunado R.M.S. Titanic.",
                RepartoId = context.Reparto.First(r => r.Nombre == "James" && r.Apellido == "Cameron" && r.Dirige).Id
            },
            new() {
                Id = Guid.NewGuid(),
                Titulo = "Jurassic Park",
                FechaEstreno = new DateTime(1993, 6, 11),
                MinutosDuracion = 127,
                Sinopsis = "Un selecto grupo de personas es invitado a un parque temático donde dinosaurios clonados vagan libres, pero todo sale mal.",
                RepartoId = context.Reparto.First(r => r.Nombre == "Steven" && r.Apellido == "Spielberg").Id
            },
            new() {
                Id = Guid.NewGuid(),
                Titulo = "The Silence of the Lambs",
                FechaEstreno = new DateTime(1991, 2, 14),
                MinutosDuracion = 118,
                Sinopsis = "Una joven cadete del FBI debe recibir la ayuda de un asesino caníbal encarcelado para atrapar a otro asesino en serie que desuella a sus víctimas.",
                RepartoId = context.Reparto.First(r => r.Nombre == "Jonathan" && r.Apellido == "Demme").Id
            },
            new() {
                Id = Guid.NewGuid(),
                Titulo = "Schindler's List",
                FechaEstreno = new DateTime(1993, 12, 15),
                MinutosDuracion = 195,
                Sinopsis = "En la Polonia ocupada por los alemanes durante la Segunda Guerra Mundial, Oskar Schindler se preocupa gradualmente por su fuerza laboral judía.",
                RepartoId = context.Reparto.First(r => r.Nombre == "Steven" && r.Apellido == "Spielberg").Id
            },
            new() {
                Id = Guid.NewGuid(),
                Titulo = "Saving Private Ryan",
                FechaEstreno = new DateTime(1998, 7, 24),
                MinutosDuracion = 169,
                Sinopsis = "Siguiendo el desembarco de Normandía, un grupo de soldados estadounidenses va detrás de las líneas enemigas para recuperar a un paracaidista cuyos hermanos han muerto en combate.",
                RepartoId = context.Reparto.First(r => r.Nombre == "Steven" && r.Apellido == "Spielberg").Id
            },
            new() {
                Id = Guid.NewGuid(),
                Titulo = "Back to the Future",
                FechaEstreno = new DateTime(1985, 7, 3),
                MinutosDuracion = 116,
                Sinopsis = "Marty McFly, un estudiante de secundaria de diecisiete años, es enviado accidentalmente treinta años al pasado en un DeLorean que viaja en el tiempo.",
                RepartoId = context.Reparto.First(r => r.Nombre == "Robert" && r.Apellido == "Zemeckis").Id
            },
            new() {
                Id = Guid.NewGuid(),
                Titulo = "Gladiator",
                FechaEstreno = new DateTime(2000, 5, 5),
                MinutosDuracion = 155,
                Sinopsis = "Un general romano traicionado reduce su estatus a esclavo y regresa para vengar el asesinato de su familia y su emperador.",
                RepartoId = context.Reparto.First(r => r.Nombre == "Ridley" && r.Apellido == "Scott").Id
            },
            new() {
                Id = Guid.NewGuid(),
                Titulo = "Braveheart",
                FechaEstreno = new DateTime(1995, 5, 24),
                MinutosDuracion = 178,
                Sinopsis = "William Wallace, un escocés medieval, lidera a su pueblo en una guerra contra el rey inglés Edward I después de que su esposa es asesinada.",
                RepartoId = context.Reparto.First(r => r.Nombre == "Mel" && r.Apellido == "Gibson" && r.Dirige).Id
            },
            new() {
                Id = Guid.NewGuid(),
                Titulo = "Terminator 2: Judgment Day",
                FechaEstreno = new DateTime(1991, 7, 3),
                MinutosDuracion = 137,
                Sinopsis = "Un cyborg idéntico al que fracasó en matar a Sarah Connor debe ahora proteger a su hijo adolescente de un cyborg más avanzado y poderoso.",
                RepartoId = context.Reparto.First(r => r.Nombre == "James" && r.Apellido == "Cameron" && r.Dirige).Id
            },
            new() {
                Id = Guid.NewGuid(),
                Titulo = "Alien",
                FechaEstreno = new DateTime(1979, 5, 25),
                MinutosDuracion = 117,
                Sinopsis = "La tripulación de una nave espacial comercial encuentra una nave alienígena abandonada y descarga una forma de vida alienígena mortal.",
                RepartoId = context.Reparto.First(r => r.Nombre == "Ridley" && r.Apellido == "Scott").Id
            },
            new() {
                Id = Guid.NewGuid(),
                Titulo = "Blade Runner",
                FechaEstreno = new DateTime(1982, 6, 25),
                MinutosDuracion = 117,
                Sinopsis = "Un blade runner debe perseguir y intentar terminar con cuatro replicantes que robaron una nave en el espacio y han regresado a la Tierra.",
                RepartoId = context.Reparto.First(r => r.Nombre == "Ridley" && r.Apellido == "Scott").Id
            },
            new() {
                Id = Guid.NewGuid(),
                Titulo = "The Green Mile",
                FechaEstreno = new DateTime(1999, 12, 10),
                MinutosDuracion = 189,
                Sinopsis = "Las vidas de los guardias en el corredor de la muerte se ven afectadas por uno de sus reclusos: un hombre negro acusado de asesinato infantil pero con un don misterioso.",
                RepartoId = context.Reparto.First(r => r.Nombre == "Frank" && r.Apellido == "Darabont").Id
            },
            new() {
                Id = Guid.NewGuid(),
                Titulo = "Interstellar",
                FechaEstreno = new DateTime(2014, 11, 7),
                MinutosDuracion = 169,
                Sinopsis = "Un equipo de exploradores viaja a través de un agujero de gusano en el espacio en un intento por asegurar la supervivencia de la humanidad.",
                RepartoId = context.Reparto.First(r => r.Nombre == "Christopher" && r.Apellido == "Nolan").Id
            },
            new() {
                Id = Guid.NewGuid(),
                Titulo = "Parasite",
                FechaEstreno = new DateTime(2019, 11, 8),
                MinutosDuracion = 132,
                Sinopsis = "La familia Kim, pobre y sin empleo, se infiltra en la adinerada familia Park haciéndose pasar por empleados altamente calificados.",
                RepartoId = context.Reparto.First(r => r.Nombre == "Bong Joon-" && r.Apellido == "ho").Id
            }
        };

            context.Peliculas.AddRange(peliculas);
            context.SaveChanges();
        }

        private static void SeedPeliculasReparto(MaxiFlixDbContext context)
        {
            var relaciones = new List<PeliculasReparto>();

            // The Godfather
            var godfather = context.Peliculas.First(p => p.Titulo == "The Godfather");
            var coppola = context.Reparto.First(r => r.Nombre == "Francis Ford" && r.Apellido == "Coppola");
            var brando = context.Reparto.First(r => r.Nombre == "Marlon" && r.Apellido == "Brando");
            var pacino = context.Reparto.First(r => r.Nombre == "Al" && r.Apellido == "Pacino");
            var caan = context.Reparto.First(r => r.Nombre == "James" && r.Apellido == "Caan");

            relaciones.AddRange(new[]
            {
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = godfather.Id, RepartoId = coppola.Id, Protagonista = false },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = godfather.Id, RepartoId = brando.Id, Protagonista = true },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = godfather.Id, RepartoId = pacino.Id, Protagonista = true },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = godfather.Id, RepartoId = caan.Id, Protagonista = false }
        });

            // Pulp Fiction
            var pulp = context.Peliculas.First(p => p.Titulo == "Pulp Fiction");
            var tarantino = context.Reparto.First(r => r.Nombre == "Quentin" && r.Apellido == "Tarantino");
            var travolta = context.Reparto.First(r => r.Nombre == "John" && r.Apellido == "Travolta");
            var jackson = context.Reparto.First(r => r.Nombre == "Samuel L." && r.Apellido == "Jackson");
            var thurman = context.Reparto.First(r => r.Nombre == "Uma" && r.Apellido == "Thurman");
            var willis = context.Reparto.First(r => r.Nombre == "Bruce" && r.Apellido == "Willis");

            relaciones.AddRange(new[]
            {
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = pulp.Id, RepartoId = tarantino.Id, Protagonista = false },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = pulp.Id, RepartoId = travolta.Id, Protagonista = true },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = pulp.Id, RepartoId = jackson.Id, Protagonista = true },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = pulp.Id, RepartoId = thurman.Id, Protagonista = true },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = pulp.Id, RepartoId = willis.Id, Protagonista = false }
        });

            // The Shawshank Redemption
            var shawshank = context.Peliculas.First(p => p.Titulo == "The Shawshank Redemption");
            var darabont = context.Reparto.First(r => r.Nombre == "Frank" && r.Apellido == "Darabont");
            var robbins = context.Reparto.First(r => r.Nombre == "Tim" && r.Apellido == "Robbins");
            var freeman = context.Reparto.First(r => r.Nombre == "Morgan" && r.Apellido == "Freeman");

            relaciones.AddRange(new[]
            {
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = shawshank.Id, RepartoId = darabont.Id, Protagonista = false },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = shawshank.Id, RepartoId = robbins.Id, Protagonista = true },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = shawshank.Id, RepartoId = freeman.Id, Protagonista = true }
        });

            // Forrest Gump
            var forrest = context.Peliculas.First(p => p.Titulo == "Forrest Gump");
            var zemeckis = context.Reparto.First(r => r.Nombre == "Robert" && r.Apellido == "Zemeckis");
            var hanks = context.Reparto.First(r => r.Nombre == "Tom" && r.Apellido == "Hanks");
            var robin = context.Reparto.First(r => r.Nombre == "Robin" && r.Apellido == "Wright");
            var sinise = context.Reparto.First(r => r.Nombre == "Gary" && r.Apellido == "Sinise");

            relaciones.AddRange(new[]
            {
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = forrest.Id, RepartoId = zemeckis.Id, Protagonista = false },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = forrest.Id, RepartoId = hanks.Id, Protagonista = true },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = forrest.Id, RepartoId = robin.Id, Protagonista = true },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = forrest.Id, RepartoId = sinise.Id, Protagonista = false }
        });

            // Inception
            var inception = context.Peliculas.First(p => p.Titulo == "Inception");
            var nolan = context.Reparto.First(r => r.Nombre == "Christopher" && r.Apellido == "Nolan");
            var dicaprio = context.Reparto.First(r => r.Nombre == "Leonardo" && r.Apellido == "DiCaprio");
            var joseph = context.Reparto.First(r => r.Nombre == "Joseph Gordon-" && r.Apellido == "Levitt");
            var hardy = context.Reparto.First(r => r.Nombre == "Tom" && r.Apellido == "Hardy");
            var elliot = context.Reparto.First(r => r.Nombre == "Elliot" && r.Apellido == "Page");

            relaciones.AddRange(new[]
            {
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = inception.Id, RepartoId = nolan.Id, Protagonista = false },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = inception.Id, RepartoId = dicaprio.Id, Protagonista = true },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = inception.Id, RepartoId = joseph.Id, Protagonista = true },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = inception.Id, RepartoId = hardy.Id, Protagonista = false },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = inception.Id, RepartoId = elliot.Id, Protagonista = false }
        });

            // The Dark Knight
            var darkKnight = context.Peliculas.First(p => p.Titulo == "The Dark Knight");
            var bale = context.Reparto.First(r => r.Nombre == "Christian" && r.Apellido == "Bale");
            var ledger = context.Reparto.First(r => r.Nombre == "Heath" && r.Apellido == "Ledger");
            var eckhart = context.Reparto.First(r => r.Nombre == "Aaron" && r.Apellido == "Eckhart");
            var oldman = context.Reparto.First(r => r.Nombre == "Gary" && r.Apellido == "Oldman");

            relaciones.AddRange(new[]
            {
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = darkKnight.Id, RepartoId = nolan.Id, Protagonista = false },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = darkKnight.Id, RepartoId = bale.Id, Protagonista = true },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = darkKnight.Id, RepartoId = ledger.Id, Protagonista = true },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = darkKnight.Id, RepartoId = eckhart.Id, Protagonista = false },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = darkKnight.Id, RepartoId = oldman.Id, Protagonista = false }
        });

            // Fight Club
            var fightClub = context.Peliculas.First(p => p.Titulo == "Fight Club");
            var fincher = context.Reparto.First(r => r.Nombre == "David" && r.Apellido == "Fincher");
            var pitt = context.Reparto.First(r => r.Nombre == "Brad" && r.Apellido == "Pitt");
            var norton = context.Reparto.First(r => r.Nombre == "Edward" && r.Apellido == "Norton");
            var helena = context.Reparto.First(r => r.Nombre == "Helena Bonham" && r.Apellido == "Carter");

            relaciones.AddRange(new[]
            {
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = fightClub.Id, RepartoId = fincher.Id, Protagonista = false },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = fightClub.Id, RepartoId = pitt.Id, Protagonista = true },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = fightClub.Id, RepartoId = norton.Id, Protagonista = true },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = fightClub.Id, RepartoId = helena.Id, Protagonista = false }
        });

            // Goodfellas
            var goodfellas = context.Peliculas.First(p => p.Titulo == "Goodfellas");
            var scorsese = context.Reparto.First(r => r.Nombre == "Martin" && r.Apellido == "Scorsese");
            var liotta = context.Reparto.First(r => r.Nombre == "Ray" && r.Apellido == "Liotta");
            var deniro = context.Reparto.First(r => r.Nombre == "Robert" && r.Apellido == "De Niro");
            var pesci = context.Reparto.First(r => r.Nombre == "Joe" && r.Apellido == "Pesci");
            var bracco = context.Reparto.First(r => r.Nombre == "Lorraine" && r.Apellido == "Bracco");

            relaciones.AddRange(new[]
            {
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = goodfellas.Id, RepartoId = scorsese.Id, Protagonista = false },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = goodfellas.Id, RepartoId = liotta.Id, Protagonista = true },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = goodfellas.Id, RepartoId = deniro.Id, Protagonista = true },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = goodfellas.Id, RepartoId = pesci.Id, Protagonista = true },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = goodfellas.Id, RepartoId = bracco.Id, Protagonista = false }
        });

            // The Matrix
            var matrix = context.Peliculas.First(p => p.Titulo == "The Matrix");
            var wachowski = context.Reparto.First(r => r.Nombre == "Lana" && r.Apellido == "Wachowski");
            var reeves = context.Reparto.First(r => r.Nombre == "Keanu" && r.Apellido == "Reeves");
            var fishburne = context.Reparto.First(r => r.Nombre == "Laurence" && r.Apellido == "Fishburne");
            var moss = context.Reparto.First(r => r.Nombre == "Carrie-Anne" && r.Apellido == "Moss");
            var weaving = context.Reparto.First(r => r.Nombre == "Hugo" && r.Apellido == "Weaving");

            relaciones.AddRange(new[]
            {
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = matrix.Id, RepartoId = wachowski.Id, Protagonista = false },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = matrix.Id, RepartoId = reeves.Id, Protagonista = true },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = matrix.Id, RepartoId = fishburne.Id, Protagonista = true },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = matrix.Id, RepartoId = moss.Id, Protagonista = true },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = matrix.Id, RepartoId = weaving.Id, Protagonista = false }
        });

            // Star Wars
            var starWars = context.Peliculas.First(p => p.Titulo == "Star Wars: Episode IV - A New Hope");
            var lucas = context.Reparto.First(r => r.Nombre == "George" && r.Apellido == "Lucas");
            var hamill = context.Reparto.First(r => r.Nombre == "Mark" && r.Apellido == "Hamill");
            var ford = context.Reparto.First(r => r.Nombre == "Harrison" && r.Apellido == "Ford");
            var fisher = context.Reparto.First(r => r.Nombre == "Carrie" && r.Apellido == "Fisher");

            relaciones.AddRange(new[]
            {
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = starWars.Id, RepartoId = lucas.Id, Protagonista = false },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = starWars.Id, RepartoId = hamill.Id, Protagonista = true },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = starWars.Id, RepartoId = ford.Id, Protagonista = true },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = starWars.Id, RepartoId = fisher.Id, Protagonista = true }
        });

            // Titanic
            var titanic = context.Peliculas.First(p => p.Titulo == "Titanic");
            var cameron = context.Reparto.First(r => r.Nombre == "James" && r.Apellido == "Cameron" && r.Dirige);
            var winslet = context.Reparto.First(r => r.Nombre == "Kate" && r.Apellido == "Winslet");
            var zane = context.Reparto.First(r => r.Nombre == "Billy" && r.Apellido == "Zane");

            relaciones.AddRange(new[]
            {
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = titanic.Id, RepartoId = cameron.Id, Protagonista = false },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = titanic.Id, RepartoId = dicaprio.Id, Protagonista = true },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = titanic.Id, RepartoId = winslet.Id, Protagonista = true },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = titanic.Id, RepartoId = zane.Id, Protagonista = false }
        });

            // Jurassic Park
            var jurassic = context.Peliculas.First(p => p.Titulo == "Jurassic Park");
            var spielberg = context.Reparto.First(r => r.Nombre == "Steven" && r.Apellido == "Spielberg");
            var neill = context.Reparto.First(r => r.Nombre == "Sam" && r.Apellido == "Neill");
            var dern = context.Reparto.First(r => r.Nombre == "Laura" && r.Apellido == "Dern");
            var goldblum = context.Reparto.First(r => r.Nombre == "Jeff" && r.Apellido == "Goldblum");
            var attenborough = context.Reparto.First(r => r.Nombre == "Richard" && r.Apellido == "Attenborough");

            relaciones.AddRange(new[]
            {
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = jurassic.Id, RepartoId = spielberg.Id, Protagonista = false },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = jurassic.Id, RepartoId = neill.Id, Protagonista = true },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = jurassic.Id, RepartoId = dern.Id, Protagonista = true },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = jurassic.Id, RepartoId = goldblum.Id, Protagonista = false },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = jurassic.Id, RepartoId = attenborough.Id, Protagonista = false }
        });

            // The Silence of the Lambs
            var silence = context.Peliculas.First(p => p.Titulo == "The Silence of the Lambs");
            var demme = context.Reparto.First(r => r.Nombre == "Jonathan" && r.Apellido == "Demme");
            var foster = context.Reparto.First(r => r.Nombre == "Jodie" && r.Apellido == "Foster");
            var hopkins = context.Reparto.First(r => r.Nombre == "Anthony" && r.Apellido == "Hopkins");
            var glenn = context.Reparto.First(r => r.Nombre == "Scott" && r.Apellido == "Glenn");

            relaciones.AddRange(new[]
            {
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = silence.Id, RepartoId = demme.Id, Protagonista = false },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = silence.Id, RepartoId = foster.Id, Protagonista = true },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = silence.Id, RepartoId = hopkins.Id, Protagonista = true },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = silence.Id, RepartoId = glenn.Id, Protagonista = false }
        });

            // Schindler's List
            var schindler = context.Peliculas.First(p => p.Titulo == "Schindler's List");
            var neeson = context.Reparto.First(r => r.Nombre == "Liam" && r.Apellido == "Neeson");
            var kingsley = context.Reparto.First(r => r.Nombre == "Ben" && r.Apellido == "Kingsley");
            var fiennes = context.Reparto.First(r => r.Nombre == "Ralph" && r.Apellido == "Fiennes");

            relaciones.AddRange(new[]
            {
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = schindler.Id, RepartoId = spielberg.Id, Protagonista = false },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = schindler.Id, RepartoId = neeson.Id, Protagonista = true },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = schindler.Id, RepartoId = kingsley.Id, Protagonista = true },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = schindler.Id, RepartoId = fiennes.Id, Protagonista = true }
        });

            // Saving Private Ryan
            var saving = context.Peliculas.First(p => p.Titulo == "Saving Private Ryan");
            var damon = context.Reparto.First(r => r.Nombre == "Matt" && r.Apellido == "Damon");
            var sizemore = context.Reparto.First(r => r.Nombre == "Tom" && r.Apellido == "Sizemore");

            relaciones.AddRange(new[]
            {
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = saving.Id, RepartoId = spielberg.Id, Protagonista = false },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = saving.Id, RepartoId = hanks.Id, Protagonista = true },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = saving.Id, RepartoId = damon.Id, Protagonista = true },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = saving.Id, RepartoId = sizemore.Id, Protagonista = false }
        });

            // Back to the Future
            var bttf = context.Peliculas.First(p => p.Titulo == "Back to the Future");
            var fox = context.Reparto.First(r => r.Nombre == "Michael J." && r.Apellido == "Fox");
            var lloyd = context.Reparto.First(r => r.Nombre == "Christopher" && r.Apellido == "Lloyd");
            var thompson = context.Reparto.First(r => r.Nombre == "Lea" && r.Apellido == "Thompson");

            relaciones.AddRange(new[]
            {
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = bttf.Id, RepartoId = zemeckis.Id, Protagonista = false },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = bttf.Id, RepartoId = fox.Id, Protagonista = true },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = bttf.Id, RepartoId = lloyd.Id, Protagonista = true },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = bttf.Id, RepartoId = thompson.Id, Protagonista = false }
        });

            // Gladiator
            var gladiator = context.Peliculas.First(p => p.Titulo == "Gladiator");
            var ridley = context.Reparto.First(r => r.Nombre == "Ridley" && r.Apellido == "Scott" && r.Dirige);
            var crowe = context.Reparto.First(r => r.Nombre == "Russell" && r.Apellido == "Crowe");
            var joaquin = context.Reparto.First(r => r.Nombre == "Joaquin" && r.Apellido == "Phoenix");
            var nielsen = context.Reparto.First(r => r.Nombre == "Connie" && r.Apellido == "Nielsen");

            relaciones.AddRange(new[]
            {
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = gladiator.Id, RepartoId = ridley.Id, Protagonista = false },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = gladiator.Id, RepartoId = crowe.Id, Protagonista = true },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = gladiator.Id, RepartoId = joaquin.Id, Protagonista = true },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = gladiator.Id, RepartoId = nielsen.Id, Protagonista = false }
        });

            // Braveheart
            var braveheart = context.Peliculas.First(p => p.Titulo == "Braveheart");
            var gibson = context.Reparto.First(r => r.Nombre == "Mel" && r.Apellido == "Gibson" && r.Dirige);
            var marceau = context.Reparto.First(r => r.Nombre == "Sophie" && r.Apellido == "Marceau");
            var mccormack = context.Reparto.First(r => r.Nombre == "Catherine" && r.Apellido == "McCormack");

            relaciones.AddRange(new[]
            {
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = braveheart.Id, RepartoId = gibson.Id, Protagonista = false },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = braveheart.Id, RepartoId = gibson.Id, Protagonista = true },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = braveheart.Id, RepartoId = marceau.Id, Protagonista = false },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = braveheart.Id, RepartoId = mccormack.Id, Protagonista = false }
        });

            // Terminator 2
            var terminator = context.Peliculas.First(p => p.Titulo == "Terminator 2: Judgment Day");
            var arnold = context.Reparto.First(r => r.Nombre == "Arnold" && r.Apellido == "Schwarzenegger");
            var linda = context.Reparto.First(r => r.Nombre == "Linda" && r.Apellido == "Hamilton");
            var furlong = context.Reparto.First(r => r.Nombre == "Edward" && r.Apellido == "Furlong");

            relaciones.AddRange(new[]
            {
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = terminator.Id, RepartoId = cameron.Id, Protagonista = false },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = terminator.Id, RepartoId = arnold.Id, Protagonista = true },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = terminator.Id, RepartoId = linda.Id, Protagonista = true },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = terminator.Id, RepartoId = furlong.Id, Protagonista = true }
        });

            // Alien
            var alien = context.Peliculas.First(p => p.Titulo == "Alien");
            var sigourney = context.Reparto.First(r => r.Nombre == "Sigourney" && r.Apellido == "Weaver");
            var skerritt = context.Reparto.First(r => r.Nombre == "Tom" && r.Apellido == "Skerritt");

            relaciones.AddRange(new[]
            {
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = alien.Id, RepartoId = ridley.Id, Protagonista = false },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = alien.Id, RepartoId = sigourney.Id, Protagonista = true },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = alien.Id, RepartoId = skerritt.Id, Protagonista = false }
        });

            // Blade Runner
            var blade = context.Peliculas.First(p => p.Titulo == "Blade Runner");
            var hauer = context.Reparto.First(r => r.Nombre == "Rutger" && r.Apellido == "Hauer");
            var young = context.Reparto.First(r => r.Nombre == "Sean" && r.Apellido == "Young");

            relaciones.AddRange(new[]
            {
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = blade.Id, RepartoId = ridley.Id, Protagonista = false },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = blade.Id, RepartoId = ford.Id, Protagonista = true },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = blade.Id, RepartoId = hauer.Id, Protagonista = true },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = blade.Id, RepartoId = young.Id, Protagonista = false }
        });

            // The Green Mile
            var greenMile = context.Peliculas.First(p => p.Titulo == "The Green Mile");
            var duncan = context.Reparto.First(r => r.Nombre == "Michael Clarke" && r.Apellido == "Duncan");
            var morse = context.Reparto.First(r => r.Nombre == "David" && r.Apellido == "Morse");

            relaciones.AddRange(new[]
            {
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = greenMile.Id, RepartoId = darabont.Id, Protagonista = false },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = greenMile.Id, RepartoId = hanks.Id, Protagonista = true },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = greenMile.Id, RepartoId = duncan.Id, Protagonista = true },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = greenMile.Id, RepartoId = morse.Id, Protagonista = false }
        });

            // Interstellar
            var interstellar = context.Peliculas.First(p => p.Titulo == "Interstellar");
            var mcconaughey = context.Reparto.First(r => r.Nombre == "Matthew" && r.Apellido == "McConaughey");
            var hathaway = context.Reparto.First(r => r.Nombre == "Anne" && r.Apellido == "Hathaway");
            var chastain = context.Reparto.First(r => r.Nombre == "Jessica" && r.Apellido == "Chastain");

            relaciones.AddRange(new[]
            {
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = interstellar.Id, RepartoId = nolan.Id, Protagonista = false },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = interstellar.Id, RepartoId = mcconaughey.Id, Protagonista = true },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = interstellar.Id, RepartoId = hathaway.Id, Protagonista = true },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = interstellar.Id, RepartoId = chastain.Id, Protagonista = false }
        });

            // Parasite
            var parasite = context.Peliculas.First(p => p.Titulo == "Parasite");
            var bong = context.Reparto.First(r => r.Nombre == "Bong Joon-" && r.Apellido == "ho");
            var song = context.Reparto.First(r => r.Nombre == "Song" && r.Apellido == "Kang-ho");
            var lee = context.Reparto.First(r => r.Nombre == "Lee Sun-" && r.Apellido == "kyun");
            var cho = context.Reparto.First(r => r.Nombre == "Cho Yeo-" && r.Apellido == "jeong");

            relaciones.AddRange(new[]
            {
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = parasite.Id, RepartoId = bong.Id, Protagonista = false },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = parasite.Id, RepartoId = song.Id, Protagonista = true },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = parasite.Id, RepartoId = lee.Id, Protagonista = true },
            new PeliculasReparto { Id = Guid.NewGuid(), PeliculaId = parasite.Id, RepartoId = cho.Id, Protagonista = true }
        });

            context.PeliculasReparto.AddRange(relaciones);
            context.SaveChanges();
        }

        private static void SeedPeliculasGeneros(MaxiFlixDbContext context)
        {
            var relaciones = new List<PeliculasGeneros>();
            var drama = context.Generos.First(g => g.Descripcion == "Drama").Id;
            var crimen = context.Generos.First(g => g.Descripcion == "Crimen").Id;
            var scifi = context.Generos.First(g => g.Descripcion == "Ciencia Ficción").Id;
            var accion = context.Generos.First(g => g.Descripcion == "Acción").Id;
            var aventura = context.Generos.First(g => g.Descripcion == "Aventura").Id;
            var suspense = context.Generos.First(g => g.Descripcion == "Suspense").Id;
            var belica = context.Generos.First(g => g.Descripcion == "Bélica").Id;
            var romance = context.Generos.First(g => g.Descripcion == "Romance").Id;
            var misterio = context.Generos.First(g => g.Descripcion == "Misterio").Id;
            var thriller = context.Generos.First(g => g.Descripcion == "Thriller").Id;
            var terror = context.Generos.First(g => g.Descripcion == "Terror").Id;

            // The Godfather - Drama, Crimen
            var godfather = context.Peliculas.First(p => p.Titulo == "The Godfather").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasGeneros { Id = Guid.NewGuid(), PeliculaId = godfather, GeneroId = drama },
            new PeliculasGeneros { Id = Guid.NewGuid(), PeliculaId = godfather, GeneroId = crimen }
        });

            // Pulp Fiction - Drama, Crimen
            var pulp = context.Peliculas.First(p => p.Titulo == "Pulp Fiction").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasGeneros { Id = Guid.NewGuid(), PeliculaId = pulp, GeneroId = drama },
            new PeliculasGeneros { Id = Guid.NewGuid(), PeliculaId = pulp, GeneroId = crimen }
        });

            // The Shawshank Redemption - Drama
            var shawshank = context.Peliculas.First(p => p.Titulo == "The Shawshank Redemption").Id;
            relaciones.Add(new PeliculasGeneros { Id = Guid.NewGuid(), PeliculaId = shawshank, GeneroId = drama });

            // Forrest Gump - Drama, Romance
            var forrest = context.Peliculas.First(p => p.Titulo == "Forrest Gump").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasGeneros { Id = Guid.NewGuid(), PeliculaId = forrest, GeneroId = drama },
            new PeliculasGeneros { Id = Guid.NewGuid(), PeliculaId = forrest, GeneroId = romance }
        });

            // Inception - Ciencia Ficción, Acción, Suspense
            var inception = context.Peliculas.First(p => p.Titulo == "Inception").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasGeneros { Id = Guid.NewGuid(), PeliculaId = inception, GeneroId = scifi },
            new PeliculasGeneros { Id = Guid.NewGuid(), PeliculaId = inception, GeneroId = accion },
            new PeliculasGeneros { Id = Guid.NewGuid(), PeliculaId = inception, GeneroId = suspense }
        });

            // The Dark Knight - Acción, Crimen, Drama
            var darkKnight = context.Peliculas.First(p => p.Titulo == "The Dark Knight").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasGeneros { Id = Guid.NewGuid(), PeliculaId = darkKnight, GeneroId = accion },
            new PeliculasGeneros { Id = Guid.NewGuid(), PeliculaId = darkKnight, GeneroId = crimen },
            new PeliculasGeneros { Id = Guid.NewGuid(), PeliculaId = darkKnight, GeneroId = drama }
        });

            // Fight Club - Drama
            var fightClub = context.Peliculas.First(p => p.Titulo == "Fight Club").Id;
            relaciones.Add(new PeliculasGeneros { Id = Guid.NewGuid(), PeliculaId = fightClub, GeneroId = drama });

            // Goodfellas - Crimen, Drama
            var goodfellas = context.Peliculas.First(p => p.Titulo == "Goodfellas").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasGeneros { Id = Guid.NewGuid(), PeliculaId = goodfellas, GeneroId = crimen },
            new PeliculasGeneros { Id = Guid.NewGuid(), PeliculaId = goodfellas, GeneroId = drama }
        });

            // The Matrix - Ciencia Ficción, Acción
            var matrix = context.Peliculas.First(p => p.Titulo == "The Matrix").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasGeneros { Id = Guid.NewGuid(), PeliculaId = matrix, GeneroId = scifi },
            new PeliculasGeneros { Id = Guid.NewGuid(), PeliculaId = matrix, GeneroId = accion }
        });

            // Star Wars - Ciencia Ficción, Aventura, Acción
            var starWars = context.Peliculas.First(p => p.Titulo == "Star Wars: Episode IV - A New Hope").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasGeneros { Id = Guid.NewGuid(), PeliculaId = starWars, GeneroId = scifi },
            new PeliculasGeneros { Id = Guid.NewGuid(), PeliculaId = starWars, GeneroId = aventura },
            new PeliculasGeneros { Id = Guid.NewGuid(), PeliculaId = starWars, GeneroId = accion }
        });

            // Titanic - Romance, Drama
            var titanic = context.Peliculas.First(p => p.Titulo == "Titanic").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasGeneros { Id = Guid.NewGuid(), PeliculaId = titanic, GeneroId = romance },
            new PeliculasGeneros { Id = Guid.NewGuid(), PeliculaId = titanic, GeneroId = drama }
        });

            // Jurassic Park - Ciencia Ficción, Aventura, Suspense
            var jurassic = context.Peliculas.First(p => p.Titulo == "Jurassic Park").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasGeneros { Id = Guid.NewGuid(), PeliculaId = jurassic, GeneroId = scifi },
            new PeliculasGeneros { Id = Guid.NewGuid(), PeliculaId = jurassic, GeneroId = aventura },
            new PeliculasGeneros { Id = Guid.NewGuid(), PeliculaId = jurassic, GeneroId = suspense }
        });

            // The Silence of the Lambs - Crimen, Drama, Suspense
            var silence = context.Peliculas.First(p => p.Titulo == "The Silence of the Lambs").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasGeneros { Id = Guid.NewGuid(), PeliculaId = silence, GeneroId = crimen },
            new PeliculasGeneros { Id = Guid.NewGuid(), PeliculaId = silence, GeneroId = drama },
            new PeliculasGeneros { Id = Guid.NewGuid(), PeliculaId = silence, GeneroId = suspense }
        });

            // Schindler's List - Drama, Bélica, Histórica
            var schindler = context.Peliculas.First(p => p.Titulo == "Schindler's List").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasGeneros { Id = Guid.NewGuid(), PeliculaId = schindler, GeneroId = drama },
            new PeliculasGeneros { Id = Guid.NewGuid(), PeliculaId = schindler, GeneroId = belica }
        });

            // Saving Private Ryan - Bélica, Drama, Acción
            var saving = context.Peliculas.First(p => p.Titulo == "Saving Private Ryan").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasGeneros { Id = Guid.NewGuid(), PeliculaId = saving, GeneroId = belica },
            new PeliculasGeneros { Id = Guid.NewGuid(), PeliculaId = saving, GeneroId = drama },
            new PeliculasGeneros { Id = Guid.NewGuid(), PeliculaId = saving, GeneroId = accion }
        });

            // Back to the Future - Ciencia Ficción, Aventura, Comedia
            var bttf = context.Peliculas.First(p => p.Titulo == "Back to the Future").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasGeneros { Id = Guid.NewGuid(), PeliculaId = bttf, GeneroId = scifi },
            new PeliculasGeneros { Id = Guid.NewGuid(), PeliculaId = bttf, GeneroId = aventura }
        });

            // Gladiator - Acción, Drama, Aventura
            var gladiator = context.Peliculas.First(p => p.Titulo == "Gladiator").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasGeneros { Id = Guid.NewGuid(), PeliculaId = gladiator, GeneroId = accion },
            new PeliculasGeneros { Id = Guid.NewGuid(), PeliculaId = gladiator, GeneroId = drama }
        });

            // Braveheart - Drama, Bélica, Histórica
            var braveheart = context.Peliculas.First(p => p.Titulo == "Braveheart").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasGeneros { Id = Guid.NewGuid(), PeliculaId = braveheart, GeneroId = drama },
            new PeliculasGeneros { Id = Guid.NewGuid(), PeliculaId = braveheart, GeneroId = belica }
        });

            // Terminator 2 - Ciencia Ficción, Acción
            var terminator = context.Peliculas.First(p => p.Titulo == "Terminator 2: Judgment Day").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasGeneros { Id = Guid.NewGuid(), PeliculaId = terminator, GeneroId = scifi },
            new PeliculasGeneros { Id = Guid.NewGuid(), PeliculaId = terminator, GeneroId = accion }
        });

            // Alien - Terror, Ciencia Ficción, Suspense
            var alien = context.Peliculas.First(p => p.Titulo == "Alien").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasGeneros { Id = Guid.NewGuid(), PeliculaId = alien, GeneroId = terror },
            new PeliculasGeneros { Id = Guid.NewGuid(), PeliculaId = alien, GeneroId = scifi },
            new PeliculasGeneros { Id = Guid.NewGuid(), PeliculaId = alien, GeneroId = suspense }
        });

            // Blade Runner - Ciencia Ficción, Thriller, Drama
            var blade = context.Peliculas.First(p => p.Titulo == "Blade Runner").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasGeneros { Id = Guid.NewGuid(), PeliculaId = blade, GeneroId = scifi },
            new PeliculasGeneros { Id = Guid.NewGuid(), PeliculaId = blade, GeneroId = thriller }
        });

            // The Green Mile - Drama, Crimen, Fantasía
            var greenMile = context.Peliculas.First(p => p.Titulo == "The Green Mile").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasGeneros { Id = Guid.NewGuid(), PeliculaId = greenMile, GeneroId = drama },
            new PeliculasGeneros { Id = Guid.NewGuid(), PeliculaId = greenMile, GeneroId = crimen }
        });

            // Interstellar - Ciencia Ficción, Drama, Aventura
            var interstellar = context.Peliculas.First(p => p.Titulo == "Interstellar").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasGeneros { Id = Guid.NewGuid(), PeliculaId = interstellar, GeneroId = scifi },
            new PeliculasGeneros { Id = Guid.NewGuid(), PeliculaId = interstellar, GeneroId = drama },
            new PeliculasGeneros { Id = Guid.NewGuid(), PeliculaId = interstellar, GeneroId = aventura }
        });

            // Parasite - Drama, Thriller, Comedia
            var parasite = context.Peliculas.First(p => p.Titulo == "Parasite").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasGeneros { Id = Guid.NewGuid(), PeliculaId = parasite, GeneroId = drama },
            new PeliculasGeneros { Id = Guid.NewGuid(), PeliculaId = parasite, GeneroId = thriller }
        });

            context.PeliculasGeneros.AddRange(relaciones);
            context.SaveChanges();
        }

        private static void SeedPeliculasCategorias(MaxiFlixDbContext context)
        {
            var relaciones = new List<PeliculasCategoria>();
            var clasicos = context.Categorias.First(c => c.Descripcion == "Clásicos").Id;
            var modernos = context.Categorias.First(c => c.Descripcion == "Modernos").Id;
            var premiados = context.Categorias.First(c => c.Descripcion == "Premiados").Id;
            var populares = context.Categorias.First(c => c.Descripcion == "Populares").Id;
            var culto = context.Categorias.First(c => c.Descripcion == "Cine de Culto").Id;
            var blockbusters = context.Categorias.First(c => c.Descripcion == "Blockbusters").Id;

            // The Godfather - Clásicos, Premiados, Populares
            var godfather = context.Peliculas.First(p => p.Titulo == "The Godfather").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = godfather, CategoriaId = clasicos },
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = godfather, CategoriaId = premiados },
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = godfather, CategoriaId = populares }
        });

            // Pulp Fiction - Clásicos, Culto, Premiados
            var pulp = context.Peliculas.First(p => p.Titulo == "Pulp Fiction").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = pulp, CategoriaId = clasicos },
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = pulp, CategoriaId = culto },
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = pulp, CategoriaId = premiados }
        });

            // The Shawshank Redemption - Clásicos, Premiados, Populares
            var shawshank = context.Peliculas.First(p => p.Titulo == "The Shawshank Redemption").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = shawshank, CategoriaId = clasicos },
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = shawshank, CategoriaId = premiados },
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = shawshank, CategoriaId = populares }
        });

            // Forrest Gump - Clásicos, Premiados, Populares, Blockbusters
            var forrest = context.Peliculas.First(p => p.Titulo == "Forrest Gump").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = forrest, CategoriaId = clasicos },
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = forrest, CategoriaId = premiados },
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = forrest, CategoriaId = populares },
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = forrest, CategoriaId = blockbusters }
        });

            // Inception - Modernos, Blockbusters, Premiados
            var inception = context.Peliculas.First(p => p.Titulo == "Inception").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = inception, CategoriaId = modernos },
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = inception, CategoriaId = blockbusters },
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = inception, CategoriaId = premiados }
        });

            // The Dark Knight - Modernos, Blockbusters, Populares
            var darkKnight = context.Peliculas.First(p => p.Titulo == "The Dark Knight").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = darkKnight, CategoriaId = modernos },
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = darkKnight, CategoriaId = blockbusters },
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = darkKnight, CategoriaId = populares }
        });

            // Fight Club - Clásicos, Culto
            var fightClub = context.Peliculas.First(p => p.Titulo == "Fight Club").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = fightClub, CategoriaId = clasicos },
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = fightClub, CategoriaId = culto }
        });

            // Goodfellas - Clásicos, Premiados, Culto
            var goodfellas = context.Peliculas.First(p => p.Titulo == "Goodfellas").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = goodfellas, CategoriaId = clasicos },
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = goodfellas, CategoriaId = premiados },
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = goodfellas, CategoriaId = culto }
        });

            // The Matrix - Clásicos, Culto, Blockbusters
            var matrix = context.Peliculas.First(p => p.Titulo == "The Matrix").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = matrix, CategoriaId = clasicos },
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = matrix, CategoriaId = culto },
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = matrix, CategoriaId = blockbusters }
        });

            // Star Wars - Clásicos, Blockbusters, Populares
            var starWars = context.Peliculas.First(p => p.Titulo == "Star Wars: Episode IV - A New Hope").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = starWars, CategoriaId = clasicos },
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = starWars, CategoriaId = blockbusters },
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = starWars, CategoriaId = populares }
        });

            // Titanic - Clásicos, Blockbusters, Premiados, Populares
            var titanic = context.Peliculas.First(p => p.Titulo == "Titanic").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = titanic, CategoriaId = clasicos },
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = titanic, CategoriaId = blockbusters },
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = titanic, CategoriaId = premiados },
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = titanic, CategoriaId = populares }
        });

            // Jurassic Park - Clásicos, Blockbusters, Populares
            var jurassic = context.Peliculas.First(p => p.Titulo == "Jurassic Park").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = jurassic, CategoriaId = clasicos },
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = jurassic, CategoriaId = blockbusters },
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = jurassic, CategoriaId = populares }
        });

            // The Silence of the Lambs - Clásicos, Premiados, Populares
            var silence = context.Peliculas.First(p => p.Titulo == "The Silence of the Lambs").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = silence, CategoriaId = clasicos },
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = silence, CategoriaId = premiados },
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = silence, CategoriaId = populares }
        });

            // Schindler's List - Clásicos, Premiados
            var schindler = context.Peliculas.First(p => p.Titulo == "Schindler's List").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = schindler, CategoriaId = clasicos },
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = schindler, CategoriaId = premiados }
        });

            // Saving Private Ryan - Clásicos, Premiados, Populares
            var saving = context.Peliculas.First(p => p.Titulo == "Saving Private Ryan").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = saving, CategoriaId = clasicos },
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = saving, CategoriaId = premiados },
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = saving, CategoriaId = populares }
        });

            // Back to the Future - Clásicos, Populares, Blockbusters
            var bttf = context.Peliculas.First(p => p.Titulo == "Back to the Future").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = bttf, CategoriaId = clasicos },
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = bttf, CategoriaId = populares },
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = bttf, CategoriaId = blockbusters }
        });

            // Gladiator - Clásicos, Premiados, Blockbusters, Populares
            var gladiator = context.Peliculas.First(p => p.Titulo == "Gladiator").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = gladiator, CategoriaId = clasicos },
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = gladiator, CategoriaId = premiados },
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = gladiator, CategoriaId = blockbusters },
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = gladiator, CategoriaId = populares }
        });

            // Braveheart - Clásicos, Premiados, Populares
            var braveheart = context.Peliculas.First(p => p.Titulo == "Braveheart").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = braveheart, CategoriaId = clasicos },
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = braveheart, CategoriaId = premiados },
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = braveheart, CategoriaId = populares }
        });

            // Terminator 2 - Clásicos, Blockbusters, Populares
            var terminator = context.Peliculas.First(p => p.Titulo == "Terminator 2: Judgment Day").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = terminator, CategoriaId = clasicos },
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = terminator, CategoriaId = blockbusters },
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = terminator, CategoriaId = populares }
        });

            // Alien - Clásicos, Culto, Premiados
            var alien = context.Peliculas.First(p => p.Titulo == "Alien").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = alien, CategoriaId = clasicos },
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = alien, CategoriaId = culto },
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = alien, CategoriaId = premiados }
        });

            // Blade Runner - Clásicos, Culto, Premiados
            var blade = context.Peliculas.First(p => p.Titulo == "Blade Runner").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = blade, CategoriaId = clasicos },
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = blade, CategoriaId = culto },
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = blade, CategoriaId = premiados }
        });

            // The Green Mile - Clásicos, Premiados, Populares
            var greenMile = context.Peliculas.First(p => p.Titulo == "The Green Mile").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = greenMile, CategoriaId = clasicos },
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = greenMile, CategoriaId = premiados },
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = greenMile, CategoriaId = populares }
        });

            // Interstellar - Modernos, Blockbusters, Premiados
            var interstellar = context.Peliculas.First(p => p.Titulo == "Interstellar").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = interstellar, CategoriaId = modernos },
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = interstellar, CategoriaId = blockbusters },
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = interstellar, CategoriaId = premiados }
        });

            // Parasite - Modernos, Premiados, Populares, Culto
            var parasite = context.Peliculas.First(p => p.Titulo == "Parasite").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = parasite, CategoriaId = modernos },
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = parasite, CategoriaId = premiados },
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = parasite, CategoriaId = populares },
            new PeliculasCategoria { Id = Guid.NewGuid(), PeliculaId = parasite, CategoriaId = culto }
        });

            context.PeliculasCategorias.AddRange(relaciones);
            context.SaveChanges();
        }

        private static void SeedPeliculasClasificaciones(MaxiFlixDbContext context)
        {
            var relaciones = new List<PeliculasClasificaciones>();
            var r = context.Clasificaciones.First(c => c.Descripcion.StartsWith("R")).Id;
            var pg13 = context.Clasificaciones.First(c => c.Descripcion.StartsWith("PG-13")).Id;
            var pg = context.Clasificaciones.First(c => c.Descripcion.StartsWith("PG -")).Id;

            // The Godfather - R
            var godfather = context.Peliculas.First(p => p.Titulo == "The Godfather").Id;
            relaciones.Add(new PeliculasClasificaciones { Id = Guid.NewGuid(), PeliculaId = godfather, ClasificacionId = r });

            // Pulp Fiction - R
            var pulp = context.Peliculas.First(p => p.Titulo == "Pulp Fiction").Id;
            relaciones.Add(new PeliculasClasificaciones { Id = Guid.NewGuid(), PeliculaId = pulp, ClasificacionId = r });

            // The Shawshank Redemption - R
            var shawshank = context.Peliculas.First(p => p.Titulo == "The Shawshank Redemption").Id;
            relaciones.Add(new PeliculasClasificaciones { Id = Guid.NewGuid(), PeliculaId = shawshank, ClasificacionId = r });

            // Forrest Gump - PG-13
            var forrest = context.Peliculas.First(p => p.Titulo == "Forrest Gump").Id;
            relaciones.Add(new PeliculasClasificaciones { Id = Guid.NewGuid(), PeliculaId = forrest, ClasificacionId = pg13 });

            // Inception - PG-13
            var inception = context.Peliculas.First(p => p.Titulo == "Inception").Id;
            relaciones.Add(new PeliculasClasificaciones { Id = Guid.NewGuid(), PeliculaId = inception, ClasificacionId = pg13 });

            // The Dark Knight - PG-13
            var darkKnight = context.Peliculas.First(p => p.Titulo == "The Dark Knight").Id;
            relaciones.Add(new PeliculasClasificaciones { Id = Guid.NewGuid(), PeliculaId = darkKnight, ClasificacionId = pg13 });

            // Fight Club - R
            var fightClub = context.Peliculas.First(p => p.Titulo == "Fight Club").Id;
            relaciones.Add(new PeliculasClasificaciones { Id = Guid.NewGuid(), PeliculaId = fightClub, ClasificacionId = r });

            // Goodfellas - R
            var goodfellas = context.Peliculas.First(p => p.Titulo == "Goodfellas").Id;
            relaciones.Add(new PeliculasClasificaciones { Id = Guid.NewGuid(), PeliculaId = goodfellas, ClasificacionId = r });

            // The Matrix - R
            var matrix = context.Peliculas.First(p => p.Titulo == "The Matrix").Id;
            relaciones.Add(new PeliculasClasificaciones { Id = Guid.NewGuid(), PeliculaId = matrix, ClasificacionId = r });

            // Star Wars - PG
            var starWars = context.Peliculas.First(p => p.Titulo == "Star Wars: Episode IV - A New Hope").Id;
            relaciones.Add(new PeliculasClasificaciones { Id = Guid.NewGuid(), PeliculaId = starWars, ClasificacionId = pg });

            // Titanic - PG-13
            var titanic = context.Peliculas.First(p => p.Titulo == "Titanic").Id;
            relaciones.Add(new PeliculasClasificaciones { Id = Guid.NewGuid(), PeliculaId = titanic, ClasificacionId = pg13 });

            // Jurassic Park - PG-13
            var jurassic = context.Peliculas.First(p => p.Titulo == "Jurassic Park").Id;
            relaciones.Add(new PeliculasClasificaciones { Id = Guid.NewGuid(), PeliculaId = jurassic, ClasificacionId = pg13 });

            // The Silence of the Lambs - R
            var silence = context.Peliculas.First(p => p.Titulo == "The Silence of the Lambs").Id;
            relaciones.Add(new PeliculasClasificaciones { Id = Guid.NewGuid(), PeliculaId = silence, ClasificacionId = r });

            // Schindler's List - R
            var schindler = context.Peliculas.First(p => p.Titulo == "Schindler's List").Id;
            relaciones.Add(new PeliculasClasificaciones { Id = Guid.NewGuid(), PeliculaId = schindler, ClasificacionId = r });

            // Saving Private Ryan - R
            var saving = context.Peliculas.First(p => p.Titulo == "Saving Private Ryan").Id;
            relaciones.Add(new PeliculasClasificaciones { Id = Guid.NewGuid(), PeliculaId = saving, ClasificacionId = r });

            // Back to the Future - PG
            var bttf = context.Peliculas.First(p => p.Titulo == "Back to the Future").Id;
            relaciones.Add(new PeliculasClasificaciones { Id = Guid.NewGuid(), PeliculaId = bttf, ClasificacionId = pg });

            // Gladiator - R
            var gladiator = context.Peliculas.First(p => p.Titulo == "Gladiator").Id;
            relaciones.Add(new PeliculasClasificaciones { Id = Guid.NewGuid(), PeliculaId = gladiator, ClasificacionId = r });

            // Braveheart - R
            var braveheart = context.Peliculas.First(p => p.Titulo == "Braveheart").Id;
            relaciones.Add(new PeliculasClasificaciones { Id = Guid.NewGuid(), PeliculaId = braveheart, ClasificacionId = r });

            // Terminator 2 - R
            var terminator = context.Peliculas.First(p => p.Titulo == "Terminator 2: Judgment Day").Id;
            relaciones.Add(new PeliculasClasificaciones { Id = Guid.NewGuid(), PeliculaId = terminator, ClasificacionId = r });

            // Alien - R
            var alien = context.Peliculas.First(p => p.Titulo == "Alien").Id;
            relaciones.Add(new PeliculasClasificaciones { Id = Guid.NewGuid(), PeliculaId = alien, ClasificacionId = r });

            // Blade Runner - R
            var blade = context.Peliculas.First(p => p.Titulo == "Blade Runner").Id;
            relaciones.Add(new PeliculasClasificaciones { Id = Guid.NewGuid(), PeliculaId = blade, ClasificacionId = r });

            // The Green Mile - R
            var greenMile = context.Peliculas.First(p => p.Titulo == "The Green Mile").Id;
            relaciones.Add(new PeliculasClasificaciones { Id = Guid.NewGuid(), PeliculaId = greenMile, ClasificacionId = r });

            // Interstellar - PG-13
            var interstellar = context.Peliculas.First(p => p.Titulo == "Interstellar").Id;
            relaciones.Add(new PeliculasClasificaciones { Id = Guid.NewGuid(), PeliculaId = interstellar, ClasificacionId = pg13 });

            // Parasite - R
            var parasite = context.Peliculas.First(p => p.Titulo == "Parasite").Id;
            relaciones.Add(new PeliculasClasificaciones { Id = Guid.NewGuid(), PeliculaId = parasite, ClasificacionId = r });

            context.PeliculasClasificaciones.AddRange(relaciones);
            context.SaveChanges();
        }

        private static void SeedPeliculasPlataformas(MaxiFlixDbContext context)
        {
            var relaciones = new List<PeliculasPlataformas>();
            var netflix = context.Plataformas.First(p => p.Nombre == "Netflix").Id;
            var prime = context.Plataformas.First(p => p.Nombre == "Amazon Prime Video").Id;
            var disney = context.Plataformas.First(p => p.Nombre == "Disney+").Id;
            var hbo = context.Plataformas.First(p => p.Nombre == "HBO Max").Id;
            var hulu = context.Plataformas.First(p => p.Nombre == "Hulu").Id;
            var apple = context.Plataformas.First(p => p.Nombre == "Apple TV+").Id;
            var paramount = context.Plataformas.First(p => p.Nombre == "Paramount+").Id;

            // The Godfather - Paramount+
            var godfather = context.Peliculas.First(p => p.Titulo == "The Godfather").Id;
            relaciones.Add(new PeliculasPlataformas { Id = Guid.NewGuid(), PeliculaId = godfather, PlataformaId = paramount, FechaAlta = DateTime.Now.AddMonths(-6), FechaBaja = DateTime.Now.AddYears(1) });

            // Pulp Fiction - Netflix, Prime
            var pulp = context.Peliculas.First(p => p.Titulo == "Pulp Fiction").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasPlataformas { Id = Guid.NewGuid(), PeliculaId = pulp, PlataformaId = netflix, FechaAlta = DateTime.Now.AddMonths(-3), FechaBaja = DateTime.Now.AddYears(1) },
            new PeliculasPlataformas { Id = Guid.NewGuid(), PeliculaId = pulp, PlataformaId = prime, FechaAlta = DateTime.Now.AddMonths(-2), FechaBaja = DateTime.Now.AddYears(1) }
        });

            // The Shawshank Redemption - Prime, Netflix
            var shawshank = context.Peliculas.First(p => p.Titulo == "The Shawshank Redemption").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasPlataformas { Id = Guid.NewGuid(), PeliculaId = shawshank, PlataformaId = prime, FechaAlta = DateTime.Now.AddMonths(-4), FechaBaja = DateTime.Now.AddYears(1) },
            new PeliculasPlataformas { Id = Guid.NewGuid(), PeliculaId = shawshank, PlataformaId = netflix, FechaAlta = DateTime.Now.AddMonths(-1), FechaBaja = DateTime.Now.AddYears(1) }
        });

            // Forrest Gump - Prime, Paramount+
            var forrest = context.Peliculas.First(p => p.Titulo == "Forrest Gump").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasPlataformas { Id = Guid.NewGuid(), PeliculaId = forrest, PlataformaId = prime, FechaAlta = DateTime.Now.AddMonths(-5), FechaBaja = DateTime.Now.AddYears(1) },
            new PeliculasPlataformas { Id = Guid.NewGuid(), PeliculaId = forrest, PlataformaId = paramount, FechaAlta = DateTime.Now.AddMonths(-2), FechaBaja = DateTime.Now.AddYears(1) }
        });

            // Inception - HBO Max, Prime
            var inception = context.Peliculas.First(p => p.Titulo == "Inception").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasPlataformas { Id = Guid.NewGuid(), PeliculaId = inception, PlataformaId = hbo, FechaAlta = DateTime.Now.AddMonths(-6), FechaBaja = DateTime.Now.AddYears(1) },
            new PeliculasPlataformas { Id = Guid.NewGuid(), PeliculaId = inception, PlataformaId = prime, FechaAlta = DateTime.Now.AddMonths(-3), FechaBaja = DateTime.Now.AddYears(1) }
        });

            // The Dark Knight - HBO Max, Prime
            var darkKnight = context.Peliculas.First(p => p.Titulo == "The Dark Knight").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasPlataformas { Id = Guid.NewGuid(), PeliculaId = darkKnight, PlataformaId = hbo, FechaAlta = DateTime.Now.AddMonths(-4), FechaBaja = DateTime.Now.AddYears(1) },
            new PeliculasPlataformas { Id = Guid.NewGuid(), PeliculaId = darkKnight, PlataformaId = prime, FechaAlta = DateTime.Now.AddMonths(-2), FechaBaja = DateTime.Now.AddYears(1) }
        });

            // Fight Club - Prime, Hulu
            var fightClub = context.Peliculas.First(p => p.Titulo == "Fight Club").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasPlataformas { Id = Guid.NewGuid(), PeliculaId = fightClub, PlataformaId = prime, FechaAlta = DateTime.Now.AddMonths(-5), FechaBaja = DateTime.Now.AddYears(1) },
            new PeliculasPlataformas { Id = Guid.NewGuid(), PeliculaId = fightClub, PlataformaId = hulu, FechaAlta = DateTime.Now.AddMonths(-3), FechaBaja = DateTime.Now.AddYears(1) }
        });

            // Goodfellas - HBO Max, Netflix
            var goodfellas = context.Peliculas.First(p => p.Titulo == "Goodfellas").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasPlataformas { Id = Guid.NewGuid(), PeliculaId = goodfellas, PlataformaId = hbo, FechaAlta = DateTime.Now.AddMonths(-6), FechaBaja = DateTime.Now.AddYears(1) },
            new PeliculasPlataformas { Id = Guid.NewGuid(), PeliculaId = goodfellas, PlataformaId = netflix, FechaAlta = DateTime.Now.AddMonths(-1), FechaBaja = DateTime.Now.AddYears(1) }
        });

            // The Matrix - HBO Max, Prime
            var matrix = context.Peliculas.First(p => p.Titulo == "The Matrix").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasPlataformas { Id = Guid.NewGuid(), PeliculaId = matrix, PlataformaId = hbo, FechaAlta = DateTime.Now.AddMonths(-4), FechaBaja = DateTime.Now.AddYears(1) },
            new PeliculasPlataformas { Id = Guid.NewGuid(), PeliculaId = matrix, PlataformaId = prime, FechaAlta = DateTime.Now.AddMonths(-2), FechaBaja = DateTime.Now.AddYears(1) }
        });

            // Star Wars - Disney+
            var starWars = context.Peliculas.First(p => p.Titulo == "Star Wars: Episode IV - A New Hope").Id;
            relaciones.Add(new PeliculasPlataformas { Id = Guid.NewGuid(), PeliculaId = starWars, PlataformaId = disney, FechaAlta = DateTime.Now.AddMonths(-12), FechaBaja = DateTime.Now.AddYears(2) });

            // Titanic - Prime, Paramount+
            var titanic = context.Peliculas.First(p => p.Titulo == "Titanic").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasPlataformas { Id = Guid.NewGuid(), PeliculaId = titanic, PlataformaId = prime, FechaAlta = DateTime.Now.AddMonths(-3), FechaBaja = DateTime.Now.AddYears(1) },
            new PeliculasPlataformas { Id = Guid.NewGuid(), PeliculaId = titanic, PlataformaId = paramount, FechaAlta = DateTime.Now.AddMonths(-1), FechaBaja = DateTime.Now.AddYears(1) }
        });

            // Jurassic Park - Netflix, Prime
            var jurassic = context.Peliculas.First(p => p.Titulo == "Jurassic Park").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasPlataformas { Id = Guid.NewGuid(), PeliculaId = jurassic, PlataformaId = netflix, FechaAlta = DateTime.Now.AddMonths(-4), FechaBaja = DateTime.Now.AddYears(1) },
            new PeliculasPlataformas { Id = Guid.NewGuid(), PeliculaId = jurassic, PlataformaId = prime, FechaAlta = DateTime.Now.AddMonths(-2), FechaBaja = DateTime.Now.AddYears(1) }
        });

            // The Silence of the Lambs - Prime, Hulu
            var silence = context.Peliculas.First(p => p.Titulo == "The Silence of the Lambs").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasPlataformas { Id = Guid.NewGuid(), PeliculaId = silence, PlataformaId = prime, FechaAlta = DateTime.Now.AddMonths(-5), FechaBaja = DateTime.Now.AddYears(1) },
            new PeliculasPlataformas { Id = Guid.NewGuid(), PeliculaId = silence, PlataformaId = hulu, FechaAlta = DateTime.Now.AddMonths(-3), FechaBaja = DateTime.Now.AddYears(1) }
        });

            // Schindler's List - Netflix, Prime
            var schindler = context.Peliculas.First(p => p.Titulo == "Schindler's List").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasPlataformas { Id = Guid.NewGuid(), PeliculaId = schindler, PlataformaId = netflix, FechaAlta = DateTime.Now.AddMonths(-6), FechaBaja = DateTime.Now.AddYears(1) },
            new PeliculasPlataformas { Id = Guid.NewGuid(), PeliculaId = schindler, PlataformaId = prime, FechaAlta = DateTime.Now.AddMonths(-2), FechaBaja = DateTime.Now.AddYears(1) }
        });

            // Saving Private Ryan - Netflix, Prime
            var saving = context.Peliculas.First(p => p.Titulo == "Saving Private Ryan").Id;
            relaciones.AddRange(new[]
            {   new PeliculasPlataformas { Id = Guid.NewGuid(), PeliculaId = saving, PlataformaId = netflix, FechaAlta =    DateTime.Now.AddMonths(-4), FechaBaja = DateTime.Now.AddYears(1) },
            new PeliculasPlataformas { Id = Guid.NewGuid(), PeliculaId = saving, PlataformaId = prime, FechaAlta = DateTime.Now.AddMonths(-2), FechaBaja = DateTime.Now.AddYears(1) }
        });

            // Back to the Future - Netflix, Prime
            var bttf = context.Peliculas.First(p => p.Titulo == "Back to the Future").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasPlataformas { Id = Guid.NewGuid(), PeliculaId = bttf, PlataformaId = netflix, FechaAlta = DateTime.Now.AddMonths(-5), FechaBaja = DateTime.Now.AddYears(1) },
            new PeliculasPlataformas { Id = Guid.NewGuid(), PeliculaId = bttf, PlataformaId = prime, FechaAlta = DateTime.Now.AddMonths(-3), FechaBaja = DateTime.Now.AddYears(1) }
        });

            // Gladiator - Netflix, Prime
            var gladiator = context.Peliculas.First(p => p.Titulo == "Gladiator").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasPlataformas { Id = Guid.NewGuid(), PeliculaId = gladiator, PlataformaId = netflix, FechaAlta = DateTime.Now.AddMonths(-4), FechaBaja = DateTime.Now.AddYears(1) },
            new PeliculasPlataformas { Id = Guid.NewGuid(), PeliculaId = gladiator, PlataformaId = prime, FechaAlta = DateTime.Now.AddMonths(-2), FechaBaja = DateTime.Now.AddYears(1) }
        });

            // Braveheart - Prime, Hulu
            var braveheart = context.Peliculas.First(p => p.Titulo == "Braveheart").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasPlataformas { Id = Guid.NewGuid(), PeliculaId = braveheart, PlataformaId = prime, FechaAlta = DateTime.Now.AddMonths(-5), FechaBaja = DateTime.Now.AddYears(1) },
            new PeliculasPlataformas { Id = Guid.NewGuid(), PeliculaId = braveheart, PlataformaId = hulu, FechaAlta = DateTime.Now.AddMonths(-3), FechaBaja = DateTime.Now.AddYears(1) }
        });

            // Terminator 2 - Prime, Netflix
            var terminator = context.Peliculas.First(p => p.Titulo == "Terminator 2: Judgment Day").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasPlataformas { Id = Guid.NewGuid(), PeliculaId = terminator, PlataformaId = prime, FechaAlta = DateTime.Now.AddMonths(-4), FechaBaja = DateTime.Now.AddYears(1) },
            new PeliculasPlataformas { Id = Guid.NewGuid(), PeliculaId = terminator, PlataformaId = netflix, FechaAlta = DateTime.Now.AddMonths(-2), FechaBaja = DateTime.Now.AddYears(1) }
        });

            // Alien - HBO Max, Prime
            var alien = context.Peliculas.First(p => p.Titulo == "Alien").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasPlataformas { Id = Guid.NewGuid(), PeliculaId = alien, PlataformaId = hbo, FechaAlta = DateTime.Now.AddMonths(-6), FechaBaja = DateTime.Now.AddYears(1) },
            new PeliculasPlataformas { Id = Guid.NewGuid(), PeliculaId = alien, PlataformaId = prime, FechaAlta = DateTime.Now.AddMonths(-3), FechaBaja = DateTime.Now.AddYears(1) }
        });

            // Blade Runner - HBO Max, Prime
            var blade = context.Peliculas.First(p => p.Titulo == "Blade Runner").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasPlataformas { Id = Guid.NewGuid(), PeliculaId = blade, PlataformaId = hbo, FechaAlta = DateTime.Now.AddMonths(-5), FechaBaja = DateTime.Now.AddYears(1) },
            new PeliculasPlataformas { Id = Guid.NewGuid(), PeliculaId = blade, PlataformaId = prime, FechaAlta = DateTime.Now.AddMonths(-2), FechaBaja = DateTime.Now.AddYears(1) }
        });

            // The Green Mile - Netflix, Prime
            var greenMile = context.Peliculas.First(p => p.Titulo == "The Green Mile").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasPlataformas { Id = Guid.NewGuid(), PeliculaId = greenMile, PlataformaId = netflix, FechaAlta = DateTime.Now.AddMonths(-4), FechaBaja = DateTime.Now.AddYears(1) },
            new PeliculasPlataformas { Id = Guid.NewGuid(), PeliculaId = greenMile, PlataformaId = prime, FechaAlta = DateTime.Now.AddMonths(-2), FechaBaja = DateTime.Now.AddYears(1) }
        });

            // Interstellar - Paramount+, Prime
            var interstellar = context.Peliculas.First(p => p.Titulo == "Interstellar").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasPlataformas { Id = Guid.NewGuid(), PeliculaId = interstellar, PlataformaId = paramount, FechaAlta = DateTime.Now.AddMonths(-6), FechaBaja = DateTime.Now.AddYears(1) },
            new PeliculasPlataformas { Id = Guid.NewGuid(), PeliculaId = interstellar, PlataformaId = prime, FechaAlta = DateTime.Now.AddMonths(-3), FechaBaja = DateTime.Now.AddYears(1) }
        });

            // Parasite - Netflix, Prime
            var parasite = context.Peliculas.First(p => p.Titulo == "Parasite").Id;
            relaciones.AddRange(new[]
            {
            new PeliculasPlataformas { Id = Guid.NewGuid(), PeliculaId = parasite, PlataformaId = netflix, FechaAlta = DateTime.Now.AddMonths(-3), FechaBaja = DateTime.Now.AddYears(1) },
            new PeliculasPlataformas { Id = Guid.NewGuid(), PeliculaId = parasite, PlataformaId = prime, FechaAlta = DateTime.Now.AddMonths(-1), FechaBaja = DateTime.Now.AddYears(1) }
        });

            context.PeliculasPlataformas.AddRange(relaciones);
            context.SaveChanges();
        }

        private static void SeedMedia(MaxiFlixDbContext context)
        {
            var relaciones = new List<Media>();
            var poster = context.MediaTipos.First(m => m.Descripcion == "Poster").Id;
            var backdrop = context.MediaTipos.First(m => m.Descripcion == "Backdrop").Id;
            var trailer = context.MediaTipos.First(m => m.Descripcion == "Trailer").Id;

            // The Godfather
            var godfather = context.Peliculas.First(p => p.Titulo == "The Godfather").Id;
            relaciones.AddRange(new[]
            {
            new Media { Id = Guid.NewGuid(), PeliculaId = godfather, MediaUrl = "https://image.tmdb.org/t/p/original/3bhkrj58Vtu7enYsRolD1fZdja1.jpg", TipoId = poster },
            new Media { Id = Guid.NewGuid(), PeliculaId = godfather, MediaUrl = "https://image.tmdb.org/t/p/original/rSPw7tgCH9c6NqICZef4k7BO9jT.jpg", TipoId = backdrop },
            new Media { Id = Guid.NewGuid(), PeliculaId = godfather, MediaUrl = "https://www.youtube.com/watch?v=sY1S34973zA", TipoId = trailer }
        });

            // Pulp Fiction
            var pulp = context.Peliculas.First(p => p.Titulo == "Pulp Fiction").Id;
            relaciones.AddRange(new[]
            {
            new Media { Id = Guid.NewGuid(), PeliculaId = pulp, MediaUrl = "https://image.tmdb.org/t/p/original/d5iIlFn5s0ImszYzBPb8JPIfbXD.jpg", TipoId = poster },
            new Media { Id = Guid.NewGuid(), PeliculaId = pulp, MediaUrl = "https://image.tmdb.org/t/p/original/9rZg4J6Q8q8Q8z8z8z8z8z8z8z8.jpg", TipoId = backdrop },
            new Media { Id = Guid.NewGuid(), PeliculaId = pulp, MediaUrl = "https://www.youtube.com/watch?v=s7EdQ4FqbhY", TipoId = trailer }
        });

            // The Shawshank Redemption
            var shawshank = context.Peliculas.First(p => p.Titulo == "The Shawshank Redemption").Id;
            relaciones.AddRange(new[]
            {
            new Media { Id = Guid.NewGuid(), PeliculaId = shawshank, MediaUrl = "https://image.tmdb.org/t/p/original/9cqNxx0GxF0bflZmeSMuL5tnGzr.jpg", TipoId = poster },
            new Media { Id = Guid.NewGuid(), PeliculaId = shawshank, MediaUrl = "https://image.tmdb.org/t/p/original/z8U0Se1jRK0ZgZz8z8z8z8z8z8.jpg", TipoId = backdrop },
            new Media { Id = Guid.NewGuid(), PeliculaId = shawshank, MediaUrl = "https://www.youtube.com/watch?v=6hB3S9bIaco", TipoId = trailer }
        });

            // Forrest Gump
            var forrest = context.Peliculas.First(p => p.Titulo == "Forrest Gump").Id;
            relaciones.AddRange(new[]
            {
            new Media { Id = Guid.NewGuid(), PeliculaId = forrest, MediaUrl = "https://image.tmdb.org/t/p/original/arw2vcBveWOVZr6pxc9RX13B9eU.jpg", TipoId = poster },
            new Media { Id = Guid.NewGuid(), PeliculaId = forrest, MediaUrl = "https://image.tmdb.org/t/p/original/z8U0Se1jRK0ZgZz8z8z8z8z8z8.jpg", TipoId = backdrop },
            new Media { Id = Guid.NewGuid(), PeliculaId = forrest, MediaUrl = "https://www.youtube.com/watch?v=bLvqoHBptjg", TipoId = trailer }
        });

            // Inception
            var inception = context.Peliculas.First(p => p.Titulo == "Inception").Id;
            relaciones.AddRange(new[]
            {
            new Media { Id = Guid.NewGuid(), PeliculaId = inception, MediaUrl = "https://image.tmdb.org/t/p/original/9gk7adHYeDvHkCSEqAvQNLV5Uge.jpg", TipoId = poster },
            new Media { Id = Guid.NewGuid(), PeliculaId = inception, MediaUrl = "https://image.tmdb.org/t/p/original/s3TBrRGB1iav7gFOCNx3H31MoES.jpg", TipoId = backdrop },
            new Media { Id = Guid.NewGuid(), PeliculaId = inception, MediaUrl = "https://www.youtube.com/watch?v=YoHD9XEInc0", TipoId = trailer }
        });

            // The Dark Knight
            var darkKnight = context.Peliculas.First(p => p.Titulo == "The Dark Knight").Id;
            relaciones.AddRange(new[]
            {
            new Media { Id = Guid.NewGuid(), PeliculaId = darkKnight, MediaUrl = "https://image.tmdb.org/t/p/original/qJ2tW6WMUDux911r6m7haRef0WH.jpg", TipoId = poster },
            new Media { Id = Guid.NewGuid(), PeliculaId = darkKnight, MediaUrl = "https://image.tmdb.org/t/p/original/nMKdUUepR0i5zn0y1T4CsSB5chy.jpg", TipoId = backdrop },
            new Media { Id = Guid.NewGuid(), PeliculaId = darkKnight, MediaUrl = "https://www.youtube.com/watch?v=EXeTwQWrcwY", TipoId = trailer }
        });

            // Fight Club
            var fightClub = context.Peliculas.First(p => p.Titulo == "Fight Club").Id;
            relaciones.AddRange(new[]
            {
            new Media { Id = Guid.NewGuid(), PeliculaId = fightClub, MediaUrl = "https://image.tmdb.org/t/p/original/pB8BM7pdSp6B6Ih7QZ4DrQ3PmJK.jpg", TipoId = poster },
            new Media { Id = Guid.NewGuid(), PeliculaId = fightClub, MediaUrl = "https://image.tmdb.org/t/p/original/rr7E0NoGKxvbkb89e1z2Zbmgv7O.jpg", TipoId = backdrop },
            new Media { Id = Guid.NewGuid(), PeliculaId = fightClub, MediaUrl = "https://www.youtube.com/watch?v=SUXWAEXZ17g", TipoId = trailer }
        });

            // Goodfellas
            var goodfellas = context.Peliculas.First(p => p.Titulo == "Goodfellas").Id;
            relaciones.AddRange(new[]
            {
            new Media { Id = Guid.NewGuid(), PeliculaId = goodfellas, MediaUrl = "https://image.tmdb.org/t/p/original/aKuFiU82s5ISJpGZp7Yk5Z0bKpJ.jpg", TipoId = poster },
            new Media { Id = Guid.NewGuid(), PeliculaId = goodfellas, MediaUrl = "https://image.tmdb.org/t/p/original/z8U0Se1jRK0ZgZz8z8z8z8z8z8.jpg", TipoId = backdrop },
            new Media { Id = Guid.NewGuid(), PeliculaId = goodfellas, MediaUrl = "https://www.youtube.com/watch?v=2ilzidi_J8Q", TipoId = trailer }
        });

            // The Matrix
            var matrix = context.Peliculas.First(p => p.Titulo == "The Matrix").Id;
            relaciones.AddRange(new[]
            {
            new Media { Id = Guid.NewGuid(), PeliculaId = matrix, MediaUrl = "https://image.tmdb.org/t/p/original/f89U3ADr1oiB1s9GkdPOEpXUk5H.jpg", TipoId = poster },
            new Media { Id = Guid.NewGuid(), PeliculaId = matrix, MediaUrl = "https://image.tmdb.org/t/p/original/nuF5yWt5e4dE4n6kChd6iX9q5wZ.jpg", TipoId = backdrop },
            new Media { Id = Guid.NewGuid(), PeliculaId = matrix, MediaUrl = "https://www.youtube.com/watch?v=m8e-FF8MsqU", TipoId = trailer }
        });

            // Star Wars
            var starWars = context.Peliculas.First(p => p.Titulo == "Star Wars: Episode IV - A New Hope").Id;
            relaciones.AddRange(new[]
            {
            new Media { Id = Guid.NewGuid(), PeliculaId = starWars, MediaUrl = "https://image.tmdb.org/t/p/original/6FfCtAuVAW8XJjZ7eWeLibRLWT.jpg", TipoId = poster },
            new Media { Id = Guid.NewGuid(), PeliculaId = starWars, MediaUrl = "https://image.tmdb.org/t/p/original/dqK9H8bH8i9yF8z8z8z8z8z8z8.jpg", TipoId = backdrop },
            new Media { Id = Guid.NewGuid(), PeliculaId = starWars, MediaUrl = "https://www.youtube.com/watch?v=1g3_CFmnU7k", TipoId = trailer }
        });

            // Titanic
            var titanic = context.Peliculas.First(p => p.Titulo == "Titanic").Id;
            relaciones.AddRange(new[]
            {
            new Media { Id = Guid.NewGuid(), PeliculaId = titanic, MediaUrl = "https://image.tmdb.org/t/p/original/9xjZS2rlVxm8SFx8kPC3aIGCOYQ.jpg", TipoId = poster },
            new Media { Id = Guid.NewGuid(), PeliculaId = titanic, MediaUrl = "https://image.tmdb.org/t/p/original/z8U0Se1jRK0ZgZz8z8z8z8z8z8.jpg", TipoId = backdrop },
            new Media { Id = Guid.NewGuid(), PeliculaId = titanic, MediaUrl = "https://www.youtube.com/watch?v=2e-eX6l2vXo", TipoId = trailer }
        });

            // Jurassic Park
            var jurassic = context.Peliculas.First(p => p.Titulo == "Jurassic Park").Id;
            relaciones.AddRange(new[]
            {
            new Media { Id = Guid.NewGuid(), PeliculaId = jurassic, MediaUrl = "https://image.tmdb.org/t/p/original/oU7Oq2kFAAlGqb4QJ2nLB0FBm40.jpg", TipoId = poster },
            new Media { Id = Guid.NewGuid(), PeliculaId = jurassic, MediaUrl = "https://image.tmdb.org/t/p/original/pD8EQoDq2s8u2aZ9j1rT8z8z8z8.jpg", TipoId = backdrop },
            new Media { Id = Guid.NewGuid(), PeliculaId = jurassic, MediaUrl = "https://www.youtube.com/watch?v=lc0UehYemQA", TipoId = trailer }
        });

            // The Silence of the Lambs
            var silence = context.Peliculas.First(p => p.Titulo == "The Silence of the Lambs").Id;
            relaciones.AddRange(new[]
            {
            new Media { Id = Guid.NewGuid(), PeliculaId = silence, MediaUrl = "https://image.tmdb.org/t/p/original/rplLJ2h8N5IXBaXMqS8qC8Q1f.jpg", TipoId = poster },
            new Media { Id = Guid.NewGuid(), PeliculaId = silence, MediaUrl = "https://image.tmdb.org/t/p/original/z8U0Se1jRK0ZgZz8z8z8z8z8z8.jpg", TipoId = backdrop },
            new Media { Id = Guid.NewGuid(), PeliculaId = silence, MediaUrl = "https://www.youtube.com/watch?v=W6Mm8Sbe__o", TipoId = trailer }
        });

            // Schindler's List
            var schindler = context.Peliculas.First(p => p.Titulo == "Schindler's List").Id;
            relaciones.AddRange(new[]
            {
            new Media { Id = Guid.NewGuid(), PeliculaId = schindler, MediaUrl = "https://image.tmdb.org/t/p/original/sF1U4EUQS8YHUYjNl3pMGNIQyr0.jpg", TipoId = poster },
            new Media { Id = Guid.NewGuid(), PeliculaId = schindler, MediaUrl = "https://image.tmdb.org/t/p/original/z8U0Se1jRK0ZgZz8z8z8z8z8z8.jpg", TipoId = backdrop },
            new Media { Id = Guid.NewGuid(), PeliculaId = schindler, MediaUrl = "https://www.youtube.com/watch?v=gG22XNhtnoY", TipoId = trailer }
        });

            // Saving Private Ryan
            var saving = context.Peliculas.First(p => p.Titulo == "Saving Private Ryan").Id;
            relaciones.AddRange(new[]
            {
            new Media { Id = Guid.NewGuid(), PeliculaId = saving, MediaUrl = "https://image.tmdb.org/t/p/original/uqx37hS9S6d5z1y9z8z8z8z8z8.jpg", TipoId = poster },
            new Media { Id = Guid.NewGuid(), PeliculaId = saving, MediaUrl = "https://image.tmdb.org/t/p/original/z8U0Se1jRK0ZgZz8z8z8z8z8z8.jpg", TipoId = backdrop },
            new Media { Id = Guid.NewGuid(), PeliculaId = saving, MediaUrl = "https://www.youtube.com/watch?v=zwhP5b4tD6g", TipoId = trailer }
        });

            // Back to the Future
            var bttf = context.Peliculas.First(p => p.Titulo == "Back to the Future").Id;
            relaciones.AddRange(new[]
            {
            new Media { Id = Guid.NewGuid(), PeliculaId = bttf, MediaUrl = "https://image.tmdb.org/t/p/original/7lyBcpYB0Qt8gYhXYaEZUNlNQ1r.jpg", TipoId = poster },
            new Media { Id = Guid.NewGuid(), PeliculaId = bttf, MediaUrl = "https://image.tmdb.org/t/p/original/z8U0Se1jRK0ZgZz8z8z8z8z8z8.jpg", TipoId = backdrop },
            new Media { Id = Guid.NewGuid(), PeliculaId = bttf, MediaUrl = "https://www.youtube.com/watch?v=qvsgGtivCgs", TipoId = trailer }
        });

            // Gladiator
            var gladiator = context.Peliculas.First(p => p.Titulo == "Gladiator").Id;
            relaciones.AddRange(new[]
            {
            new Media { Id = Guid.NewGuid(), PeliculaId = gladiator, MediaUrl = "https://image.tmdb.org/t/p/original/ty8T7UV0tZL4qT8pRQ2p6j1z8z8.jpg", TipoId = poster },
            new Media { Id = Guid.NewGuid(), PeliculaId = gladiator, MediaUrl = "https://image.tmdb.org/t/p/original/z8U0Se1jRK0ZgZz8z8z8z8z8z8.jpg", TipoId = backdrop },
            new Media { Id = Guid.NewGuid(), PeliculaId = gladiator, MediaUrl = "https://www.youtube.com/watch?v=owK1qxDselE", TipoId = trailer }
        });

            // Braveheart
            var braveheart = context.Peliculas.First(p => p.Titulo == "Braveheart").Id;
            relaciones.AddRange(new[]
            {
            new Media { Id = Guid.NewGuid(), PeliculaId = braveheart, MediaUrl = "https://image.tmdb.org/t/p/original/or1gBugZMH3PUz7jMNhXNRY8z8.jpg", TipoId = poster },
            new Media { Id = Guid.NewGuid(), PeliculaId = braveheart, MediaUrl = "https://image.tmdb.org/t/p/original/z8U0Se1jRK0ZgZz8z8z8z8z8z8.jpg", TipoId = backdrop },
            new Media { Id = Guid.NewGuid(), PeliculaId = braveheart, MediaUrl = "https://www.youtube.com/watch?v=1NJO0jxBtMo", TipoId = trailer }
        });

            // Terminator 2
            var terminator = context.Peliculas.First(p => p.Titulo == "Terminator 2: Judgment Day").Id;
            relaciones.AddRange(new[]
            {
            new Media { Id = Guid.NewGuid(), PeliculaId = terminator, MediaUrl = "https://image.tmdb.org/t/p/original/weVXMD5QBGeQil4KGJMo5rR9p8I.jpg", TipoId = poster },
            new Media { Id = Guid.NewGuid(), PeliculaId = terminator, MediaUrl = "https://image.tmdb.org/t/p/original/z8U0Se1jRK0ZgZz8z8z8z8z8z8.jpg", TipoId = backdrop },
            new Media { Id = Guid.NewGuid(), PeliculaId = terminator, MediaUrl = "https://www.youtube.com/watch?v=LWwZ8J9uQ0E", TipoId = trailer }
        });

            // Alien
            var alien = context.Peliculas.First(p => p.Titulo == "Alien").Id;
            relaciones.AddRange(new[]
            {
            new Media { Id = Guid.NewGuid(), PeliculaId = alien, MediaUrl = "https://image.tmdb.org/t/p/original/vfrQk5IPloGg1v9Rzbh2Eg3VGyM.jpg", TipoId = poster },
            new Media { Id = Guid.NewGuid(), PeliculaId = alien, MediaUrl = "https://image.tmdb.org/t/p/original/z8U0Se1jRK0ZgZz8z8z8z8z8z8.jpg", TipoId = backdrop },
            new Media { Id = Guid.NewGuid(), PeliculaId = alien, MediaUrl = "https://www.youtube.com/watch?v=LjLamj-b0I8", TipoId = trailer }
        });

            // Blade Runner
            var blade = context.Peliculas.First(p => p.Titulo == "Blade Runner").Id;
            relaciones.AddRange(new[]
            {
            new Media { Id = Guid.NewGuid(), PeliculaId = blade, MediaUrl = "https://image.tmdb.org/t/p/original/63N9uy8nd9j7Eog2axPQ8lB3DjE.jpg", TipoId = poster },
            new Media { Id = Guid.NewGuid(), PeliculaId = blade, MediaUrl = "https://image.tmdb.org/t/p/original/z8U0Se1jRK0ZgZz8z8z8z8z8z8.jpg", TipoId = backdrop },
            new Media { Id = Guid.NewGuid(), PeliculaId = blade, MediaUrl = "https://www.youtube.com/watch?v=eogpIG53Cis", TipoId = trailer }
        });

            // The Green Mile
            var greenMile = context.Peliculas.First(p => p.Titulo == "The Green Mile").Id;
            relaciones.AddRange(new[]
            {
            new Media { Id = Guid.NewGuid(), PeliculaId = greenMile, MediaUrl = "https://image.tmdb.org/t/p/original/velWPhVMQeQKcxggNEU8YmIo55R.jpg", TipoId = poster },
            new Media { Id = Guid.NewGuid(), PeliculaId = greenMile, MediaUrl = "https://image.tmdb.org/t/p/original/z8U0Se1jRK0ZgZz8z8z8z8z8z8.jpg", TipoId = backdrop },
            new Media { Id = Guid.NewGuid(), PeliculaId = greenMile, MediaUrl = "https://www.youtube.com/watch?v=Ki4haFrqSrw", TipoId = trailer }
        });

            // Interstellar
            var interstellar = context.Peliculas.First(p => p.Titulo == "Interstellar").Id;
            relaciones.AddRange(new[]
            {
            new Media { Id = Guid.NewGuid(), PeliculaId = interstellar, MediaUrl = "https://image.tmdb.org/t/p/original/gEU2QniL6E86tC9z1Pa1gr5Z0y8.jpg", TipoId = poster },
            new Media { Id = Guid.NewGuid(), PeliculaId = interstellar, MediaUrl = "https://image.tmdb.org/t/p/original/rAiYTfKGqDCRIIqo664sY9XZIv.jpg", TipoId = backdrop },
            new Media { Id = Guid.NewGuid(), PeliculaId = interstellar, MediaUrl = "https://www.youtube.com/watch?v=zSWdZVtXT7E", TipoId = trailer }
        });

            // Parasite
            var parasite = context.Peliculas.First(p => p.Titulo == "Parasite").Id;
            relaciones.AddRange(new[]
            {
            new Media { Id = Guid.NewGuid(), PeliculaId = parasite, MediaUrl = "https://image.tmdb.org/t/p/original/7IiTTgloJzvGI1TAYymCfbfl3vT.jpg", TipoId = poster },
            new Media { Id = Guid.NewGuid(), PeliculaId = parasite, MediaUrl = "https://image.tmdb.org/t/p/original/TuT3n3QE6vZl9z8z8z8z8z8z8.jpg", TipoId = backdrop },
            new Media { Id = Guid.NewGuid(), PeliculaId = parasite, MediaUrl = "https://www.youtube.com/watch?v=5xH0HfJHsaY", TipoId = trailer }
        });

            context.Media.AddRange(relaciones);
            context.SaveChanges();
        }

        private static void SeedUsuarios(MaxiFlixDbContext context)
        {
            var usuarios = new List<Usuarios>
        {
            new() { Id = Guid.NewGuid(), Nombre = "Juan", Apellido = "García", Email = "juan.garcia@email.com", Clave = "123abc", FechaCreacion = DateTime.Now.AddMonths(-12), Activo = true, UrlImgPerfil = "https://i.pravatar.cc/150?u=juan" },
            new() { Id = Guid.NewGuid(), Nombre = "María", Apellido = "López", Email = "maria.lopez@email.com", Clave = "456def", FechaCreacion = DateTime.Now.AddMonths(-10), Activo = true, UrlImgPerfil = "https://i.pravatar.cc/150?u=maria" },
            new() { Id = Guid.NewGuid(), Nombre = "Carlos", Apellido = "Martínez", Email = "carlos.martinez@email.com", Clave = "789ghi", FechaCreacion = DateTime.Now.AddMonths(-8), Activo = true, UrlImgPerfil = "https://i.pravatar.cc/150?u=carlos" },
            new() { Id = Guid.NewGuid(), Nombre = "Ana", Apellido = "Rodríguez", Email = "ana.rodriguez@email.com", Clave = "321jkl", FechaCreacion = DateTime.Now.AddMonths(-6), Activo = true, UrlImgPerfil = "https://i.pravatar.cc/150?u=ana" },
            new() { Id = Guid.NewGuid(), Nombre = "Luis", Apellido = "Sánchez", Email = "luis.sanchez@email.com", Clave = "654mno", FechaCreacion = DateTime.Now.AddMonths(-4), Activo = true, UrlImgPerfil = "https://i.pravatar.cc/150?u=luis" },
            new() { Id = Guid.NewGuid(), Nombre = "Laura", Apellido = "Pérez", Email = "laura.perez@email.com", Clave = "987pqr", FechaCreacion = DateTime.Now.AddMonths(-2), Activo = true, UrlImgPerfil = "https://i.pravatar.cc/150?u=laura" },
            new() { Id = Guid.NewGuid(), Nombre = "Pedro", Apellido = "Gómez", Email = "pedro.gomez@email.com", Clave = "147stu", FechaCreacion = DateTime.Now.AddMonths(-1), Activo = true, UrlImgPerfil = "https://i.pravatar.cc/150?u=pedro" },
            new() { Id = Guid.NewGuid(), Nombre = "Sofía", Apellido = "Fernández", Email = "sofia.fernandez@email.com", Clave = "258vwx", FechaCreacion = DateTime.Now.AddDays(-15), Activo = true, UrlImgPerfil = "https://i.pravatar.cc/150?u=sofia" },
            new() { Id = Guid.NewGuid(), Nombre = "Diego", Apellido = "Ruiz", Email = "diego.ruiz@email.com", Clave = "369yza", FechaCreacion = DateTime.Now.AddDays(-7), Activo = true, UrlImgPerfil = "https://i.pravatar.cc/150?u=diego" },
            new() { Id = Guid.NewGuid(), Nombre = "Elena", Apellido = "Torres", Email = "elena.torres@email.com", Clave = "159bcd", FechaCreacion = DateTime.Now.AddDays(-3), Activo = true, UrlImgPerfil = "https://i.pravatar.cc/150?u=elena" }
        };

            context.Usuarios.AddRange(usuarios);
            context.SaveChanges();
        }

        private static void SeedPeliculasPuntuacion(MaxiFlixDbContext context)
        {
            var random = new Random();
            var peliculas = context.Peliculas.ToList();
            var usuarios = context.Usuarios.ToList();

            var puntuaciones = new List<PeliculasPuntuacion>();

            foreach (var pelicula in peliculas)
            {
                // Cada película tiene entre 3 y 8 puntuaciones de usuarios aleatorios
                var numPuntuaciones = random.Next(3, 9);
                var usuariosAleatorios = usuarios.OrderBy(x => random.Next()).Take(numPuntuaciones).ToList();

                foreach (var usuario in usuariosAleatorios)
                {
                    puntuaciones.Add(new PeliculasPuntuacion
                    {
                        Id = Guid.NewGuid(),
                        PeliculaId = pelicula.Id,
                        UsuarioId = usuario.Id,
                        Puntuacion = (byte)random.Next(3, 6), // Puntuación entre 3 y 5
                        FechaPuntuacion = DateTime.Now.AddDays(-random.Next(1, 365))
                    });
                }
            }

            context.PeliculasPuntuaciones.AddRange(puntuaciones);
            context.SaveChanges();
        }

        private static void SeedUsuariosFavoritos(MaxiFlixDbContext context)
        {
            var random = new Random();
            var peliculas = context.Peliculas.ToList();
            var usuarios = context.Usuarios.ToList();

            var favoritos = new List<UsuariosFavoritos>();

            foreach (var usuario in usuarios)
            {
                // Cada usuario tiene entre 2 y 6 películas favoritas
                var numFavoritos = random.Next(2, 7);
                var peliculasAleatorias = peliculas.OrderBy(x => random.Next()).Take(numFavoritos).ToList();

                foreach (var pelicula in peliculasAleatorias)
                {
                    favoritos.Add(new UsuariosFavoritos
                    {
                        Id = Guid.NewGuid(),
                        UsuarioId = usuario.Id,
                        PeliculaId = pelicula.Id,
                        FechaFavorito = DateTime.Now.AddDays(-random.Next(1, 180))
                    });
                }
            }

            context.UsuariosFavoritos.AddRange(favoritos);
            context.SaveChanges();
        }
    }
}
