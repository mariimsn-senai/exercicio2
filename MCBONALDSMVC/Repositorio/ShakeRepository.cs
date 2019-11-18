using System.Collections.Generic;
using System.IO;
using MCBONALDSMVC.Models;

namespace MCBONALDSMVC.Repositorio
{
    public class ShakeRepository
    {
        private const string PATH = "Database/Shake.csv";

        public double ObterPrecoDe(string nomeShake)
        {
            var lista = ObterTodos();
            var preco = 0.0;
            foreach(var item in lista)
            {
                if(item.Nome.Equals(nomeShake))
                {
                    preco = item.Preco;
                    break;
                }
            }
            return preco;
        }

        public List<Shake> ObterTodos()
        {
            List<Shake> shakes = new List<Shake>();
            string [] linhas = File.ReadAllLines(PATH);
            foreach (var linha in linhas)
            {
                Shake S = new Shake();
                string [] dados = linha.Split(";");
                S.Nome = dados[0];
                S.Preco = double.Parse(dados[1]);
                shakes.Add(S);
            }
            return shakes;
        }
    }
}