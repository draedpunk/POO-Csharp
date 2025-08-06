using POO_Csharp.Interfaces;
using POO_Csharp.Models;

ICalculadora calculadora = new Calculadora();
Console.WriteLine("Soma: " + calculadora.Somar(5, 3));
Console.WriteLine("Subtração: " + calculadora.Subtrair(5, 3));
Console.WriteLine("Multiplicação: " + calculadora.Multiplicar(5, 3));
Console.WriteLine("Divisão: " + calculadora.Dividir(5, 10));

// Computador c = new Computador();
// c.Marca = "Dell";
// c.Processador = "Intel Core i7";
// c.Ram = 16;
// c.Apresentar();

// Corrente c = new Corrente();
// c.Creditar(1000.00m);
// c.ExibirSaldo();

// Herança
// Aluno a1 = new Aluno();
// a1.Nome = "Sara Sidle";
// a1.Idade = 28;
// a1.Nota = 9.5;
// a1.Apresentar();

// Professor p1 = new Professor();
// p1.Nome = "Gil Grissom";
// p1.Idade = 45;
// p1.Salario = 5000.00m;
// p1.Apresentar();

// ENCAPSULAMENTO DE CLASSES
// ContaCorrente c1 = new ContaCorrente(12345, 1000.00m);
// c1.Sacar(1200.00m);

// APRESENTAÇÃO INICIAL DA CLASSE PESSOA
// Pessoa p1 = new Pessoa();
// p1.Nome = "Pamela";
// p1.Idade = 25;
// p1.Apresentar();