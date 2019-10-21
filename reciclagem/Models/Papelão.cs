using reciclagem.Interfaces;
using System;
namespace reciclagem.Models
{
    public class Papelão : IPapel
    {
        public bool ReciclarPapel()
        {
            System.Console.WriteLine("Lixo AZUL");
            return true;
        }
    }
}