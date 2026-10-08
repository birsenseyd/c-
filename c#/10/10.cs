/*
internal class Program
{
    static void Main(string[] args)
    {
        //Calisan c = new Stajyer();
        Calisan[] calisanlar = new Calisan[3];
        //int [] sayilar = new int[3];
        calisanlar[0] = new Mudur("Gb", 345, 100000, 20000); //tırnak içindekiler isim he
        calisanlar[1] = new Muhendis("Ök", 123, 120000, 20);
        calisanlar[2] = Stajyer("Bk", 2323, 32000);

        foreach (Calisan c in calisanlar)
        {
            c.bilgileriYazdir();
        }

        Console.ReadLine();
    }

}


//Class
//kapsülleme
//kalıtım
//Kurucu virtual
//Çok biçimlilik - Polimorfizm - Polymorphizm:
//kalıtım yapıda ata sınıfa ait referans değişkene 
//alt sınıfa ait nesnelerin atanması
//kullanımı birden fazla nesnelerin ekranda gösterimli gibi durumlarda..
//Hayvanlar h1 = new Kediler();
//Hayvanlar h2 = new Köpekler();

//Calisan -> Müdür, Mühendis, Stajyer
class Calisan
{
    private string isim;
    private string sicilNo;
    private double maas;

    public string pbİsim
    {
        set { isim = value; }
        get { return isim; }
    }

    public int pbSicilNo
    {
        set { sicilNo = value; }
        get { return sicilNo; }
    }

    public double pbMaas
    {
        set { maas = value; }
        get { return maas; }
    }

    public Calisan(string gİsim, int gSicil, double gMaas)
    {
        pbİsim = gİsim;
        pbSicilNo = gSicil;
        pbMaas = gMaas;
    }

    public virtual double maasHesapla()
    {
        return maas;
    }

    public void bilgileriYazdir()
    {
        Console.WriteLine(pbSicilNo + "Sicil numaralı" + pbİsim + "isimli kişinin maaşı: " + maasHesapla());
    }
}

class Mudur : Calisan
{
    private int prim;
    public int pbPrim
    {
        set { prim = value; }
        get { return prim; }
    }
    public Mudur(string gİsim, int gSicil, double gMaas, int gPrim) : base(gİsim, gSicil, gMaas)
    {
        pbPrim = gPrim;
    }

    public override double maasHesapla() //metodu eziyoruz (override kullanarak)
    {
        return pbMaas + pbPrim;
    }

}
class Mühendis : Calisan
{
    private int projeSayisi;
    public int pbProjeSayisi
    {
        set { projeSayisi = value; }
        get { return projeSayisi; }
    }

    public Muhendis(string gİ, int gS, double gM, int gPS) : base(gİ, gS, gM)
    {
        pbProjeSayisi = gPS;
    }

    public override double maasHesapla() //metodu ezdi yine :)
    {
        return pbMaas + (projeSayisi * 5000);
    }

    class Stajyer : Calisan
    {
        public Stajyer(string gİ, int gS, double gM) : base (gİ, gS, gM)
        { }

        public override double maasHesapla()
        {
            return pbMaas * 0.1;
        }
    }
}
    */

    internal class Program
    {       
        static void Main(string[] args)
        {
            //Sekil -> Daire, Dikdörtgen
            //Sekil s1 = new Sekil(10, 20); -> HATALI KULLANIM //abstract sınıftan nesne türetilemez ama polymorphizm yapabilmek için tanımlayabilirim (?) ayrıca nesne tanımlanamayan static metodu vardır.
            //Sekil s1 = new Daire(0, 0, 5); -> DOĞRU KULLANIM
            //int [] dizi = {1,2,3,4};
            Sekil [] sekiller = 
                 { new Daire(0,0,5), new Dikdörtgen(0,0,5,10) };
            
           foreach (Sekil s in sekiller)
            {
                s.bilgileriYazdir();
            }



            Console.ReadLine();
        }
    }

    //Abstract 
    //Abstract metotlar alt sınıflar tarafından ezilmek zorundadır.
    //virtual metotları ezmek zorunda değildir
    //ezmezsem atadan olduğu gibi miras alırdı 
    //ama abstract metotlar öyle değil, onlar ezilmek zorunda.

    //Abstract metodu içeren sınıflar da abstract olmak zorundadır.
    //Abstract class Calisan 
    //Sekil -> Daire, Dikdörtgen
    abstract class Sekil //metotların yazılışı abstract olduğu gibi classlarda abstract olmalıdır.
    {
        private double cevre;
        private double alan;

        public double pbCevre
        {
            set { cevre = value; }
            get { return cevre; }
        }

        public double pbAlan
        {
            set { alan = value; }
            get { return alan; }
        }

        public Sekil(double gAlan = 0, double gCevre = 0)
        {
            pbAlan = gAlan;
            pbCevre = gCevre;
        }

        public abstract double alanHesapla(); //abstract metotların ezmesi vs zorunlu olduğundan gövdesi bulunmaz, gövde dediğimiz süslü parantezdeki kodlamalardır.
        public abstract double cevreHesapla(); //class abstract olmayınca hata verdi classlarda abstract olmalı
        
        public void bilgileriYazdir()
        {
            Console.WriteLine("Alan: " + alanHesapla());
            Console.WriteLine("Cevre: " + cevreHesapla());
        }
    }

    class Daire : Sekil
    {
        private double yariCap;

        public double pbYariCap
        {
            set { yariCap = value; }
            get { return yariCap; }
        }

        public Daire(double gA, double gC, double gY) : base(gA, gC)
        {
            pbYariCap = gY;
        }

        public override double alanHesapla()
        {
            return 3.14 * pbYariCap * pbYariCap; 
             //return 3.14 * Math.Pow(pbYariCap, 2); 
        }

        public override double cevreHesapla()
        {
            return 2 * 3.14 * pbYariCap;
        }
    }

    class Dikdörtgen : Sekil //sekilden türediğini göstermek için : kullanılıyor
    {
        private int kisaKenar;
        private int uzunKenar;

        public int pbKisaKenar
        {
            set { kisaKenar = value; }
            get { return kisaKenar; }
        }

        public int pbUzunKenar
        {
            set { uzunKenar = value; }
            get { return uzunKenar; }
        }

        public Dikdörtgen(double gA, double gC, int kK, int uK) : base(gA, gC)
        {
            pbKisaKenar = kK;
            pbUzunKenar = uK;
        }

        public override double alanHesapla()
        {
            return pbUzunKenar * pbKisaKenar;
        }

        public override double cevreHesapla()
        {
            return 2 * (pbKisaKenar + pbUzunKenar);
        }

    }


