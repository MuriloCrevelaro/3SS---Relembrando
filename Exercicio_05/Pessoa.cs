namespace Exercicio_05
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

        public Pessoa(string nome, int idade)
        {
            nome = Nome;
            idade = Idade;
        }
        
    }
}