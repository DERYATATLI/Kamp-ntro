using System;

namespace Kampİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string kategoriEtiketi = "kategori";
            int ogrenciSayısı = 32000;
            double faizOrani = 1.45;
            bool sistemGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;


            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Eşittir butonu");
            }

            if (sistemGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
        }
    
    }
}
