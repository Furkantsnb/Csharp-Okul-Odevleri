namespace Ornek5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            model1 oto1 = new model1();
            model2 oto2 = new model2();
            oto1.tur = "Sedan";
            oto1.silindir_sayisi = 4;
            oto1.subap_sayisi = 8;
            oto1.guc = 75;
            oto1.tork = 100;
            oto1.ozellikYaz();
            Console.WriteLine("**************************");
            oto2.model2_boy = 6;
            oto2.model2_agirlik = 900;
            oto2.model2_renk = "Siyah";
            oto2.ozellikYaz();
            Console.WriteLine("**************************");
            oto2.goster();
            Console.WriteLine("**************************");
            oto1.goster();
            Console.ReadLine();
        }
    }
    class oto
    {
        protected double boy = 5;
        protected double agirlik = 800;
        protected string renk = "sarı";
        public void goster()
        {
            Console.WriteLine("boy : " + boy);
            Console.WriteLine("Ağırlık : " +agirlik);
            Console.WriteLine("renk : " + renk);
        }
    }

    class model1 : oto
    {
        public string tur;
        public int silindir_sayisi;
        public int subap_sayisi;
        public int tork;
        public int guc;
        public void ozellikYaz()
        {
            Console.WriteLine("Tür = "+tur);
            Console.WriteLine("Boy : " +boy);
            Console.WriteLine("Ağırlık : " +agirlik);
            Console.WriteLine("Renk : " + renk);
            Console.WriteLine("Silindir sayisi : " + silindir_sayisi);
            Console.WriteLine("Subab Sayisi : " +subap_sayisi);
            Console.WriteLine("Tork : " + tork);
            Console.WriteLine("Güç : " + guc);

        }
    }
    class model2 : oto
    {
        public double model2_boy
        {
            get{ return boy; }
            set { boy = value; }
        }
        public double model2_agirlik
        {
            get { return agirlik; }
            set { agirlik = value; }
        }
        public string model2_renk
        {
            get { return renk; }
            set { renk = value; }
        }
        public string tur = "Hatchback";
        public int silindir_sayisi = 8;
        public int subap_sayisi = 16;
        public int tork=300;
        public int guc = 210;
        public void ozellikYaz()
        {
            Console.WriteLine("Tür = " + tur);
            Console.WriteLine("Boy : " + model2_boy);
            Console.WriteLine("Ağırlık : " + model2_agirlik);
            Console.WriteLine("Renk : " + model2_renk);
            Console.WriteLine("Silindir sayisi : " + silindir_sayisi);
            Console.WriteLine("Subab Sayisi : " + subap_sayisi);
            Console.WriteLine("Tork : " + tork);
            Console.WriteLine("Güç : " + guc);

        }
       
    }
}