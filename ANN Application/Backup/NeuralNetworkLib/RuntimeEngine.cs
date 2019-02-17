using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using System.Data;
using Qazi.Commons;

namespace Qazi.MachineLearningModels.NeuralNetworks
{
    public class RuntimeEngine : ObjectX
    {
        private NeuralNetwork _NeuralNetwork;
        private List<string> _ListOfInputAttributes;
        private DataRow _PatternRow;

        //Working Variable
        private int inputDimensionIndex;
        private float inputMagnitude;
        private string inputAttribute;
        private int hiddenLayerIndex;
        private int totalLayers;
        private Layer layer;

        public RuntimeEngine(int id, NeuralNetwork nn, List<string> listOfInputAttributes)
        {
            _NeuralNetwork = nn;
            ID = id;
            _ListOfInputAttributes = listOfInputAttributes;
            totalLayers = _NeuralNetwork._ListOfLayers.Count;
        }

        public float Run() {
            if (_PatternRow == null){
                throw new Exception("Runtime Engine (ID = " + ID.ToString() + ") cannot evaluate because Input Patten Vector is Empty/NULL/Invalid");
            }

            //Assign Pattern To Input Layer Neurons;           
            for (inputDimensionIndex = 0; inputDimensionIndex < DimensionsOfInputPattern; inputDimensionIndex++){
                inputAttribute = _ListOfInputAttributes[inputDimensionIndex];
                inputMagnitude = int.Parse(_PatternRow[inputAttribute].ToString());
                _NeuralNetwork._InputLayer._ListOfNeurons[inputDimensionIndex]._Value = inputMagnitude;
            }
           // _NeuralNetwork.RaiseTaskProgressEvent(this ,0.00f ,"Executing With: " + _NeuralNetwork._InputLayer.ToValueString());

            //Execute Hidden Layer(s)'s Neurons
            for (hiddenLayerIndex = 1; hiddenLayerIndex < totalLayers - 1; hiddenLayerIndex++)
            {
                ((HiddenLayer)_NeuralNetwork._ListOfLayers[hiddenLayerIndex]).Run();
            }
            //Execute Output Layer's Neuron
            _NeuralNetwork._OutputLayer.Run();
            return _NeuralNetwork._OutputLayer._ListOfNeurons[0]._Value;
        }

        public int DimensionsOfInputPattern
        {
            get {
                return _ListOfInputAttributes.Count;
            }
        }

        public DataRow PatternRow{
            get {
                return _PatternRow;
            }
            set {
                _PatternRow = value;
            }
        }
    }
}
