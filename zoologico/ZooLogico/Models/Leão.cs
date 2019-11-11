using ZooLogico.Interfaces;
namespace ZooLogico.Models
{
    public class Leão : ITerrestre
    {
        public bool Pasto()
        {
            System.Console.WriteLine("Esse animal vai para o Pasto. ");
            return true;

        }
    }
}