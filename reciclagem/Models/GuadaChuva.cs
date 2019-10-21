using reciclagem.Interfaces;
using System;

namespace reciclagem.Models
{
    public class GuadaChuva : IDescarteEspecial
    {
        public bool ReciclarDescarteEspecial(){
            System.Console.WriteLine("Lixo CINZA");
            return true;
        }
        
    }
}