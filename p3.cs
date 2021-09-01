using System;

class Program
{
  static void Main(string[] args)
  {
		
    Console.WriteLine("Digite a nota da primeira prova:");
		float prova1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite a nota da segunda prova:");
		float prova2 = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite a nota do trabalho:");
		float trabalho = float.Parse(Console.ReadLine());

		if(((prova1*3)+(prova2*3)+trabalho)/7>=7){
		  Console.WriteLine("Aprovado");
	  }

    else
      Console.WriteLine("Reprovado");

  }
}
