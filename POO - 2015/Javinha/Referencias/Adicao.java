//segundo programa
import java.util.Scanner;

public class Adicao
{
	public static void main(String args[])
	{
		Scanner input = new Scanner ( System.in );
		int num1;
		int num2;
		int soma;
		
		System.out.print("Digite o primeiro numero: ");
		num1 = input.nextInt(); //Le o primeiro numero
		
		System.out.print("Digite o segundo numero: ");
		num2 = input.nextInt(); //Le o segundo numero
		
		soma = num1 + num2;
		
		System.out.printf ("A soma é %d\n", soma);
	}
}