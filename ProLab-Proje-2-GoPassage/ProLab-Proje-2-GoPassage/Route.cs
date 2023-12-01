using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProLab_Proje_2_GoPassage
{
    internal class Route
    {
        public string basNoktasi;
        public string bitNoktasi;
        public double mesafe;
        public void guzergahBelirle()
        {
            Form2 form2 = new Form2();
            basNoktasi = form2.basNoktasiLocal;
            bitNoktasi = form2.bitNoktasiLocal;
        }
        
    }
}
