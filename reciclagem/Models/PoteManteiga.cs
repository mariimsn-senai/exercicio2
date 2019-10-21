using reciclagem.Interfaces;
using System;
namespace reciclagem.Models
{
    public class PoteManteiga : IPlastico
    {
        public bool ReciclagemPlastico()
        {
            System.Console.WriteLine("Lixo VERMELHO");
            return true;
        }
    }
}