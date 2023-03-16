namespace Ornek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Ornek2.Deneme d1 = new Ornek2.Deneme();
            isimalan2.Deneme isimalan2 = new isimalan2.Deneme();
        }
    }
    class Deneme
    {
        public Deneme()
        {
            Console.WriteLine("Deneme1");
        }
    }
}
namespace isimalan2
{
    class Deneme
    {
        public Deneme()
        {
            Console.WriteLine("Deneme2");
        }
    }
}