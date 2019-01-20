using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorState.Calculator
{
    public class Context
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char O { get; set; }
        public State State { get; set; }

        public Context()
        {
            State = new StateX();
            State.clear(this);
        }
        public void press(char key)
        {
            switch (key)
            {
                case 'c':
                case 'C': State.clear(this);
                    break;
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9': State.digit(this, key);
                    break;
                case '+':
                case '-':
                case '*':
                case '/': State.arifm(this, key);
                    break;
                case '=': State.equal(this);
                    break;
            }
        }

        public int run(string keys)
        {
            foreach (var k in keys.ToCharArray())
            {
                press(k);
            }

            return X;
        }

        public override string ToString()
        {
            return "x = " + X + ", y = " + Y + ", operation = " + O + ", state = " + State.GetType().Name + ".";
        }
    }
}
