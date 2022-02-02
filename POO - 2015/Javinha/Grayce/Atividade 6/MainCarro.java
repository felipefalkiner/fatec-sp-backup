import java.util.Scanner;

public class MainCarro{
	public static void main(String args[]){
	
		Scanner sc = new Scanner(System.in);
		//Veiculo v = new Veiculo("Fiesta", "ABC1678", 2007, 34000);
		Carro c = new Carro("Fiesta", "ABC1678", 2007, 34000, 2008, 4);
		
		//uso de metodos da superclasse
		c.imprime();
		c.deprecia(10);
		
		System.out.println("Carro depreciado");
		c.imprime();
	
	}
}