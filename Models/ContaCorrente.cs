using System;

class CarroMonitoramento
{
    // TODO: Crie o método estático que verifica se o carro está apto
    public static bool EstaApto(int anoFabricacao, int anoAtual)
    {
        // TODO: Calcule a idade do carro
        int idade = anoAtual - anoFabricacao;

        // TODO: Verifique se o carro tem até 10 anos
        if (idade <= 10)
        {
            return true; // O carro tem até 10 anos
        }
        else
        {
            return false; // O carro tem mais de 10 anos
        }
     }


    static void Main()
    {
        // Lendo os dados de entrada
        string modelo = Console.ReadLine();
        int anoFabricacao = int.Parse(Console.ReadLine());
        int anoAtual = int.Parse(Console.ReadLine());

        //  TODO: Implemente a chamada do método para verificar se o carro está apto
        string resultado = CarroMonitoramento.EstaApto(anoFabricacao, anoAtual)
            ? $"{modelo}: Apto"
            : $"{modelo}: Nao apto";

        // Exibindo o resultado
        Console.WriteLine(resultado);
    }
}




// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace POO_Csharp.Models
// {
//     public class ContaCorrente
//     {
//         public ContaCorrente(int numeroConta, decimal saldoInicial)
//         {
//             NumeroConta = numeroConta;
//             saldo = saldoInicial;
//         }
//         // encapsulamento
//         public int NumeroConta { get; set; }
    
//         private decimal saldo;

//         public void Sacar(decimal valor)
//         {
//             if (saldo >= valor)
//             {
//                 saldo -= valor;
//                 Console.WriteLine($"Saque de {valor:C} realizado. O saldo atual é: {saldo:C}");
//             }
//             else
//             {
//                 Console.WriteLine($"Saque de {valor:C} não realizado. Saldo insuficiente.");
//             }
//         }

//     }
// }