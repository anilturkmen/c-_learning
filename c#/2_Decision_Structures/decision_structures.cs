using System;
namespace turkcell_proje_1
{
    public class karar_yapilari
    {


        public static void Main3(string[] args )
        {
            ////////******IF ve ELSE KULLANIMI*******////////


            //string sehir;

            //Console.WriteLine("Sehir adı giriniz:");
            //sehir = Console.ReadLine();
            //if (sehir == "Antep")
            //{


            //    Console.WriteLine("Antep");


            //}

            //else
            //{
            //    Console.WriteLine("Yanlış şehir girdiniz");

            //}

            //Console.Read();


            //string deger;
            //Console.WriteLine("Değer giriniz"); 
            //deger = Console.ReadLine();
            //if (deger == "beş")
            //{
            //    Console.WriteLine("Değeriniz: BEŞ");
            //}
            //else
            //{
            //    Console.WriteLine("Değeriniz yanlış");
            //}
            //Console.Read();



            ////////******Öğrenci Sınav-Not Uygulaması*******////////


            //int sayi;

            //Console.Write("Notunuzu Giriniz: ");
            //sayi = int.Parse(Console.ReadLine());
            //if (sayi <= 44 | sayi>=0)
            //{
            //    Console.WriteLine("Maalesef kaldınız");

            //}
            //if (sayi == 45)
            //{
            //    Console.WriteLine("Sınırla geçtiniz: ");

            //}

            //if (46 <= sayi |sayi <= 100)
            //{
            //    Console.WriteLine("Tebrikler! Geçtiniz");
            //}

            //else
            //{
            //    Console.WriteLine("Lütfen 0-100 arasında geçerli bir değer giriniz");
            //}

            //Console.Read();

            /////********UYGYLAMA********/////
            //int s1, s2, ort;

            //Console.WriteLine("1.Sınav Notunuzu Giriniz: ");
            //s1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("2.Sınav notunuzu giriniz: ");
            //s2 = int.Parse(Console.ReadLine());

            //ort = (s1 + s2) / 2;

            //if ( 0<=ort & ort < 45 )
            //{
            //    Console.WriteLine("Maalesef kaldınız :(");

            //}
            //if (ort == 45)
            //{
            //    Console.WriteLine("Sınırla geçtiniz");

            //}
            //if(45<ort & ort<=100)
            //{
            //    Console.WriteLine("Geçtiniz");
            //}
            //else
            //{
            //    Console.Write("Lütfen değer aralığında sayı giriniz");
            //}

            //Console.Read();



            ////////******BİLGİ YARIŞMASI UYGULAMASI*******////////



            //Console.WriteLine("Turkcell Bilgi Yarışmasına HOŞGELDİNİZ!");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------");
            //Console.WriteLine();

            //int soru;
            //string cevap;
            //soru = 1;

            //if (soru == 1)
            //{
            //    Console.WriteLine("Aşağıdakilerden hangisi Türkiyenin Başkentidir?");
            //    Console.WriteLine("A) Istanbul");
            //    Console.WriteLine("B) Ankara");
            //    Console.WriteLine("C) İzmir");
            //    Console.WriteLine("D) Gaziantep");
            //    Console.WriteLine("Cevabınızı yazınız:");
            //    cevap =Convert.ToString(Console.ReadLine());
            //    if(cevap == "B"||cevap== "b")
            //    {
            //        soru = soru + 1;
            //        Console.WriteLine("Cevabınız Doğru! Toplam Puanınız 25");


            //    }
            //    else
            //    {
            //        Console.WriteLine("Hatalı Cevap verdiniz");
            //    }


            //}

            //if (soru == 2)
            //{
            //    Console.WriteLine("Cumhuriyet kaç yılında ilan edilmiştir? ");
            //    Console.WriteLine();
            //    Console.WriteLine("A) 1920");
            //    Console.WriteLine("B) 1921");
            //    Console.WriteLine("C) 1922");
            //    Console.WriteLine("D) 1923");
            //    Console.WriteLine("Cevabınızı yazınız:");
            //    cevap = Console.ReadLine();
            //    if(cevap == "D"| cevap == "d")
            //    {
            //        soru = soru + 1;
            //        Console.WriteLine("Cevabınız Doğru! Toplam Puanınız 50");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Hatalı cevap verdiniz.");
            //    }

            //}
            //if (soru == 3)
            //{
            //    Console.WriteLine("Adana hangi coğrafi bölgemizdedir? ");
            //    Console.WriteLine();
            //    Console.WriteLine("A) Karadeniz");
            //    Console.WriteLine("B) İç Anadolu");
            //    Console.WriteLine("C) Akdeniz");
            //    Console.WriteLine("D) Marmara");
            //    Console.WriteLine("Cevabınızı yazınız:");
            //    cevap = Console.ReadLine();
            //    if (cevap == "c" | cevap == "C")
            //    {
            //        soru = soru + 1;
            //        Console.WriteLine("Cevabınız Doğru! Toplam Puanınız 75");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Hatalı cevap verdiniz.");
            //    }

            //}




            /////********Switch Case Kullanımı********/////
            ///Cok fazla İF kullanmak yerine kullanılır///



            //byte plaka;

            //Console.WriteLine("Lütfen plaka giriniz: ");
            //plaka = byte.Parse(Console.ReadLine());

            //switch (plaka)
            //{
            //    case 1: Console.WriteLine("merhaba Adana"); break;
            //    case 2: Console.WriteLine("Merhaba Adıyaman"); break;
            //    case 3: Console.WriteLine("Merhaba Afyon"); break;
            //    default: Console.WriteLine("Böyle bir plaka bulanamadı."); break;
            //}

            /////********Switch Case Kullanımı STRING TURUNDEN********/////
            ///Cok fazla İF kullanmak yerine kullanılır///


            //string mevsim;
            //Console.WriteLine("Mevsim Uygulamasına Hoşgeldiniz!");
            //Console.WriteLine();
            //Console.WriteLine("------------------------");
            //Console.WriteLine();
            //Console.WriteLine("Öğrenmek istediğiniz mevsimi giriniz:");
            //mevsim = Console.ReadLine();

            //switch (mevsim)
            //{
            //    case "kış": Console.WriteLine("Aralık - Ocak -Şubat"); break;
            //    case "ilkbahar": Console.WriteLine("Mart - Nisan - Mayıs"); break;
            //    case "yaz": Console.WriteLine("Haziran - Temmuz - Ağustos"); break;
            //    case "sonbahar": Console.WriteLine("Eylül - Ekim - Kasım"); break;
            //    default: Console.WriteLine("Girdiğiniz değer mevsim değildir."); break;
            //}

            //Console.Read();
        }
    }
}

