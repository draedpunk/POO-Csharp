using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Csharp.Models
{
    public class Corrente : Conta
    {
        public override void Creditar(decimal valor)
        {
            saldo += valor;
            Console.WriteLine($"Crédito de {valor:C} realizado. O saldo atual é: {saldo:C}");
        }
    }
}