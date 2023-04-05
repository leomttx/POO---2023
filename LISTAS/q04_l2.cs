using System;

public class pra4 {
  public static void Main(String[] args) {
    Console.WriteLine("Digite a altura e base do retângulo:");
    int altura = int.Parse(Console.ReadLine());
    int basi = int.Parse(Console.ReadLine());

    int area = basi * altura;
    int perimetro = 2*(basi + altura);
    double diagonal = Math.Sqrt(Math.Pow(basi, 2) + Math.Pow(altura, 2));

    Console.WriteLine($"Área: {area: f2} Perímetro: {perimetro: 0.00} Diagonal: {diagonal: 0.00}");
  }
}