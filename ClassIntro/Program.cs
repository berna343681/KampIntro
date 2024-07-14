using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string adi = "engin";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Eğitmen = "Engin Demirog";
            kurs1.İzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Eğitmen = "Kerem Varış";
            kurs2.İzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Eğitmen = "Berkay Bilgin";
            kurs3.İzlenmeOrani = 80;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "c++";
            kurs4.Eğitmen = "Murat Kurtboğan";
            kurs4.İzlenmeOrani = 100;


            // Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Eğitmen);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Eğitmen);
            }

            Console.WriteLine("hello world");

        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        //prop 2x tab 
        public string Eğitmen { get; set; }
        public int İzlenmeOrani { get; set; }
    }

 }
