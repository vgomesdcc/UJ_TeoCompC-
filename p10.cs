using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Insira o seu cargo:");
    string cargo = Console.ReadLine();
    string programador = "programador";

    Console.WriteLine ("Insira o seu salario:");
    double salario = double.Parse(Console.ReadLine());

    if(String.Equals(cargo,programador)){
      salario = salario+(salario*0.30);
      Console.WriteLine("Seu novo salario e de: "+salario);
    }

    else{
      salario = salario+(salario*0.10);
       Console.WriteLine("Seu novo salario e de: "+salario);
    }
  }
}
