using System;

public class pra2 {
  public static void Main(String[] args) {
    Console.WriteLine("Escreva seu nome completo:");
    String nome = Console.ReadLine();
    String[] pnome= nome.Split(' ');
    Console.WriteLine($"Bem vindo ao C# {pnome[0]}");
  }
}