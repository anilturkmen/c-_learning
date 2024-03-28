using System;

public class EmptyClass
{
    public void HesaplamaYap()
    {
        int sayi1 = 10;
        int sayi2 = 20;

        Console.Write("Hesaplamak istediğiniz kare veya dikdörtgenin alanı= " +
                      sayi1 * sayi2);
        Console.Read();
    }

    public static void Main1(string[] args)
    {
        EmptyClass hesap = new EmptyClass();
        hesap.HesaplamaYap();
    }
}


