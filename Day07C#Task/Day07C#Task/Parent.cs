using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07C_Task
{
    internal class Parent
    {
        #region properties
        public int X { get; set; }
        public int Y { get; set; }
        #endregion

        #region Constructors
        public Parent(int _x, int _y)
        {
            X = _x;
            Y = _y;
        }
        #endregion

        #region Methods
        public virtual int Product()
        {
            return X * Y;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
        #endregion


       

        

       
    }
}


