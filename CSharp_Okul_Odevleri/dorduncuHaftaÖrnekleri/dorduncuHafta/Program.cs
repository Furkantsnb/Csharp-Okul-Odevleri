namespace dorduncuHafta
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 4.Hafta örnek sorular

            /*
            //Örnek 1: Diziler
            Random r = new Random();
            int[] dizi = new int[20];
            char[] chr = new char[20];
            for(int i =0; i < 20; i++)
            {
                dizi[i] = r.Next(1,51);
                chr[i] = (char)r.Next(20, 126);
            }
            for(int i = 0; i < 20; i++)
            {
                Console.Write("{0,2}.değer {1,2} -> ", i, dizi[i]);
                for(int j = 0; j < dizi[i]; j++)
                    Console.Write(chr[i]);
                Console.WriteLine();
            }
            */

            /*
            //Örnek 2:Matris Dizileri

            int[,] dizi = { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(dizi[i, j]);
                   
                }
            */


            /*
            //Örnek 3: Düzensiz Diziler
            int[][] dizi = new int[3][];
            dizi[0] = new int[] { 1, 2 };
            dizi[1] = new int[] { 3, 4,5,6,7 };
            dizi[2] = new int[] {8,9,0 };

            foreach (int[] boyut in dizi)
            {
                foreach (int eleman in boyut)
                {
                    Console.Write("{0,3}", eleman);
                }
                Console.WriteLine();
            }
            */



            /*
            //Örnek 4: diziler
            int[,] d = { { 2, 3 }, { 4, 5 }, { 6, 7 } };// 3x2 lik int dizi.
            d[2,1]=33; //doğru
            //d[2][1]=33;//hata
           Console.WriteLine(d.GetValue(2,1));//  7 değerini yazacak
           int[][] dd = new int[2][];// şekildeki düzensiz dizi oluşturuluyor.
           dd[0] = new int[2];//ilk satırın 2 sutunlu olacağı
           dd[1] = new int[1];//ikinci satırın 1 sütunlu olacağı
           dd[0][0] = 23;dd[0][1] = 234;dd[1][0] = 44;
           Random rnd = new Random();
            int[] dizi =new int[3];
            dizi[0] = rnd.Next(2,10); // 2 ile 10 arası rastgele sayı
            dizi[1] = rnd.Next(50);   //0 ile 50 arası
            dizi[2] = rnd.Next();  //rastgele integer değer
            Console.WriteLine(dizi.GetValue(2));//dizi değişkeninin 2. indis elemanını (3.eleman) yazar.
            Console.WriteLine(dd[1][0]);
            */

            /*
            //Örnek 5: foreach döngü
            string[] isimler = { "ali", "ahmet", "selda", "canan", "melike" }; 
            Console.WriteLine("aranan isim="); 
            string aranan = Console.ReadLine();
            foreach (string ss  in isimler) 
            {
                if (aranan.Equals(isimler[0]))
                    Console.WriteLine("aranan isim bulundu...");
                else
                    Console.WriteLine("isim yok");
            }
            Console.ReadKey();
            */

            /*
            //Örnek 6

            static int BuyukBul(int a , int b)
            {
                if (a > b)
                    return a;
                return b;
            }

            int s1, s2;
            Console.Write("1.Sayıyı girin : ");
            s1=Convert.ToInt32(Console.ReadLine());
            Console.Write("2.Sayiyi girin : ");
            s2= Convert.ToInt32(Console.ReadLine());  

            int enBuyuk= BuyukBul((int)s1, (int)s2);
            Console.WriteLine("En büyük : {0}`dir.", enBuyuk);
            */


            /*
            //Örnek 7

            static int BuyukBul(int a, int b)
            {
                if (a > b)
                    return a;
                return b;
            }
            static int BuyukBul3(int a , int b , int c)
            {
                return BuyukBul(a,BuyukBul(b,c));
            }
            int s1, s2 , s3;
            Console.Write("1.Sayıyı girin : ");
            s1= Convert.ToInt32(Console.ReadLine());
            Console.Write("2.Sayıyı girin : ");
            s2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("3.Sayıyı girin : ");
            s3 = Convert.ToInt32(Console.ReadLine());
            int enbuyuk = BuyukBul3(s1,s2,s3);
            Console.WriteLine("En büyük : {0}'dir", enbuyuk);
            */


            /*
            //Örnek 8 
            static void DegerTipAktarim(int sayi)
            {
                sayi = 30;

            }
            int x = 100;
            Console.WriteLine(x);

            DegerTipAktarim(x);
            Console.WriteLine(x);
            */

            /*
            //Örnek 9
            static void Metot1(float x, float y)
            {
                Console.WriteLine(" 1. metot çağrılır");

            }
            static void Metot1(double x, double y)
            {
                Console.WriteLine(" 2. metot çağrılır");
            }
            
        Metot1(5,6);// en az kapasiteli metot kullanılır bu programda 1. metot çağrılır.
            */

            /*
            //Örnek 10 
            static int Islem(string a, params int[] sayilar)
            { if (a == "carp")
                { if (sayilar.Length == 0) return 1;
                    int carpim = 1;
                    foreach (int i in sayilar) carpim *= i;
                    return carpim;
                }
                else if (a == "topla")
                { if (sayilar.Length == 0) return 0;
                    int toplam = 0;
                    foreach (int i in sayilar) toplam += i;
                    return toplam; } else return 0; }
            Console.WriteLine(Islem("topla", 3, 4, 7, 8));
            Console.WriteLine(Islem("carp", 5, 23, 6)); 
            */

            /*
            //Örnek 11
            static void Yaz(object o)
            {
                Console.WriteLine("1.Metot:" + o);
            }
            static void yaz(params object[] o)
            { 
                if (o.Length == 0) return;
                Console.Write("2.Metot:");
                foreach (object n in o)
                    Console.Write(n.ToString() + " ");
                Console.WriteLine(); }
             Yaz(25);  
            yaz("Deneme1", "Deneme2");
            yaz('a'); 
            yaz('z', 1, 23f, 4, 56, "abc"); 
        */


            // Örnek 12
            static int Faktoriyel(int a)
            {
                if (a == 0) return 1;
                return a* Faktoriyel(a-1);//fonksiyon kendi içerisinde çağrıldı
            }
            Console.Write("Faktöriyelini alacağınız sayıyı giriniz :");
            int fak_değeri=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Girmiş olduğunuz sayının faktöriyeli :"+
            Faktoriyel(fak_değeri));




            }
    }
}