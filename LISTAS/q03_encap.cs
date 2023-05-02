using System;

public class q03_encap {
  class viagem {
    private double distancia;
    private double tempo;

    public void SetDistancia(double d){
      if (d > 0) {
           distancia = d;
        }
    }
  public void SetTempo(double t){
    if (t > 0) {tempo = t;}
  }

  public double GetDistancia(){
    return distancia;
  }
  public double GetTempo(){
    return tempo;
  }

  public double VelocidadeMedia(){
    return distancia / tempo;
  }
  
  public static void Main(String[] args) {
    viagem mv = new viagem();
    mv.SetDistancia(double.Parse(Console.ReadLine()));
    mv.SetTempo(double.Parse(Console.ReadLine()));
    double vm = mv.VelocidadeMedia();
    Console.WriteLine($"{vm}");
    }
  }
}