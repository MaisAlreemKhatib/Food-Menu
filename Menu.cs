using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yemek_Menusu
{
    class Menu
    {
        private List<Yiyecek> liste = new List<Yiyecek>();

        public void ekle(Yiyecek y)
        {
            liste.Add(y);
        }

        public void sil(int index)
        {
            if (index >= 0 && index < liste.Count)
                liste.RemoveAt(index);
        }

        public List<Yiyecek> menuYazdir()
        {
            return liste;
        }
    }

}
