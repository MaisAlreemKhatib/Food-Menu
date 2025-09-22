using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yemek_Menusu
{
    class Icecek : Yiyecek
    {
        public double kalori;

        public Icecek(string a, string c, double f, double kdv, double k) : base(a, c, f, kdv)
        {
            kalori = k;
        }

        public override string yazdir()
        {
            return base.yazdir() + $" {kalori} kcal";
        }
    }

}
