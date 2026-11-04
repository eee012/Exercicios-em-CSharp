using System;
using System.Collections.Generic;
using System.Text;

namespace Explicação_POO_Leve
{
    public class Moto : Veiculo
    {
        public bool temPartidaEletrica {  get; set; }
        
        //pilar POO ??
        override
        public void ExibirDetalhes()
        {
            Console.WriteLine($"{this.modelo}, {this.marca}, {this.ano}, {this.cor}, {this.valor}, {this.temPartidaEletrica}");
        }
    }
}
