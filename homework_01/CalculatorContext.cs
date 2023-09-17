using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_01
{
    internal class CalculatorContext
    {
        private readonly IOperation _opStrategy;//Asociace s rozhranim IOperation

        public CalculatorContext(IOperation opStrategy) 
        {
            this._opStrategy = opStrategy;
        }

        public int ExecuteStrategy(int a, int b)
        {
            return _opStrategy.Execute(a, b);
        }
    }
}
