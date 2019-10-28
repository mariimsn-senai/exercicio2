using System;

namespace VerboUR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva um verbo: ");
            var Verbo = (Console.ReadLine());

            if(Verbo.EndsWith("ar"))
            {
                System.Console.WriteLine("Verbo da 1ª- conjugação");
            } else if (Verbo.EndsWith("er")){
                System.Console.WriteLine("Verbo da 2ª- conjugação");
            }else if (Verbo.EndsWith("ir")){
            System.Console.WriteLine("Verbo da 3ª- conjugação");
        }else{
            System.Console.WriteLine("não é verbo");
        }
    }
}
}
