public class Carro extends Veiculo{
	public int numPortas;
	public int anoModelo;
	
	public Carro(String modelo, String placa, int anoFabr, double valor, int anoModelo, int numPortas){
		super(modelo,placa,anoFabr,valor);
		setNumPortas(numPortas);
		setAnoModelo(anoModelo);
	}
	
	public void setNumPortas(int numPortas){
		this.numPortas = numPortas >= 2 ? numPortas : 2;
	}
	
	public int getNumPortas(){
		return this.numPortas;
	}
	
	public void setAnoModelo(int anoModelo){
		this.anoModelo = anoModelo;
	}
	
	public int getAnoModelo(){
		return this.anoModelo;
	}
	
	public void imprime(){
		System.out.printf("\nVeículo: %s \nPlaca: %7s \nAno: %4d \nValor: R$%.2f \nAno Modelo: %4d \nNumero de portas: %02d \n", modelo, placa, anoFabr, valor, anoModelo, numPortas);
	}
}