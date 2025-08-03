using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Csharp.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            saldo = saldoInicial;
        }
        // encapsulamento
        public int NumeroConta { get; set; }
    
        private decimal saldo;

        public void Sacar(decimal valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
                Console.WriteLine($"Saque de {valor:C} realizado. O saldo atual é: {saldo:C}");
            }
            else
            {
                Console.WriteLine($"Saque de {valor:C} não realizado. Saldo insuficiente.");
            }
        }

    }
}