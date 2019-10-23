using System;

namespace LeiDeTemperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            double Resultado;
            double celsus;
            Console.WriteLine("Qual a temperatura Celsus: ");
            celsus = double.Parse(Console.ReadLine());
            Resultado = celsus * 9/5 + 32;

            System.Console.WriteLine("A temperatura em Fahreinhet é" + Resultado);

        }
    }
}
