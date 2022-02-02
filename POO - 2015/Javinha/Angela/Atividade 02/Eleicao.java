import java.util.Scanner;

public class Eleicao
{
	public static void main(String args[])
	{
		Scanner input = new Scanner ( System.in );
		int dilma;
		int aecio;
		int soninha;
		int chalita;
		int voto;
		
		dilma = 0;
		aecio = 0;
		soninha = 0;
		chalita = 0;
		voto = 0;
		
		
		
		do{
		System.out.printf("\n\t\tEscolha o seu candidato: \n");
		System.out.printf("13 - Dilma\n");
		System.out.printf("45 - Aecio \n");
		System.out.printf("43 - Soninha \n");
		System.out.printf("15 - Chalita \n\n");
		
		System.out.printf("Voto: ");
		voto = input.nextInt();
		
		switch(voto)
		{
			case 13: System.out.printf("\nVoto confirmado para Dilma!\n"); dilma += 1; break;
			case 45: System.out.printf("\nVoto confirmado para Aecio!\n"); aecio += 1; break;
			case 43: System.out.printf("\nVoto confirmado para Soninha!\n"); soninha += 1; break;
			case 15: System.out.printf("\nVoto confirmado para Chalita!\n"); chalita += 1; break;
			case 0: System.out.printf("\n\tVotacao Encerreda, computando votos...\n\n"); break;
			default: System.out.printf("\nNao existe nenhum candidato com esse numero...\n"); break;
		}
		
		}while(voto!=0);
		
	System.out.printf("Dilma: %d \n", dilma);
	System.out.printf("Aecio: %d \n", aecio);
	System.out.printf("Soninha: %d \n", soninha);
	System.out.printf("Chalita: %d \n\n", chalita);
		
	if( dilma > aecio && dilma > soninha && dilma > chalita )
    {
        System.out.printf("\nVencedor: Dilma!\n"); 
    }
    else if( aecio > dilma && aecio > soninha && aecio > chalita )
    {
        System.out.printf("\nVencedor: Aecio!\n"); 
    }
    else if( soninha > dilma && soninha > aecio && soninha > chalita )
    {
        System.out.printf("\nVencedor: Soninha!\n"); 
    }
    else if( chalita > dilma && chalita > aecio && chalita > soninha )
    {
        System.out.printf("\nVencedor: Chalita!\n"); 
    }  
    else
    {
        System.out.printf("\n HOUVE UM EMPATE!!! \n");
    }
		
	}
}