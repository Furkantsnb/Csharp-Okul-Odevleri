namespace Ornek6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            T t = new T();
            t.listele();
            t.Yaz();
        }
    }
    class A
    {
        public int x;
        private int y;
        protected int z;
        public A()
        {
            x = 1;
            y = 2;
            z = 3;
            Console.WriteLine("A yapıcısı çalıştı");
        }
        public void listele()
        {
            Console.WriteLine("x={0}; y={1};z={2}",x,y,z);

        }
    }
    class T : A
    {
        public string s;
        public T()
        {
            s = "Türemiş sınıf";
            Console.WriteLine("T yapıcısı çalıştı");
        }
        public void Yaz()
        {
            Console.WriteLine("s={0}; y={1};z={2}", s, x, z);
        }
    }
}