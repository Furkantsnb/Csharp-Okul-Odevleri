namespace basicPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //1-Verilen Bir Sayının Çift mi Tek mi Olduğunu Kontrol Eden C# Programı
            /*
            int i;
            Console.WriteLine("Enter a number : ");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.WriteLine("Entered number is an even number ");
                Console.Read();
            }
            else
            {
                Console.WriteLine("Entered number is an odd number");
                Console.ReadLine();
            }*/

            //2-Celsius'u Fahrenheit'e Dönüştürmek için C# Programı
            /*
            int celsius, faren;
            Console.WriteLine("Enter the temperature in Celsius(°C) :");
            celsius = int.Parse(Console.ReadLine());
            faren = (celsius*9) / 5 + 32;
            Console.WriteLine("0Temperature in fahrenheit is(°F) : " +faren);
            Console.ReadLine();
            */

            //3-Bir Sayının Pozitif Olup Olmadığını Kontrol Eden C# Programı
            /*
            int sayi;
            Console.WriteLine("Bir sayı girin");
            sayi= int.Parse(Console.ReadLine());

            if (sayi < 0)
            {
                Console.WriteLine("Girilen sayi negatif");

            }
            else if (sayi == 0)
            {
                Console.WriteLine("Girilen sayi sıfır");

            }
            else
            {
                Console.WriteLine("Girilen sayı pozitif");
            }
            Console.ReadLine();
            */

            //4-İki Sayıdan En Büyüğünü Bulan C# Programı
            /*
            int a, b;
            Console.WriteLine("ilk sayiyi girin : ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("ikinci sayiyi girin : ");
            b = int.Parse(Console.ReadLine());

            if (a > b)
                Console.WriteLine("En büyük değer : " + a);
            else if (b > a)
                Console.WriteLine("En büyük değer : " + b);

            else
                Console.WriteLine("İki sayi bir birine eşit");
            */

            //5-İki Sayının Yerini Değiştirmek İçin C# Programı

            /*
            int sayi1, sayi2, temp;

            Console.Write("Birinci sayiyi girin : ");
            sayi1 = int.Parse(Console.ReadLine());
            Console.Write("ikici Sayiyi girin : ");
            sayi2 = int.Parse(Console.ReadLine());

            temp = sayi1;
            sayi1 = sayi2;
            sayi2 = temp;
            Console.WriteLine("girilen sayi değiştikten sonra");
            Console.WriteLine("{0} ilk sayi " , sayi1);
            Console.WriteLine("{0} ikinci sayi " ,sayi2);
            Console.ReadLine();
            */

            //Bir Sayının 2'ye Bölünebilir Olup Olmadığını Kontrol Eden C# Programı

            /*
            Console.Write("Bir sayi girin :");
            int sayi = int.Parse(Console.ReadLine());
            if (sayi % 2 == 0)
                Console.WriteLine("Girilen sayi ikiye bölünüyor.");
            else
                Console.WriteLine("Girilen sayi 2 ye tam bölünmüyor.");

            Console.ReadLine();
            */

            //6- 3 ve 5'in Tüm Katlarının Toplamını Bulan C# Programı

            /*
            int a, b, toplam = 0;

            for(int i=0; i < 100; i++)
            {
                a = i % 3;
                b = i % 5; 

                if(a==0 || b == 0)
                {
                    Console.Write("{0}\t", i);
                    toplam += i;


                }
            }
            Console.WriteLine(" 3 ve 5 in katlarının toplamı : " + toplam);
            Console.ReadLine();

            */


            //7-17'nin 100'den Küçük Tüm Katlarını Yazdırmak İçin C# Programı

            /*
            for(int i = 17; i <= 100; i++)
            {
                if (i % 17 == 0)
                    Console.WriteLine("\t {0} sayısı 17 nin katı ", i);
            }
            Console.ReadLine();
            */

            //8-C# Program to Find Sum of Digits of a Number

            /*
            Console.WriteLine("Bir tam sayı girin");

            int sayi, toplam=0, x,y;
            sayi = int.Parse(Console.ReadLine());
            y = sayi;
            while (sayi != 0)
            {
                x = sayi % 10;
                sayi = sayi / 10;
                toplam += x;
            }

            Console.WriteLine( "{0} sayinin rakamlarının toplamı : " +toplam,y);
            Console.ReadLine();
            */


            //9- Özyineleme Kullanarak Bir Sayının Rakamlarının Toplamını Bulan C# Programı  // Soru 9 çalıştırmadan önce sınıf kısmının yorum satırlarını kaldırın 
            /*
            int deger, sayi;
            toplam x = new toplam();
            Console.WriteLine("bir sayi girin");
            sayi = int.Parse(Console.ReadLine());

             deger= x.top(sayi);
            Console.WriteLine("{0} sayisının basamak toplamları : {1}" ,sayi,deger);
            Console.ReadLine();
            */

            //Bir Sayıyı Ters Çevirmek için C# Programı

            /*
            int sayi, tersi = 0;
            Console.Write("Bir sayi girin : ");
            sayi = int.Parse(Console.ReadLine());

            while(sayi!= 0)
            {
                tersi = tersi * 10;
                tersi = tersi + (sayi % 10);
                sayi = sayi / 10;
            }
            Console.WriteLine("Girilen sayinin tersi : " + tersi);
            Console.ReadLine();
            */

            //10-Bir Sayıyı Tersine Çevirmek ve Palindrom olup olmadığını Kontrol Etmek için C# Programı
            /*
            int sayi, tersi = 0;
            Console.Write("Bir sayi girin : ");
            sayi = int.Parse(Console.ReadLine());
            int x = sayi;
            while (sayi != 0)
            {
                tersi = tersi * 10;
                tersi = tersi + (sayi % 10);
                sayi = sayi / 10;
            }
            if (x == tersi)
            {
                Console.WriteLine("Girilen sayının polindrom bir sayıdır.");
            }
            else
                Console.WriteLine("polindrom değil ");
            */

           




        }
    }

    //Soru 9 da istenen sınıf ve metot 
    /*
    class toplam
    {
        public int top(int sayi)
        {
            if(sayi!=0)
            return (sayi % 10 + top(sayi / 10));

            else
                return 0;
        }
    }
    */
}