using System;

public class pra5 {
  public static void Main(String[] args) {
    Console.WriteLine("Digite o intervalo de tempo no formato “HH:MM:SS”");
    String[] hs = Console.ReadLine().Split(':');
    /*int h = int.Parse(sep_horas[0]);
    int m = int.Parse(sep_horas[1]);
    int s = int.Parse(sep_horas[2]);
    */
    int conversao = hs.Select(int.Parse).Toarray();
    int conver = (h * 3600) + (m * 60) + s;
    
    long valor_total = conver * 300000;
    Console.WriteLine($"A luz percorreu {valor_total}km nesse intervalo");
  }
}


/*
using System;
using System.Linq;

public class Program {

  public static void Main(string[] args) {
    int a = 2147483647;
    a = a + 1;
    Console.WriteLine(a);
    ulong b = 12345678901234567890;
    b++;
    Console.WriteLine(b);
    double c = 12345678901234567890;
    c++;
    Console.WriteLine($"{c:f2}");
    
    
    Console.WriteLine("Digite o intervalo de tempo no formato HH:MM:SS");
    string[] t = Console.ReadLine().Split(':');
    int h = int.Parse(t[0]);
    int m = int.Parse(t[1]);
    int s = int.Parse(t[2]);
    int[] v = t.Select(int.Parse).ToArray();
    Console.WriteLine(v[0] + v[1] + v[2]);
    long totalSegundos = s + m * 60 + h * 3600;
    long distancia = 300000 * totalSegundos;
    Console.WriteLine($"A luz percorreu {distancia} km nesse intervalo");
  }
}
*/