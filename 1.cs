 using System;

namespace 122121
{
    internal class tip
  {
    static void main (string[] args)
    {
        //DEĞİŞKEN TANIMLAMA - TİP DÖNÜŞÜMLERİ
        //-> Tek satırlık yorum
        /*
        * satır1
        * satır2
        * satır3
        * */
        //int, short, long, uint, ushort, ulong, (tam sayı saklayabilen değişkenler)
        //u= unsigned - işaretsiz
        //u olmayanlar + ve - değerleri saklayabilir
        //u olanlar ise sadece + değerleri saklayabilir
        //short -> int -> long 
        //16bit-> 32bit-> 64bit
        //u-> 8bit
        short sh1;
        sh1 = 10;
        short sh2 = 20;
        short sh3, sh4, sh5;
        short sh6, sh7 = 10, sh8;
        int i1 = 67;
        long lo1;
        ushort ush1 = 5;

        //float, double, decimal (ondalık sayıları saklayabilen değişkenler)
        float flt1 = 3.14f;
        double dbl1 = 3.14;
        decimal dcml1 = 3.14m;


        //karakter-char-character
        char ch1 = 'a';
        char ch2 = '2';
        char ch3 = '-';
        //ASCII
        //a->97 b->98
        //A->65 B->66 ...

        //string
        //karakter dizileri
        //karakter katarları 
        string st1 = "Ahi Evran Üniversitesi";
        string st3 = "Kırşehir";
        string st3 = st2 + " " + st1;
        Console.WriteLine(st3[2]); //printf()
        //C#'da stringlere dizi mualemesi yapılabilir, string olmasa da.


        //boolean 
        //true-false
        //if, else if, while, do while
        bool b1 = true;
        bool b1 = false;


        //var-variable (sakladığı değer atanana kadar belli değildir.)
        var v1 = 'a';



        //TİP DÖNÜŞÜMLERİ 
        //int-string 
        //char-int
        //string-float

        //1. Convert Sınıfı
        string st4 = "15";
        int i2 = Convert.ToBoolean(st5);

        string st5 = "true";

        //2.Parse metodu
        string st6 = "15";
        int i3 = int.Parse(st6);

        //3.Örtülü Dönüşüm
        //sayısal değerlerin birbirine dönüşmesi
        //için kullanılır
        float flt2 = 5.45f;
        int i6 = (int)flt2;




        //KONSOL İŞLEMLERİ
        //printf - write,writeline
        Console.Write("Ahi Evran Üniversitesi\n");
        Console.Write("Bilgisayar Mühendisliği");

        Console.WriteLine("Ahi Evran Üniversitesi");
        Console.WriteLine("Bilgisayar Mühendisliği");
        //writeline, write'ın sonuna \n eklenmiş halidir
        //printf("Numarasi: %d, ogrNo);
        int ogrNo = 213433;
        int telNo = 0454355435;

        Console.WriteLine("Numarasi: {0}, Telefonu: {1}", ogrNo, telNo);
        Console.WriteLine("Numarasi: " + ogrNo + "Telefonu: " + telNo);

        //scanf - read, readline, readkey
        //scanf(%d, &ogrNo);
        //read-> konsoldan bir karakter okumaya yarar 
        //geriye char döndürür


        //readline->konsoldan entera basana kadar girilen
        //tüm stringi okumaya yarar 
        //geriye string döndürür
        Console.WriteLine("Adınızı ve soyadınızı giriniz");
        string adSoyad = Console.ReadLine();
        Console.WriteLine("Girilen Ad Soyad:" + adSoyad);

        Console.WriteLine("Cinsiyetinizi giriniz:");
        char cinsiyet = (char)Console.Read();
        Console.WriteLine("Girilen cinsiyet:" + cinsiyet);

        //klavyeden girileb vize ve final notlarına 
        //göre öğrencinin ortalamasını hesaplayan kodu yazınız
        Console.WriteLine("Vize notunu giriniz:");
        float vize = float.Parse(Console.ReadLine());

        Console.WriteLine("Final notunu giriniz:");
        float final = float.Parse(Console.ReadLine());

        float ortalama = (vize * 0.4f) + (final * 0.6f);
        Console.WriteLine("Öğrencinin ortalaması: " + ortalama); 





        Console.ReadKey();



    }


  }


}

