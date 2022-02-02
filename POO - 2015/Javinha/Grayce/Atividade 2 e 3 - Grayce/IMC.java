import java.util.Scanner;

public class IMC
{
	public static void main(String args[])
	{
		Scanner input = new Scanner ( System.in );
		double peso;
		double altura;
		double imc;
		
		System.out.print("Digite o seu peso: ");
		peso = input.nextDouble(); 
		
		System.out.print("Digite sua altura: ");
		altura = input.nextDouble(); 
		
		altura = altura * altura;
		
		imc = peso / altura;
		
		System.out.printf ("Seu imc eh %.2f\n", imc);
	}
}