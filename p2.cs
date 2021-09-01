using System;

class Program
{
  static void Main(string[] args)
  {
		
    Console.WriteLine("Digite o primeiro numero:");
		float num1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo numero:");
		float num2 = float.Parse(Console.ReadLine());

		if(num1==num2){
		  Console.WriteLine("os numeros sao iguais");
	  }

    else if(num1>num2){
       Console.WriteLine(num1);
    }

    else if(num1<num2){
      Console.WriteLine(num2);
    }
    
  }
}
