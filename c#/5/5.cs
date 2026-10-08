//metot overloading 
//aynı isimle birden fazla metot yazabilmek
using System.Diagnostics.Contracts;

class program
{
    static void Main(string[] args)
    {
    }
    public static int carp(int sayi1, int sayi2, int sayi3)
{
    return sayi1 * sayi2;
}

    public static int carp(int sayi1, int sayi2, int sayi3=5)
{
    return sayi1 * sayi2 * sayi3;
}

    public static int carp(int sayi1, int sayi2, int sayi3, int sayi4)
{
    return sayi1 * sayi2 * sayi3 * sayi4;
}
    //params kullanımı
    //kaç parametre geleceği belli olmayan durumlarda overloading yerine params kullanılır.
    public int pCarp(params int[] sayilar)
    {
        int carpim = 1;
        foreach (int sayi in sayilar)
        {
            carpim *= sayi;
        }
    return carpim;
    }

    //parametre olarak aldığı değişken miktarda
    //sayıların ardışık olup olmadığını
    //kontrol eden ve geriye true-false
    //döndüren metodu yazınız
    public static bool ardisikMi(params int [] sayilar)
    {
        for (int i = 0; i<sayilar.Length-1; i++)
        {
            if(sayilar[i+1]-sayilar[i]!=1)
                return false;
        }
        return true;
    }
}





