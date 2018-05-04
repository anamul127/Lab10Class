using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10Classes
{
    class Circle
    {
        private double radius;

        public double Radius { get => radius; set => radius = value; }

        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public double CalculateCircumfrence()
        {
            return Radius * Math.PI * 2;
        }
        public string CalculateFormattedCircumference()
        {
            return FormatNumber(Radius * Math.PI * 2);
        }
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius; 
        }
        public string CalculateFormattedArea()
        {
            return FormatNumber(Math.PI * Radius * Radius);
        }
        private string FormatNumber(double x)
        {
            return x.ToString("#.00"); 
        }
    }
}
