import java.util.Scanner;

public class Temperatura
{
	public static void main(String args[])
	{
		Scanner input = new Scanner ( System.in );
		double celsius;
		double fahr;
		
		System.out.print("Digite a temperatura em Celsius: ");
		celsius = input.nextDouble(); 
		
		celsius = celsius * 9;
		
		celsius = celsius + 160;
		
		fahr = celsius / 5;
		
		System.out.printf ("A conversao eh %.2f\n", fahr);
	}
}