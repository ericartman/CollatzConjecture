using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollatzConjectureStepCounter
{
    class CollatzCalculator
    {
        public long NumberInQuestion { get; set; }

        public CollatzCalculator(long numberInQuestion)
        {
            NumberInQuestion = numberInQuestion <= 0 ? 0 : numberInQuestion;
        }

        internal List<Step> CalculateStepsRequired()
        {
            List<Step> steps = new List<Step>();

            if (NumberInQuestion <= 0)
            {
                steps.Add(new Step(-1, -1, "Negative or zero value provided"));
                return steps;
            }

            long currentStep = NumberInQuestion;
            long currentStepNumber = 0;
            steps.Add(new Step(NumberInQuestion));
            while (currentStep != 1)
            {
                if (currentStep % 2 == 0)
                {
                    currentStep = currentStep / 2;
                    currentStepNumber += 1;
                    steps.Add(new Step(currentStep, currentStepNumber));
                }
                else
                {
                    currentStep = currentStep * 3 + 1;
                    currentStepNumber += 1;
                    steps.Add(new Step(currentStep, currentStepNumber));
                }
            }

            steps.Add(new Step(currentStep, ++currentStepNumber, "Value of 1 reached; process breaks to avoid infinite looping."));

            return steps;
        }
    }
}