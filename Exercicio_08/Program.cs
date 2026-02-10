using Atividades_Praticas_de_POO;

int idade;

Pessoa edu = new Pessoa("Eduardo",43);


Console.WriteLine($"Qual o seu nome?");
edu.Nome = Console.ReadLine();
Console.WriteLine($"Qual a sua idade?");
idade = int.Parse(Console.ReadLine());
if (idade > 0)
{
    edu.Idade = idade;
}
else
{
    Console.WriteLine($"Idade inferior a 0 não pode!");
}

edu.ExibirDados();