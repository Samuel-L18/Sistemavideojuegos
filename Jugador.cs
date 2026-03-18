namespace SistemaVideojuegos.Models
{
    public class Jugador : Persona
    {
        public string Nickname { get; set; }

        public Jugador(string nombre, int edad, string nickname) 
            : base(nombre, edad)
        {
            Nickname = nickname;
        }
    }
}
