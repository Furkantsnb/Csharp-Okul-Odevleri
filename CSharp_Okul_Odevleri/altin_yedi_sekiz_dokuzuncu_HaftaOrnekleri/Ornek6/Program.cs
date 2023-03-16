namespace Ornek6
{
    struct universite
    {
        public string fakulte;
        public string bolum;
        public string ogr_gor;
        public universite(string a, string b,string c)
        {
            fakulte = a; bolum = b; ogr_gor = c; 
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            universite k = new universite("Teknoloji fakültesi", "Yazılım mühendisliği", "2.Sınıf");
            universite k2;
            Console.WriteLine(k.fakulte);
            Console.WriteLine(k.bolum);
            Console.WriteLine(k.ogr_gor);
            k2.fakulte = "Tıp fakültesi ";
            Console.WriteLine();
            Console.WriteLine(k2.fakulte);
        }
    }
}