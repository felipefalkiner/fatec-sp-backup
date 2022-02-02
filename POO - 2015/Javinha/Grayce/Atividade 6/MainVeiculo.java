import java.util.Scanner;

public class MainVeiculo{
	public static void main(String args[]){
	
		Scanner sc = new Scanner(System.in);
		Veiculo v = new Veiculo("Fiesta", "ABC1678", 2007, 34000);
		v.imprime();
		
		v.deprecia(10);
		System.out.println("Veículo depreciado");
		v.imprime();
	
	}
}