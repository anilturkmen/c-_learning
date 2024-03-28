using System;
namespace turkcell_proje_1
{
    public class Donusumler
    {
        public static void Main1(string[] args)
        {
            ///*****DÖNÜŞÜMLER*****//

            //INT DÖNÜŞÜMLERİ

            //int sayi;

            //Console.Write("SAYIYI GIRINIZ");

            //sayi = Convert.ToInt16(Console.ReadLine());

            //Console.WriteLine(sayi);

            ////////İki sayının toplanması////////

            //int sayi1, sayi2, toplam;

            //Console.Write("1. sayıyı giriniz: ");
            //sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("İkinci sayıyı giriniz: ");
            //sayi2 = Convert.ToInt32(Console.ReadLine());

            //toplam = sayi1 + sayi2;

            //Console.Write("İki sayının toplamı: " + toplam);

            //Console.Read();

            ////////******ÖDEV*******////////
            //Soru: Klavyeden kısa ve uzun kenarı girilen dikdörtgenin alan
            //ve çevresini hesaplayan kodu yazınız.

            //int ukenar, kkenar;

            //Console.Write("Uzun kenar değerini giriniz: ");
            //ukenar = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Kısa kenar değerini giriniz: ");
            //kkenar = Convert.ToInt32(Console.ReadLine());

            //int cevre, alan;
            //cevre = (ukenar * 2) + (kkenar * 2);
            //alan = ukenar * kkenar;

            //Console.WriteLine("Hesaplamak istediğiniz alan: " + alan);
            //Console.Write("Hesaplamak istedeğiniz çevre:" + cevre);

            //Console.Read();



            ////////******ÖDEV2*******////////
            ///Soru: Klavyeden girilen 2 sayıya aritmetik 4 işlem uygulayan kodu yazın.

            //int s1, s2, toplama, cıkarma, bolme, carpma;

            //Console.Write("Birinici sayıyı giriniz: ");
            //s1= Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("İkinci sayıyı giriniz: ");
            //s2 = Convert.ToInt32(Console.ReadLine());

            //toplama = s1 + s2;
            //cıkarma = s1 - s2;
            //bolme = s1 / s2;
            //carpma = s1 * s2;

            //Console.WriteLine("Toplama işlemini sonucu: " + toplama);
            //Console.WriteLine("Çıkarma işleminin sonucu:" + cıkarma);
            //Console.WriteLine("Bölme İşleminin sonucu:" + bolme);
            //Console.WriteLine("Çarpma İşleminin sonucu:" + carpma);

            //Console.Read();





            ////////******DOUBLE DÖNÜŞÜMLER*******////////
            //-----Klavyeden ondalıklı sayı girişleri için kullanılır-----//

            //double s1, s2, toplam;
            //Console.Write("Birinci Ondalıklı sayıyı giriniz: ");
            //s1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("İkinci Ondalıklı sayıyı giriniz: ");
            //s2 = Convert.ToDouble(Console.ReadLine());

            //toplam = s1 + s2;

            //Console.WriteLine("Toplamları: " + toplam);
            //Console.Read();

            ////////******CHAR DEĞİŞKENİ ve DÖNÜŞÜMLER*******////////
            //-----Tek karakterleri 'h', '+', '%' gibi girişler için kullanılır-----//

            //char deger;
            //deger = '+';
            //Console.WriteLine(deger);
            //Console.Read();

            //char secim;
            //Console.Write("Kahvenizin hangi boyda olmasını istedğinizi seçiniz: S, M ,L : ");
            //secim = Convert.ToChar(Console.ReadLine());
            //Console.Write("Seçtiğiniz boy: " + secim);
            //Console.Read();




            ////////******BYTE DEĞİŞKENİ ve DÖNÜŞÜMLER*******////////
            //-----0-255 sayıları dahil ve o arasındaki değerleri alabilir -----//
            //-----Değer aralığına çıktığı takdirde hata mesajı verir -----//

            //byte s1;
            //Console.Write("Sayınızı giriniz: ");
            //s1 = Convert.ToByte(Console.ReadLine());
            //Console.WriteLine("Sayınız: " + s1);

            //Console.Read();


            //byte s1, s2, carpım;

            //Console.Write("İlk sayınızı giriniz: ");
            //s1 = Convert.ToByte(Console.ReadLine());

            //Console.Write("İkinci Sayınızı Giriniz: ");
            //s2 = Convert.ToByte(Console.ReadLine());

            //carpım = Convert.ToByte(s1*s2);

            //Console.Write("Byte türündeki carpım sonucu: " + carpım);

            //Console.Read();



            ////////******SBYTE DEĞİŞKENİ ve DÖNÜŞÜMLER*******////////
            //-----128, +127 sayıları dahil ve o arasındaki değerleri alabilir -----//
            //-----Değer aralığına çıktığı takdirde hata mesajı verir -----//

            //sbyte s1;
            //Console.Write("Sayınızı Giriniz: ");
            //s1 = Convert.ToSByte(Console.ReadLine());
            //Console.WriteLine("Sayınız: " + s1);
            //Console.Read();

            //sbyte s1, s2, toplam;

            //Console.Write("Birinci Sayınızı Giriniz: ");
            //s1 = Convert.ToSByte(Console.ReadLine());

            //Console.Write("İkinci sayınızı giriniz: ");
            //s2 = Convert.ToSByte(Console.ReadLine());

            //toplam = Convert.ToSByte(s1 + s2);

            //Console.WriteLine("Girmiş olduğunuz sayıların toplamı: " + toplam);
            //Console.Read();

            ////////******FLOAT DEĞİŞKENİ ve DÖNÜŞÜMLER*******////////
            //-----Ondalıklı sayıları geniş yelpazede alır -----//
            //-----Eğer sayı tanımlanırsa kod kısmında sonun 'F' harfi gelir -----//
            //-----Dönüşüm yaparken float.parse kullanılır -----//

            //float s1;

            //s1 = 64.31F;

            //Console.WriteLine("Sayınız:" + s1);
            //Console.Read();



            //float s1, s2, toplam;

            //Console.WriteLine("Birinci sayınızı giriniz: ");
            //s1 = float.Parse(Console.ReadLine());
            //Console.WriteLine("İkinci sayınızı giriniz:");
            //s2 = float.Parse(Console.ReadLine());

            //toplam =(s1 + s2);

            //Console.WriteLine("Sayılarınızın toplamı: " + toplam);
            //Console.Read();



            ////////******MİN ve MAX değerleri öğrenme *******////////
            //-----Sayıların hangi değer aralıklarında bulunduğu gösterir-----//
            //-----Console.WriteLine(int.MaxValue); şeklinde tanımlanır-----//

            //Console.WriteLine("İnt sayı Max Değeri, "+ int.MaxValue);
            //Console.WriteLine("İnt sayı Min Değeri, " +int.MinValue);
            //Console.WriteLine("Byte sayı Max Değeri, "+ byte.MaxValue);
            //Console.WriteLine("Byte sayı Min Değeri, "+byte.MinValue);
            //Console.WriteLine("Sbyte sayı Max Değeri, "+sbyte.MaxValue);
            //Console.WriteLine("Sbyte sayı Min Değeri, "+sbyte.MinValue);
            //Console.WriteLine("Float sayı Max Değeri, "+float.MaxValue);
            //Console.WriteLine("Float sayı Max Değeri, "+float.MinValue);
            //Console.WriteLine("Double sayı Max Değeri, "+Double.MaxValue);
            //Console.WriteLine("Double sayı Max Değeri, "+Double.MinValue);

            //Console.Read();


            ////////******Short kullanımı *******////////
            //-----Sayıları alırken kullanıcdan short.parse olarak alınır-----//
            //-----Dönüşümde (short) veya Toİnt16-----//




            //short s1, s2, toplam;

            //Console.WriteLine("Birinci sayınızı giriniz: ");
            //s1 = short.Parse(Console.ReadLine());

            //Console.WriteLine("İkinci sayınızı giriniz: ");
            //s2 = short.Parse(Console.ReadLine());

            //toplam = (short)(s1 + s2);

            //Console.WriteLine("Sayılarınızın toplamı: " + toplam);
            //Console.Read();




            ////////******Ushort kullanımı *******////////
            //-----0-65535 arasında değerler alabilir------//
            //-----Sayıları alırken kullanıcdan ushort.parse olarak alınır-----//
            //-----Dönüşümde (short) veya Toİnt16-----//

            //ushort s1;

            //s1 = 29347;

            //Console.WriteLine(s1);
            //Console.Read();


            //ushort sayi, sayi1, toplam;
            //sayi = 23;
            //sayi1 = 599;
            //toplam = (ushort)(sayi + sayi1);
            //Console.WriteLine(toplam);
            //Console.Read();

            //ushort s1, s2, toplam;

            //Console.WriteLine("Birinci sayıyı giriniz: ");
            //s1 = ushort.Parse(Console.ReadLine());
            //Console.WriteLine("İkinci sayıyı giriniz: ");
            //s2 = ushort.Parse(Console.ReadLine());

            //toplam = (ushort)(s1 + s2);
            //Console.WriteLine("Seçtiğiniz Sayıların Toplamı: " + toplam);
            //Console.Read();

            ////////******BOOL kullanımı *******////////
            //-----Doğru yada Yanlış ifadeleri belirler------//
            //bool durum;

            //durum = true;

            //Console.WriteLine(durum);

            //Console.Read();

            //bool durum;

            //Console.Write("Geçtimi:");
            //durum = Boolean.Parse(Console.ReadLine());
            //Console.WriteLine(durum);


            //Console.Read();













        }
    }
}

