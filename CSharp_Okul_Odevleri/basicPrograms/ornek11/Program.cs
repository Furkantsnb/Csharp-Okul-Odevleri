namespace ornek11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int b1, b2;
            int i = 0, kalan = 0;
            int[] toplam = new int[20];

            Console.Write("ilk binary sayıyı girin : ");
            b1 = int.Parse(Console.ReadLine());

            Console.Write("ikinci binary sayıyı girin : ");
            b2 = int.Parse(Console.ReadLine());

            while (b1 != 0 || b2 != 0)
            {
                toplam[i++] = (b1 % 10 + b2 % 10 + kalan) % 2;
                kalan = (b1 % 10 + b2 % 10 + kalan) / 2;
                b1 = b1 / 10;
                b2 = b2 / 10;
            }
            if (kalan != 0)
            {
                toplam[i++] = kalan;
                --i;
                Console.WriteLine(" iki binary sayının toplamı : ");
                while (i >= 0)
                    Console.Write("{0}", toplam[i--]);
                Console.ReadLine();

            }
        }
    }
}