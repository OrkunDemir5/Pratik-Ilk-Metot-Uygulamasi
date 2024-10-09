using System;

class Program
{
    static void Main()
    {
        // Değer döndürmeyen metodu çağırma
        SarkiSozu();
        // Geriye tam sayı döndüren metodu çağırma (2'ye bölümünden kalan)
        RandomSayiKalan();
        // Parametre Alan ve Geriye Değer döndüren Bir Metotu çağırma (2 sayının çarpımı)
        carpim(5, 6);
        // Parametre Alan ve Geriye Değer döndürmeyen bir Metotu çağırma
        HosGeldin("Orkun", "Demir");

    }

    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    /*Geriye Değer Döndürmeyen Bir void metot.
    Ekrana sevdiğiniz bir şarkı sözünü yazdırsın. */
    static void SarkiSozu()
    {
        Console.WriteLine("Seher vakti ılgıt ılgır eserken\r\nSeher vakti bir güzele vuruldum");
    }

    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    /*Geriye Tamsayı Döndüren Bir metot
    Rastgele bir sayı üretip bu sayının 2'ye bölümünden kalanı geriye döndürsün. */
    static void RandomSayiKalan()
    {
        Random rastgele = new Random();
        int sayi = rastgele.Next();
        Console.WriteLine("Üretilen sayı: " + sayi);
        sayi = sayi % 2;
        Console.WriteLine("Kalan: " + sayi);
    }

    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    /*Parametre Alan ve Geriye Değer Döndüren Bir Metot
    Parametre olarak aldığı iki sayının çarpımını geriye dönsün. */

    // Parametre alan bir metot tanımlama
    static int carpim(int sayi1, int sayi2)
    {
        return sayi1 * sayi2;
        
    }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    /*Parametre Alan ve Geriye Değer Döndürmeyen bir Metot
    Parametre olarak isim ve soyisim bilgilerini alıp " Hoş Geldiniz {isim} {soyisim} " şeklinde ekrana bassın. */

    static void HosGeldin(string isim, string soyisim)
    {
        Console.WriteLine($"Hoş Geldiniz {isim} {soyisim}");
    }

}


