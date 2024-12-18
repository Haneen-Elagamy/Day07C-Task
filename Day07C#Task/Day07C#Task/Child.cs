using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07C_Task
{
    internal class Child:Parent
    {
       
        #region Properties
        public int Z { get; set; }
        #endregion

        #region Constructors
        public Child(int _x, int _y, int _z) : base(_x, _y)
        {
            Z = _z;
        } 
        #endregion

        #region Methods

        // new >> parent hiding
        public new int Product()
        {
            return base.Product() * Z;
        }

        public override string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }

        #endregion

    }
}
