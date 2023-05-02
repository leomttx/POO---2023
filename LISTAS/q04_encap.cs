using System;

public class q04_encap {
  class ContaBancaria{
    // ATRIBUTOS ENCAPSULADOS
    private string titular;
    private int conta;
    private double saldo;
    
    //METÓDOS
    public void SetTitular(string t){
      if (t != " ") {titular = t;}
    }
    public void SetConta(int c){
      if (c > 0) {conta = c;}
    }
    public void SetSaldo(double s){
      if (s >= 0) {saldo = s;}
    }

    public string GetTitular(){
      return titular;
    }
    public int GetConta(){
      return conta;
    }
    public double GetSaldo(){
      return saldo;
    }
    public double Deposito(double valord){
      return saldo + valord;
    }
    public double Saque(double valors){
      return saldo - valors;
    }
  }
  
  public static void Main(String[] args) {
    ContaBancaria minhaconta = new ContaBancaria();
    Console.WriteLine("Digite o Nome do titular da Conta:");
    minhaconta.SetTitular(Console.ReadLine());
    Console.WriteLine("Digite o saldo da Conta:");
    double saldu = double.Parse(Console.ReadLine());
    minhaconta.SetSaldo(saldu); // Saldo da conta.
    Console.WriteLine("Digite o número da Conta:");
    minhaconta.SetConta(int.Parse(Console.ReadLine()));

    
    Console.WriteLine("Digite 1 para sacar, 2 para depositar, 3 para ver o saldo ou 0 para sair:");
    int acao = int.Parse(Console.ReadLine());
    do{
      if (acao == 1){
        Console.WriteLine("Digite o Valor do Saque:");
        double valor_saque = double.Parse(Console.ReadLine());
        double saqui = minhaconta.Saque(valor_saque);
        saldu = saldu;
        saldu = saqui;
      }
      if (acao == 2){
        Console.WriteLine("Digite o Valor do Depósito:");
        double valor_depo = double.Parse(Console.ReadLine());
        double depozito = minhaconta.Deposito(valor_depo);
        saldu = saldu;
        saldu = depozito;
      }
      if (acao == 3) {Console.WriteLine($"Seu saldo é: {saldu}");}
      Console.WriteLine("Digite 1 para sacar, 2 para depositar, 3 para ver o saldo ou 0 para sair:");
      acao = int.Parse(Console.ReadLine());
    } while (acao != 0);
    
    /*while(acao != 0); {
      if (acao == 1){
        double valor_saque = double.Parse(Console.ReadLine());
        double saqui = minhaconta.Saque(valor_saque);
      }
      if (acao == 2){
        double valor_depo = double.Parse(Console.ReadLine());
        double depozito = minhaconta.Deposito(valor_depo);
      }
      if (acao == 3) {Console.WriteLine($" Seu saldo é: {saldu}");}
      Console.WriteLine("Digite 1 para sacar, 2 para depositar, 3 para ver o saldo ou 0 para sair:");
      int acao = int.Parse(Console.ReadLine());*/
  }
}