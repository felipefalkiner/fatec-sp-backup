import java.util.Scanner;

public class MainCaminhao{
	public static void main(String args[]){
	
		Scanner sc = new Scanner(System.in);
		Caminhao c = new Caminhao("IVECO", "ABC1678", 2015, 95400, 3000.5, 3);
		
		//uso de metodos da superclasse
		c.imprime();
		c.deprecia(10);
		
		System.out.println("Caminhão depreciado");
		c.imprime();
	
	}
}