using System;

public class pra3 {
  public static void Main(String[] args) {
    Console.WriteLine("Digite sua primeira nota:");
    int pnota = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite sua segunda nota:");
    int snota = int.Parse(Console.ReadLine());

    int media = (pnota * 2) + (snota * 3);
    int mf = media / 5;

    Console.WriteLine($"Sua nota final é: {mf}");
  }
}