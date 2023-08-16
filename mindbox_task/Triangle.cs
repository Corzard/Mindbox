using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindbox_task
{
    internal class Triangle : IShape
    {
        private double SideA { get; }
        private double SideB { get; }
        private double SideC { get; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double CalculateArea()
        {
            var tr = IsRightTriangle();
            if (tr.Item1)
            {
                return (tr.Item2 * tr.Item3) / 2;
            }
            else
            {
                double p = (SideA + SideB + SideC) / 2;
                return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
            }
        }

        public (bool, double, double) IsRightTriangle()
        {
            double max = Math.Max(SideA, Math.Max(SideB, SideC));
            double[] others = new double[] { SideA, SideB, SideC }.Where(x => x != max).ToArray();
            double first = others[0];
            double second = others[1];

            return (Math.Pow(max, 2) == Math.Pow(first, 2) + Math.Pow(second, 2), first, second);
        }
    }
}
