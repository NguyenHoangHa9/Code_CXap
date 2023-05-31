using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiThucHanhC_
{
   class Cylinder
    {
        double Height;
        double Radius;
        double BaseArea;
        double LateralArea;
        double TotalArea;
        double Volumn;

        public void Process()
        {
            Console.WriteLine("Enter the dimenstions of the cylinder");
            Console.Write("Radius: ");
            Radius = Convert.ToDouble(Console.ReadLine());
            Console.Write("Height: ");
            Height = Convert.ToDouble(Console.ReadLine());

            BaseArea = Radius * Radius * Math.PI;
            LateralArea = 2 * Math.PI * Radius * Height;
            TotalArea = 2 * Math.PI * Radius * (Height + Radius);
            Volumn = Math.PI * Radius * Radius * Height;
        }
        public void Result()
        {
            Console.WriteLine("\nCylinder Characteristics");
            Console.WriteLine("Radius: " + Radius + ". Height: " + Height);
            Console.WriteLine("Base: " + BaseArea.ToString("F2") + " | Lateral: " + LateralArea.ToString("F2") + " | Total: " + TotalArea.ToString("F2") + " | Volumn: " + Volumn.ToString("F2"));
        }
    }
}
