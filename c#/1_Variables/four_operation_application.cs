using System;
namespace turkcell_proje_1
{
	public class EmptyClass
	{
        
            public void Dortislem()
            {
            int s1=10, s2=7, toplam, cikarma, carpma;
            float bolme;
            
            toplam = s1 + s2;
            cikarma = s1 - s2;
            carpma = s1 * s2;
            bolme = s1 / s2;

            Console.WriteLine("Toplama işleminin sonucu" + " = " + toplam);
            Console.WriteLine("Çıkarma işleminin sonucu" + " = " + cikarma);
            Console.WriteLine("Çarpma işleminin sonucu" + " = " + carpma);
            Console.WriteLine("Bölme işleminin sonucu" + " = " + bolme);
            
            }

            public static void Main1(string[] args)
            {
                EmptyClass hesap1 = new EmptyClass();
            hesap1.Dortislem();
            Console.ReadLine();
            }
        }
    }
	

