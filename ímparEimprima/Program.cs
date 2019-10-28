using System;

namespace ímparEimprima
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            System.Console.WriteLine("escreva um mumero: ");
            int num =int.Parse(Console.ReadLine());


        for(i = 1 ; i <= num ; i +=2){


            System.Console.WriteLine();
            Console.Write(i);
            
        }
        }
    }
}

