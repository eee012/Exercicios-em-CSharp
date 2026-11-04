using System;
using System.Collections.Generic;
using System.Text;

namespace Explicação_POO_Leve
{
    public abstract class Veiculo
    {
        public int ano { get; set; }
        public string modelo { get; set; }
        public string cor { get; set; }
        public string marca { get; set; }

        public double valor { get; set; }
        public abstract void ExibirDetalhes();
    }
}
