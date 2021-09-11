using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Insira o custo:");
    double custo = double.Parse(Console.ReadLine());

    double distribuidor = custo*0.28;
    double imposto = custo*0.45;
    double consumidorpaga =  custo+distribuidor+imposto;

    Console.WriteLine("O consumidor paga "+consumidorpaga);
  }
}
