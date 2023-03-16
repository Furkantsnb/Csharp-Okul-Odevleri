namespace Ornek7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kedi kedi = new Kedi();
            kedi.yakalaAv();
            Kaplan kaplan = new Kaplan();
            kaplan.yakalaAv();
        }
    }
    class Kedi
    {
        protected int ayakSayisi = 4;
        public void yakalaAv()
        {
            Console.WriteLine("Kedi sinifi av yakaladi");
        }
    }
    class Kaplan : Kedi
    {
        public Kaplan()
        {
            Console.WriteLine("Ayak sayisi = " + ayakSayisi);
        }
    }
}