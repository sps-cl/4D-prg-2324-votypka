using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_01
{
    internal class CalculatorApp
    {
        static void Main()
        {
            CalculatorContext calculator = new CalculatorContext(new OpAdd());
            int res = calculator.ExecuteStrategy(1, 1);
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
