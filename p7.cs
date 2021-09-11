using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Insira seu Salario:");
    double salario = double.Parse(Console.ReadLine());

    if(salario<=1903.98){
       Console.WriteLine("Seu salario liquido e R$"+salario+", voce esta insento do imposto\n");
    }

    else if(salario>=1903.99 && salario <=2826.65){
      salario = salario-(salario*0.075);
      Console.WriteLine("Seu salario liquido e R$"+salario+", voce foi tributado em 7.5%\n");
    }

    else if(salario>=2826.66 && salario <=3751.05){
      salario = salario-(salario*0.15);
      Console.WriteLine("Seu salario liquido e R$"+salario+", voce foi tributado em 15%\n");
    }

    else if(salario>=3751.06 && salario <=4664.68){
      salario = salario-(salario*0.225);
      Console.WriteLine("Seu salario liquido e R$"+salario+", voce foi tributado em 22.5%\n");
    }

    else if(salario>=4664.69){
      salario = salario-(salario*0.275);
      Console.WriteLine("Seu salario liquido e R$"+salario+", voce foi tributado em 27.5%\n");
    }

  }
}
