using System;
using System.Collections.Generic;
using reciclagem.Models;

namespace reciclagem
{
    class Program
    {
        static void Main(string[] args)
        {
            int opção;
        System.Console.WriteLine("O que você quer jogar no lixo?");
        System.Console.WriteLine("1- Guarrafa");
        System.Console.WriteLine("2- GuarrafaPET");
        System.Console.WriteLine("3- Guarda Chuva");
        System.Console.WriteLine("4- Latinha");
        System.Console.WriteLine("5- Papelão");
        System.Console.WriteLine("6- Pote Manteiga ");
        opção = int.Parse(Console.ReadLine());
        
        switch(opção)
        {
            case 1:
                Console.Clear();
                Garrafa guarrafa = new Garrafa();
                Console.ForegroundColor = ConsoleColor.Green;
                guarrafa.ReciclarVidro();
                Console.ResetColor();
                break;

                case 2:
                Console.Clear();
                GarrafaPet GuarrafaPET = new GarrafaPet();
                Console.ForegroundColor = ConsoleColor.Red;
                GuarrafaPET.ReciclagemPlastico();
                Console.ResetColor();
                break;

                case 3:
                Console.Clear();
                GuadaChuva GuardaChuva = new GuadaChuva();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                GuardaChuva.ReciclarDescarteEspecial();
                Console.ResetColor();
                break;

                case 4:
                Console.Clear();
                Latinha latinha = new Latinha();
                Console.ForegroundColor = ConsoleColor.Yellow;
                latinha.ReciclarMetal();
                Console.ResetColor();
                break;

                case 5:
                Console.Clear();
                Papelão Papelão = new Papelão();
                Console.ForegroundColor = ConsoleColor.Blue;
                Papelão.ReciclarPapel();
                Console.ResetColor();
                break;

                case 6:
                Console.Clear();
                PoteManteiga poteManteiga = new PoteManteiga();
                Console.ForegroundColor = ConsoleColor.Red;
                poteManteiga.ReciclagemPlastico();
                Console.ResetColor();
                break;
        }
        }
    }
}
