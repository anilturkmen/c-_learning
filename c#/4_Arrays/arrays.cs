using System;
namespace turkcell_proje_1
{
	public class diziler
	{
        public static void Main(string[] args)
        {
            //int a = 0, b = 0, c = 0;
            //a = 4;
            //b += a;
            //c = ++a - b--;
            //Console.WriteLine(" {0},{1},{2}" , b,c,a);
            //Console.Read();

            ////////******DİZİLER*******////////
            ///-----AYNI TÜRDEN VERİLERİN BİR ARAYA GELEREK OLUŞTURDUĞU KÜME-----///
            ///---ARRAY OLARAK TANIMLANIR---///


            //string[] sehirler = { "adana", "bursa", "ankara", "istanbul" };

            //Console.WriteLine("2.İndex değer: " + sehirler[1]);
            //Console.Read();

            //string[] renkler = { "Siyah", "Kırmızı", "Beyaz", "Yeşil", "Turuncu" };

            //Console.WriteLine("3. index değer: " + renkler[3]);
            //Console.Read();



            ////////******DÖNGÜYLE DİZİLER*******////////

            //int[] sayilar = { 10, 20, 30, 40, 50, 60, 70 };
            //Console.WriteLine();
            ////Console.WriteLine(sayilar[2]);
            //for (int i = 0; i <= 6; i += 1)
            //{
            //    Console.WriteLine(i + ".değer, " + sayilar[i]);
            //}


            //Console.Read();


            //int[] sayilar = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            //Console.WriteLine();
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] % 20 == 0 | sayilar[i] % 30 == 0)
            //    {

            //        Console.WriteLine(i + ".değer, " + sayilar[i]);


            //    }
            //}
            //Console.Read();



            ////////******Lenght komutu kullanımı DİZİLER*******////////


            //Console.WriteLine("*****Lenght komutunun kullanımı*****");
            //Console.WriteLine();

            //string[] kisiler = {"Sena", "Anıl","Ahmet","Ayşe","Mehmet", "Ömer",
            //"Nigar","Buğra"};
            //for (int i = 0; i < kisiler.Length; i++)
            //{
            //    Console.WriteLine(i + ").değer, " + kisiler[i]);
            //}
            //Console.WriteLine();
            //Console.WriteLine(kisiler.Length + " Elamanlı grup");
            //Console.Read();



            //Console.WriteLine("******Dizilerde Toplama işlemi*****");
            //Console.WriteLine();
            //int[] sayilar = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            //int toplam = 0;
            //for(int i =0; i<sayilar.Length; i++)
            //{
            //    toplam += sayilar[i];
            //}
            //Console.WriteLine("Tüm sayıların toplamı= " + toplam);

            //Console.Read();




            ////////******DİZİ METOTLARI*******////////
            ///-----SORT: Dizideki elemanları küçükten büyüğe doğru sıralar. -----///
            ///---REVERSE: Diziyi TERSTEN yazdırır.---///
            ///-----İndex of: Aranan değerin index sırasını döndürür. -----///
            ///---Max: Dizideki en büyük elemanı verir.---///
            ///---Min: Dizideki en küçük elemanı verir.---///
            ///---Lenght: dizinin boyutunu verir.---///


            ////////****** SORT METODU*******////////

            //int[] sayilar = { 20, 14, 12, 35, 13 };
            //Array.Sort(sayilar);
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //    Console.WriteLine();

            //}
            //Console.WriteLine(sayilar[4]);

            //Console.Read();




            ////////****** REVERSE METODU*******////////



            //string[] sehirler = { "adana", "antep", "zonguldak", "malatya", "elazığ", "bursa" };

            //Array.Reverse(sehirler);

            //for(int i =0; i < sehirler.Length; i++)
            //{
            //    Console.WriteLine(sehirler[i]);

            //}
            //Console.Read();





            ////////****** İndex OF METODU*******////////


            //string[] kisiler = { "Sena", "Anıl", "Ali", "Eylül", "Melek" };
            //int sira;
            //Array.Sort(kisiler);
            //sira = Array.IndexOf(kisiler,"Sena");
            //Console.WriteLine(sira);
            //Console.Read();


            ////////****** MAX ve MİN METODU*******////////

            //int[] sayilar = { 76, 43, 12, 56, 34 };

            //Console.WriteLine("En Küçük Değer= " + sayilar.Min());
            //Console.WriteLine("En Büyük Değer= " + sayilar.Max());
            //Console.Read();


            ////////****** Foreach Döngüsü ******////////
            ///***** Genelde dizilerde kullanılır****///

            //string[] sehirler = { "ankara", "adana", "bursa", "izmir" };

            //foreach (string s in sehirler)
            //{
            //    Console.WriteLine(s);
            //}

            //Console.Read();





            ////////****** Foreach Aritmetik İşlemler ******////////
            ///

            //int[] sayilar = { 23, 55, 32, 16, 89, 70 };
            //int toplam = 0;
            //foreach (int x in sayilar)
            //{
            //    toplam += x;

            //}
            //Console.WriteLine(toplam);
            //Console.Read();



            //int[] sayilar = { 34, 22, 11, 67, 89, 50 };
            //Array.Sort(sayilar);

            //foreach (int s in sayilar)
            //{
            //    if (s % 2 == 0)
            //    {
            //        Console.WriteLine(s);
            //        Array.Sort(sayilar);

            //    }


            //}
            //Console.Read();



            /////******Diziye kullanıcıdan alınan eleman girişi******/////

            //string[] sehiler = new string[5];
            //for (int s = 0; s < 5; s++)
            //{
            //    Console.Write("Sehir giriniz: ");
            //    sehiler[s] = Console.ReadLine();

            //}
            //for(int j = 0; j < 5; j++)
            //{
            //    Console.WriteLine(sehiler[j]);

            //}
            //Console.Read();

            //int b, a, c;
            //double disk, birkok,ikikok, tekkok;
            //Console.WriteLine("b giriniz: ");
            //b = int.Parse(Console.ReadLine());

            //Console.WriteLine("a değerini giriniz: ");
            //a = int.Parse(Console.ReadLine());

            //Console.WriteLine("c değerini giriniz: ");
            //c = int.Parse(Console.ReadLine());

            //disk = (b * b) - (4 * a * c);
            //if (disk > 0)
            //{
            //    Console.WriteLine("İki kökümüz vardır: ");
            //    birkok = -b - (Math.Sqrt(disk) / (2 * a));
            //    Console.WriteLine("Birinci kök: " + birkok);

            //    ikikok = -b + (Math.Sqrt(disk) / 2 * a);
            //    Console.WriteLine("İkinci Kök: " + ikikok);
            //}
            //if (disk == 0)
            //{

            //    tekkok = -b / 2 * a;
            //    Console.WriteLine("Delta sıfıra eşittir Tek kök vardır. " + tekkok);
            //}
            //else
            //{
            //    Console.WriteLine("Reel Kök yoktur: ");
            //}
            //int sayi = 1, toplam = 0;
            //while (sayi <= 456)
            //{
            //    toplam = toplam + sayi;
            //    sayi = sayi + 13;



            //}
            //Console.WriteLine("TOPLAMI " + toplam);

            //Console.Read();
            
            int a=6, b=3;
            int sonuc = 1;
            for (int i = 1; i<= b; i++)
            {
                sonuc = sonuc*a;

            }
            Console.WriteLine(sonuc);
            Console.ReadLine();




        }



    }
}

