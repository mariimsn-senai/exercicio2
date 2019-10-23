using System;

namespace BaseRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {

            double Base;
            double altura;
            double Perimeto;
            double area;
            double diagonal;
            double dois = 2;
            Console.WriteLine("Coloque a altura do retangulo: ");
            Base = double.Parse(Console.ReadLine());
            Console.WriteLine("Coloque a base do retangulo: ");
            altura=double.Parse(Console.ReadLine());
            area = Base*dois + altura*dois;
            System.Console.WriteLine($" o resultado da área é "+ area);

            Console.WriteLine("Coloque a altura do retangulo: ");
            Base = double.Parse(Console.ReadLine());
            Console.WriteLine("Coloque a base do retangulo: ");
            altura=double.Parse(Console.ReadLine());
            Perimeto = Base * altura;
            System.Console.WriteLine($" o resultado Perimetro é "+ Perimeto);

            Console.WriteLine("Coloque a altura do retangulo: ");
            Base = double.Parse(Console.ReadLine());
            Console.WriteLine("Coloque a base do retangulo: ");
            altura=double.Parse(Console.ReadLine());
            
            diagonal = Math.Sqrt((Base * Base) + (altura * altura));
            System.Console.WriteLine($" o resultado diametro é "+ diagonal);



        }
    }
}
