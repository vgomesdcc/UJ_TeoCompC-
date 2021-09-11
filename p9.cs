using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Insira o tempo em segundos:");
    int s = int.Parse(Console.ReadLine());

    int horas,minutos,segundos, resto;
    
    horas = s/3600;
    resto = s%3600;

    minutos = resto/60;
	  segundos = resto%60;

    Console.WriteLine("Hora(s): "+horas+", Minuto(s): "+minutos+", Segundos: "+segundos);
  }
}
