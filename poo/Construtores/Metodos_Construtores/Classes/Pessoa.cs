using System;

namespace Metodos_Construtores.Classes
{
    public class Pessoa
    {
        public string nome;
        public string sobrenome;

        public Pessoa(string nome, string sobrenome){
           this.nome = nome;
           this.sobrenome = sobrenome;

           Console.WriteLine($"Bem vindo, {nome} {sobrenome}!");
        }
    }
}