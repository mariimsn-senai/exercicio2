using System;

namespace VerboUR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva um verbo: ");
            var Verbo = (Console.ReadLine());

            if(Verbo.EndsWith($"{Verbo}")){
                System.Console.WriteLine("é verbo");
            }
        }
    }
}
