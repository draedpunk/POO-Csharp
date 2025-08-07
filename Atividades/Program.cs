using System;

class Bicicleta
{
    static void Main()
    {
        // Leitura do modelo
        string modelo = Console.ReadLine();

        // Leitura do nível de bateria
        string nivelStr = Console.ReadLine();
        int nivelBateria = int.Parse(nivelStr);

        // Criação do objeto BicicletaInterna
        BicicletaInterna bicicleta = new BicicletaInterna(modelo, nivelBateria);

        // Exibição da mensagem
        Console.WriteLine(bicicleta.ObterMensagem());
    }
}

// Classe interna para representar a bicicleta
class BicicletaInterna
{
    private string modelo;
    private int nivelBateria;

    // TODO: Crie o construtor da classe BicicletaInterna que inicializa os atributos com os valores recebidos.
    public BicicletaInterna(string modelo, int nivelBateria){
      this.modelo = modelo;
      this.nivelBateria = nivelBateria;
    }
    // TODO: Implemente o método que calcula a distância estimada com base no nível da bateria.
    public double CalcularDistancia(int nivelBateria){
      double x = nivelBateria/100.0 * 0.5/0.01;

      return x;
    }

    public string ObterMensagem()
    {
        return $"{modelo}: Distancia estimada = {CalcularDistancia(nivelBateria):F1} km";
    }
}