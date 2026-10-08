namespace _08042024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OBS
            string ogr1Ad = "Mehmet";
            string ogr1Soyad = "Yılmaz";
            string ogr1Bolum = "Bilgisayar Müh.";
            int ogr1No = 24234;
            double ogrGNO = 3.14;

            string ogr2Ad = "Merve";
            string ogr2Soyad = "Deniz";
            string ogr2Bolum = "Hemşirelik";
            int ogr2No = 231231;
            double ogr2GNO = 1.80;

            Ogrenci ogr1 = new Ogrenci();
            ogr1.ad = "Mehmet Ali";
            ogr1.soyad = "Yalçınkaya";
            ogr1.bolum = "Bilgisayar Müh";
            ogr1.no = 42432;
            ogr1.gno = 3.00;
            ogr2.özellikYazdir();

            Ogrenci ogr2 = new Ogrenci();
            ogr2.ad = "Buket";
            ogr2.soyad = "Yıldırım";
            ogr2.bolum = "Gastronomi";
            ogr2.no = 23232;
            ogr.gno = 2.50;
            ogr2.ozellikYazdir();

            Ogrenci ogr3 = new Ogrenci("Mustafa", "Yıldırım", "Makine Müh", 234243,3.00);
            ogr3.ozellikYazdir();

            Console.ReadKey();

        }
    }
    //Class-Sınıf
    class Ogrenci
    {
        public string ad;
        public string soyad;
        public string bolum;
        public int no;
        public double gno;

        //kurucu ve yıkıcı metotlar 
        //bir sınıftan nesne tanımlandığı anda
        //çalışmasını istediğim kodlar varsa
        //kurucu metot içerisinde yazılır

        //oluşturulan nesne ömrünü tamamladığı anda
        //çalışmasını istediğim kodlar varsa 
        //kurucu metotlar içerisinde yazılır

        //kurucu ve yıkıcı metotlar sınıf ismiyle aynı olmalıdır
        //kurucu metotlar daha esnek 
        //kurucu ve yıkıcı metotlar geriye değer döndüremez
        //ama aynı zamanda void de değillerdir
        //kurucu ve yıkıcı metotlar ayrıyetten çağrılamazlar
        //otomatik çalışırlar

        public Ogrenci()
        {
            Console.WriteLine("Parametresiz kurucu metot çalıştı");
        }

        public Ogrenci(string ad, string soyad, string bolum, int no, double gno)
        {
            Console.WriteLine("Parametreli kurucu metot çalıştı");
            this.ad = ad;
            this.soyad = soyad;
            this.bolum = bolum;
            this.no = no;
            this.gno = gno;
        }
        public void ozellikYazdir()
        {
            Console.WriteLine("Öğrencinin özellikleri yazdırılıyor...");
            Console.WriteLine("Adı: " + ad);
            Console.WriteLine("Soyadı: " + soyad);
            Console.WriteLine("No: " + no);
            Console.WriteLine("GNO: " + gno);
        }
        
        ~Ogrenci()
        {
            Console.WriteLine("Yıkıcı metot çalıştı");
        }
    }
}