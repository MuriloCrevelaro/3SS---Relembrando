using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_05
{
    public class Funcionario : Pessoa
    {
        public float Salario;
        public Funcionario(string nome, int idade): base( nome, idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine($"Salario: {Salario}");
            return;
        }
    }
}