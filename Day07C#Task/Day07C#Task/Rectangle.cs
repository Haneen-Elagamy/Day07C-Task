using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07C_Task
{
    internal class Rectangle:IShap
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Area 
        {
            get {  return Length*Width;}
        }

        public void Draw()
        {
            Console.WriteLine($"Drawing a rectangle with Length = {Length} and Width = {Width}");
        }
    }
}
