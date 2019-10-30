using System;

namespace CaixaEletronico
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Qual é o seu saldo? ");
            
            Console.WriteLine("Escolha uma opção: ");
            System.Console.WriteLine("1- Depositar");
            System.Console.WriteLine("2- Sacar");
            int opção = int.Parse(Console.ReadLine());

            switch(opção)
            {
                case 1:
                System.Console.WriteLine("Quanto gostaria de depositar? ");

            }
        }
    }
}
