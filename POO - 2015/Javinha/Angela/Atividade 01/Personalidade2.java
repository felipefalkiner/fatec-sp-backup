import java.util.Scanner;

public class Personalidade2
{
	public static void main(String args[])
	{
		Scanner input = new Scanner ( System.in );
		int dia;
		int mes;
		int ano;
		int calc;
		int bkp1;
		int bkp2;
		int bkp3;
		
		
		System.out.print("Digite sua data de nascimento: ");
		dia = input.nextInt(); 
		
		System.out.print("Digite seu mes de nascimento: ");
		mes = input.nextInt(); 
		
		System.out.print("Digite seu ano de nascimento: ");
		ano = input.nextInt(); 
		
		dia = dia * 100;
		dia = dia + mes;
		calc = dia + ano;
		bkp1 = calc / 100;
		bkp2 = calc % 100;
		bkp3 = bkp1 + bkp2;
		bkp3 = bkp3 % 5;
		
		
		     if (bkp3==0)
     {
          System.out.print("Voce eh Timido!");
     }

     if (bkp3==1)
     {
          System.out.print("Voce eh Sonhador!");
     }

     if (bkp3==2)
     {
          System.out.print("Voce eh Paquerador!");
     }

     if (bkp3==3)
     {
          System.out.print("Voce eh Atraente!");
     }

     if (bkp3==4)
     {
          System.out.print("Voce eh Irresistivel!");
     }
		
	}
}