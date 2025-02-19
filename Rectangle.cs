using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.LectureActivity6_2
{
    internal class Rectangle : Shape
    {
        // Auto implemtned properties for length and width of rectangle
        public double Length {  get; set; }
        public double Width { get; set; }

        /// <summary>
        /// Constructor for Rectangle class
        /// </summary>
        /// <param name="length"></param>
        /// <param name="width"></param>
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }
        /// <summary>
        /// Displays area of rectangle
        /// </summary>
        public override void DisplayArea()
        {
            Console.WriteLine($"Rectangle Area: {Length * Width}");
        }
    }
}
