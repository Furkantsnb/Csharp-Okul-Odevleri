namespace Ornek10
{
    internal class Program
    {
        public static void Goster(oto Oto)
        {
            //Console.WriteLine(Oto.Tur); Hata ulaşılamaz
            Console.WriteLine(Oto.MotorGucu);
            Console.WriteLine(Oto.Tork);
            Console.WriteLine(Oto.Renk);

        }
        static void Main(string[] args)
        {
            oto oto1 = new oto(75, 100,"Yeşil");
            Goster(oto1);
            Console.WriteLine("------------------------");
            model oto2 = new model("TOOG", 100, 110, "Siyah");
            Goster(oto2);
            Console.WriteLine("------------------------");
            model oto3 = new model("Doğan", 100, 120, "kıp kırmızı");
            Goster(oto3);
            Console.ReadLine();
        }
    }
    class oto
    {
        protected double motorgucu = 5;
        protected double tork = 800;
        protected string renk = "sarı";
        public oto (double guc , double tork, string renk){
            this.motorgucu = guc;
            this.tork = tork;
            this.renk = renk;
        }
        public void ozellkgoster()
        {
            Console.WriteLine("Motor gücü : " +motorgucu);
            Console.WriteLine("Tork : " + renk);
            Console.WriteLine("Renk : " + renk);
        }
        public double MotorGucu
        {
            get { return motorgucu; }
            set { motorgucu = value; }
        }
        public double Tork
        {
            get { return tork; }  
            set { tork = value; }
        }
        public string Renk
        {
            get { return renk; }
            set { renk = value; }
        }
    }

    class model : oto
    {
        public string Tur;
        public model( string tur , double guc , double tork,string renk ): base(guc,tork,renk)
        {
            this .Tur = tur;
        }
        public void Turgoster()
        {
            Console.WriteLine("Türü : " + Tur);


        }
    }

    class model2 : oto
    {
        public string Tur;
        public model2(string tur, double guc, double tork, string renk): base(guc,tork,renk){
            this.Tur = tur;
            
        }
        public void Turgoster()
        {
            Console.WriteLine("Türü : " + Tur);


        }

    }

}