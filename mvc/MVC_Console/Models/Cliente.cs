using System.Collections.Generic;
using System.IO;

namespace MVC_Console.Models
{
    public class Cliente
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Telefone { get; set; }
        public string Endereco { get; set; }
        public string DatadeNascimento { get; set; }
        public string Sexo { get; set; }
        public int CPF { get; set; }

        private const string PATH = "Database/Cliente.csv";

        public Cliente()
        {
            string pasta2 = PATH.Split("/")[0];
            if(!Directory.Exists(pasta2))
            {
                Directory.CreateDirectory(pasta2);
            }
            if(!File.Exists(PATH))
            {
                File.Create(PATH);
            }

        }

        public List<Cliente> LerCliente()
        {

        List<Cliente> clientes = new List<Cliente>();

        string[] linhas = File.ReadAllLines(PATH);

        foreach (var item in linhas)
        {
            
            string[] atributos2 = item.Split(";");

            Cliente cliente = new Cliente();
            cliente.Codigo = int.Parse(atributos2[0]);
            cliente.Nome = atributos2[1];
            cliente.Email = atributos2[2];
            cliente.Telefone = int.Parse(atributos2[3]);
            cliente.Endereco = atributos2[4];
            cliente.DatadeNascimento = atributos2[5];
            cliente.Sexo = atributos2[6];
            cliente.CPF = int.Parse(atributos2[7]);
            clientes.Add(cliente);
        }
            return clientes;

        }
        
        public void InserirClientes (Cliente cliente)
        {
            string[] linhas = {PrepararLinhasCSVCliente(cliente)};
            File.AppendAllLines(PATH, linhas);
        }

        public string PrepararLinhasCSVCliente(Cliente cli)
        {
            return $"{cli.Codigo};{cli.Nome};{cli.Email};{cli.Telefone};{cli.Endereco};{cli.DatadeNascimento};{cli.Sexo};{cli.CPF};";
        }
        
    }
}