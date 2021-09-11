using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Insira os numeros:");
    int perfeito1 = int.Parse(Console.ReadLine());
    int perfeito2 = int.Parse(Console.ReadLine());

    int flag1=0;
    int flag2=0;

    for(int i=1; i<perfeito1; i++){
		  if(perfeito1%i==0){
			  flag1+=i;
		  }
	  }

    for(int z=1; z<perfeito2; z++){
		  if(perfeito2%z==0){
		  	flag2+=z;
		  }
	  }

    if(perfeito1==flag1 && perfeito2==flag2){
		 Console.WriteLine("Sao divisores perfeitos\n");
	}
	else
		 Console.WriteLine("Nao sao divisores perfeitos\n");
  }
}
