using System;
using SistemaVideojuegos.Models;

class Program
{
    static void Main(string[] args)
    {
        Jugador jugador = new Jugador("Juan", 20, "ProGamer");
        Videojuego juego = new Videojuego("FIFA", "Deportes");

        Partida partida = new Partida(jugador, juego, 100);
        partida.MostrarResumen();

        Console.ReadKey();
    }
}
