using System;

namespace MultiploDe3
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digete o numero: ");
            int Num = int.Parse(Console.ReadLine());
            if(Num % 3 == 0){
                System.Console.WriteLine("O numero é multiplo por 3");
            } else {
                System.Console.WriteLine("O numero não é multiplo de 3");
            }
        }
    }
}
