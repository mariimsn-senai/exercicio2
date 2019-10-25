using System;

namespace NumerosIguaisTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva o primeiro numero: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o segundo numero: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o terceiro numero: ");
            double num3 = double.Parse(Console.ReadLine());

            if(num1 == num2 && num1 == num2 && num2 == num3){
                System.Console.WriteLine("isso é um triangulo");
            }else{
                System.Console.WriteLine("isso não é um triangulo");
            }

        }
    }
}
