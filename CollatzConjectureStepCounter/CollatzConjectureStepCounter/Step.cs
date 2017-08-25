namespace CollatzConjectureStepCounter
{
    class Step
    {
        public string Message { get; private set; }

        public double Value { get; private set; }

        public double StepNumber { get; private set; }

        public Step(double value, double stepNumber = 0, string message = null)
        {
            Message = message;
            Value = value;
            StepNumber = stepNumber;
        }
    }
}