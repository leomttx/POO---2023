// MAIOR ENTRE TRÊS NÚMEROS.

using System;

public class q1013 {
  public static void Main(String[] args) {
    String[] valores = Console.ReadLine().Split(' ');
    int n1 = int.Parse(valores[0]);
    int n2 = int.Parse(valores[1]);
    int n3 = int.Parse(valores[2]);
    int comparacao1 = ((n1 + n2) + Math.Abs(n1-n2))/2;
    int comparacao2 = ((comparacao1 + n3) + Math.Abs(comparacao1 - n3))/2;


    Console.WriteLine($"{comparacao1} eh o maior");
    }
}