using ZooLogico.Interfaces;
namespace ZooLogico.Models
{
    public class GolfinhO : IAquatico
    {
        public bool Aquario()
        {
            System.Console.WriteLine("Esse animal vai para o aquario. ");
            return true;
        }
    }
}