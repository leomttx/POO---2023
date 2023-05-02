using System;

public class q03_l2{
  public static void Intervalo(double x, out int inicio, out int fim) {
  int con = (int) x;
  inicio = con;
  fim = con + 1;
  Console.WriteLine($"[{con} {fim}]");
  }
  
  public static void Main(String[] args){
    int comeco, final;
    double a = double.Parse(Console.ReadLine());
    Intervalo(a, out comeco, out final);
  }
}