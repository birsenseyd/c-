using System.Runtime.Serialization;

class Hesap: Uye, IOdemeYap
{
    private string IBAN;
    private double bakiye;

    public string pbIBAN
    {
        set{IBAN = value; }
        get{return IBAN; }
    }

    public double pbBakiye
    {
        set{bakiye = value; }
        get {return bakiye; }
    }
    
    public Hesap(string gAdSoyad, string gIBAN, double gBakiye) : base(gAdSoyad)
    {
        pbIBAN = gIBAN;
        pbBakiye= gBakiye;
    }

    public void ode(double miktar)
    {
        if(pbBakiye >= miktar)
        {
            pbBakiye -= miktar;
            Console.WriteLine("Ödeme başarılı. Ödeme" + "sonrası hesap bakiyesi:" + pbBakiye);
        }
        else
        {
            Console.WriteLine("Ödeme başarısız. ")
        }
    }

}


//İnterface - Arayüz
//Kalıtım -> üst sınıf - alt sınıf
//Hayvanlar -> kediler
//...is a...
//Cat is an Animal
//... can do...
//Cats can walk 
//uçmak
//class kuslar : uçmak
using System.ComponentModel;
using System.Linq.Expressions;

interface IUcus
{
    int maksYukseklik{set; get; }
    void uc();
}

interface IYuzme
{
    int maksDerinlik {set; get; }
    void yuz();
}

interface IKosma
{
    int maksHiz{set; get; }
    void kos();
}

//interface class değildir.
//kurucu metot, yıkıcı metot vb yoktur.
//interfacelerden nesne üretilemez.
//Ikosma k1 = new IKosma() -> diyemem
//interfacei uygulayan her sınıf,
//interface içindeki değişken ve metotları
//içermek zorundadır.
//virtual, abstract
//kalıtım ile türetmede bir sınıf sadece bir tane sınıftan türeyebilir
//ama interface kullanımında, bir sınıf aynı anda birden fazla interfacei implement edebilir.

class Ordekler : IUcus, IYuzme, IKosma
{
    public int maksYükseklik
    {
        set {pvMaksYükseklik = value; }
        get {return pvMaksYükseklik; }
    }
    
    private int pvMaksDerinlik;
    public int maksDerinlik
    {
        set{ pvMaksDerinlik = value; }
        get{return pvMaksDerinlik; }
    }

    private int pvMaksHiz;
    public int maksHiz
    {
        set {pvMaksHiz = value; }
        get {return pvMaksHiz; }
    }

    public void kos()
    {
        Console.WriteLine("Ördek maksimum " + maksHiz + "hizda koşabilirler.");
    }

    public void yuz()
    {
        Console.WriteLine("Ördekler maksimum " + maksDerinlik + "derinlikte dalabilir.");    
    }
    public void uc()
    {
        Console.WriteLine("Ördekler maksimum " + maksYükseklik + "yüksekliğinde uçarlar.");
    }
} 

class Kediler : IKosma
{
    private int pvMaksHiz;
    public int maksHiz
    {
        set{ pvMaksHiz = value; }
        get{ return pvMaksHiz; }
    }
    public string tur
    {
        set { pvTur = value; }
        get { return pvTur;}
    }
    
    public void Kos()
    {
        Console.WriteLine("Kediler maksimum " + maksHiz + "hızda koşarlar.");
    }
    
}

internal class Program
{
    static void Main(string[] args)
    {
        KrediKartı kart1 = new KrediKartı("Mehmet", 32432423, 10000);
        kart1.ode(9800);
        kart1.iade(9800);

        Hesap hesap1 = new Hesap("Mehmet", "TR332432423",50000);
        hesap1.ode(10000);

        //interfaceler class olm. için
        //nesne oluşturulamaz
        //ama interfacelerin referans kullanılabilir
        //polimorfizm yapmak için kullanılabilir.
        
        IOdemeYap o1 = new KrediKartı("Mehmet", 32432423, 10000);
        kart1.ode(9800);
        kart1.iade(9800);
        o1.ode(5000);


        Console.ReadKey();
    }
}

//online bir alışveriş sitesi
//ödeme paneli - backend 
//kredi kartı - havale/eft
//üye -> kredikartı, hesap
//IOdemeYap, IIadeAl
//kredikart:uye; IOdemeYap, IİadeAl
//hesap: üye, IOdemeYap
class Uye
{
    private string adSoyad;
  

    public string pbAdSoyad
    {
        get{ return adSoyad; }
        set{ adSoyad = value; }
    }

    public Uye(string gAdSoyad, int gTelNo)
    {
        pbAdSoyad = gAdSoyad;
        pbTelNo = gTelNo;
    }
} 
interface IOdemeYap
{
    void ode(double miktar);

}

interface IIadeAl
{
    void iade(double miktar);
}

//bir sınıf hem üst sınıftan türeyecek 
//hem de interface uygulayacaksa
//sınıf: ........ stilde önce türediği sınıf adı yazılmak zorundadır.
class KrediKartı : Uye, IOdemeYap, IIadeAl
{
    private int kartNo;
    private double limit;

    public pbKartNo
    {
        get {return kartNo; }
        set {kartNo = value; }
    }

    public double pbLimit
    {
        get {return Limit; }
        set {limit = value; }
    }

    public KrediKartı(string gAdSoyad, int gKartNo, double gLimit) : base(gAdSoyad)
    {
        pbKartNo = gKartNo;
        pbLimit = gLimit;
    }

    public void ode(double miktar)
    {
        if(miktar <= pbLimit)
        {
            pbLimit -= miktar;
            Console.WriteLine("Ödeme başarılı. Hesapta" + pbLimit + "kadar limit kaldı." );
        }
        else
        {
            Console.WriteLine("İşlem başarısız. Yetersiz limit.");
        }
    }

    public void iade(double miktar)
    {
        pbLimit += miktar;
        Console.WriteLine("İade işlemi başarılı. İade" + miktar + "sonrası toplam limitiniz" + pbLimit);
    }
}

 

    