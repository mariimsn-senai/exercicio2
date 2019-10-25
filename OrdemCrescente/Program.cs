using System;

namespace OrdemCrescente
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Escreva o primeiro numero: ");
            double Num = Double.Parse(Console.ReadLine());
            System.Console.WriteLine("Escreva o segundo numero: ");
            double Num1 = Double.Parse(Console.ReadLine());
            System.Console.WriteLine("Escreva o terceiro numero: ");
            double Num3 = Double.Parse(Console.ReadLine());

            int Compare = string.Compare(Num, Num1);
            int Compare1 = string.Compare(Num, Num3);
            int Compare2 = string.Compare(Num1, Num3);



            if (Compare >= 0)
            {
                if (Compare1 >= 0 && Compare3 >=0){
                    System.Console.WriteLine($"{Num} {Num1} {Num3}");
                }else{
                    System.Console.WriteLine($"{Num} {Num3} {Num1}");
                }
            } else {
                if (Compare2 >=0 && Compare1){
                    System.Console.WriteLine($"{Num1} {Num} {Num3}");
                } else {
                    System.Console.WriteLine($"{Num3} {Num}");
                }
            }





        }
    }
}
