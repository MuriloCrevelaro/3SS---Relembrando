using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_07
{
    public class Carro : Veiculo
    {
        public override void Mover()
        {
            Console.WriteLine($"Carro se movendo");
        }
    }
}