using System;

class Program
{
  static void Main(string[] args)
  {
		
    Console.WriteLine("Digite o primeiro numero:");
		float numerador = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo numero:");
		float denominador = float.Parse(Console.ReadLine());

		if(numerador%denominador==0){
		  Console.WriteLine("Divisores perfeitos");
	  }

    else
      Console.WriteLine("Nao sao divisores perfeitos");

  }
}
