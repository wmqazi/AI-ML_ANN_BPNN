using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using System.Data;
using Qazi.Commons;
using Qazi.MachineLearningModels.MatthewsCorrelationCoefficientLib;

namespace Qazi.MachineLearningModels.NeuralNetworks
{
    public class ValidationEngine:ObjectX
    {
        private RuntimeEngine _RuntimeEngine;
        public DataTable _ValidationDataTable;
        public List<string> _ListOfInputAttributes;
        public string _OutputAttribute;
        public NeuralNetwork _NeuralNetwork;
        public MatthewsCorrelationCoefficientCalculator _MCCCalculator;

        //Working Variables
        private DataRow patternRow;
        private int patternIndex;
        private float y;
        private float t;
        private string predictionResult;

        public ValidationEngine(int id, NeuralNetwork neuralNetwork, List<string> listOfInputAttributes, string outputAttribute, float predictionThreshold, float positivePredictionLimit, float negativePredictionLimit)
        {
            ID = id;
            _NeuralNetwork = neuralNetwork;
            _ListOfInputAttributes = listOfInputAttributes;
            _OutputAttribute = outputAttribute;
            _RuntimeEngine = new RuntimeEngine(1 ,neuralNetwork ,listOfInputAttributes);
            _MCCCalculator = new MatthewsCorrelationCoefficientCalculator(predictionThreshold ,positivePredictionLimit ,negativePredictionLimit);
        }

        public void Run()
        {
            if (_ValidationDataTable == null)
            {
                throw new Exception("Validation Engine (ID = " + ID.ToString() + " cannot start training because TrainingDataTable is Empty/NULL/Invalid");
            }
            _MCCCalculator.Reset();
            for (patternIndex = 0; patternIndex < InputPatternCount; patternIndex++)
            {
                //Feed Farword
                patternRow = _ValidationDataTable.Rows[patternIndex];
                _RuntimeEngine.PatternRow = patternRow;
                y = _RuntimeEngine.Run();
                //Feed Backword
                //OutputLayer:- dpj=(Tpj-Ypj) Ypj (1-Ypj)
                t = float.Parse(patternRow[_OutputAttribute].ToString());
                predictionResult = _MCCCalculator.Update(t ,y);
                _NeuralNetwork.RaiseTaskProgressEvent(this, 0.00f ,"Validation result of pattern no. " + ((int)(patternIndex + 1)).ToString() + " is T = " + t.ToString() + " and Y = " + y.ToString() + " difference is: " + ((float)(t - y)).ToString() + " [" + predictionResult + "]");
            }
            
        }

        private int InputPatternCount
        {
            get
            {
                return _ValidationDataTable.Rows.Count;
            }
        }

        public MatthewsCorrelationCoefficientCalculator PerformanceEvaluation
        {
            get
            {
                return _MCCCalculator;
            }
        }

        
    }
}
