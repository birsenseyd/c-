using System.Globalization;
using System.Text;

namespace 222333
{
    class döngüler
  {
    static void main (StringBuilder[] args)
        {
            /*
            //Döngüler
            //Klavyeden girilen sayıya kadar ki
            //sayıların toplamını ekrana yazdırın 
            //5 girilmiş olsun
            //1'e kadar ki sayıların toplamı:1
            //2'ye kadar ki sayıların toplamı:3
            //....
            //5'e kadar ki sayıların toplamı: 15

            Console.WriteLine("Bir sayı giriniz:");
            int girilenSayi = int.Parse(Console.ReadLine);
    
            for(int i = 1; i<=girilenSayi;i++)
                {
                Console.WriteLine(i+ "sayısına kadar ki sayıların toplamı")
                ("toplamı:" + toplam);
                }
            */
            
            //OPERATÖRLER - DİZİLER
            //+-*/
            //+= *= -= /=
            //++ --
            //-
            //& | ^ 
            int a = 10;
            int b = 2;
            a += b;
            //a=a+b;
            a -= b;
            //a=a-b;
            a *= b;
            //a=a*b;
            a /= b;
            //a/b;
        

            //%
            int c = a % b;
            //yukarıdaki işlem mod alma operatörü
            //kullanmadan hesaplayınız
            int a = 10;
            int b = 3;

            while(a>b)
            {
                a -= b;
            }
            Console.WriteLine("Mod işlemi sonucu:" + a);

            //++ -- 
            //increment
            //decrement
            int c = 10;

            //+ -
            int e = -5;
            Console.WriteLine(+e);

            //& | ^
            int sayi1 = 65; 
            int sayi2 = 19;
            int sayi3 = sayi1 & sayi2;
            int sayi4 = sayi1 | sayi2;

            //DİZİLER-ARRAYS
            string ogr1 = "Ali";
            string ogr2 = "Ayşe";
            string ogr3 = "Mehmet";

            string [] ogrenciler = new string[3];
            ogrenciler[0] = "Ali";
            ogrenciler[1] = "Ayşe";
            ogrenciler[2] = "Mehmet";

            string[] ogrenciler2 = ("Ali", "Ayşe", "Mehmet");
            string[] ogrenciler3 = { new[] {"Ali", "Ayşe", "Mehmet"}};
            string[] ogrenciler4 = new string[3] {"Ali", "Ayşe", "Mehmet"};

            for(int i = 0; i<ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            foreach(string ogr in ogrenciler)
            {
                Console.WriteLine(ogr);
            }

            int[] sayilar = {2, 5, 8, 9, 3, 4, 6};
            Console.WriteLine(sayilar.Sum());
            Console.WriteLine(sayılar.Average());
            Console.WriteLine(sayilar.Min());
            Console.WriteLine(sayilar.Max());
            Array.Sort(sayilar);
            Array.Reverse(sayilar);
            //Array.Exists(sayilar, 9);
            Array.IndexOf(sayilar, 5);
            Array.LastIndexOf(sayilar, 5);

            foreach(int sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }

            /*
            //Verilen dizi için en küçük elemanı
            //bulan kodu min fonksiyonu kullanmadan 
            // while döngüsüyle bulunuz.
            int[] sayilar = {2, 5, 8, 9, 5, 4, 6};
            int enKucuk = sayilar[0]; 
            int i = 1;
            while(i<sayilar.Length)
            { 
              if (sayilar[i] < enKucuk )
                 enKucuk = sayilar[i];
              i++;       
            }
            Console.WriteLine("En küçük sayi:" + enKucuk);

            //verilen dizi içerisinde klavyeden girilen 
            //sayıyı arayan ve bulursa true
            //bulamazsa false değerini 
            //ekrana basan kodu yazınız
            //int[] sayilar = {2, 5, 8, 9, 5, 4, 6};
            Console.WriteLine("Aranan sayiyi giriniz:");
            int arananSayi = int.Parse(Console.ReadLine());
            bool sonuc = false;
            for(int i = 0; j<sayilar.Length; j++)
            {
                if(sayilar[j]==arananSayi)
                {
                    sonuc = true; 
                }
            }
            Console.WriteLine(sonuc);
            */

            /*
            //verilen dizi içerisinde
            //klavyeden girilen sayının 
            //varsa kaçıncı indiste olduğunu 
            //yoksa -1 değerini ekrana yazan kodu
            //indexOf kullanmadan yazınız
            int[] sayilar = {2, 5, 8, 9, 5, 4, 6};
            Console.WriteLine("Aranan sayiyi giriniz:");
            int arananSayi = int.Parse(Console.ReadLine());
            int indisNo = -1;
            for(int i=0; i<sayilar.Length; i++);
            {
                if(sayilar[i]==arananSayi)
                {
                    indisNo = i;
                    break;
                }
            }
            Console.WriteLine(indisNo);
            */

            /*
            //Verilen dizinin elemanlarının 
            //aritmetik ortalamasını
            //avarage ve length kullanmadan 
            //hesaplayıp ekrana yazdırınız
            int[] sayilar = {2, 5, 8, 9, 5, 4, 6};
            int toplam = 0, sayac=0;
            foreach(int sayi in sayilar)
            {
                sayac++;
                toplam += sayi;
            }
            double ortalama = (double)toplam / (double)sayac;
            Console.WriteLine(ortalama);
            */

            /*
            //verilen bir sayı dizisindeki
            //tek sayıları yeni bir diziye 
            //kopyalayan kodu herhangi bir 
            //hazır metot kullanmadan yazını
            //length kullanmak serbest   
            //1. tek sayıları say
            //2. o kadarlık ek dizi oluştur
            //3. tek sayıları o diziye kopyala
            int[] sayilar = {2, 5, 8, 9, 5, 4, 6};
            int kacTane = 0;
            foreach(int sayi in sayilar)
            {
                if(sayi%2==1)
                    kacTane++;
            }
            int [] tekSayilar = new int[kacTane];
            int i = 0;
            foreach(int sayi in sayilar)
            {
                if (sayi%2==1)
                {
                    tekSayilar[i] = sayi;
                    i++;
                }
            }
            */


            //verilen sayı dizisi içerisinde 
            //her bir rakamdan kaçar tane olduğunu 
            //ekrana yazan kodu yazınız
            //0->1 tane
            //1->0 tane
            //..
            //9->2 tane
            int[] sayilar = {2, 5, 2, 9, 5, 4, 6};
            int [] adet = new int[10];
            // 0 1 2 3 4 5 6 7 8 9 
            //{0,0,1,0,0,1,0,0,0,0}
            for (int i = 0; i<sayilar.Length; i++)
            {
                adet[sayilar[i]++];
                //adet[2]++;
                //adet[5]++;
                //...
            }
            








            Console.ReadKey();




        }
    
 

    

  }
}

