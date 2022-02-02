public class Veiculo{
	protected String modelo, placa;
	protected int anoFabr;
	protected double valor;
	
	//construtor
	public Veiculo(String pModelo, String pPlaca, int pAnoFabr, double pValor){
		setModelo(pModelo);
		setPlaca(pPlaca);
		setAnoFabr(pAnoFabr);
		setValor(pValor);
	}
	
	//getters e setters
	
	public void setModelo(String modelo){
		this.modelo = modelo;
	}
	
	public String getModelo(){
		return this.modelo;
	}
	
	public void setPlaca(String placa){
		this.placa = placa;
	}
	
	public String getPlaca(){
		return this.placa;
	}
	
	public void setAnoFabr(int anoFabr){
		this.anoFabr = anoFabr;
	}
	
	public int getAnoFabr(){
		return this.anoFabr;
	}
	
	public void setValor(double valor){
		this.valor = valor >= 0 ? valor : 0;
	}
	
	public double getValor(){
		return this.valor;
	}
	
	public void deprecia(float taxa){
		setValor(valor - valor * taxa/100);
	}
	
	public void imprime(){
		System.out.printf("\nVeículo: %s \nPlaca: %7s \nAno: %4d \nValor: R$%.2f \n", modelo, placa, anoFabr, valor);
	}
}