using System.Security.Cryptography;

namespace _22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Hayvanlar h1 = new Hayvanlar ();
            h1.pbAğirlik = 10;
            h1.pbBoy =  60;
            h1.pbYas = 3;
            h1.ozellikGoster();
            */
            /*
            Kediler kd1 = new Kediler();
            kd1.pbAğirlik = 4;
            kd1.pbBoy = 50;
            kd1.pbYas = 2;
            kd1.pbCinsi = "Tekir";
            kd1.ozellikGoster();
            kd1.cinsGoster();

            Tekirler tk1 = new Tekirler();
            tk1.pbAğirlik = 3;
            tk1.pbBoy = 30;
            tk1.pbYas = 10;
            tk1.pbCinsi = "Orman Tekiri";
            tk1.pbİsim = "Gece";
            tk1.ozellikGoster();
            tk1.cinsGoster();
            tk1.isimGoster();
            */
            
            Kediler kd2 = new Kediler();
            kd2.konus();

            Keçiler kc1 = new Keçiler();
            kc1.konus();

            Tekirler tk3 = new Tekirler();
            tk3.konus();
        }
    }
}

//kalıtım, erişim belirleyici, sanal metotlar, çok biçimlilik
//inheritance
class Hayvanlar
{
    private int yas;
    private int ağırlık;
    private int boy;
    protected int id; //Public: her sınıftan erişilir ancak Private: kendisi hariç hiç kimse erişemez. Protected: mainden ulaşamayız ama o sınıftan ve alt nesilleri ulaşabilir.

    public int pbYas
    {
        set
        {
            yas = value;
        }
        get
        {
            return yas;
        }
    }

    public int pbAğırlık
    {
        set
        {
            ağırlık = value;
        }
        get
        {
            return ağirlik;
        }
    }
    public int pbBoy
    {
        set
        {
            boy = value;
        }
        get
        {
            return boy;
        }
    }

    public Hayvanlar()
    {
        Console.WriteLine("Hayvanlar sınıfının kurucusu çalıştı");
    }

    public Hayvanlar(int agirlik, int boy, int yas)
    {
        Console.WriteLine("Hayvanlar sınfının parametreli kurucusu çalıştı");
        pbAğırlık = agirlik;
        pbBoy = boy;
        pbYas = yas;
    }

    public void ozellikGoster() 
    {
        Console.WriteLine("Yaşı:" + yas);
        Console.WriteLine("Ağırlığı:" + ağirlik);
        Console.WriteLine("Boyu:" + boy);
    }

    public virtual void konus() //alt nesillerde ezilmezse çalışır ama ezilirse alt nesillerdeki gibi çalışır
    {
        Console.WriteLine("Ben hayvanım konuşamam");
    }

    class Kediler : Hayvanlar  //kediler sınıfı hayvanlar kümesinden türetilmiştir.
    {
        private string cinsi;
        public string pbCinsi;
        {
            set {cinsi = value;}
            get {return cinsi;}
        }
        //kedilerin kurucusu
        public Kediler()
        {
            Console.WriteLine("Kediler sınıfının kurucu metodu çalıştı");
        }

        public Kediler(int agirlik, int boy, int yas, string cins) : base(agirlik, boy, yas)//tekrarlı ifade, atadan geleni kısalttırdık
        {
            Console.WriteLine("Kediler sınıfının parametreli kurucusu çalıştı");
            pbCinsi = cins;
        }

        public void cinsGoster()
        {
            Console.WriteLine("Cinsi: " + cinsi);
        }

        public override void konus()
        {
           Console.WriteLine("Miyav");
        }
    }

    class Tekirler : Kediler //kedilerden türüyor
    {
        private string isim
        public string pbİsim
        {
            set {isim = value;}
            get {return isim;} 
        }

        public Tekirler()
        {
            Console.WriteLine("Tekirler sınıfının kurucu metodu çalıştı");
        } 

        public Tekirler(int agirlik, int boy, int yas, string cins, string isim) : base(agirlik, boy, yas, cins) //tekrarlı ifadeler kullanmamak için atadan geleni aldırmayız
        {
            Console.WriteLine("Tekir sınıfının parametreli kurucusu çalıştı");
            pbİsim = isim;   
        }
        public void isimGoster()
        {
            Console.WriteLine("İsmi: " + ismi);
        }

        public override void konus()
        {
            base.konus(); //ekrana miyav yazar.
            Console.WriteLine("Ben bir tekirim");
        }

        
    }
    class Keçiler : Hayvanlar
    {
        
    }

}

