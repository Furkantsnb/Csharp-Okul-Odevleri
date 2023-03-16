namespace Ornek9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C nesnesi");
            Console.WriteLine("-------------------");
            C c = new C(2,3,4);
            Console.WriteLine("a="+c.a);
            Console.WriteLine("b=" + c.b);
            Console.WriteLine("c=" + c.c+"\n");

            Console.WriteLine("B nesnesi");
            Console.WriteLine("-------------------");
            B b = new B(5,6);
            Console.WriteLine("a=" + b.a);
            Console.WriteLine("b=" + b.b);
            

            Console.WriteLine("A nesnesi");
            Console.WriteLine("-------------------");
            A a = new A(7);
            Console.WriteLine("a=" + a.a+"\n");
            Console.ReadLine();
           
        }
    }
    class A
    {
        public int a;
        public A(int a)
        {
            this.a = a;
            Console.WriteLine("A yapıcısı çalıştı \n");
        }
    }
    class B:A
    {
        public int b;
        public B(int a ,int b):base(a)
        {
            this.b = b;
            Console.WriteLine("B yapıcısı çalıştı \n");
        } 
    }
    class C : B
    {
        public int c;
        public C(int a, int b, int c) : base(a, b)
        {
            this.c = c;
            Console.WriteLine("C Sınıfının yapıcısı çağrıldı \n");
        }
    }
}