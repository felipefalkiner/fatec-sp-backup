import java.util.Scanner;

public class ProgCirculo
{
	public static void main(String args[])
	{
                Scanner input = new Scanner ( System.in );
                
                int raio;
                do{
                System.out.printf("Digite um raio: ");
                raio = input.nextInt();
                
                
                if (raio < 0)
                {
                    System.out.printf("Tu é burro, por favor digite um numero positivo, pode até ser 0...\n");
                }
                            else
                {      
		Circulo c = new Circulo();
	
		c.setRaio(raio);
                c.setDiametro();
                c.setArea();
                c.setCircun();
		c.mostraDados();
                }
              }while(raio<0);
	}

}