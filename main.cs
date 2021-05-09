using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter model :");
    int model = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine ("Enter price :");
    double price = Convert.ToDouble(Console.ReadLine());

     if(model < 1990){
        Console.WriteLine ("price = " + price * 0.25);
     }else if(model >=1990 && model < 2000){
       Console.WriteLine ("price = " + price * 0.50);
     }else if(model >=2000){
       Console.WriteLine ("price = " + price * 0.75);
     }
  }
}