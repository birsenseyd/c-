/*
//recusive metotlar döngülere alternatif olarak kullanılır
//ekrana 100 defa alt alta ahi evran yazan metodu, normal ve recursive olarak yazınız
public static void mesajYaz()
{
    for (int i = 0; i<100; i++ )
    {
        Console.WriteLine("Ahi Evran");
    }
} 
*/

/*
//faktöriyel
//parametre olarak aldığı sayının faktöriyelini hesaplayan ve sonucu geriye döndüren metodu normal ve recursive olarak yazınız.
//5! = 5.4.3.2.1
public static int fact(int sayi)
{
    int sonuc=1;
    for (int i = sayi; i>0; i--)
    {
        sonuc*=i;       
    }
    return sonuc;
}
//rec
public static int factRec(int sayi)
{
    if(sayi>0)
    {
        return sayi * factRec(--sayi);
    }
    else 
        return 1;   
}
//5-> return 5 * factRec(4);
//4-> return 4 * factRec(3);
//3-> return 3 * factRec(2);
//2-> return 2 * factRec(1);
//1-> return 1 * factRec(0);
//0-> return 0 * 
*/

/*
//parametre olarak taban ve üs değerlerini alan ve sonucu geriye döndüren metodu normal ve recursive olarak yazınız.
//2.5 = 32
public  static int usAl(int taban, us)
{
    int sonuc = 1;
    for(int i=0; i<us; i++)
        sonuc *= taban;
    return sonuc;
}
public static int usAlRec(int taban, int us)
{
    if(us>0)
        return taban * usAlRec(taban, --us);
    else 
        return 1;
}

//2,3-> return 2 * usAlRec(2,2)
//2,2-> return 2 * usAlRec(2,1)
//2,1-> return 2 * usAlRec(2,0)
//2,0-> return 1;
*/

/*
//parametre olarak aldığı int dizinin elemanları toplamını hesaplayıp geriye döndğren recursive metodu yazınız
//[2,5,6,1]=14
//for(int i = 0; i<sayilar.length; i++)
//mainde -> toplaRec(dizi,0)
public static int toplaRec(int [] sayilar, int i)
{
    if(i<sayilar.Length)
    {
        return sayilar[i] + toplaRec(sayilar, ++i);
    }
    else
        return 0;
}
//[2,5,3],0-> (10) return 2 + toplaRec(sayilar, 1)
//sayilar, 1-> return 5 + toplaRec(sayilar, 2)
//sayilar, 2-> return 3 + toplaRec(sayilar, 3)
//sayilar, 3-> return 0;
*/

/*
//Sınav sorusu
//parametre olarak aldığı string veriyi tersine çeviren ve geriye döndüren metodu recursive olarak yazınız
//AhiEvran -> narvEihA
//tersRec("AhiEvran",6)
public static string tersRec(string kelime, int i)
{
    if(i>=0)
    {
        return kelime[i] + tersRec(kelime, --i);
    else 
        return "";
    }
}
//Arda,3 -> (adra)return a + ters(Arda, 2);
//Arda,2 -> return d + ters(Arda, 1);
//Arda,1 -> return r + ters(Arda, 0);
//Arda,0 -> return a + ters(Arda, -1);
//Arda, -1 -> return "";
*/

/*
//Sınav sorusu
//yukarıdaki örneği ikinci bir parametre olmadan, sadece tek bir string kullanarak yazınız (i olmadan)
public static string tersRec2(string kelime)
{
    //Arda-> return a + tersRec2(Ard)
    //Ard-> return d + tersRec2(Ar)
    //Ar-> return r + tersRec(A)
    //A-> return A
    if(kelime.Length == 0)
        return "";
    else 
        return kelime[kelime.Length-1] +
        tersRec2(kelime.Substring(0, kelime.Length-1))
        //(adra) a + rec(Ard)
        //d + rec(Ar)
        //r + rec(A)
        //A + rec("")
        //"" 
}
*/

/*
//parametre olarak gönderilen integer bir sayının basamak sayısını geriye döndüren recursive metodu yazınız
//1903 -> 4 
//1903 / 10 = 190
//190 / 10 = 19
//19 / 10 = 1
//1
public static int basamakHesapla(int sayi)
{
    if(sayi>10)
    {
        return 1 + basamakHesapla(sayi/10);
    }
    else
        return 1;
}
//1903 -> (return 4) return 1 + bH(190)
//190 -> return 1 + bH(19)
//19 -> return 1 + bh(1)
*/