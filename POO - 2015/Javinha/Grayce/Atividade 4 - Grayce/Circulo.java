import java.util.Scanner;

public class Circulo {
    
    private double raio;
    private double diametro;
    private double area;
    private double circun;

    public Circulo() {
    }
	
    public Circulo(double r)
    {
        this.setRaio(r);
    }

    
    public void setRaio(double r)
    {
        if (r < 0)
            System.out.println("O raio não pode ser negativo.");
        else
            this.raio = r;
    }
    
    public double getRaio()
    {
        return raio;
    }

    public void setDiametro()
	{
		diametro = raio * 2;
	}
    
	public double getDiametro()
	
	{
		return diametro;
	}

	public void setArea()
	
	{
		area = Math.PI * Math.pow(raio, 2);
	}
	
	public double getArea()
	
	{
		return area;
	}
	
	public void setCircun()
	{
		circun = 2 * Math.PI * raio;
	}
	
	public double getCircun()
	{
		return circun;
	}
	
	public void mostraDados()
	{
		System.out.println("##########################################################");
		System.out.println("O raio do circulo é: " + getRaio() );
		System.out.println("\n Seu diâmetro é: " + getDiametro() );
		System.out.println("\n Sua área é: " + getArea() );
		System.out.println("\n Sua circunfência é: " + getCircun() );
		System.out.println("##########################################################\n \n \n ");
	}

}
