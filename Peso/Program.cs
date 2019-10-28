using System;

namespace Peso
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("digite o seu nome: ");
            string Nome =(Console.ReadLine());

            Console.WriteLine("digite o peso: ");
            double Peso = double.Parse(Console.ReadLine());

            Console.WriteLine("digite a altura: ");
            double altura = double.Parse(Console.ReadLine());

            double imc= Peso/(altura * altura);

            if(imc < 20){
                System.Console.WriteLine($"paciente {Nome}");
                System.Console.WriteLine("abaixo do peso");
            }else if (imc < 25 ){
                System.Console.WriteLine($"paciente {Nome}");
                System.Console.WriteLine("Normal");
            }else if (imc < 30){
                System.Console.WriteLine($"paciente {Nome}");
                System.Console.WriteLine("excesso de peso");
            }else if(imc < 35){
                System.Console.WriteLine($"paciente {Nome}");
                System.Console.WriteLine("obesidade");
            }else if(imc > 35){
                System.Console.WriteLine($"paciente {Nome}");
                System.Console.WriteLine("obesidade mórbida");
            }
        }
    }
}
