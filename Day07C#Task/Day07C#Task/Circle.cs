using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Day07C_Task
{
    internal class Circle:IShap
    {
       public double R { get; set; }
       public double Area
        { 
            get {return 3.14*R*R;}
        }

        public void Draw()
        {
            Console.WriteLine($"Drawing a circle with R = {R}");
        }


    }
}
