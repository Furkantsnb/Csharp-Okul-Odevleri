namespace Ornek11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Y y = new Y(5);
            X yy = new X(6);

            int deneme = y.A;
            int deneme2 = yy.A;
        }
    }
    class X
    {
        protected int a;
        public X(int a)
        {
            Console.WriteLine("X " +a);
            this.a = a;
        }
        public int A
        {
            get { Console.WriteLine("X sınıfı : " +a); return a; }
        }
    }
    class Y:X
    {
        protected int b;
        public Y(int a):base(a)
        {
            this.b = a;

        }
        new public int A
        {
            get { Console.WriteLine("Y sınıfı = " +b); return b; }
        }
    }
}