using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "yazılım geliştirici kapı ";
            string kurs2 = "Programlamaya başlangıç için temel kurs ";
            string kurs3 = "java";
            string kurs4 = "python";
            string kurs5 = "c++";

            Console.WriteLine(kurs1);   
            Console.WriteLine(kurs2);   
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);

            // array - dizi 

            string[] kurslar = new string[] {
                "yazılım geliştirici kapı ",
                "Programlamaya başlangıç için temel kurs ",
                 "java", "python", "c++" };

 
            for (int i = 0; i < kurslar.Length; i++) 
            {
                Console.WriteLine(kurslar[i]);
            }
             Console.WriteLine("for bitti ");


            // dizi temelli yapıları tek tek dönmeye yarıyor 
            foreach (string kurs in kurslar)
            { 
              Console.WriteLine(kurs); 
            }
                
             Console.WriteLine("sayfa sonu - footer");
        }
    }
}
