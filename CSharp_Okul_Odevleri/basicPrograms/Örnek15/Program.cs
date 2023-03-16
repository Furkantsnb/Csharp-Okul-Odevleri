namespace Örnek15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            program prg = new program();
            Console.WriteLine("Bir ondalık sayi girin");
            sayi = int .Parse(Console.ReadLine());
            Console.Write("girilen sayının ikilik karşılığı : ");
            prg.binaryconversiyon(sayi);
            Console.ReadLine();

        }
    }
    public class program
    {
        public int binaryconversiyon(int sayi)
        {
            int bin;
            if (sayi != 0)
            {
                bin = (sayi % 2) + 10 * binaryconversiyon(sayi / 2);
                Console.Write(bin);
                return 0;
            }
            else 
                return 0;
        }
    }
}