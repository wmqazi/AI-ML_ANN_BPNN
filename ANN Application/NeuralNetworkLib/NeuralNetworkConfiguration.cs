using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Qazi.BinaryFileIOManager;

namespace Qazi.MachineLearningModels.NeuralNetworks
{
    [Serializable]
    public class NeuralNetworkConfiguration
    {
        public int ID;
        public string TopoloyString;
        public float LearningRate;
        public Dictionary<string, float> WeightConfiguration;

        public NeuralNetworkConfiguration(NeuralNetwork nn)
        {
            ID = nn.ID;
            TopoloyString = nn._TopoloyString;
            LearningRate = nn._LearningRate;
            WeightConfiguration = new Dictionary<string, float>();
            float weight;
            foreach (string synapticKey in nn._SourceTargetNeuronSynapticDictionary.Keys)
            {
                weight = nn._SourceTargetNeuronSynapticDictionary[synapticKey]._Weight;
                WeightConfiguration.Add(synapticKey, weight);
            }
        }
        public NeuralNetworkConfiguration()
        {}
    }


    [Serializable]
    public class TrainingSession
    { 
        public NeuralNetworkConfiguration NeuralNetworkArchiecture;
        public string TrainingDataTablePath;
        public string NameOfTrainingDataTable;
        public string ValidationDataTablePath;
        public string NameOfValidationDataTable;
        public int LearningIterations;
        public int CompletedLearningIterations;
        public float Momentum;
        public List<string> ListOfInputAttributes;
        public string OutputAttribute;
        public float AcceptableRMS;
        public float PredictionThreashold;
        public float PositiveClassificationLevel;
        public float NegativeClassificationLevel;



    }

    public class NeuralNetworkSerializationManager
    {
        public static void Save(NeuralNetworkConfiguration  nnc, string fileName)
        {
            BinaryFileSerializationManager fileManager = new BinaryFileSerializationManager();
            fileManager.Save(fileName, nnc);
        }

        public static NeuralNetworkConfiguration Open(string fileName)
        {
            BinaryFileSerializationManager fileManager = new BinaryFileSerializationManager();
            NeuralNetworkConfiguration nnc = (NeuralNetworkConfiguration)fileManager.Open(fileName);
            return nnc;
        }

    }
}
