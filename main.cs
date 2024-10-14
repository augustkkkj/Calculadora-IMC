using System;
					
public class Program
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Digite seu peso(KG): ");
		double peso = Convert.ToDouble(Console.ReadLine());
		
		Console.Write("Digite sua altura (m): ");
		double altura = Convert.ToDouble(Console.ReadLine());
		
		double imc = peso / (altura * altura);
		
		Console.WriteLine("Seu IMC é: " + imc);
		
		if(imc < 18.5)
		{
		    Console.WriteLine("vc esta abaixo do peso.");
		} 
		
		else if(imc >= 18.5 && imc < 24.9)
		{
		    Console.WriteLine("seu peso está normal");
		} 
		
		else
		{
		    Console.WriteLine("vc esta obeso.");
		}
		Console.ReadKey();
	
	}
}