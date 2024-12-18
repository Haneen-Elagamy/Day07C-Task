using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07C_Task
{
    internal class Rectangle2:Shape
    {
        #region properties
        public double Length { get; set; }
        public double Width { get; set; }
        #endregion

        #region Methods
        public override void Draw()
        {
            Console.WriteLine("Drawing Rectangle");
        }

        public override double CalculateArea()
        {
            return Length * Width;
        } 
        #endregion

    }
}
