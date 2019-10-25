using System;

namespace TrianguloEstrelinha
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string ast = "*";
            int alt = 0;

            
            System.Console.WriteLine("escolha a altura: ");
            alt = int.Parse(Console.ReadLine());
            for(int i = alt ; i >= 1; i--){
            for(int k = 1 ; k <= i; k++){
            Console.Write(ast);
            }
            Console.WriteLine("");
        }
    }
    }
}

