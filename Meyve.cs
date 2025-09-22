using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yemek_Menusu
{
    class Meyve : Yiyecek
    {
        public double kalori;

        public Meyve(string a, string c, double f, double kdv, double k) : base(a, c, f, kdv)
        {
            kalori = k;
        }

        public override string yazdir()
        {
            return base.yazdir() + $" {kalori} kcal";
        }
    }

}
