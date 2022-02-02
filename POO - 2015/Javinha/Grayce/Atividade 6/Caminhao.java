public class Caminhao extends Veiculo{
	public double capacidade;
	public int numEixos;
	
	public Caminhao(String modelo, String placa, int anoFabr, double valor, double capacidade, int numEixos){
		super(modelo,placa,anoFabr,valor);
		setCapacidade(capacidade);
		setNumEixos(numEixos);
	}
	
	public void setCapacidade(double capacidade){
		this.capacidade = capacidade;
	}
	
	public double getCapacidade(){
		return this.capacidade;
	}
	
	public void setNumEixos(int numEixos){
		this.numEixos = numEixos;
	}
	
	public int getNumEixos(){
		return this.numEixos;
	}
	
	public void imprime(){
		System.out.printf("\nVeículo: %s \nPlaca: %7s \nAno: %4d \nValor: R$%.2f \nCapacidade: %.2f \nNum eixos: %02d \n", modelo, placa, anoFabr, valor, capacidade, numEixos);
	}
}