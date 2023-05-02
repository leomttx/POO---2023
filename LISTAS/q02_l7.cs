using System;
using System.Linq;

public class q2_l7 {
  public static void Ordenar(ref int x, ref int y, ref int z) { // 
    if (x > y && y > z)
    {
      Console.WriteLine($"{z} {y} {x}");
    }
    if (y > x && x > z)
    {
      Console.WriteLine($"{z} {x} {y}");
    }
    if (z > y && y > x)
    {
      Console.WriteLine($"{x} {y} {z}");
    }
    if (x > y && y < z)
    {
      Console.WriteLine($"{y} {z} {x}");
    }
    // mudar os valores de cada variáveis com os ifs para ordenelás; 
  }
  public static void Main(String[] args) {
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
    Ordenar(ref a, ref b, ref c);
  }
}