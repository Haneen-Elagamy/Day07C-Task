using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07C_Task
{
    internal interface IShap
    {
        /*o Modify the IShape interface to include a default implementation of a method
PrintDetails().
o Create a class Circle that implements IShape.
o Call PrintDetails() on an instance of Circle.*/
        double Area { get; }

         void Draw();

        void PrintDetails()
        {
            Console.WriteLine("default implemented method");
        }

        

        


    }
}
