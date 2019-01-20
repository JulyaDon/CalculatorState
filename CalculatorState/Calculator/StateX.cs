using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorState.Calculator
{
    class StateX : State
    {
        private bool typing = false;
        public override void clear(Context context)
        {
            context.X = 0;
            context.Y = 0;
            context.O = '+';
        }

        public override void digit(Context context, char key)
        {
            if (!typing)
            {
                context.X = 0;
                typing = true;
            }
            context.X = context.X * 10 + (int)char.GetNumericValue(key);
        }

        public override void arifm(Context context, char key)
        {
            context.State = new StateAction();
            context.State.arifm(context, key);
        }

        public override void equal(Context context)
        {
            context.State = new StateAnswer();
            context.State.equal(context);
        }
    }
}
