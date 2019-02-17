using System;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Qazi.Commons;
using Qazi.MachineLearningModels.MatthewsCorrelationCoefficientLib;
namespace Qazi.MachineLearningModels.NeuralNetworks
{
    public class TraintimeEngine : ObjectX
    {
        private RuntimeEngine _RuntimeEngine;
        private DataTable _TrainingData;
        private List<string> _ListOfInputAttributes;
        private string _OutputAttribute;
        private NeuralNetwork _NeuralNetwork;
        private Dictionary<int, float> _NeuronErrorDictionary;
        private float _Momentum;
        public float _TSSE;
        public float _RMSE;
        private MatthewsCorrelationCoefficientCalculator _MCCCalculator;
        private Dictionary<int ,float> _PreviousWeightDictionary;

        //Working Variable
        private DataRow patternRow;
        private int patternIndex;
        private float y;
        private float t;
        private int hiddenLayerIndex;
        private int totalLayers;
        private Layer layer;
        private int totalNeurons;
        private int neuronIndex;
        private Neuron neuron;
        private float error;
        private float postSynapticErrorSignal;
        private int totalPostSynapticNeurons;
        private int postSynapticNeuronIndex;
        private Neuron postSynapticNeuron;
        private Layer postLayer;
        private float postSynapticNeuronError;
        private SynapticConnection postSynapticConnection;
        private float deltaWeight;
        private SynapticConnection synaptic;
        private int synapticIndex;


        public TraintimeEngine(int id, NeuralNetwork nn, List<string> listOfInputAttributes, string outputAttribute, float momentum, float predictionThreshold, float positivePredictionLimit, float negativePredictionLimit)
        {
            _RuntimeEngine = new RuntimeEngine(id ,nn ,listOfInputAttributes);
            _ListOfInputAttributes = listOfInputAttributes;
            _OutputAttribute = outputAttribute;
            _NeuralNetwork = nn;
            _NeuronErrorDictionary = new Dictionary<int, float>();
            foreach (Neuron neuron in _NeuralNetwork._ListOfNeurons) {
                _NeuronErrorDictionary.Add(neuron.ID, 0.00f);
            }
            _MCCCalculator = new MatthewsCorrelationCoefficientCalculator(predictionThreshold ,positivePredictionLimit ,negativePredictionLimit);
            _Momentum = momentum;
            _PreviousWeightDictionary = new Dictionary<int ,float>();
            foreach (SynapticConnection synaptic in _NeuralNetwork._ListOfSynapticConnections) {
                _PreviousWeightDictionary.Add(synaptic.ID ,0.00f);
            }
        }

        public DataTable TrainingDataTable{
            get {
                return _TrainingData;
            }
            set {
                _TrainingData = value;
            }
        }

        public void Run(){
            if (TrainingDataTable == null) {
                throw new Exception("Training Engine (ID = " + ID.ToString() + " cannot start training because TrainingDataTable is Empty/NULL/Invalid");
            }
            _MCCCalculator.Reset();
            _TSSE = 0.00f;
            _RMSE = 0.00f;
            for (patternIndex = 0; patternIndex < InputPatternCount; patternIndex++){
                //Feed Farword
                patternRow = _TrainingData.Rows[patternIndex];
                _RuntimeEngine.PatternRow = patternRow;
                y = _RuntimeEngine.Run(); 
                //Feed Backword
                    //OutputLayer:- dpj=(Tpj-Ypj) Ypj (1-Ypj)
                t = float.Parse(patternRow[_OutputAttribute].ToString());
                _MCCCalculator.Update(t ,y);
                error = ((t - y) * y * (1 - y));
                neuron = _NeuralNetwork._OutputLayer._ListOfNeurons[0];
                _NeuronErrorDictionary[neuron.ID] = error;
                    //Compute TSSE and RMSE
                _TSSE = _TSSE + ((t - y) * (t - y))/2;
                _RMSE = (float)Math.Sqrt((2 * _TSSE) / InputPatternCount);
                    //HiddenLayer:- dpj= Ypj (1-Ypj) Sum(&pk Wkj); where &pk is the error post synaptic neuron k 
                totalLayers = _NeuralNetwork._ListOfLayers.Count;
                for (hiddenLayerIndex = totalLayers - 2; hiddenLayerIndex > 0; hiddenLayerIndex--){
                    layer = _NeuralNetwork._ListOfLayers[hiddenLayerIndex];
                    totalNeurons = layer._ListOfNeurons.Count;
                    for (neuronIndex = 0; neuronIndex < totalNeurons; neuronIndex++) {
                        neuron = layer._ListOfNeurons[neuronIndex];
                        y = neuron._Value;

                        postSynapticErrorSignal = 0;
                        postLayer = _NeuralNetwork._ListOfLayers[hiddenLayerIndex + 1];
                        for (postSynapticNeuronIndex = 0; postSynapticNeuronIndex < postLayer._ListOfNeurons.Count; postSynapticNeuronIndex++) {
                            postSynapticNeuron = postLayer._ListOfNeurons[postSynapticNeuronIndex];
                            postSynapticNeuronError = _NeuronErrorDictionary[postSynapticNeuron.ID];
                            postSynapticConnection = _NeuralNetwork._SourceTargetNeuronSynapticDictionary[neuron.ID.ToString() + "-" + postSynapticNeuron.ID.ToString()];
                            postSynapticErrorSignal = postSynapticErrorSignal + (postSynapticNeuronError * postSynapticConnection._Weight);
                        }
                        error = y * (1 - y) * postSynapticErrorSignal;
                        _NeuronErrorDictionary[neuron.ID] = error;
                    }
                }
            //Change Weights
                for (synapticIndex = 0; synapticIndex < _NeuralNetwork._ListOfSynapticConnections.Count; synapticIndex++) {
                    
                    synaptic = _NeuralNetwork._ListOfSynapticConnections[synapticIndex];
                    deltaWeight = synaptic._SourceNeuron._Value * _NeuronErrorDictionary[synaptic._TargetNeuron.ID] * _NeuralNetwork._LearningRate;
                    synaptic._Weight = synaptic._Weight + deltaWeight + (_Momentum * _PreviousWeightDictionary[synaptic.ID]);
                    _PreviousWeightDictionary[synaptic.ID] = deltaWeight;
                    
                }
         //Progress report
                // _NeuralNetwork.RaiseTaskProgressEvent(this ,((((float)(patternIndex + 1)) / ((float)(InputPatternCount))) * 100) ,"Training Engine Learning Pattern No: " + patternIndex.ToString() + " of " + InputPatternCount.ToString());
            }
        }

        private int InputPatternCount
        {
            get {
                return _TrainingData.Rows.Count;
            }
        }

        public MatthewsCorrelationCoefficientCalculator PerformanceEvaluation
        {
            get {
                return _MCCCalculator;
            }
        }

        
    }
}
