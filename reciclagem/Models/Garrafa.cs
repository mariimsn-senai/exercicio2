using reciclagem.Interfaces;

namespace reciclagem.Models
{
    public class Garrafa : IVidro
    {
        public bool ReciclarVidro()
        {
            System.Console.WriteLine("Lixo VERDE");
            return true;
        }
    }
}