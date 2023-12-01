using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProLab_Proje_2_GoPassage
{
    internal abstract class Vehicle
    {
        public string aracID { get; set; }
        public int Capacity { get; set; }

        // Araçlara ait ortak özellikler...
        public abstract float CalculateFuelCost();

    }
}
