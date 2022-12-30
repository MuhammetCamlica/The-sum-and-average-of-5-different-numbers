
using System;

namespace bes.sayinintoplami;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("1. SAYIYI GİRİNİZ");
        int sayi1 = int.Parse(Console.ReadLine());

        Console.WriteLine("2. SAYIYI GİRİNİZ");
        int sayi2 = int.Parse(Console.ReadLine());

        Console.WriteLine("3. SAYIYI GİRİNİZ");
        int sayi3 = int.Parse(Console.ReadLine());

        Console.WriteLine("4. SAYIYI GİRİNİZ");
        int sayi4 = int.Parse(Console.ReadLine());

        Console.WriteLine("5. SAYIYI GİRİNİZ");
        int sayi5 = int.Parse(Console.ReadLine());

        var sonuc = sayi1 + sayi2 + sayi3 + sayi4 + sayi5;

        var islem = sonuc / 5;

        Console.WriteLine("SAYILARIN TOPLAMI : " + sonuc );
        Console.WriteLine( "ORTALAMASI : " + islem);


        Console.ReadKey();
    }
    
    
}



