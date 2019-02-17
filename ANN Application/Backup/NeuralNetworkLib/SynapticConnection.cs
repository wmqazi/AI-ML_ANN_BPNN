using System;
using System.Collections.Generic;
using System.Text;
using Qazi.Commons;
namespace Qazi.MachineLearningModels.NeuralNetworks
{
    class SynapticConnection : ObjectX
    {
        internal Neuron _SourceNeuron;
        internal Neuron _TargetNeuron;
        internal float _Weight;
        
        public SynapticConnection(int id, Neuron sourceNeuron, Neuron targetNeuron, float weight)
        {
            _SourceNeuron = sourceNeuron;
            _TargetNeuron = targetNeuron;
            _Weight = weight;
            ID = id;
        }
    }
}
