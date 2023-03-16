namespace Ornek12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ogr d = new ogr("Furkan TAŞAN", 88, 99);
            d.adGoster();
        }
    }
    abstract class ogrNot
    {
        public int vize;
        public int final;
        public ogrNot(int vize, int final)
        {
            this.vize = vize;
            this.final = final;
        }
    }
    class ogr : ogrNot
    {
        public string str;
        public ogr(string ad, int vize, int final):base(vize, final)
        {
            str = ad;
        }
        public void adGoster ()
        {
            Console.WriteLine("ögrenci adı : " + str);
            Console.WriteLine("Vize notu : " +vize+ "\n Final Notu : " + final);
        }
    }
}