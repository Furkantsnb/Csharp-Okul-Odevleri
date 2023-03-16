namespace Ornek8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kedi k = new Kedi();
        }
    }
    public class Hayvan
    {
        protected string a = "Hayvan.a";
        string b = "Hayvan.b";//friendly
        private string c = "Hayvan.c";
        public string d = "Hayvan.d";
    }
    public class Kedi : Hayvan // Türeyen
    {
         public Kedi()
        {
            Console.WriteLine("Kedi olusturuluyor");
                Console.WriteLine(a);
                Console.WriteLine(d);
        }
    }
}