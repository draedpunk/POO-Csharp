using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using POO_Csharp.Interfaces;

namespace POO_Csharp.Models
{
    public class Calculadora : ICalculadora
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }

        public int Subtrair(int a, int b)
        {
            return a - b;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public double Dividir(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Divisão por zero não é permitida.");
            return (double)a / b;
        }
    }

}