namespace besinciHafta
{
    internal class Program
    {
        private static string En;

        // 5.Hafta Örnek Sorular
        static void Main(string[] args)
        {
            //Örnek 1
            /*
            static float Fonksiyon(float x)
            {
                return 2* x+5; 
            }static float TersFonksiyon(float x)
            {  return (x - 5) / 2; 
            }
            
                float x = 10;
            Console.WriteLine(Fonksiyon(x));
            Console.WriteLine(TersFonksiyon(x));
            Console.WriteLine(Fonksiyon(TersFonksiyon(x)));
            */

            //Örnek2
            /*
            Ogrenci ogr = new Ogrenci();
            Console.WriteLine("ogrenci No : " +ogr.OgrenciNo);
            Console.WriteLine("Ogrenci Ad : "+ogr.Ad);
            Console.WriteLine("Ogrenci Soyad : "+ogr.Soyad);
            Console.WriteLine("Ogrenci Bolum : " + ogr.Bolum);
            Console.WriteLine("ogrenci sınıf : " +ogr.Sinif);
           */

            //Örnek3 
            /*
            Ogrenci hesap1 = new Ogrenci(); 
            Ogrenci hesap2 = new Ogrenci();
            hesap1.HesapNo = 3456;
            hesap2.HesapNo = 1111;
            Console.WriteLine(hesap1.HesapNo); 
            Console.WriteLine(hesap2.HesapNo);
            */

            //Örnek 4 
            /*
            SinifIsmi nesne = new SinifIsmi(); 
            Console.WriteLine(nesne.ozellik1);
            Console.WriteLine(nesne.ozellik2);
            Console.WriteLine(nesne.ozellik3); 
            Console.WriteLine(nesne.metot1(2, 5));
            nesne.metot2("deneme");
            */
            /*
            //Örnek 5
            Dortgen d1 = new Dortgen();
            d1.EnBoyBelirle(20, 50);
            d1.Yaz();
            Dortgen d2 = new Dortgen();
            d2.EnBoyBelirle(25, 12); d2.Yaz();
            */

            /*
            //Örnek 6
            int En = 50;
            int Boy = 100;
            Console.WriteLine(En + "\n" + Boy);
            */

            /*
            //Örnek 7
            int en = 50;
            int boy = 100;
            Console.WriteLine(En + "\n" + Boy);
            */
            /*
            //Örnek 8
            int boy = 100;
            Console.WriteLine(En + "\n" + boy);
            */
            /*
            //Örnek 9
            Topla ekle = new Topla(0);
            Console.WriteLine("Başlangıç değeri->" + ekle.Toplama);
            for (int i = 1; i < 100; i++) ekle.Toplama = i; 
            Console.WriteLine("Sayıların toplamı" + ekle.Toplama);
            */

            //örnek 10
            Programa a = new Programa();
            metotlar(a.Zar(), a.Zar(), a.Zar());
        }

        

        /*
class Ogrenci

{
   public ulong HesapNo; // örnek 4
   public ulong OgrenciNo;
   public String Ad;
   public String Soyad;
   public String Bolum;
   public byte Sinif;

}*/

        /*
        //Örnek 4
        class SinifIsmi
        {
            public int ozellik1 = 55;// başlangıç değerleri verildi.
            public string ozellik2 = "deneme";
            public float ozellik3 = 123.78f;
            public int metot1(int a, int b)
            {
                return a + b;
            }
            public void metot2(string a)
            {
                Console.WriteLine(a);
            }
        }
        */

        /*
        //Örnek 5
        class Dortgen
        {
            static int en = 8;
            static int boy = 3;


            public int En;
            public int Boy;
            public int Alan()
            {
                int Alan = En * Boy;
                return Alan;
            }
            public void EnBoyBelirle(int en, int boy) { En = en; Boy = boy; }
            public void Yaz()
            {
                Console.WriteLine("***************");
                Console.WriteLine("En:{0,5}", En);
                Console.WriteLine("Boy:{0,5}", Boy);
                Console.WriteLine("Alan:{0,5}", Alan());
                Console.WriteLine("***************");
            }


        }
    }
    */
        //Örnek 9
        class Toplam
        {
            public int tpl;
            public Toplam(int toplam)
            {
                tpl = toplam;
            }
            public int Toplama
            {
                get { return tpl; } // değeri görüntüleme
                set { tpl = value + tpl; } // yeni değeri depola}
            }
        }

        //Örnek 10
        class Programa
        {
            //Random rnd= new Random(); // kullanılsaydı yine farklı değer üretirdi.
            public int Zar()
            {
                Random rnd = new Random();
                return rnd.Next(1, 7);
            }
            public static void metotlar(int a, int b, int c)
            {
                Console.WriteLine("a= " + a + " b= " + b + " c= " + c);
            }
        }
    }
    
    }