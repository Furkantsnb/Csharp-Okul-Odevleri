namespace ucuncuHafta
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            
            // 3. hafta bölüm sonu örnek sorular

            /*  
            //Örnek 1 : Operatör
            //(a < b) = bu ifadenin doğru (true) olduğunu biliyoruz(c < d) = bu ifadenin yanlış (false) olduğunu biliyoruz   
            int a = 2; int b = 3; int c = 6; int d = 1;
            Console.WriteLine(" (a<b)&&(c<d) --> " + ((a < b) && (c < d)));
            Console.WriteLine(" (a<b)||(c<d) --> " + ((a < b) || (c < d)));
            Console.WriteLine(" ! (a<b) -->" + (!(a < b)));
            Console.WriteLine(" (a<b)&(c<d) --> " + ((a < b) & (c < d)));
            Console.WriteLine(" (a<b)|(c<d) --> " + ((a < b) | (c < d)));
            Console.WriteLine(" (a<b)^(c<d) --> " + ((a < b) ^ (c < d)));
            */



            /*
            //Örnek 2 : Operatör
            int a = 2; int b = 3; int c = 6;
            Console.WriteLine(" (a & b) --> " + (a & b));
            Console.WriteLine(" (a | b) --> " + (a | b));
            Console.WriteLine(" (a ^ b) --> " + (a ^ b));
            Console.WriteLine(" ( ~a ) --> " + (~a));
            Console.WriteLine(" ( ~b ) --> " + (~b));
            Console.WriteLine(" ( ~c ) --> " + (~c));
            */


            /*
            //Örnek 3 : While Döngüsü
            int i = 0; //döngü kontrol değişkeni
            while (i < 5)
            {
                Console.WriteLine("i = " + i);
                i++;
            }
            */

            /*
            //Örnek 5: do-while döngü
            int i = 0; //döngü kontrol değişkeni
            do
            {
                Console.WriteLine("i = "+ i);
                i++;
            } while(i < 0);
            */

            /*
            //Örnek 6: fordöngü
            for (int i = 0, j = 0; i < 20; i++, j++)
            {
                i *= j;
                Console.WriteLine("i = " + i + "  j = " + j); 
            }

            */

            /*
            //Örnek 7: for döngü
            string s;
            Console.WriteLine("Bir sayi gir");
            for (s = Console.ReadLine(); s != "Çıkış"; s = Console.ReadLine()) 
                Console.WriteLine(s);

            */

            /*
            //Örnek 8: for döngü
            int i= 0,a,n;

            Console.Write("Bir sayi girin : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Artım miktarı : ");
            a = Convert.ToInt32(Console.ReadLine());

            for (; i<n;)
            {
                Console.Write("{0}",i);
                i += a;
            }
            */

            /*
            //Örnek 9: for döngü
            int k, t, toplam, n1, n2;
            Console.WriteLine("Aralık başlangıcı");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Aralık Sonu : ");
            n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 <= n2)
            {
                for (k = n1; k <= n2; k++)
                {
                    toplam = 0;
                    for (t = 1; t <= k; t++)
                    {
                        if (k % t == 0)
                            toplam = toplam + t;
                    }
                    if (toplam == k + 1)
                        Console.WriteLine(k);
                }
            }

            else
                Console.WriteLine("Geçerli bir aralık girin...");
            */


            /*
            //Örnek 10: for döngü
            int sayi;
            Console.WriteLine("Bir tamsayı giriniz : ");
            sayi=Convert.ToInt32(Console.ReadLine());

            for(int bit = 32; bit >= 1; bit--)
            {
                Console.Write("{0}", (sayi >> bit - 1) & 1);
            }
            Console.WriteLine();
            */
        }
    }
}