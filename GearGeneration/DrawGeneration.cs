using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GearGeneration
{
    internal class DrawGeneration
    {


        
        public static void CreateGear(Gear gear, string output)
        {


            Bitmap image = new Bitmap(gear.Diameter1, gear.Diameter1);
            Graphics myGraph = Graphics.FromImage(image);
            SolidBrush redBrush = new SolidBrush(Color.White);
            myGraph.FillRectangle(redBrush, 0, 0, gear.Diameter1, gear.Diameter1);

            float angle = 180.0f / gear.NbTeeth;
            for (int i = 0; i < gear.NbTeeth; i++)
            {
                DrawPiePart(myGraph,Color.FromArgb(110,255,0,0), gear.Diameter1, gear.Diameter2,i*2*angle,angle);
                DrawPoint(myGraph,Geometry.GetPoint(gear.Diameter1/2,gear.Diameter2, i *2* angle),Color.Red,3);

            }

            for (int i = 0; i < gear.NbTeeth; i++)
            {
               DrawPiePart(myGraph, Color.Wheat, gear.Diameter1, gear.Diameter1, angle+i * 2 * angle, angle);
            }

        
            image.Save(output);

        }


        public static void DrawPoint( Graphics myGraphics,Tuple<float,float> pos, Color color, int size )
        {
            SolidBrush brush = new SolidBrush(color);
            myGraphics.FillEllipse(brush,pos.Item1-size/2,pos.Item2-size/2,size,size);

        }


        public static void DrawPiePart(Graphics myGraph,Color color, int size, int diameter, float startAngle, float sweepAngle)
        {


            SolidBrush redBrush = new SolidBrush(color);

            // Create rectangle for ellipse.
            Rectangle rect = new Rectangle(size/2-diameter/2, size/2-diameter/2, diameter, diameter);


            // Fill pie to screen.
            myGraph.FillPie(redBrush, rect, startAngle, sweepAngle);
        }
    }
}
