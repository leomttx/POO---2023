using System;

public class q1018{
    public static void Main(String[] args) {
        int valor = int.Parse(Console.ReadLine());
        Console.WriteLine($"{valor}");
        int notas_100 = valor / 100;
        int notas_50 = (valor % 100) / 50;
        int notas_20 =  ((valor % 100) %50) / 20;
        int notas_10 =(((valor % 100) % 50) % 20)/10;
        int notas_5 = ((((valor % 100) %50)%20)%10)/5;
        int notas_2 = (((((valor %100)%50)%20)%20)%5)/2;
        int notas_1 = (((((valor %100)%50)%20)%20)%5)%2;

        Console.WriteLine($"{notas_100} nota(s) de R$ 100,00" );
        Console.WriteLine($"{notas_50} nota(s) de R$ 50,00" );
        Console.WriteLine($"{notas_20} nota(s) de R$ 20,00" );
        Console.WriteLine($"{notas_10} nota(s) de R$ 10,00" );
        Console.WriteLine($"{notas_5} nota(s) de R$ 5,00" );
        Console.WriteLine($"{notas_2} nota(s) de R$ 2,00" );
        Console.WriteLine($"{notas_1} nota(s) de R$ 1,00" );
    }
}