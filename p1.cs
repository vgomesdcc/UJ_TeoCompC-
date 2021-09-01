using System;

class Program
{
  static void Main(string[] args)
  {
		
    Console.WriteLine("Digite a sua temperatura:");
		
		float temp = float.Parse(Console.ReadLine());

		if(temp>37){
		  Console.WriteLine("O paciente esta com febre");
	  }

    else
      Console.WriteLine("A temperatura do paciente esta normal");
  }
}
