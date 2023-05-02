using System;

public class q01_l7 {
  public static void Main(String[] args) {
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    Console.WriteLine(Maior(a, b));
  }
  public static double Maior(double x, double y) {
    if(x < y)
    {
      return y;
    }
    else
    {
      return x;
    }
  }
}