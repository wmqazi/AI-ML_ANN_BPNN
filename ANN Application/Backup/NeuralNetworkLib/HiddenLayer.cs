using System;
using System.Collections.Generic;
using System.Text;
using Qazi.Commons;

namespace Qazi.MachineLearningModels.NeuralNetworks
{
    class HiddenLayer : Layer
    {
        //Working Variables
        private int neuronIndex;
        
        public HiddenLayer(int id, NeuralNetwork n){
            ID = id;
            _NeuralNetwork = n;
            _InternalMemory = new SigmoidalInternalMemory();
        }

        public void Run(){
            for (neuronIndex = 0; neuronIndex < _ListOfNeurons.Count; neuronIndex++) {
                _ListOfNeurons[neuronIndex].Run();
            }
        }

    }
}
