using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Csharp.Models
{
    public class Computador
    {
        public string Marca { get; set; }
        public string Processador { get; set; }
        public int Ram { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Computador Marca: {Marca}, Processador: {Processador}, RAM: {Ram}GB");
        }
    }
}