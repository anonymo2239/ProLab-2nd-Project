using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProLab_Proje_2_GoPassage
{
    internal class Airplane : Vehicle
    {
        public override float CalculateFuelCost()
        {
            // Uçak yakıt hesaplama...
            return 32;
        }
        // Uçağa özgü diğer özellikler...
    }
}
