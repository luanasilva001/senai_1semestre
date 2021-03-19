using System;

namespace Metodos_Construtores2.Classes
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Estoque { get; set; }

        // public Produto(){
            
        // }

        public Produto(int codigo, string nome, string descricao, int estoque){
            this.Codigo = codigo;
            this.Nome = nome;
            this.Descricao = descricao;
            this.Estoque = estoque;

            Console.WriteLine($"Produto cadastrado!\nCódigo: {Codigo}\nNome: {Nome}\nDescrição: {Descricao}\nQuantidade no estoque: {Estoque}");
        }

        // public Produto(int codigo){
        //     if(codigo >= 0){
        //         Codigo = codigo;
        //         Nome = "Pepsi";
        //         Console.WriteLine($"Produto Cadastrado Código: {Codigo}\nNome: {Nome ?? "Sem Nome"}");
        //     }else{
        //         Console.WriteLine("Codigo invalido");
        //     }
        // }
    }
}