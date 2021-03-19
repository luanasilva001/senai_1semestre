using System;
using System.Collections.Generic;
namespace Objeto_Argumento.Classes
{
    public class Carrinho
    {
        public float ValorTotal { get; set; }
        List<Produto> carrinho = new List<Produto>(); 

        public void AdicionarProduto(Produto _produto){
            carrinho.Add(_produto);
        }

        public void MostrarProduto(){
            if(carrinho != null){
                foreach (var item in carrinho)
                {
                    Console.WriteLine($"Código {item.Codigo}, Nome: {item.Nome}, Preço: {item.Preco}");
                }
                MostrarTotal();
            }
        }

        public void RemoverProduto(Produto _produto){
            carrinho.Remove(_produto);
        }

        public void MostrarTotal(){
            ValorTotal = 0;
            if(carrinho != null){
                foreach (var item in carrinho)
                {
                    ValorTotal += item.Preco;
                }
                Console.WriteLine($"O total do carrinho é: R${ValorTotal}\n");
            }else{
                Console.WriteLine("Seu carrinho ainda não tem nenhum produto!");
            }
        }

        public void AlterarItem(int _codigo, Produto _novoProduto){
            carrinho.Find(x => x.Codigo == _codigo).Nome = _novoProduto.Nome;
            carrinho.Find(x => x.Codigo == _codigo).Preco = _novoProduto.Preco;
        }
    }
}