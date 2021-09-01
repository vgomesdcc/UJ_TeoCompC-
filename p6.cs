using System;

class Program
{
  static void Main(string[] args)
  {
		
    Console.WriteLine("Insira o seu peso:");
		float peso = float.Parse(Console.ReadLine());

    Console.WriteLine("Insira a sua altura:");
		float altura = float.Parse(Console.ReadLine());

  float imc = peso/(altura*altura);

		if(imc>30){
		  Console.WriteLine("O usuario esta obeso");
	  }

    else
      Console.WriteLine("O usuario esta abaixo da linha de obesidade");
  }
}
