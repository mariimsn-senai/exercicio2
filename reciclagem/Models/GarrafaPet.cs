using reciclagem.Interfaces;
using System;

namespace reciclagem.Models
{
    public class GarrafaPet : IPlastico
    {
        public bool ReciclagemPlastico()
        {
            System.Console.WriteLine("Lixo VERMELHO");
            return true;
        }
    }
}