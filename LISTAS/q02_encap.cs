using System;

public class q_02_encap {
  class Disciplina{
    private string nome;
    private int nota1;
    private int nota2;
    private int nota3;
    private int nota4;
    private int notaFinal;
    
    public void SetNome(string s){
      if (s != " ") { nome = s;}
    }
    public void SetNota1(int n1){
      if (n1 > 0) { nota1 = n1;}
    }
    public void SetNota2(int n2){
      if (n2 > 0) {nota2 = n2;}
    }
    public void SetNota3(int n3){
      if (n3 > 0) {nota3 = n3;}
    }
    public void SetNota4(int n4){
      if (n4 > 0) {nota4 = n4;}
    }
    public void SetNotaFinal(int notaf){
      if (notaf > 0) {notaf = notaFinal;}
    }

    public string GetNome(){
      return nome;
    }
    public int GetNota1(){
      return nota1;
    }
    public int GetNota2(){
      return nota2;
    }
    public int GetNota3(){
      return nota3;
    }
    public int GetNota4(){
      return nota4;
    }
    public int GetNotaFinal(){
      return notaFinal;
    }

    public int CalcMediaParcial(){
      return ((nota1 * 2 + nota2 * 2 + nota3 * 3 + nota4 * 3) / 10);
    }
    public int MediaFinal(){
      return notaFinal;
    }
  }
  
  public static void Main(String[] args) {
    Disciplina n = new Disciplina();
    n.SetNome(Console.ReadLine());
    Disciplina notas = new Disciplina();
    notas.SetNota1(int.Parse(Console.ReadLine()));
    notas.SetNota2(int.Parse(Console.ReadLine()));
    notas.SetNota3(int.Parse(Console.ReadLine()));
    notas.SetNota4(int.Parse(Console.ReadLine()));

    int md = notas.CalcMediaParcial();
    Console.WriteLine($"{md}");
    if (md < 60)
    {
      Disciplina nf = new Disciplina();
      nf.SetNotaFinal(int.Parse(Console.ReadLine()));
      int mdf = nf.MediaFinal();
      int final = mdf + md / 2; // pq não ta saindo a media final normal.
      Console.WriteLine($"{final}");
    }
  }
}