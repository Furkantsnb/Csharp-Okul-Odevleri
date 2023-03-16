namespace ornek14
{
    //Aynı Tabana Sahip Üslerin Çarpımını ve bölümü Gerçekleştiren C# Programı
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayiyi girin : ");
            int sayi = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("birinci üssü girin : ");
            double ust1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ikinci üssü girin : ");
            double ust2 = Convert.ToDouble(Console.ReadLine());

            double toplam = ust1 + ust2;
            double çıkarma = ust1 - ust2;
            Console.WriteLine("Çarpımı===> {0}^{1} : {2}",sayi,toplam,Math.Pow(sayi,toplam));
            Console.WriteLine("Bölümü===> {0}^{1} : {2}", sayi, çıkarma, Math.Pow(sayi, çıkarma));



        }
    }
}