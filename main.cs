using System;

class MainClass {
  public static void Main (string[] args) {
    double Base, altura, area;
    
    Console.Write ("Qual o valor da base do triângulo? Digite a resposta a seguir: ");
    Base = double.Parse (Console.ReadLine ());
    
    Console.Write ("Qual o valor da altura do triângulo? Digite a resposta a seguir: ");
    altura = double.Parse (Console.ReadLine ());
    
    area = (Base * altura)/2;
    
    Console.Write ("Hmmm... estou pensando"+"\n");
    Console.Write ("Entendi! A área do seu triângulo é: "+area+"!");
    
    Console.ReadKey ();
  }
}