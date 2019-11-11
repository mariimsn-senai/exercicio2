
using ZooLogico.Interfaces;
namespace ZooLogico.Models
{
    public class Orangotango : IArboricola
    {
        public bool CasaEmArvore()
        {
            System.Console.WriteLine("esse animal vai para a casa de arvore. ");
            return true;
        }
    }
}