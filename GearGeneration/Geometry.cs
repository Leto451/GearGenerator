using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GearGeneration
{
    public static class Geometry
    {
        public static Tuple<float, float> GetPoint(int middle, int diameter, double angle)
        {
            var rad = Math.PI * angle / 180;
            return new Tuple<float, float>(middle + diameter / 2 * Convert.ToSingle(Math.Cos(rad)), middle + diameter / 2 * Convert.ToSingle(Math.Sin(rad)));
        }
    }
}
