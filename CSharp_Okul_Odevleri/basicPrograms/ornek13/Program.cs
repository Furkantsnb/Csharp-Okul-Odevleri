namespace ornek13
{
    // İki Sayının Toplamını, Çarpmasını, Bölmesini ve Çıkarmasını Hesaplayan C# Programı
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, sonuc;
            char karakter;

            Console.Write("Birinci sayiyi girin : ");
            sayi1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("ikinci sayiyi girin : ");
            sayi2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Menü");
            Console.WriteLine("1-Toplama ");
            Console.WriteLine("2-Çıkarma");
            Console.WriteLine("3-Çarpma");
            Console.WriteLine("4-Bölme");
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz : ");

            karakter = Convert.ToChar(Console.ReadLine());

            switch (karakter)
            {
                case '1':
                    sonuc = sayi1 + sayi2;
                    Console.WriteLine("Toplam : " + sonuc);
                    break;
                case '2':
                    sonuc = sayi1 - sayi2;
                    Console.WriteLine("çıkarma : " + sonuc);
                    break;
                case '3':
                    sonuc = sayi1 * sayi2;
                    Console.WriteLine("Çarpma : " + sonuc);
                    break;

                case '4':
                    sonuc = sayi1 / sayi2;
                    Console.WriteLine("Bölme : " + sonuc);
                    break;
                   default:
                    Console.WriteLine("Yanlış parametre girdiniz...");
                    break;

              
            }
            Console.ReadLine();




        }
    }
}