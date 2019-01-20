using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorState.Calculator
{
    public abstract class State
    {
        public abstract void clear(Context context);
        public abstract void digit(Context context, char key);
        public abstract void arifm(Context context, char key);
        public abstract void equal(Context context);
    }
}
