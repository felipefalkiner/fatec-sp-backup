//segundo programa
import java.util.Scanner;

public class LeituraString
{
	public static void main(String args[])
	{
		Scanner input = new Scanner ( System.in );

		String frase;
		
		System.out.print("Digite uma frase: ");
		frase = input.nextLine(); //Le o primeiro numero
		
		System.out.printf ("Frase lida: %s", frase);
	}
}