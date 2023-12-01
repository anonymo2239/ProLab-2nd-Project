using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProLab_Proje_2_GoPassage
{
    internal class Bus : Vehicle
    {
        public override float CalculateFuelCost()
        {
            // Otobüs yakıt hesaplama...
            return 23;
        }
        // Otobüse özgü diğer özellikler...
    }
}
