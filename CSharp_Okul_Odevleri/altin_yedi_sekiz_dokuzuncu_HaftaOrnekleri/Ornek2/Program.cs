namespace Örnek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sinif a = new Sinif(50);
            int b = a;
            Console.WriteLine(b);
        }
    }
    class Sinif
    {
        public int Sayi;
        public Sinif (int sayi)
        {
            Sayi = sayi;   
        }
            public static implicit operator int (Sinif a)
        {
            return a.Sayi;
        }
    } 
}