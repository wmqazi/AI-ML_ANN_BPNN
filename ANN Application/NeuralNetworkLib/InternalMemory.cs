using System;
using System.Collections.Generic;
using System.Text;

namespace Qazi.MachineLearningModels.NeuralNetworks
{
    public interface InternalMemory
    {
        float ThresholdFunction(float activation ,object otherParameters);
    }

    public class LinearInternalMemory : InternalMemory
    {
        public float ThresholdFunction(float activation ,object otherParameters)
        {
            return activation;
        }
    }

    public class SigmoidalInternalMemory : InternalMemory
    {
        public float ThresholdFunction(float activation ,object otherParameters){

            float power = (-1 * float.Parse(otherParameters.ToString()) * activation);
            float ePower = (float)Math.Pow(Math.E, power);
            float term = 1 + ePower;
            float value = 1 / term;
            return value;
            //return (1/(1 + (Math.Pow(Math.E,(-1 * float.Parse(otherParameters.ToString()) * activation)) )));
        }
    }
}