using System;
using System.Collections.Generic;
using System.Text;

namespace BTBLib
{
    public class Objective
    {
        public int TypeCode { get; set; }
        public int Val1 { get; set; }
        public int Val2 { get; set; }

        public Objective(int typecode, int val1, int val2)
        {
            this.TypeCode = typecode;
            this.Val1 = val1;
            this.Val2 = val2;
        }
    }
}
