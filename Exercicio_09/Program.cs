// See https://aka.ms/new-console-template for more information
using Calculadora;

float n1;
float n2;
float e;

Console.WriteLine($"Qual o seu primeiro numero");
n1 = float.Parse(Console.ReadLine());
Console.WriteLine($"Qual o seu segundo numero");
n2 = float.Parse(Console.ReadLine());

Console.WriteLine($"Você quer multiplicar(1) ou somar(2)?");
if(e == 1)
{
    Multiplicar();
} else if(e == 2)
{
    Somar();
} else
{
    Console.WriteLine($"Escolha invalida");
    
}


