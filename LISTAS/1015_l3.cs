using System;
using System.Linq;

public class q1015 {
  public static void Main(String[] args) {
    double[] p1 = Console.ReadLine().Split().Select(double.Parse).ToArray();
    double[] p2 = Console.ReadLine().Split().Select(double.Parse).ToArray();
    double distancia = Math.Sqrt(Math.Pow((p2[0] - p1[0]), 2) + Math.Pow((p1[1] - p2[1]), 2));

    Console.WriteLine($"{distancia:0.0000} ");
  }
}