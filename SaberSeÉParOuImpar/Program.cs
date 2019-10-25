using System;

namespace SaberSeÉParOuImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero: ");
            int num = int.Parse(Console.ReadLine());

            if (num != 0){
                if(num % 2 == 0){ 
                System.Console.WriteLine("O numero é par: ");
                }else{
                    System.Console.WriteLine("O numero é impar: ");
                }
            }while(num != 0);
        }
    }
}
