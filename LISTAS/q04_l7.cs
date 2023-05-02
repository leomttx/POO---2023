using System;

public class q04_l7 {
  public static int MMC(int x, int y){
    if (x > y)
    {
      int maior = x;
    }
    else
    {
      int maior = y;
    }
    while (true)
    {
      if (maior % x == 0 && maior % y == 0)
      {
        return maior;
        break;
      }
    }
  }
  public static void Main(String[] args) {
    int x = MMC(2, 4);
    Console.WriteLine(x);
  }
}
