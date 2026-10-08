/*
//0'da 100'e kadar olan çift sayıların toplamını sağlayan program
int n = 0;
int toplam = 0;

while(n <= 100)
{
    if (n % 2 == 0)
    {
        toplam += n; //toplam= toplam + n;
        n++;
    }
    else
    {
        n++;
    }
}
*/

/*
//Klavyeden 0 girilene kadar girilen sayıları toplayan program
string yazi;
int sayi = 0, toplam = 0;

do
{
    Console.Write("Bir sayi giriniz:");
    sayi = Convert.ToInt32(Console.ReadLine());
    toplam += sayi;  //toplam = toplam + sayi;
}
while (sayi != 0);

Console.WriteLine("Toplam sonuc {0} {1} olarak bulundu", sayi, toplam);
*/

/*
//0 girilene kadar olan sayıları toplayan programı while döngüsüyle yaz
int toplam = 0; 
while (true)
{
    Console.Write("Sayi giriniz (çıkış 0): ");
    int sayi = Convert.ToInt32(Console.ReadLine());
    if (sayi == 0)
        break;

    toplam += sayi;
}
Console.WriteLine("Toplam = ", toplam);
*/

/*
//
Console.WriteLine("Sayi giriniz: ");
int sayi = Convert.ToInt32(Console.ReadLine());

if (sayi % 3 == 0 && sayi % 5 == 0)
    Console.WriteLine("Sayı hem 3'e hem de 5'e bölünür. ");
else if (sayi % 3 == 0 || sayi % 5 == 0)
    Console.WriteLine("Sayi 3'e veya 5'e bölünür (ikisine birden değil). ");
else 
    Console.WriteLine("Sayi ne 3'e ne de 5'e bölünür. ");
*/

//Yıldızlarla dik üçgen yapmayı sağlayan kod
/*
*
**
***
****
*****
*/
/*
for(int i = 0; i < 5; i++)
{
    for(int j= 0; j <= i; j++)
    {
        Console.Write("*");
    }
        Console.WriteLine();
}
*/

/*
//Yıldızlarla dik üçgen yapmayı sağlayan kod 2
Console.Write("Kaç satır? ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= i; j++)
        Console.Write("*");
    
    Console.WriteLine();
} 
*/

/*
//Yıldızlarla piramit yapmayı sağlayan kod
for (int i = 0; i < 7; i++)
{
    for (int k = i; k < 7; k++)   //soldaki boşluklar için
    {
        Console.Write(" ");
    }
    for (int x = 0; x <= i; x++)
    {
        Console.Write("*");

        Console.Write(" ");
    }
    Console.WriteLine();
}
*/

/*
//10 elemanlı tek boyutlu dizi tanımlayıp 
//elemanlarını topladıktan sonra ekrana yazdıran kod
using System.Security.Principal;

int [] sayilar = new int[10];
int Sayi = 0, Toplam = 0;
for (int a = 0; a<10; a++)
{
    Console.Write("Sayi Giriniz: ");
    Sayi = Convert.ToInt32(Console.ReadLine());
    sayilar[a] = Sayi;
}

int i = 0; 
while (i < 10)
{
    Console.WriteLine("Dizinin {0}. elemanı = {1}", i, sayilar[i]);
    Toplam = Toplam + sayilar[i];
    i++;
}

Console.WriteLine("Dizinin elemanlarının toplamı = " + Toplam);
*/

/*
//string ile dizi tanımlama ve elemanlarını atama
string[] sehirler = {"Bursa", "İstanbul", "İzmir"};
int[] plakalar = { 35, 16, 34 };

Console.WriteLine("Şehir {0} Plaka {1}", sehirler[0], plakalar[1]);
Console.WriteLine("Şehir {0} Plaka {1}", sehirler[1], plakalar[2]);
Console.WriteLine("Şehir {0} Plaka {1}", sehirler[2], plakalar[0]);
*/

/*
//çok boyutlu dizi (2 boyutlu dizi) uygulaması
//tüm öğrencilerin not ortalamasını hesaplayan ve en yüksek notu bulan
//for döngüsüyle yazdıran C# kodunu yaz. [SINAVDA ÇIKAR DİKKAT!!!]
using System.Globalization;
using System.Reflection;
using System.Runtime.Serialization.Formatters;

int [,] TumSinavNotlari =
{
    {40,75},
    {65,35},
    {55,35},
    {65,85},
    {45,35},
    {15,30},
    {70,90},
    {85,100},
    {25,40},
    {55,60}
};

int toplam = 0; 
int enBüyük = 0;

int satir = TumSinavNotlari.GetLength(0); //öğrenci sayısı
int sutun = TumSinavNotlari.GetLength(1); //sınav sayısı 

for (int i = 0; i < satir; i++)
{
    Console.Write((i+1) + ". öğrenci notları: ");

    for (int j = 0; j < sutun; j++)
    {
    toplam += TumSinavNotlari[i, j];

    if (TumSinavNotlari[i, j] > enBuyuk)
        enBuyuk = TumSinavNotlari[i, j];
    }
}
Console.WriteLine();

double ortalama = (double) toplam / (satir * sutun);

Console.WriteLine("Tüm notların ortalaması: " + ortalama);
Console.WriteLine("En yüksek not: " + enBuyuk);
*/

/*
//Kullanıcıdan girilen iki sayıdan büyük olanı bulan metod
class Program
{
    static void Main(string[] args)
    {
        int sayi1, sayi2;
        Console.WriteLine("Sayıları Girin");
        sayi1 = Convert.ToInt32(Console.ReadLine());
        sayi2 = Convert.ToInt32(Console.ReadLine());
        int Max = EnBuyuk2(sayi1,sayi2);
        Console.WriteLine("En büyük sayi = {0}", Max);
    }
    public static int EnBuyuk2(int a, int b)
    {
        if (a>b)
            return a;
        return b;
    }
}
*/

/*
//dizinin elemanlarını yazdrıan metod
class Program
{
    static void Main(string[] args)
    {
        int[] dizi = {1,2,3,4};
        DiziYaz(dizi);
    }
    static void DiziYaz(int[] gelen_dizi)
    {
      foreach(int i in gelen_dizi)
    }
    Console.WriteLine(i);
}
*/

/*
//dikdörtgenin alanını hesaplayan metod
namespace Method3
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Write("En kısa kenarı girin: ");
           int kk = Convert.ToInt32(Console.ReadLine());
           Console.Write("En uzun kenarı girin: ");
           int uk = Convert.ToInt32(Console.ReadLine());
        
        }


    }
    
}
*/

/*
namespace Class3
{
    class Daire 
    {
        double alan, cevre; 
        public double Alan(float ycap)
        {
            alan = Math.Pow(ycap,2) * 3;
            return alan;
        }

        public double Cevre(float ycap)
        {
            cevre = 2 * 3 * ycap;
            return cevre;
        }
    }

    class Program 
    {
        static void Main(string[] args)
        {
            float yaricap;
            Daire daire = new Daire();
            
            Console.Write("Çemberin Yarıçapını Giriniz:");
            yaricap = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Çemberin Alanı: {0:F2}", daire.Alan(yaricap));
            Console.WriteLine("Çemberin Çevresi: {0:F2}",daire.Cevre(yaricap));

            Console.ReadLine();
        }
    }
}
*/

/*
namespace Class4
{
    public class Tasit
    {
        public String yakit; //taşıtın yakıt tipi
        public int hiz; //taşıtın max hızı
        public String renk; //taşıtın rengi
        public String marka; //taşıtın markası

        //taşıtın bilgilerini ekrana yazdıran kod
        public void tasitİnfo()
        {
            String tasit = "Taşıtın markası" + marka + "rengi: " + renk + "yakıt tipi: " + yakit + "maksimum hızı: " + hiz;

            System.Console.WriteLine(tasit); 
        } 
    }
    class Program 
    {
        static void Main(string[] args)
        {
            //taşıt tipinden otomobil nesnesini oluşturuyoruz
            Tasit otomobil = new Tasit();

            //nesnemize özellik değerlerini giriyoruz
            otomobil.hiz = 220;
            otomobil.yakit = "LPG";
            otomobil.renk = "Sivalı";
            otomobil.marka = "Renault";

            //bilgileri ekrana yazdıracak metodu çağırıyoruz
            otomobil.tasitİnfo();
            Console.ReadKey();

        }
    }
}
*/

/*
class Program
{
    static Random rastgele = new Random();

    static void Main(string[] args)
    {
        int tahmin, sayi = rastgele.Next(100); //rastgele.Next!!!

        while(true)
        {
            Console.Write("Sayi giriniz:");
            tahmin = Convert.ToInt32(Console.ReadLine());

            if(tahmin>sayi)
            {
                Console.WriteLine("Daha küçük bir sayı giriniz:");
            }
            else if(tahmin<sayi)
            {
                Console.WriteLine()
            }
            else
            {
                Console.WriteLine
            }
        }
    }
}
*/

/*
//temel bit hayvan isminde sınıf tasarlanacak 
//her hayvanda bulunan özellikler bu sınıfın içinde bulunacak.(bu ders için sadece ağırlık ve boy parametreleri alınacak.)
//bu sınıfın içinde parametre almayan OzellikGoster() isminde bir metot olacak.
//daha sonra Kedi isminde bir sınıf tasarlanacak
//kedinin türü tanımlanacak
//TurGoster isminde parametre almayan ve değer döndürmeyen bir metot tanımlanacak. (Örnek kod değerleri: Tür: Van, Boy: 10, Ağırlık: 5)
class Program
{
    static void Main(string[] args)
    {
        Kedi kedi1 = new Kedi();
        kedi1.Agirlik = 5; 
        kedi1.Boy = 10;
        kedi1.turu = "Van";

        kedi1.OzellikGoster();
        kedi1.TurGoster();

        Console.ReadKey();
    }
}

class Hayvan
{
    public double Boy;
    public double Agirlik;

    public void OzellikGoster()
    {
        Console.WriteLine("Boy: " + Boy);
        Console.WriteLine("Ağırlık: " + Agirlik);
    }
}

class Kedi : Hayvan
{
    public string turu;
    public void TurGoster()
    {
        Console.WriteLine(turu + "Kedisi");
    }
}
*/

//soru2

//soru3

//soru4












