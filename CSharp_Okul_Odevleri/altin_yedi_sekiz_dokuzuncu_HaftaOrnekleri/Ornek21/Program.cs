namespace Ornek13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            S s = new S(5);
            s.y = 2 * s.x;
            s.Metot();
        }
    }
    abstract class A
    {
        public int x;
        abstract public int y
        {
            set;
            get;
        }
        public A(int x)
        {
            this.x = x;
        }
        abstract public void Metot();
        

        
    }
    class S : A
    {
        int z;
        public S(int x) : base(x)
        {

        }
        public override int y
        {
            get { return z; }
            set { z = value; }
        }
        public override void Metot()
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
}
    