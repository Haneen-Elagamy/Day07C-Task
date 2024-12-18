using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07C_Task
{
    internal class Calculator
    {

        #region Methods
        //1. Add two integers.
        public int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        //2. Add three integers.
        public int Sum(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        //3. Add two doubles.
        public double Sum(double num4, double num5)
        {
            return num4 + num5;
        } 
        #endregion

       
    }
}
