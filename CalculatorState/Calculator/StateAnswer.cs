using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorState.Calculator
{
    class StateAnswer : State
    {
        public override void clear(Context context)
        {
            context.State = new StateX();
            context.State.clear(context);
        }

        public override void digit(Context context, char key)
        {
            context.State = new StateX();
            context.State.digit(context, key);
        }

        public override void arifm(Context context, char key)
        {
            context.State = new StateAction();
            context.State.arifm(context, key);
        }

        public override void equal(Context context)
        {
            int answer = 0;
            switch(context.O)
            {
                case '+': answer = context.X + context.Y;
                    break;
                case '-':
                    answer = context.X - context.Y;
                    break;
                case '*':
                    answer = context.X * context.Y;
                    break;
                case '/':
                    answer = context.X / context.Y;
                    break;
            }
            context.X = answer;
        }
    }
}
