using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07C_Task
{
    internal class Child2: Parent
    {

        #region Properties
        public int Z { get; set; }
        #endregion

        #region Constructors
        public Child2(int _x, int _y, int _z) : base(_x, _y)
        {
            Z = _z;
        }
        #endregion

        #region Methods

        // override --> Change bahaviour of parent
        public override int Product()
        {
            return base.Product()*Z;
        }
        #endregion

    }
}
