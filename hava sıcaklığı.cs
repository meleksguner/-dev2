using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Hava Sıcaklığını Giriniz!");
        double sayi = Convert.ToInt32(Console.ReadLine());

        if (sayi > 10 && sayi < 20)
        {

            Console.WriteLine("Normal Sıcaklık!!");
            Console.WriteLine("GÜNEŞ KREMİNİZİ SÜRMEYİ UNUTMAYIN!!");
        }

        else if (sayi > 20 && sayi < 30)
        {
            Console.WriteLine("Sıcaklık yüksek!!");
            Console.WriteLine("GÜNEŞ KREMİNİZİ SÜRMEYİ UNUTMAYIN!!");

        }

        else if (sayi > 30 && sayi < 40)
        {
            Console.WriteLine("Sıcaklık Çok Yüksek!!");
            Console.WriteLine("GÜNEŞ KREMİNİZİ SÜRMEYİ UNUTMAYIN!!");

        }

        else
        {
            Console.WriteLine("Hava 40 dereceden yüksek EVDEN ÇIKMAYIN!!");
        }

        Console.ReadKey();

    }
}