using System;
using System.Collections.Generic;

namespace POO_Produtos.Classes
{
    public class Marca
    {
        public int Codigo { get; set; }
        public string NomeMarca { get; set; }
        public DateTime DataCadastro { get; set; }

        public List<Marca> ListadeMarcas { get; set; } = new List<Marca>();

        public Marca Cadastrar(){
            Marca novaMarca = new Marca();
            Console.WriteLine("Digite o código da marca");
            novaMarca.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da marca");
            novaMarca.NomeMarca = Console.ReadLine();

            DataCadastro = DateTime.Now;

            ListadeMarcas.Add(novaMarca);
            return novaMarca;
        }

        public void Listar(){
            Console.ForegroundColor = ConsoleColor.Cyan;

            foreach (var item in ListadeMarcas)
            {
                Console.WriteLine("Código: " + item.Codigo);
                Console.WriteLine("Nome da marca: " + item.NomeMarca);
                Console.WriteLine("Data do cadastro: " + DataCadastro);
            }
            Console.ResetColor();

        }

        public void Deletar(int cod){
            Marca marcaDelete = ListadeMarcas.Find (m => m.Codigo == cod);
            ListadeMarcas.Remove(marcaDelete);
        }
    }
}