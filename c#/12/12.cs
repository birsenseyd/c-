using System.ComponentModel;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

using System IO; //dosya üzerinden yapılacak kullanıcı işlemini bu kütüphane yardımıyla yapabiliriz.

namespace _34324
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            if(File.Exists("materyal.txt") == false)
               File.WriteAllText("materyal.txt","");
            if(File.Exists("kisiler.txt") == false)
                File.WriteAllText("kisiler.txt","");
            if(File.Exists("odunc.txt") == false)
                File.WriteAllText("odunc.txt","");
            
            while(true)
            {
                Console.WriteLine("-----Kütüphane Uygulaması-----");
                Console.WriteLine("(1)Yeni Materyal Ekle");
                Console.WriteLine("(2)Yeni üye ekle");
                Console.WriteLine("(3)Yeni ödünç kaydı ekle");
                Console.WriteLine("(4)Mevcut Kayıtlar Listele");
                string secim = Console.ReadLine();

                if(secim == "1")
                   yeniMateryalEkle();
                else if(secim == "2");
                    uyeEkle();
                else if(secim == "3");
                    oduncEkle();
                else if(secim == "4");
                    mevcutkayıtlarlistele();
                else
                    Console.WriteLine("Geçersiz bir giriş yaptınız.");
            }



            /*
            //eğer parametre olarak verilen
            //txt dosyası hali hazırda yoksa
            //onu oluşturur.
            //eğer dosya varolsaydı, o zaman mevcut dosyayı açacaktı.
            
            //aldığı ikinci parametre ise
            //txt içine gömülecek olan string verisidir.
            File.WriteAllText("C://users/mali/deneme.txt", "1.MAYalçınkaya");
            //File.WriteAllText("C://users/mali/deneme.txt", "2.BK"); bu 1.yi silip üstüne 2.yi ekler ve ekranda sadece bu satır gözükür.
            File.AppendAllText("deneme.txt", "\n2.BK"); //\n : alt satıra gitmesi için eklendi. imlecin kaldığı yerden 
            //veri eklemeye devam etmek için appendalltext kullanılmalı.

            string donenVeri = File.ReadAllText("deneme.txt"); 
            string [] donenSatirlar = File.ReadAllLines("out deneme.txt"); 
            //123131|Mehmet Yılmaz|23|Bilg. Müh.|4.sınıf
            //donenVeri[0].split('|');

            Materyal m1 = new Kitap(234, "Beyaz Diş", "Jack London", "Epsilon", "Roman");
            Materyal m2 = new Dergi(234, "Bilim teknik", "helele", "hele", "hel",2021,1);
            File.WriteAllText("materyal.txt", "");
            m1.dosyayaYaz("materyal.txt");
            m2.dosyayaYaz("materyal.txt");

            Kisi k1 = new Ogrenci(3423141214,"BK", "05034984923", 3);
            Kisi k2 = new Ogretmen(132314433332, "YO", "050565060809", "Biyoloji")
            File.WriteAllText("kisiler.txt", "");
            k1.dosyayaYaz("kisiler.txt");
            k2.dosyayaYaz("kisiler.txt");

            Odunc o1 = new Odunc(234, 294902132443, DateTime.Now.AddDays(14)); //adddays(14) : 14 gün ekle dateline o olsun.
            File.WriteAllText("odunc.txt" + "");
            o1.dosyayaYaz("odunc.txt");
            */
        }
        //SQL-
        //JSON,XML
        //txt
    }

        public static void materyalEkle()
        {
            /*
            Materyal m1 = new Kitap(234, "Beyaz Diş", "Jack London", "Epsilon", "Roman");
            Materyal m2 = new Dergi(234, "Bilim teknik", "helele", "hele", "hel",2021,1);
            File.WriteAllText("materyal.txt", "");
            m1.dosyayaYaz("materyal.txt");
            m2.dosyayaYaz("materyal.txt");
            */

            Console.WriteLine("Barkod No giriniz:");
            int BarkodNo = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Kitap adını giriniz:");
            string kitapAdi = Console.ReadLine();
            Console.WriteLine("Yazar adi giriniz:");
            string yazarAdi = Console.ReadLine();
            Console.WriteLine("Yayın evini giriniz:");
            string yayınEvi = Console.ReadLine();
            Console.WriteLine("Girilen materyalin türünü" +
                   "seçiniz (1)Kitap  (2)Dergi");
            string secim = Console.ReadLine();
            if(secim == "1")
            {
                Console.WriteLine("Kitabın türünü giriniz:");
                string tur = Console.ReadLine();
                Kitap k = new Kitap(BarkodNo,kitapAdi,yazarAdi,yayınEvi,tur);
                k.dosyayaYaz("materyal.txt");
                //KİTAP|kitap ismi|kitap yazarı|yayınevi|türü

            }
            else
            {
                Console.WriteLine("Derginin yayın yılını giriniz:");
                int yil = Convert.ToUInt32(Console.ReadLine());
                Console.WriteLine("Derginin sayısını giriniz:");
                int sayi = Convert.ToUInt32(Console.ReadLine());
                Dergi d = new Dergi(BarkodNo, kitapAdi, yazarAdi, yayınEvi, yayınEvi, yil, sayi);
                d.dosyayaYaz("materyal.txt");
                //DERGİ|dergi ismi|dergi yazarı|yayınevi|yılı|sayısı
            }   

            public static void uyeEkle()
            {
                /*
                Kisi k1 = new Ogrenci(3423141214,"BK", "05034984923", 3);
                Kisi k2 = new Ogretmen(132314433332, "YO", "050565060809", "Biyoloji")
                File.WriteAllText("kisiler.txt", "");
                k1.dosyayaYaz("kisiler.txt");
                k2.dosyayaYaz("kisiler.txt");
                */
                
                Console.WriteLine("Tc kimlik no giriniz:");
                int tcKimlik = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ad soyad giriniz:");
                string adSoyad = Console.ReadLine();
                Console.WriteLine("Telefon numarası giriniz:");
                int tel = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Üye türünü seçiniz: (1)Ogrenci (2)Ogretmen");
               
                if(Console.ReadLine() == "1")
                {
                    int ogrNo = Convert.ToInt32(Console.ReadLine());
                    Ogrenci ogr = new Ogrenci(tcKimlik, adSoyad, ogrNo);
                    ogr.dosyayaYaz("kisiler.txt");
                    //ÖĞRENCİ|23423242|öğrenci adi|tel no| ogr no
                }

                else
                {
                    string brans = Console.ReadLine();
                    Ogretmen o = new Ogretmen(tcKimlik,adSoyad,tel,brans);
                    o.dosyayaYaz("kisiler.txt");
                    //OGRETMEN|tc kimlik|adsoyad|tel|brans
                }
            }

            public static void oduncEkle()
            {
                /*
                Odunc o1 = new Odunc(234, 294902132443, DateTime.Now.AddDays(14)); //adddays(14) : 14 gün ekle dateline o olsun.
                File.WriteAllText("odunc.txt" + "");
                o1.dosyayaYaz("odunc.txt");
                */

                Console.WriteLine("Odunc alınan kitabın" +
                                "Barkod Nosunu giriniz:");
                int BarkodNo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Odunc alan kisinin tckimlik no giriniz:");
                int tckimlik = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("odunc alınan kitabın materyal türünü seciniz (1)Kitap (2)Dergi");
                if(Console.ReadLine() == "1")
                {
                    Odunc o = new Odunc(BarkodNo,tckimlik,DateTime.Now, DateTime.Now.AddDays(14));
                    o.dosyayaYaz("odunc.txt");
                }
                else
                {
                    Odunc o = new Odunc(BarkodNo,tckimlik, DateTime.Now,DateTime.Now.AddDays(7));
                    o.dosyayaYaz("odunc.txt");
                }
            }
            
            public static void kayitlariListele()
            {
                Console.WriteLine("Kişi kayıtları listeleniyor...");
                string [] kisiler = File.ReadAllLines("kisiler.txt");
                foreach(string kisi in kisiler)
                {
                    Console.WriteLine(kisi);
                }
                
                Console.WriteLine("----------------------------");
                Console.WriteLine("Materyal kayıtları listeleniyor...");
                string [] materyaller = File.ReadAllLines("materyal.txt");
                foreach(string materyal in materyaller)
                {
                    Console.WriteLine(materyal);
                }

                Console.WriteLine("----------------------------");
                Console.WriteLine("Ödünç kayıtları listeleniyor...");
                string [] oduncler = File.ReadAllLines("odunc.txt");
                foreach(string ödünç in ödünçler)
                {
                    Console.WriteLine(odunc);
                }
            }
        }








    class Materyal
    {
        public int id;
        public string adi;
        public string yazari;
        public string yayınEvi;

        public Materyal(int id, string adi, string yazari, string yayınEvi)
        {
            this.id = id;
            this.adi = adi;
            this.yazari = yazari;
            this.yayınEvi = yayınEvi;
        }
        
        //211|Suç ve Ceza|Dostayevski|İş Bankası Yayınları|.....
        public abstract string formataCevir();

        public void dosyayaYaz(string dosyaAdi)
        {
            File.AppendAllText(dosyaAdi, formataCevir());
        }
    }

    class Kitap : Materyal
    {
        public string tur;
        public Kitap():base() {}
        public Kitap(int id, string adi, string yazari, string yayınEvi, string tur) : base(id, adi, yazari, yayınEvi)
        {
            this.tur = tur;
        }

        public override string formataCevir()
        {
            return "KİTAP|" + id + "|" + adi + "|" +yazari+ "|" + yayınEvi + "|" + "\n";
        }
    }

    class Dergi : Materyal
    {
        public int yili;
        public int sayisi;
        public Dergi() :base() {}

        public Dergi(int id, string adi, string yazari, string yayınEvi, int yili, int sayisi) : base(id, yazari, yayınEvi)
        {
            this.yili = yili;
            this.sayisi = sayisi;
        }

        public override string formataCevir()
        {
            return "DERGİ|" + id + "|" + adi + "|" + yazari + "|" + yayınEvi + "|" + yili + "|" + sayisi + "\n";
        }
    }

    abstract class Kisi
    {
        public int tcKimlik;
        public string adSoyad;
        public int tel;

        public Kisi() : base() {}

        public Kisi(int tcKimlik, string adSoyad, int tel)
        {
            this.tcKimlik = tcKimlik;
            this.adSoyad = adSoyad;
            this.tel = tel;
        }
        
        public abstract string formataCevir();

        public void dosyayaYaz(string dosyaAdi)
        {
            File.AppendAllText(dosyaAdi, formataCevir());
        }
    }

    class Ogrenci : Kisi
    {
        public int sinif;
        public Ogrenci():base() {}
        public Ogrenci(int tcKimlik, string adSoyad, int tel, int sinif) : base(tcKimlik, adSoyad, tel)
        {
            this.sinif = sinif;
        }

        public override string formataCevir()
        {
            return "OGRENCİ|" + tcKimlik + "|" + adSoyad + "|" + sinif + "|" + tel + "|" + "\n";
        }
    }

    class Ogretmen : Kisi
    {
        public string brans;
        public Ogretmen():base() {}
        public Ogretmen(int tcKimlik, string adSoyad, int tel, string brans) : base(tcKimlik, adSoyad, tel)
        {
            this.brans = branş;
        }

         public override string formataCevir()
        {
            return "OGRETMEN|" + tcKimlik + "|" + adSoyad + "|" + brans + "|" + tel + "|" + "\n";
        }
    }

    class Odunc
    {
        public int materyalID;
        public int tcKimlik;
        DateTime baslangicTarihi;
        DateTime bitisTarihi;

        public Odunc() {}

        public Odunc(int materyalID, int tcKimlik, DateTime baslangicTarihi, DateTime bitisTarihi)
        {
            this.materyalID = materyalID;
            this.tcKimlik = tcKimlik;
            this.baslangicTarihi = baslangicTarihi;
            this.bitisTarihi = bitisTarihi;
        }

        public string formataCevir()
        {
            return materyalID + "|" + tcKimlik + "|" + baslangicTarihi + "|" + bitisTarihi + "|" + "\n";
        }
        
        public void dosyayaYaz(string dosyaAdi)
        {
            File.AppendAllText(dosyaAdi, formataCevir());
        }
        
    }


}