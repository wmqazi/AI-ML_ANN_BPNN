using System;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Qazi.Commons;

namespace Qazi.MachineLearningModels.NeuralNetworks
{
    public class TraintimeEngine : ObjectX
    {
        private RuntimeEngine _RuntimeEngine;
        private DataTable _TrainingData;
        private StringCollection _ListOfInputAttributes;
        private string _OutputAttribute;
        private NeuralNetwork _NeuralNetwork;

        //Working Variable
        private DataRow patternRow;
        private int patternIndex;

        public TraintimeEngine(int id,NeuralNetwork nn, StringCollection listOfInputAttributes, string outputAttribute){
            _RuntimeEngine = new RuntimeEngine(id ,nn ,listOfInputAttributes);
            _ListOfInputAttributes = listOfInputAttributes;
            _OutputAttribute = outputAttribute;
            _NeuralNetwork = nn;
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

            for (patternIndex = 0; patternIndex < InputPatternCount; patternIndex++){
                patternRow = _TrainingData.Rows[patternIndex];
                _RuntimeEngine.PatternRow = patternRow;
                _RuntimeEngine.Run(); //Feed Farword

                //Feed Backwork

                //Progress report
               // _NeuralNetwork.RaiseTaskProgressEvent(this ,((((float)(patternIndex + 1)) / ((float)(InputPatternCount))) * 100) ,"Training Engine Learning Pattern No: " + patternIndex.ToString() + " of " + InputPatternCount.ToString());
            }
        }

        private int InputPatternCount {
            get {
                return _TrainingData.Rows.Count;
            }
        }

        
    }
}
