using System;
using System.Collections.Generic;
using System.Text;
using Qazi.Commons;

namespace Qazi.MachineLearningModels.NeuralNetworks
{
    class Neuron : ObjectX
    {
        internal Layer _ContainerLayer;
        internal float _Value;
        internal List<SynapticConnection> _ListOfInputSynaptics = null;
        internal List<SynapticConnection> _ListOfOutputSynaptics = null;

        //Working Variables
        private int synapticIndex;
        private float activation;
        private SynapticConnection synaticConnection;

        public Neuron(int id, Layer containerLayer){
            ID = id;
            _ContainerLayer = containerLayer;
            _ListOfInputSynaptics = new List<SynapticConnection>();
            _ListOfOutputSynaptics = new List<SynapticConnection>();
        }

        public void Run(){
            activation = 0;
            for (synapticIndex = 0; synapticIndex < TotalInputSynaptics; synapticIndex++)            {
                synaticConnection = _ListOfInputSynaptics[synapticIndex];
                activation = activation + synaticConnection._SourceNeuron._Value * synaticConnection._Weight;
            }
            _Value = _ContainerLayer._InternalMemory.ThresholdFunction(activation, _ContainerLayer._NeuralNetwork._LearningRate);
        }

        private int TotalInputSynaptics{
            get {
                return _ListOfInputSynaptics.Count;
            }
        }

        private int TotalOutputSynaptics{
            get {
                return _ListOfOutputSynaptics.Count;
            }
        }
    }
}
