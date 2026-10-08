using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Oyuncu o1 = new Oyuncu();
        Oyuncu o2 = new Oyuncu();
        Oyuncu o3 = new Oyuncu();
        //derleme sonucu ekranda yazan durumlar
        //statik kurucu çalıştı
        //normal kurucu-o1
        //oyuncu sayısı 1

        //normal kurucu-o2
        //oyuncu sayısı 2

        //normal kurucu-o3
        //oyuncu sayısı 3
    }
}

//amacımız bu sınıftan bir nesne tanımlandığı anda oyuncu sayısını arttırmak
//nesne ömrünü tamamladığında oyuncu sayısını azaltmak 
class Oyuncu
{
    public static int Toplam;

    public Oyuncu()
    {
        Console.WriteLine("Normal kurucu metot çalıştı");
        Console.WriteLine("Yeni bir oyuncu oluşturuldu");
        Toplam++;
        Console.WriteLine("Anlık olarak oyundaki oyuncu sayisi: " + Toplam);
    }
    static Oyuncu()
    {
        Console.WriteLine("Statik kurucu metot çalıştı");
        Toplam=0;
    }

    Oyuncu()
    {
        Console.WriteLine("Bir oyuncu elendi");
        Toplam--;
        Console.WriteLine("Anlık olarak oyundaki oyuncu sayisi: " + Toplam);
    }



}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        //Matematik m1 = new Matematik();
        //m1.Topla(12,56,78,43);

        Matematik.Topla(12,56,78,43);
        Console.WriteLine();

    
    }
}


//static kurucu metotlar, bir defaya mahsus olmak üzere, ilk nesne tamamlandığı anda çalışırlar ve bir daha çalışmazlar 
//static bir sınıftan nesne türetilemez
//Matematik.Topla(2,5,7);
static class Matematik
{
    public void topla(params int [] sayilar)
    {
        int toplam = 0;
        foreach(int sayi in sayilar)
        {
            toplam += sayi;
        }
        Console.WriteLine(toplam);
    }

}

class Matematik
{
    public void Carp(params int [] sayilar)
    {
        int carpim = 0;
        foreach(int sayi in sayilar)
        {
            carpim += sayi;
        }
        Console.WriteLine(çarpim);
    }

}



public class HelloWorld
{
    public static void Main(string[] args)
    {
        Dortgen d1 = new Dortgen();
        d1.pbEn = -5;
        Console.WriteLine(d1.pbEn);

        d1.alanHesapla();
        //d1.en = 5;
        //d1.boy = 6;
        //Console.WriteLine(d1.en);

        Dortgen d2 = new Dortgen(4,5);
        d2.alanHesapla();
        d2.cevreHesapla();
    }
}


//Erişim belirleyiciler
//public,private, protected vb. olabilir
//bir sınıfın bileşenlerine nereden erişilebileceğini belirlemeye yarar 
class Dortgen
{
    public int en;
    public int boy;
    private int cevre;
    private int alan;

    //kapsülleme - encapsulation
    public int pbEn
    {
        set
        {
            if(value !< 0)
                en = value;
            else 
            Console.WriteLine("En özelliğine negatif değer atanamaz.");
            en = 1;
        }
        get
        {
            return en;
        }
    }

    public int pbBoy
    {
        set
        {
            if(value<0)
              boy = value;
            else
            {
                Console.WriteLine("Boy özelliğine negatif değer atanamaz");
                boy = 1;
            }
        }
        get
        {
            Console.WriteLine("Gizli boy özelliğinin değeri okunuyor");
            return boy;
        }
    }

    public Dortgen()
    {
        Console.WriteLine("Parametresiz kurucu metot çalıştı");
    }

    public Dortgen(int en, int boy)
    {
        this.en = en;
        this.boy = boy;
    }

    public void alanHesapla()
    {
        alan = en * boy;
        Console.WriteLine(alan);
    }

    public void çevreHesapla()
    {
        cevre = 2 * (en + boy);
        Console.WriteLine(cevre);
    }

}