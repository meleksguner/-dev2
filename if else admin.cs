using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Kullanıcı adınızı girin:");
        string kullaniciadi = Console.ReadLine();

        Console.WriteLine("Şifrenizi girin:");
        string sifre = Console.ReadLine();

        if (kullaniciadi == "admin" && sifre == "admin_32453")
            Console.WriteLine("Giriş Başarılı!");

        else
            Console.WriteLine("Giriş Başarısız!");
        
        Console.ReadKey();
    }
}
