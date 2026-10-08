//STRİNGLER 
//stringler char dizileri gibi davranırlar
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters;
/*
string cumle = "Kırşehir Ahi Evran Üniversitesi";
Console.WriteLine(cumle[4]);

Console.WriteLine(cumle.Length);
var cumle2 = cumle.Clone();

bool cevap = cumle.Contains("ran");
Console.WriteLine(cevap);

string cumle3 = "";
char[] harfler = new char[5];
cumle.CopyTo(0, harfler, 0, 5);

bool cevap2 = cumle.StartsWith("Ahi");
Console.WriteLine(cevap2);

bool cevap3 = cumle.EndsWith("es");
Console.WriteLine(cevap3);

int indis1 = cumle.IndexOf("h");
Console.WriteLine(indis1);

int indis2 = cumle.LastIndexOf("hi Evr");
Console.WriteLine(indis2);

string cumle4 = cumle.Insert(19,"bok ");
Console.WriteLine(cumle4);

string cumle5 = cumle.Remove(9, 4);  //SINAVDA SORMAYA BAYILIYORMUŞ AQQ
Console.WriteLine(cumle5);

string cumle6 = cumle.Replace("Ahi Evran", "Bok ve Kalma "); //REPLACE KULLANMADAN YAZILIR SORUYORMUŞ
Console.WriteLine(cumle6);

string[] kelimeler = cumle.Split(' ');
foreach(string kelime in kelimeler)
    Console.WriteLine(kelime);

string cumle7 = cumle.Substring(9, 8);
Console.WriteLine(cumle7);

string cumle9 = cumle.ToUpper();
Console.WriteLine(cumle9);

string cumle10 = cumle.ToLower();
Console.WriteLine(cumle9);
*/

/*
//klavyeden girilen bir string verinin
//kaç kelimeden oluştuğunu
//ekrana yazılan kodu hazır metotlar kullanmadan yazınız
//kırşehir ahi evran üniversitesi 
//4
Console.WriteLine("String bir veri giriniz:");
string girilenVeri = Console.ReadLine();
int sayac = 0;
for(int i = 0; i<girilenVeri.Length; i++)
{
    if (girilenVeri[i] == ' ')
        sayac++;
}
Console.WriteLine("Toplam kelime sayisi:{0}", ++sayac);
*/

/*
//klavyeden girilen string veri içerisindeki 
//kelimeleri ekrana alt alta yazan kodu yazınız
//split vb hazır metotlar kullanmadan
//kırşehir ahi evran
//kırşehir
//ahi
//evran
Console.WriteLine("String bir veri giriniz:");
string girilenVeri2 = Console.ReadLine();
//harflere tek tek ulaşsam
//boşluk olmayanları write ile yanyana yazsam
//boşluk denk gelince imleci bir alt satıra indirsem olmaz mı?
for(int i = 0; i<girilenVeri2.Length; i++)
{
    if (girilenVeri2[i] != ' ')
        Console.Write(girilenVeri2[i]);
    else 
    Console.WriteLine();
}
*/

/*
//klavyeden girilen stringteki kelimeleri 
//yeni bir diziye, tek tek atan kodu
//split kullanmadan yazınız
//not: yeni dizinin eleman sayısı kelime sayısı kadar 
//olmak zorundadır
//ahi evran üni
//[ahi, evran, üni]
//1.kelimelerin sayısını bul, bu sayede 
//yeni dizinin kaç elemanlı olacağını bileceksin

//2.ayrı oluşturduğun bu dizinin içine kelimeleri 
//ayrı ayrı at
Console.WriteLine("String bir veri giriniz:");
string girilenVeri3 = Console.ReadLine();

int sayac = 0;
for(int i = 0; i<girilenVeri3.Length; i++)
{
    if (girilenVeri3[i] == ' ')
        sayac++;
}

string[] kelimeler = new string[sayac + 1];
//kır ahi evran üniversitesi
//[kır, ahi, evran, ]
int indisNo = 0;
for(int i = 0; i<girilenVeri3.Length; i++)
{
    if(girilenVeri3[i] != ' ')
        kelimeler[indisNo] += girilenVeri3[i];
    else 
        indisNo++;
}
*/

/*
//SINAV SORUSU
//klavyeden girilen bir string veri içerisindeki 
//sessiz harflerin sayısını bulan ve ekrana yazan kodu
//yazınız
//galatasaray
//11
Console.WriteLine("String bir veri giriniz:");
string girilenVeri = Console.ReadLine();
//1.Sesli harfleri bir stringin içine at
//2.Klavyeden girilen verinin harflerini tek tek al
//3.Aldığın karakter sesli stringinde yoksa nedir?
//sessizdir
string sesliler = "eaıioöuü";
int sessizSayac = 0;
string girilenVeriKucuk = girilenVeri.ToLower();
for(int i = 0; i<girilenVeri.Length; i++)
{
    if(!sesliler.Contains(girilenVeriKucuk[i])) //değilse sağlanmasını sağlıyoruz ! ile == false da olur
        sessizSayac++;

}
Console.WriteLine(sessizSayac);
*/

/*
//klavyeden girilen string bir verideki
//küçük harfleri büyük harfe çeviren kodu
//toupper kullanmadan yazınız.
Console.WriteLine("String bir veri giriniz:");
string girilenVeri = Console.ReadLine();
for(int i = 0; i<girilenVeri.Length; i++)
{
    if (girilenVeri[i] >= 97) //ASCII ÖNEMLİ BU NOKTADA KÜÇÜK BÜYÜK HARF AÇISINDAN
        yeniVeri += (char)(girilenVeri[i] - 32);
    else 
        yeniVeri += girilenVeri[i];       
}
Console.WriteLine(yeniVeri);
*/

/*
      //bir string ifade içerisinde yer alan sessiz harflerin sayısını ekrana yazan kodu yazınız
      //kırşehir ahi evran üniversitesi -> 15
      string cumle="Kırşehir Ahi Evran Üniversitesi";
      string sesliHarfler = "aeıioöuü";
      int sayac=0;
      
      for(int i =0; i< cumle.Length; i++)
      {
      	if(!sesliHarfler.Contains(cumle[i].ToString().ToLower()) && cumle[i]!=' ')
        {
        	sayac++;
        
        }
      
      }
      Console.WriteLine("Cumle İçerisindeki Sessiz Harflerin Sayısı:{0}",sayac);
      
      */

  /*
      //bir string ifade içerisindeki küçük harfleri büyük harflere dönüştüren kodu yazınız. ToUpper kullanmayınız.
      //Ahi Evran Universitesi -> AHİ EVRAN UNIVERSITESI
    
    string cumle="Kirsehir Ahi Evran Universitesi";
    string yeniCumle="";
    
    for(int i =0 ; i<cumle.Length; i++)
    {
    	if( cumle[i]>=97 && cumle[i]<=122)
        	 yeniCumle+= (char)(cumle[i]-32);
        
        else
         	yeniCumle+= cumle[i];
    
    
    }
    
    Console.WriteLine(yeniCumle);
    
    */

/*
    //Bir parola kontrol kodu yazmanız istenmektedir
    //1. parola boş bırakılamaz
    //2.parola en az 8 en fazla 15 karakter olmalıdır
    //3.parola içerisinde Türkçe karakter kullanılamaz
    
    //YUKARIDAKİ KONTROLÜ YAPAN VE KULLANICI DOĞRU YAPIDA PAROLAYI GİRENE KADAR TEKRAR PAROLA GİRMESİNİ İSTEYEN KODU YAZINIZ

    string tKarakterler="üÜıİşŞçÇğĞöÖ";
    bool tekrarGir;
    do
    {
    	tekrarGir=false;
    	
        Console.WriteLine("Bir parola giriniz:");
        string parola = Console.ReadLine();
        
        if(parola == "" || parola == null || parola.Length==0 )
        {
        	Console.WriteLine("Parola Boş Bırakılamaz");
            tekrarGir=true;
        }
    	
        else if (parola.Length<8 || parola.Length>15)
        {
        	Console.WriteLine("Parola 8 ile 15 karakter arasında olmalıdır.");
            tekrarGir=true;
        
        }
        else
        {
        	for(int i =0; i<parola.Length; i++)
            {
            	if(tKarakterler.Contains(parola[i]))
                {
                	Console.WriteLine("Parola İçerisinde Türkçe Karakterler Kullanılamaz.");
                    tekrarGir=true;
                    break;
                }
            
            }
        }
    }while(tekrarGir);

    Console.WriteLine("Girilen parola geçerlidir.");
*/

Console.ReadKey();

