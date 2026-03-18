namespace SistemaVideojuegos.Models
{
    public class Videojuego
    {
        public string Titulo { get; set; }
        public string Genero { get; set; }

        public Videojuego(string titulo, string genero)
        {
            Titulo = titulo;
            Genero = genero;
        }
    }
}
