using ZooLogico.Interfaces;
namespace ZooLogico.Models
{
    public class Chimpanze : IArboricola
    {
        public bool CasaEmArvore()
        {
            System.Console.WriteLine("Esse animal vai para a casa em arvore. ");
            return true;
        }
    }
}