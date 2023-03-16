namespace ornek15
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Sinif s = new Sinif();
            IArayuz a;
            a = s;
            a.Metot1();
        }
    }
    interface IArayuz
    {
        int Metot1();
        int Metot2();
        int Sayi
        {
            get;
            set;
        }
        int this[int indeks]
        {
            get;
        }
    }
    class Sinif : IArayuz
    {
        private int sayi;
        public int Metot1()
        {
            return 0;
        }
        public void Metot2()
        {
            
        }

        int IArayuz.Metot2()
        {
            throw new NotImplementedException();
        }

        public int Sayi
        {
            get { return sayi; }
            set { sayi = value; }   

        }
        public int this[int indeks]
        {
            get { return indeks; }
            set {  }
        }
    }
}