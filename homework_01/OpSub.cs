using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_01
{
    internal class OpSub : IOperation // implementace rozhrani IOperation
    {
        public int Execute(int a, int b)
        {
            return a - b;
        }
    }
}
