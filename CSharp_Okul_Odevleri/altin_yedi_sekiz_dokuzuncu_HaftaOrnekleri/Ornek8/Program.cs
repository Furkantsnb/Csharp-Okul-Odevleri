namespace Ornek8
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
            string[] sabitler = Enum.GetNames(typeof(Gunler));
            foreach (string s in sabitler)
                Console.WriteLine(s);
        }
    }
}