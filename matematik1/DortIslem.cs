using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matematik1
{
    public class DortIslem
    {
        public static double Toplam(double sayi1, double sayi2)
        {
            double sonuc = sayi1 + sayi2;
            return sonuc;
        }
        public static double Cikarma(double sayi1, double sayi2)
        {
            double sonuc = sayi1 - sayi2;
            return sonuc;
        }
        public static double Carpma(double sayi1, double sayi2)
        {
            double sonuc = sayi1 * sayi2;
            return sonuc;
        }
        public static double Bolme(double sayi1, double sayi2)
        {
            double sonuc = sayi1 / sayi2;
            return sonuc;
        }
    }
}
