using System;
using System.Collections.Generic;
using System.Text;

namespace Qazi.MachineLearningModels.NeuralNetworks
{
    class InputLayer : Layer 
    {
        private string valueString;

        public InputLayer(int id, NeuralNetwork n)
        {
            _NeuralNetwork = n;
            ID = id;
            _InternalMemory = new LinearInternalMemory();
        }

        public string ToValueString(){
            valueString = "";
            foreach (Neuron n in _ListOfNeurons) {
                valueString = valueString + n._Value.ToString();           
            }
            return valueString;
        }
    }
}
