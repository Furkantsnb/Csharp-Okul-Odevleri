namespace Örnek4
{
    internal class Program
    {
       static void Main(string[] args)
        {
            Ogrenci ogr1 = new Ogrenci();
            ogr1.numara = 123;
            ogr1.Ad = "Furkan";
            ogr1.Soyad = "Taşan";

            Ogrenci ogr2 = ogr1;
            ogr2.numara = 456;
            Console.WriteLine("{0}{1}{2}",ogr1.numara,ogr1.Ad,ogr1.Soyad);
            Console.WriteLine("{0}{1}{2}", ogr2.numara, ogr2.Ad, ogr2.Soyad);

        }
        struct Ogrenci
        {
            public int numara;
            public string Ad;
            public string Soyad;
        }
    }
    
    
    }
