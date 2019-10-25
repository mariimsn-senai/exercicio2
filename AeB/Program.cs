using System;

namespace AeB
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o numero A: ");
            double A = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero B: ");
            double B = double.Parse(Console.ReadLine());


            A += B;
            B = A - B;
            A -= B;

            System.Console.WriteLine($"O valor do A é {A} e o B é {B}");


        }
    }
}

