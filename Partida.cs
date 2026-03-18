using System;

namespace SistemaVideojuegos.Models
{
    public class Partida
    {
        public Jugador Jugador { get; set; }
        public Videojuego Videojuego { get; set; }
        public int Puntaje { get; set; }

        public Partida(Jugador jugador, Videojuego videojuego, int puntaje)
        {
            Jugador = jugador;
            Videojuego = videojuego;
            Puntaje = puntaje;
        }

        public void MostrarResumen()
        {
            Console.WriteLine($"Jugador: {Jugador.Nickname} - Juego: {Videojuego.Titulo} - Puntaje: {Puntaje}");
        }
    }
}
