using System;
using System.Collections.Generic;
using System.Text;
using Qazi.Commons;

namespace Qazi.MachineLearningModels.NeuralNetworks
{
    class Layer : ObjectX
    {
        internal NeuralNetwork _NeuralNetwork;
        internal List<Neuron> _ListOfNeurons;
        internal InternalMemory _InternalMemory;

        public Layer(){
            _ListOfNeurons = new List<Neuron>();
        }

        public void AddNeurons(Neuron neuron){
            _ListOfNeurons.Add(neuron);
        }
    }
}
