namespace Ornek7
{
    enum Gunler : byte
    {
        PAZARTESI,
        SALI,
        CARSAMBA,
        PERSEMBE,
        CUMA,
        CUMARTESI,
        PAZAR,
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((int)Gunler.PAZARTESI);
            Console.WriteLine((int)Gunler.PAZAR);
        }
    }
}