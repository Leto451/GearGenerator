using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GearGeneration
{
    internal class Gear
    {
        public Gear( int diameter1, int diameter2, int nbTeeth )
        {
            Diameter1 = diameter1;
            Diameter2 = diameter2;
            NbTeeth = nbTeeth;
        }

        public int Diameter1 { get; private set; }
        public int Diameter2 { get; private set; }
        public int NbTeeth { get; private set; }

    }
}
