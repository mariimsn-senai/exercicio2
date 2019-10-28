using System;

namespace RepetiçãoVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero: ");
            int x= int.Parse(Console.ReadLine());
            Console.Clear();
            int[] vetor = new int[x];
            for(int i =0; i < x; i++){
                int n =int.Parse(Console.ReadLine());
                vetor[i] = i;
            }
        }
    }
}
