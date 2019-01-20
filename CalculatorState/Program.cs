using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorState.Calculator;

namespace CalculatorState
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Glad to see you at my calculator! Write 'exit' to finish.");
            Context calc = new Context();
            while (true)
            {
                char key = (char)Console.Read();
                if (key == 'e')
                {
                    break;
                }
                if (key>=' ') { 
                    calc.press(key);
                    Console.WriteLine(calc);
                }
            }
        }
    }
}
