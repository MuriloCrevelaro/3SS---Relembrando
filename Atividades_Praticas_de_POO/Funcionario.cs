using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividades_Praticas_de_POO
{
    public class Funcionario : Pessoa
    {
        public Funcionario(string nome, int idade): base( nome, idade)
        {
            Nome = nome;
            Idade = idade;
        }
    }
}