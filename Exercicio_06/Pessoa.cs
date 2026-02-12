namespace Exercicio_06
{
    public class Pessoa
    {
        public string Nome = "";
        public int Idade;
        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
            return;
        }
        public void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome} tenho {Idade}");
        }
        public void Apresentar(string Sobrenome)
        {
            Console.WriteLine($"Meu nome é {Nome} {Sobrenome} tenho {Idade}");
        }

        public Pessoa(string nome, int idade)
        {
            nome = Nome;
            idade = Idade;
        }
        
    }
}