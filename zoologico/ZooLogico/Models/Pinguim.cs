using ZooLogico.Interfaces;
namespace ZooLogico.Models
{
    public class Pinguim : IQuinofilo
    {
        public bool PiscinaGelada()
        {
            System.Console.WriteLine("esse aanimal vai para Piscina Gelada");
            return true;
        }
    }
}