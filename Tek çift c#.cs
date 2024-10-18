using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bir sayı giriniz: ");
        int a = int.Parse(Console.ReadLine());

        if (a % 2 == 0)
            Console.WriteLine("Sayı çift sayıdır.");

        else
            Console.WriteLine("Sayı tek sayıdır. ");

        Console.ReadKey();
    }
  
}

