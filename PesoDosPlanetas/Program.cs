using System;

namespace PesoDosPlanetas
{
    class Program
    {
        static void Main(string[] args)
        {
            string opção;
            double Resultado;

            System.Console.WriteLine("Escolha uma opção: ");
            System.Console.WriteLine("1- Mercurio");
            System.Console.WriteLine("2- Vênus");
            System.Console.WriteLine("3- Marte");
            System.Console.WriteLine("4- Júpite");
            System.Console.WriteLine("5- Saturno");
            System.Console.WriteLine("6- Urano");
            opção = Console.ReadLine();

            Console.WriteLine("Escreva o seu peso: ");
            double Peso = double.Parse(Console.ReadLine());
            
            switch(opção){
                case "1":
                Resultado = Peso * 0.37;
                System.Console.WriteLine("O seu peso em mercurio é " + Resultado );
                break;

                case "2":
                Resultado = Peso * 0.88;
                System.Console.WriteLine("O seu peso em Vênus é " + Resultado );
                break;
                
                case "3":
                Resultado = Peso * 0.38;
                System.Console.WriteLine("O seu peso em Marte é " + Resultado );
                break;

                case "4":
                Resultado = Peso * 2.64;
                System.Console.WriteLine("O seu peso em Júpite é " + Resultado );
                break;

                case "5":
                Resultado = Peso * 1.15;
                System.Console.WriteLine("O seu peso em Saturno é " + Resultado );
                break;

                case "6":
                Resultado = Peso * 1.17;
                System.Console.WriteLine("O seu peso em Urano é " + Resultado );
                break;

            }
            


        }
    }
}
