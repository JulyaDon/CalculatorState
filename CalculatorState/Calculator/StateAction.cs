namespace CalculatorState.Calculator
{
    class StateAction : State
    {
        public override void clear(Context context)
        {
            context.State = new StateX();
            context.State.clear(context);
        }

        public override void digit(Context context, char key)
        {
            context.State = new StateY();
            context.State.digit(context, key);
        }

        public override void arifm(Context context, char key)
        {
            context.O = key;
        }

        public override void equal(Context context)
        {
            context.Y = context.X;
            context.State = new StateAnswer();
            context.State.equal(context);
        }
    }
}
