import java.util.Scanner;

public class ContaCorrente {

    private int cnt;
    private double sald;
    private String cc;
    
	Scanner entrada = new Scanner(System.in);
			
	public ContaCorrente (int conta, String ContaCorrente, double saldo)
	{
		do{
			System.out.printf("\nPor favor insira um saldo maior ou igual a Zero: ");
			saldo = entrada.nextDouble();
		}while(saldo<0);
	
                cnt = conta;
                sald = saldo;
                cc = ContaCorrente;
	}
	
	public void deposito(double dep)
	{
		if (sald<0)
			{
			System.out.printf("\nO valor para deposito nao pode ser menor que 0\n");
			}
		else
			{
			sald = sald + dep;
			}
		
	}
	
	
	
	public void verDados()
	{
		System.out.println("##########################################################");
		System.out.println("Conta:   ");
		System.out.println("Titular: ");
		System.out.println("Saldo:   ");
		System.out.println("##########################################################\n \n \n ");
	}

}
