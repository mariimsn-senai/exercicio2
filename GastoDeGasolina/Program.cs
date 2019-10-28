using System;

namespace GastoDeGasolina
{
    class Program
    {
        static void Main(string[] args)
        {
            double Distancia;
            double Resultado;


            System.Console.WriteLine("Digite o tempo: ");
            double Tempo = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite a velocidade: ");
            double Velocidade = double.Parse(Console.ReadLine());
            Distancia = Tempo * Velocidade;
            Resultado = Distancia / 12;
            System.Console.WriteLine("A quantidade gasta de litros de combustível é " + Resultado);
        }
    }
}

//jksfkdsnf  % 2 == 0!=0 