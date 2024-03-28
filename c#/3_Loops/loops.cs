//using System;
//namespace turkcell_proje_1
//{
//	public class Donguler
//    {

//    }
    
//    //public bool Tekmi()
       
//    //{
//    //    Console.WriteLine(d)
//    //    if (deger % 2 == 0)
//    //    {
//    //        return true;
//    //    }

//    //    else
//    //    {
//    //        return false;
//    //    }

    
//    //}

//    //public bool asalmi()
//    //{
//    //    for(int i =1; i <= deger; i++)
//    //    {
//    //        if (deger % i == 0)
//    //            return false;
            

//    //    }
//    //    return true;
        
//    //}
//    //public int faktoriyel()
//    //{
//    //    int sonuc = 1;
//    //    for(int i = 2; i <= deger; i++)
//    //    {
//    //        sonuc = sonuc * i;
//    //    }
//    //}
//    //public bool tekmi()
//    //{
//    //    if (deger % 2 == 0)
//    //    {

//    //        return false;
//    //    }
//    //    else
//    //    {
//    //        return true;
//    //    }
//    //}
//    public bool asalmi()
//    {
//        for(int i = 1; i <= deger; i++)
//        {
//            if (deger % i == 0)
//            {
//                return false;
//            }
            
//        }
//        return true;
//    }
//    public int faktoriyel()
//    {
//        int sonuc = 0;
//        for(int i = 2; i <= deger; i++)
//        {
//            sonuc = sonuc * i;
//        }
//    }

//    public bool tekmi()
//    {
//        if (deger % 2 == 0)
//        {
//            return false
//        }
//        else
//            return true
//    }

//    public bool asalmi()
//    {
//        for(int i =2;i<=deger; i++)
//        {
//            if (deger % i == 0)
//            {
//                return false
//            }
//            else
//            {
//                return true
//            }
//        }
//    }

//    public int faktoriyel()
//    {
//        int sonuc = 0;
//        for(int i = 2; i <= deger; i++)
//        {
//            sonuc = sonuc * i;
//        }

//    }


//        //{
// //       int deger=0;
// //       public static bool Tekmi
// //       {
           
// //       }

//        //public static void Main(string[] args)
//        //{
//        ////////******DÖNGÜLER*******////////
//        ///---------FOR DÖNGÜSÜ----------///

//        //int i;

//        //for (i = 1; i <= 10; i++)
//        //{
//        //    Console.WriteLine("Merhaba");


//        //}
//        //Console.Read();


//        /////******* 2ŞER ARTIRMA UYGLAMASI /////*******

//        //int i;
//        //for (i = 0; i <= 20; i += 2)
//        //{
//        //    Console.WriteLine(i);
//        //}
//        //Console.Read();
//        ///******* Birer artırıp UYGULAMASI /////*******

//        //int k;

//        //for (k = 0; k <= 100; k += 1)
//        //{
//        //    Console.WriteLine(k + ") ANIL");
//        //}
//        //Console.Read();


//        /////******* TEK Mİ ÇİFT Mİ UYGULAMASI /////*******
//        //int k;
//        //Console.WriteLine("Sayınızı Giriniz: ");
//        //k =int.Parse(Console.ReadLine());
//        //if (k % 2 ==0)
//        //{
//        //    Console.WriteLine("Sayınız çiftir");
//        //}
//        //else
//        //{
//        //    Console.WriteLine("Sayınız Tektir");

//        //}
//        //Console.Read();


//        /////******* 3 ile bölümü kalan 0 olan /////*******


//        //for (int k = 0; k <= 21; k+=1)
//        //{
//        //    if (k % 3 == 0)
//        //    {

//        //        Console.WriteLine(k);

//        //    }

//        //}
//        //Console.Read();



//        /////******* Tam bölenleri bulma UYGULAMASI *******/////
//        ///
//        //int sayi;
//        //Console.WriteLine("Sayı Giriniz: ");

//        //sayi = Convert.ToInt32(Console.ReadLine());
//        //for(int k = 1; k <= sayi; k += 1)
//        //{

//        //    if (sayi % k == 0)
//        //    {
//        //        Console.WriteLine(k);

//        //    }
//        //}
//        //Console.Read();





//        /////******* MÜLAKAT SORUSU *******/////
//        ///Her saatte 2 ye bölünerek devam eden bakteri///
//        //int bakteri = 1;
//        //for(int i = 1; i <= 24; i += 1)
//        //{
//        //    bakteri = bakteri * 2;
//        //    Console.WriteLine(i+") durumda  "+bakteri);

//        //}

//        //Console.Read();
//        //Console.WriteLine(bakteri);
//        //Console.Read();

//        /////*******Ardışık Sayılarla İşlemler*******/////
//        //***** 1den N kadar sayıların toplamı*****//

//        //int toplam, i;
//        //toplam = 0;

//        //for (i = 1; i <= 10; i++)
//        //{
//        //    toplam = toplam + i;
//        //}
//        //Console.WriteLine(toplam);
//        //Console.Read();



//        //***** Kullanıcıdan alınan sayının toplamı*****//

//        //int toplam;
//        //Console.Write("Lütfen bir değer giriniz: ");
//        //toplam = Convert.ToInt32(Console.ReadLine());
//        //int toplamSonuc = 0;

//        //for (int k = 1; k <= toplam; k++)
//        //{
//        //    toplamSonuc += k;
//        //}
//        //Console.WriteLine(" "+toplamSonuc);

//        //Console.Read();



//        //***** faktöriyel olan sayının toplamı*****//

//        //int faktoriyel;
//        //Console.Write("Değer Giriniz: ");
//        //faktoriyel = Convert.ToInt32(Console.ReadLine());
//        //int sonuc=1;

//        //for (int i = 1; i <= faktoriyel; i++)
//        //{

//        //    sonuc = sonuc * i;
//        //    Console.WriteLine(i + "DURUM sonucu" +sonuc);

//        //}

//        //Console.Read();

//        ///Kullanıcıdan girilen sayının asal mı asal değil mi olduğunu bul
//        //int deger;
//        //Console.WriteLine("DeğerGiriniz:");
//        //deger = Convert.ToInt32(Console.ReadLine());

//        //if (deger % 2 == 0) 
//        //{
//        //    Console.WriteLine("Sayınız Çiftir.");

//        //}

//        //Console.Read();
//        //int deger;
//        //Console.WriteLine("Sayı giriniz");
//        //deger = Convert.ToInt32(Console.ReadLine());

//        //bool tekmi, cift;
//        //tekmi = true;
//        //cift = false;

//        //if (deger % 2 == 1)
//        //{
//        //    Console.WriteLine(tekmi);

//        //}
//        //Console.ReadLine();


//        //int faktoriyel;
//        //Console.Write("Değer Giriniz: ");
//        //faktoriyel = int.Parse(Console.ReadLine());
//        //int faktoriyelcarpi = 1;

//        //for (int i = faktoriyel; i >= 1; i--)
//        //{
//        //    faktoriyelcarpi *= i;
//        //}

//        //Console.WriteLine("Faktoriyel: " + faktoriyelcarpi);
//        //Console.Read();

//        //int faktöriyel;
//        //faktöriyel = 1;
//        //for(int i = 19; 1<= i; i--)
//        //{
//        //    faktöriyel *= i;
//        //}
//        //Console.WriteLine(faktöriyel);
//        //Console.Read();







//        /////*******WHİLE DÖNGÜSÜ*******/////
//        //*****ÖZELLİKLE VERİTABANINDAN VERİ ÇEKMEK İÇİN KULLANILIR*****//

//        //int sayac = 1;
//        //while (sayac <= 5)
//        //{
//        //    Console.WriteLine("ANILBABA");
//        //    sayac++;
//        //}
//        //Console.Read();


//        //int sayac = 1;
//        //while (sayac <= 20)
//        //{
//        //    Console.WriteLine(sayac);
//        //    sayac++;
//        //}
//        //Console.Read();

//        //int sayi = 0;
//        //int toplam = 0;
//        //while (sayi <= 10)
//        //{
//        //    toplam += sayi;
//        //    sayi++;

//        //}
//        //Console.WriteLine(toplam);
//        //Console.Read();


//        //int sayi = 1;
//        //int toplam = 0;
//        //Console.WriteLine("Sayı Giriniz: ");
//        //int limit = Convert.ToInt32(Console.ReadLine());

//        //while (sayi <= limit)
//        //{
//        //    toplam = toplam + sayi;
//        //    sayi++;
//        //}

//        //Console.WriteLine("Toplam: " + toplam);
//        //Console.Read();




//        /////*******DO WHİLE DÖNGÜSÜ*******/////
//        //*****WHİLE FARKI EN AZ BİR KERE DE OLSA ÇALIŞTIRIR İLK DEĞERİ YAZIDIRRR*****//

//        //int sayi = 12;
//        //do
//        //{
//        //    Console.WriteLine(sayi);
//        //    sayi++;
//        //}
//        //while (sayi <= 10);
//        //Console.Read();

//        //int kkenar, bkenar, alan, cevre;
//        //Console.WriteLine("Hesaplamak istediğiniz diktörgenin kenar uzunluklarını giriniz");
//        //Console.WriteLine("Kisa Kenarı Giriniz: ");
//        //kkenar = int.Parse(Console.ReadLine());
//        //Console.WriteLine("Büyük Kenarı Giriniz: ");
//        //bkenar = int.Parse(Console.ReadLine());

//        //alan = kkenar * bkenar;

//        //cevre = 2*(kkenar + bkenar);
//        //Console.WriteLine("Diktörgenin Alanı: " + alan);
//        //Console.WriteLine("Diktörgenin Çevresi: " + cevre);
//        //Console.Read();

//        //int s=0, i=1;
//        //while (i <= 456)
//        //{
//        //    s += i;
//        //    i+=13;
//        //}
//        //Console.WriteLine(s);
//        //Console.Read();
//        //int deger;
//        //Console.WriteLine("Deger giriniz: ");
//        //deger = int.Parse(Console.ReadLine());
//        //bool tekmi, asalmi,ciftmi;
//        //public bool tekmi()
//        //{
//        //    if (deger % 2 == 1  )
//        //        return true;
//        //    else
//        //        return false;

//        //}

//        //public void asalmi()
//        //{
//        //    for (int i = 2; i < deger; i++)
//        //    {
//        //        if (deger % i == 0)
//        //            return false;
//        //    }
//        //    return true;
//        //}

//        //public Int64 faktoriyel()
//        //{
//        //    Int64 sonuc = 1;
//        //    for(int i=2; i <= deger; i++)
//        //    {
//        //        sonuc = sonuc * i;
//        //    }
//        //    return sonuc;
//        //}

//        //int[] s = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//        //int tek = 0, toplam = 0;
//        //for(int i = 0; i <= s.Length; i++)
//        //{
//        //    toplam = toplam + i;

//        //    if (i % 2 ==1)
//        //    {
//        //        tek++;

//        //    }
//        //}
//        //Console.WriteLine(tek);
//        //Console.WriteLine(toplam);
//        //Console.Read();




//    }
//    }
//}

//public bool tekmi()
//    if (deger % 2 ==0)
//{
//    return false

//}
//    else
//    return true


