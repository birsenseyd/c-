using System.Collections;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Dynamic;
using System.IO.Enumeration;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Net.Quic;
using System.Numerics;
using System.Reflection;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Security;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Text;
using System.Xml;
using Microsoft.Win32.SafeHandles;

namespace 34343
{
    class değişkenler
    {
        static void Main(StringBuilder[] args)
        {
            
            //değişkenler, tip dönüşümleri, konsol işlemleri 
            //koşullu ifadeler, döngüler
            //KOŞULLU İFADELER
            //if, else if, else
            //switch-case

            /*
            Console.WriteLine("Bir sayi giriniz:");
            int sayi = Convert.ToInt32(Console.Readline());
            
            if (sayi<=50)
            {
                Console.Writeline("Girilen sayi 50'den küçük veya eşit");   
            }
            else if (sayi>50 && sayi<100)
            {
                Console.WriteLine("Sayi 50 ile 100 arasındadır");
            }
            else
            {
                Console.WriteLine("Girilen sayi 100'den büyük");   
            }
            Console.WriteLine("Bir sayi giriniz:");
            int sayi = Convert.ToInt32(Console.Readline());

            if(sayi<=50)
            {
               if (sayi < 0)
                  Console.WriteLine("Sayi negatif");
               else
                  Console.WriteLine("Sayi 50'den küçük ve pozitif");
            }
            else if (sayi>50 && sayi<100)
            {
                Console.WriteLine("Sayi 50 ile 100 arasındadır");
            }      
            else
            {
                Console.WriteLine("Girilen sayi 100'den büyük");
            }


            
            //SWİTCH CASE
            
            Console.WriteLine("Bir sayi giriniz:");
            int sayi = Convert.ToInt32(Console.Readline());

            switch(sayi)
            {
                case 0:
                    Console.WriteLine("0 sayisi girildi");
                    break;
                case 10:
                    Console.WriteLine("10 sayisi girildi");
                    break;
                default:
                    Console.WriteLine("Geçersiz giriş yaptiniz");
                    break;

            }
            *\
            
            /*
            Console.WriteLine("Sayi tahmin oyununa hoş geldiniz!");
            Random rnd = new Random();
            int rastgeleSayi = rnd.Next(101);
            while(true)
            {
                Console.WriteLine("Bir tahmin giriniz:");
                int tahmin = Convert.ToInt32(Console.ReadLine());
                sayac++;

                if (tahmin<rastgeleSayi)
                {
                    Console.WriteLine("Daha büyük bir sayi giriniz:");
                }
                else if (tahmin>rastgeleSayi)
                {
                    Console.WriteLine("Daha küçük bir sayi giriniz:");
                }
                else
                {
                    Console.WriteLine("Tahmininiz doğru! Tebrikler!)");
                    Console.WriteLine(sayac + "{0}. adımda buldunuz!", sayac );
                }
                break;

                Consol.Readkey();
            } 
            */
            
            
            /*
            //Hesap Makinesi
            while (true)
            {
                Console.WriteLine("**Hesap Makinesine Hoş Geldiniz**");
                Console.WriteLine("Birinci sayiyi giriniz:");
                int sayi1 = int.Parse(Console.ReadLine());
                Console.WriteLine("İkinci sayiyi giriniz:");
                int sayi2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Yapmak istediğiniz işlemi giriniz:");
                Console.WriteLine("\tToplama: +");
                Console.WriteLine("\tÇıkarma: -");
                Console.WriteLine("\tÇarpma: *");
                Console.WriteLine("\tBölme: /");
                string secim = Console.ReadLine();
                //switch(Console.ReadLine());
                switch(secim)
                {
                    case "+":
                        Console.WriteLine("İşlemin sonucu: {0}", sayi1 + sayi2);
                        break;
                    case "-":
                        Console.WriteLine("İşlemin sonucu: {0}", sayi1 - sayi2);
                        break;
                    case "*":
                        Console.WriteLine("İşlemin sonucu: {0}", sayi1 * sayi2);
                        break;
                    case "/":
                        Console.WriteLine("İşlemin sonucu {0}", sayi1 / sayi2);
                        break;
                    default:
                Console.Readkey();
                }
            }
            */

            /*
            //DÖNGÜLER
            //for, while, do-while, foreach
            //for
            //for(1.Blok: Değişkene baş.değer.ata. ; 2.Blok: Koşulu; 3.Blok:He dön)
            //0'dan 100e kadar sayıları ekrana yazan döngü
            for (int i = 100; i>=0; i=i-2)
            {
                Console.WriteLine(i);
            } 

            for(int i=0, j=100; j>i; i++, j--)
            {
                Console.WriteLine("i:" + i + "j:" + j);
            }
            */


            
            /*
             *****
             *****
             *****
             *****
             *****
             */

            /*
            for(int i = 0; i<5; i++)
            {
                for(int j=0; j<5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            */

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
            //klavyeden girilen n sayısı için 
            //x= 1/2 + 2/3 + 3/4 + ..... + n/n+1
            //işleminin sonucunu hesaplayan kodu yazınız
            Console.WriteLine("n sayisini giriniz:");
            int nSayisi = Convert.ToInt32(Console.ReadLine());
            float toplam = 0f;
            for(float i = 1f; i<=nSayisi; i++)
            {
                toplam += i / (i + 1);
            }
            Console.WriteLine("İşlemin sonucu:" + toplam);
            */

            /*
            //klavyeden girilen n sayısı için 
            //x= 1/2 + 2/3 + 3/4 + ..... + n-1/n
            //işleminin sonucunu hesaplayan kodu yazınız
            Console.WriteLine("n sayisini giriniz:");
            int nSayisi = Convert.ToInt32(Console.ReadLine());
            float toplam = 0f;
            for (float i = 1f; i<nSayisi; i++)
            {
                toplam += i / (i+1);
            }
            Console.WriteLine("İşlemin sonucu:" + toplam);
            */

            //while (koşul) {kodlar} - koşul sağlanmalı
            //do {kodlar} while(koşul) - kodlar en az bir defa kesin çalışır

            /*
            int sayi = 100;
            while(sayi<100)
            {
                Console.WriteLine(sayi);
                sayi--;       
            }

            int sayi2 = 100;
            do
            {
                Console.WriteLine(sayi2);
                sayi2--;
            } while (sayi2 <100);
            */


           
            
            


            
        }

    }
    
}
