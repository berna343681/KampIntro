using System;

namespace KampIntro
{
    class Program
    {

        static void Main(string[] args)
        {
            // stype safety - tip güvenliği
            // Do not repeat yourself - kendini tekrarlama 
            // değer tutucu, alias 

            string KategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOranı = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if(dolarDun<dolarBugun) 
            {

                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giris yap Butonu");    
            }
 
            Console.WriteLine(KategoriEtiketi);


        }
    }
}
