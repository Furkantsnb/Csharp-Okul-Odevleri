namespace Ornek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ornek1.Deneme d = new Ornek1.Deneme(1, 2);
            Console.WriteLine(d);
            Console.WriteLine(Ornek1.Deneme.Topla(2, 3));

        }
    }
    class Deneme
    {
        public int a;
        public int b;
        public Deneme (int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public static int Topla(int x, int y)
        {
            return x + y;

        }
    } 
}