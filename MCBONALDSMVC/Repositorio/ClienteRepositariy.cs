using System;
using System.IO;

namespace MCBONALDSMVC.Models.Repositario
{
    public class ClienteRepositariy
    {
        private const string PATH = "Database/Cliente.csv";
        public ClienteRepositariy()
        {
            if (!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }

        }
        public bool Inserir(Cliente cliente)
        {
            var linha = new string[] { PrepararRegistroCSV(cliente)};
            File.AppendAllLines(PATH, linha);
            return true;
        }

        public Cliente ObterPor (string email)
        {
            var linhas = File.ReadAllLines(PATH);
            foreach (var item in linhas)
            {
                if(ExtrairValorDoCampo("email", item).Equals(email))
                {
                    Cliente c = new Cliente();
                    c.Nome = ExtrairValorDoCampo("nome", item);
                    c.Email = ExtrairValorDoCampo("email", item);
                    c.DataNascimento = 
                    DateTime.Parse(ExtrairValorDoCampo("Data_Nascimento", item));
                    c.Endereco = ExtrairValorDoCampo("endereco", item);
                    c.Telefone = ExtrairValorDoCampo("telefone", item);
                    c.Senha = ExtrairValorDoCampo("senha", item);

                    return c;
                }
            }
            
        }

        private string ExtrairValorDoCampo(string nomeCampo, string linha)
        {
            var chave = nomeCampo;
            var indiceChave = linha.IndexOf(chave);

            var indiceTerminal = linha.IndexOf(";", indiceChave);

            var valor = "";

            if(indiceTerminal != -1)
            {

            valor = linha.Substring(indiceChave, indiceTerminal - indiceChave);
            }else{
                valor = linha.Substring(indiceChave);
            }
            System.Console.WriteLine($"Campo {nomeCampo} e valor {valor}");
            return valor.Replace(nomeCampo + "=", "");
        }

        private string PrepararRegistroCSV(Cliente cliente)
        {
            return $"nome={cliente.Nome};email={cliente.Email};senha{cliente.Senha};endereco={cliente.Endereco};telefone={cliente.Telefone};data_nascimento{cliente.DataNascimento}";
        }
    }
}