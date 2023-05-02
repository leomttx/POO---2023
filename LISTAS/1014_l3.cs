using System;
 public class lista_03{
   public static void Main(string[] args){
   int x = int.Parse(Console.ReadLine());
   double y = double.Parse(Console.ReadLine());
   double z = x / y;
   Console.WriteLine($"{z:f3} km/l");
   }
 }