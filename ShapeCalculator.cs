using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.LectureActivity6_2
{
    /// <summary>
    /// Demonstrates method overloading for different shape calculations
    /// </summary>
    internal class ShapeCalculator
    {
        /// <summary>
        /// Calculates the area of a circle
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        public double CalculateArea(double radius)
        {
            return Math.PI * radius * radius;
        }
        /// <summary>
        /// Calculates the area of a triangle
        /// </summary>
        /// <param name="baselength"></param>
        /// <param name="height"></param>
        /// <param name="isTriangle"></param>
        /// <returns></returns>
        public double CalculateArea(double baselength, double height, bool isTriangle)
        {
            return 0.5 * baselength * height;
        }
    }
}
