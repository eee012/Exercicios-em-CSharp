using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Text;

namespace Explicação_POO_Leve
{
    public class Carro : Veiculo
    {
        override

        public void ExibirDetalhes()
        {
            Console.WriteLine($"{this.modelo}, {this.marca}, {this.ano}, {this.cor}, {this.valor}. Isso aqui e um carro.");
        }
    }
}
