using System;

class Program
{
  static void Main(string[] args)
  {
		
    Console.WriteLine("Digite um numero:");
		float numero = float.Parse(Console.ReadLine());

		if(numero%2==0){
		  Console.WriteLine("O numero e par");
	  }

    else
      Console.WriteLine("o numero e impar");
  }
}
