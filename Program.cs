using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneTabanlıProgramlamaOdev2
{
    class Dikdortgen
    {
        public int b;
        public int h;

        public int alanhesapla()
        {
            int sonuc = b * h;
            return sonuc;
        }

        public int cevrehesapla()
        {
            int sonuc = (2 * b) + (2 * h);
            return sonuc;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen = new Dikdortgen();
            Console.WriteLine("b ve h için değer giriniz");
            dikdortgen.b = Convert.ToInt32(Console.ReadLine());
            dikdortgen.h = Convert.ToInt32(Console.ReadLine());
            
        }
    }
}
