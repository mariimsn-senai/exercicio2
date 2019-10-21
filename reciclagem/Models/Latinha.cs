using reciclagem.Interfaces;
using System;
namespace reciclagem.Models
{
    public class Latinha : IMetal
    {
        public bool ReciclarMetal(){
            System.Console.WriteLine("Lixo AMARELO");
            return true;
        }
        
    }
}