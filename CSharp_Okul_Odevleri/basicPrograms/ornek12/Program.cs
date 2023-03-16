namespace ornek12
{
    //İki Binary Sayıyı Çarpmak için C# Programı
    internal class Program
    {
        static void Main(string[] args)
        {
            int b1, b2, çarpım = 0;
            int digit, factor = 1;
            program pg = new program();

            Console.WriteLine("ilk binary sayıyı girin");
            b1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ikinci binatty sayıyı girin");
            b2 = int.Parse(Console.ReadLine());

            while (b2 != 0)
            {
                digit = b2 % 10;
                if(digit == 1)
                {
                    b1 = b1 * factor;
                    çarpım = pg.binaryproduct(b1, b2);    
                }
                else
                {
                    b1 = b1 * factor;
                    b2 = b2 / 10;
                    factor = 10;
                }
                Console.WriteLine(" iki binayr sayını çarpımı : {0}", çarpım);
                Console.ReadLine();
            }
        }
           
    }
    class program
    {
        public int binaryproduct(int b1 , int b2)
        {
            int i = 0, kalan = 0;
            int[] toplam = new int[20];
            int binaryprod = 0;

            while(b1!=0 || b2 != 0)
            {
                toplam[i++]= (b1%10 + b2%10 + kalan)%2;
                kalan = (b1 % 10 + b2 % 10 + kalan) / 2;
                b1 = b1 / 10;
                b2 = b2 / 10;
            }
            if (kalan != 0)
            {
                toplam[i++] = kalan;
                --i;
            }
            while (i >= 0)
                binaryprod = binaryprod * 10 + toplam[i--];
            return binaryprod;

        }
    }
}