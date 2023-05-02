using System;

public class q01_l2_encaps {
  public static void Main(String[] args) {
    Circulo r = new Circulo();
    
    r.SetRaio(5);
    double area_circulo = r.CalcArea();
    Console.WriteLine(area_circulo);

    //Circulo r_2 = new Circulo();
    
    //r_2 = SetRaio(3);
    double circuferencia = r.CalcCircuferencia(); 
    Console.WriteLine(circuferencia);
  }
  class Circulo {
    private double raio;
    public void SetRaio(double v)
    {
      if (v > 0) raio = v;
    }
    public double GetRaio()
    {
      return raio;
    }
    public double CalcArea()
    {
      return (3.14 * raio * raio);
    }
    public double CalcCircuferencia() {
      return (2 * 3.14 * raio);
    }
  }
}