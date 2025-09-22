using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yemek_Menusu
{
    class Yiyecek
    {
        public string adi;
        public string cins;
        public double fiyat;
        public double kdvOrani;

        public Yiyecek()
        {
            adi = "";
            cins = "";
            fiyat = 0;
            kdvOrani = 0;
        }

        public Yiyecek(string a, string c, double f, double kdv)
        {
            adi = a;
            cins = c;
            fiyat = f;
            kdvOrani = kdv;
        }

        public virtual string yazdir()
        {
            return $"{adi,-10} {cins,-10} {fiyat.ToString("C2", new CultureInfo("tr-TR"))} {kdvOrani,5}%";
        }
    }
}
