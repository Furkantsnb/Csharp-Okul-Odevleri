namespace AlgoritmaSorulari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Soru1 basit carpim tablosu
            /*
            int i, j;
            for(i = 1; i <= 10; i++)
            {
                Console.WriteLine();
                for (j = 1; j < 10; j++)
                {
                    Console.WriteLine(i + " * " + j + " = " + i * j);
                }
                Console.WriteLine();
                Console.WriteLine("Furkan Taşan");
            }    
            Console.WriteLine();

            */



            //Soru2 Girilen sayının 5 in kuvveti mi?
            /*
            Console.WriteLine("Bir sayi girin");
            int sayi = Convert.ToInt32(Console.ReadLine());

            while (sayi > 0)
            {
                sayi = sayi - 5;

            }
            if (sayi == 0)
                Console.WriteLine("Sayi 5 in kuvveti");
            else 
                Console.WriteLine("sayi 5 in kuvveti degil");
            */



            //Soru3 fibonacci serini ik 10 serisini oluştur 
            /*
             
            int x = 1 ,  y =1 ,  z , sayac = 3;
            Console.Write(x +" " +y);
            while (sayac<=10)
            {
                z = x + y;
                Console.Write(" " + z + " ");
                x = y;
                y = z;
                sayac++;
            }
            */



            //Soru4 mukemmel sayi bulma
            /*
            int sayac = 2;
            int top = 1;

            Console.WriteLine(" bir sayi girin");
            int sayi = Convert.ToInt32(Console.ReadLine());

            while (sayac <=sayi/2)
            {
                if (sayi % sayac == 0)
                {
                    top =top+ sayac;
                }
                sayac++;
            }
            if (top == sayi)
                Console.WriteLine("mukemmel sayi");

            else
                Console.WriteLine("mukemmel degil");
            */



            //Soru5 bir sayinin herhangi bir dereceden kuvvetini bulma
            /*
            int sayi, ust, carpma = 1;

            Console.WriteLine("sayiyi gir ");
            sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sayinin ustunu gir ");
            ust = Convert.ToInt32(Console.ReadLine());  

            while(ust > 0)
            {
                carpma *= sayi;
                ust--;

            }
            Console.WriteLine("sonuc : " + carpma);
            */


            //Soru6 girilen sayinin abundant veya deficient sayi oldugunu bulun
            /*
            int bolen = 1, sayac = 2;
            Console.WriteLine("Bir sayi girin");
            int sayi = Convert.ToInt32(Console.ReadLine());

            while(sayac<= (sayi / 2))
            {
                if (sayi % sayac == 0)
                {
                    bolen += sayac;
                    
                }
                sayac++;

            }
            if (bolen > sayi)
                Console.WriteLine("Abundant");

            else
                Console.WriteLine("deficient");
            */


            //Soru7 istenilen aralıkta random sayı bulma 
            /*
            int alt, ust, tahmin, sayac = 0;
            Console.WriteLine("alt sayiyi gir");
            alt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ust sayiyi gir");
            ust = Convert.ToInt32(Console.ReadLine());  
            Random rnd = new Random();
            int tutulan = rnd.Next(ust)+1;

            do
            {
                tahmin = (alt + ust) / 2;
                sayac++;
                if (tahmin == tutulan)
                {
                    Console.WriteLine("Tutulan : " + tutulan + " sayac : " + sayac);
                    break;
                }
                else if (tahmin > tutulan)
                    ust = tahmin;
                else
                    alt = tahmin;

            } while (tahmin != tutulan);
            Console.ReadLine();
            */

            // Soru8 Decimal sayiyi binary sayiya donusturme


            /* int sayi, i = 0;
                 double top = 0;
             Console.WriteLine(" Onluk Sayi degerini girin");
             sayi = Convert.ToInt32(Console.ReadLine());

             while (sayi > 2)
             {
                 top = top + (sayi % 2) * Math.Pow(10,i);
                 sayi = sayi / 2;
                 i++;

             }
             top = top + (sayi % 2) * Math.Pow(10,i);
             Console.WriteLine("Binary : " + top);


             bool a = new bool();
             Console.WriteLine(a);*/

            object x;
            x = 10;
            Console.WriteLine(x.GetType());
            var y = "String değer";
            Console.WriteLine(y.GetType());

            int i = 10;
            object o = i;
            int z = (int) o;
            Console.WriteLine(i);
            Console.WriteLine(z);

        }
    }
}