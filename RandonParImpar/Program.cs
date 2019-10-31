using System;
using System.Collections.Generic;

namespace RandonParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> impar = new List<int>();
            List<int> Par = new List<int>();
            Random random = new Random();
            int [] vetor = new int[10];
            for(int i = 0; i <10; i++){
                vetor[i] = random.Next(0, 100);
            }
            foreach (var item in vetor)
            {
                if (item % 2 == 0)
                {
                    Par.Add(item);
                }
                else
                {
                    impar.Add(item);
                }
            }
            foreach(var item in Par)
            {
                System.Console.WriteLine($"{item} Par");
            }
            System.Console.WriteLine();
            foreach (var item in impar)
            {
            System.Console.WriteLine($"{item} impar");
            }

            Console.ReadKey();

        }
    }
}
