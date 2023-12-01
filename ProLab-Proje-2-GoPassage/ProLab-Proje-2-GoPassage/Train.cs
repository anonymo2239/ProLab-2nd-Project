using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProLab_Proje_2_GoPassage
{
    internal class Train : Vehicle
    {
        public override float CalculateFuelCost()
        {
            // Tren yakıt hesaplama...
            return 32;
        }
        // Trene özgü diğer özellikler...
    }
}
