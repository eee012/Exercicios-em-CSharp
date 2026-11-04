using System;
using System.Collections.Generic;
using System.Text;

namespace Explicação_POO_Leve
{
    public class ContaBancaria
    {
        private double saldo;

        public void Depositar(double valorDepositado)
        {
            saldo += valorDepositado;
        }

        public void Sacar(double valorSaldo)
        {
            if(valorSaldo <= saldo)
            {
                saldo -= valorSaldo;
            }
            else
            {
                Console.WriteLine("Saldo Insuficiente!");
            }
        }
        public void MostrarSaldo()
        {
            Console.WriteLine($"Saldo Atual: R$ {saldo} reais");
        }
    }
}
