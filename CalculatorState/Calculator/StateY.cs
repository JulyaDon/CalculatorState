using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorState.Calculator
{
    class StateY : State
    {
        private bool typing = false;
        public override void clear(Context context)
        {
            context.State = new StateX();
            context.State.clear(context);
        }

        public override void digit(Context context, char key)
        {
            if (!typing)
            {
                context.Y = 0;
                typing = true;
            }
            context.Y = context.Y * 10 + (int)char.GetNumericValue(key);
        }

        public override void arifm(Context context, char key)
        {
            equal(context);
            context.State.arifm(context, key);
        }

        public override void equal(Context context)
        {
            context.State = new StateAnswer();
            context.State.equal(context);
        }
    }
}
