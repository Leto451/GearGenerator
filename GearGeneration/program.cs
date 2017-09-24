using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GearGeneration
{
    class Program
    {
        public static void Main( string[] args )
        {

            Gear gear = new Gear(600,500,18);
            DrawGeneration.CreateGear(gear,"gear.png");
            Process.Start("gear.png");



        }
    }
}
