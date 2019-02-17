using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Qazi.Commons;
using Qazi.Common;

namespace Qazi.MachineLearningModels.NeuralNetworks
{
    public class NeuralNetwork : ObjectX, IDisposable 
    {
        public WorkerCompletedEventArg  NeuralNetworkTaskCompletedArgs;
        public WorkerProgressEventArg   NeuralNetworkTaskProgressArgs;
        public WorkerStartedEventArg    NeuralNetworkTaskStartedArgs;

        public event WorkerCompletedEventHandler NeuralNetworkTaskCompleted;
        public event WorkerProgressUpdateEventHandler NeuralNetworkTaskProgress;
        public event WorkerStartedWithStatusUpdateEventHandler NeuralNetworkTaskStarted;

        internal List<Neuron> _ListOfNeurons;
        internal List<SynapticConnection> _ListOfSynapticConnections;
        internal List<Layer> _ListOfLayers;
        internal InputLayer _InputLayer;
        internal OutputLayer _OutputLayer;
        internal Dictionary<string ,SynapticConnection> _SourceTargetNeuronSynapticDictionary;
        
        internal float _LearningRate;
        internal string _TopoloyString;

        public void Dispose()
        { 
        
        }

        public NeuralNetwork(int id)
        {
            ID = id;
            
            NeuralNetworkTaskCompletedArgs = new WorkerCompletedEventArg();
            NeuralNetworkTaskProgressArgs = new WorkerProgressEventArg();
            NeuralNetworkTaskStartedArgs = new WorkerStartedEventArg();
        }

        public void CreateNetwork(string topoloy ,float learningRate)
        {
            #region Initialization
            RaiseTaskStartedEvent(this, "Constructing Network Topology: " + topoloy);
            _ListOfLayers = new List<Layer>();
            _ListOfNeurons = new List<Neuron>();
            _ListOfSynapticConnections = new List<SynapticConnection>();
            _SourceTargetNeuronSynapticDictionary = new Dictionary<string ,SynapticConnection>();
            int neuronid, layerid, synapticid;
            neuronid = 0;
            layerid = 0;
            synapticid = 0;
            _TopoloyString = topoloy;
            char[] sep = { ',' };
            string[] toplogyarray = topoloy.Split(sep);
            int numberofneurons = int.Parse(toplogyarray[0]);
            int index;
            Neuron neuron;
            float progress;
            #endregion Initialization
            _LearningRate = learningRate;
            #region InputLayer Code
            layerid++;
            _InputLayer = new InputLayer(layerid, this);
            _ListOfLayers.Add(_InputLayer);
            RaiseTaskProgressEvent(this, 0.00f, "Adding Neurons to Input Layer");
            for (index = 1; index <= numberofneurons; index++)
            {
                neuronid++;
                neuron = new Neuron(neuronid, _InputLayer);
                _InputLayer.AddNeurons(neuron);
                _ListOfNeurons.Add(neuron);
                progress = ((float)(index)/(float)(numberofneurons))*100;
                RaiseTaskProgressEvent(this, progress, "");
            }
            RaiseTaskProgressEvent(this, 0.00f, _InputLayer._ListOfNeurons.Count.ToString() + " Neuron(s) Has Been Added in InputLayer");
            #endregion InputLayer Code

            #region HiddenLayer Code
            int hiddenLayerIndex;
            HiddenLayer hiddenLayer;
            
            for (hiddenLayerIndex = 1; hiddenLayerIndex < toplogyarray.Length - 1; hiddenLayerIndex++)
            {
                layerid++;
                RaiseTaskProgressEvent(this, 0.00f, "Adding Neurons to Hidden Layer No.: " + hiddenLayerIndex.ToString());
                numberofneurons = int.Parse(toplogyarray[hiddenLayerIndex]);
                hiddenLayer = new HiddenLayer(layerid, this);
                for (index = 1; index <= numberofneurons; index++)
                {
                    neuronid++;
                    neuron = new Neuron(neuronid, hiddenLayer);
                    hiddenLayer.AddNeurons(neuron);
                    _ListOfNeurons.Add(neuron);
                    progress = ((float)(index) / (float)(numberofneurons)) * 100;
                    RaiseTaskProgressEvent(this, progress, "");
                }
                _ListOfLayers.Add(hiddenLayer);
                progress = ((float)(hiddenLayerIndex) / (float)(toplogyarray.Length - 1)) * 100;
                RaiseTaskProgressEvent(this, progress, "");
                RaiseTaskProgressEvent(this, 0.00f, hiddenLayer._ListOfNeurons.Count.ToString() + " Neuron(s) Has Been Added in HiddenLayer No.: " + hiddenLayerIndex.ToString()); 
            }
            #endregion HiddenLayer Code

            #region OutputLayer Code
            RaiseTaskProgressEvent(this, 0.00f, "Adding Neurons to OutputLayer");
            layerid++;
            _OutputLayer = new OutputLayer(layerid, this);
            neuronid++;
            neuron = new Neuron(neuronid, _OutputLayer);
            _OutputLayer.AddNeurons(neuron);
            _ListOfLayers.Add(_OutputLayer);
            _ListOfNeurons.Add(neuron);
            RaiseTaskProgressEvent(this, 100.00f, "");
            RaiseTaskProgressEvent(this, 0.00f, _OutputLayer._ListOfNeurons.Count.ToString() + " Neuron(s) Has Been Added in OutputLayer");
            #endregion OutputLayer Code

            Neuron sourceNeuron, targetNeuron;
            int sourceNeuronIndex, targetNeuronIndex;
            int sourceLayerIndex, targetLayerIndex;
            int totalSourceNeurons, totalTargetNeurons;
            int totalSourceLayer, totalTargetLayer;
            Layer sourceLayer, targetLayer;
            SynapticConnection synapticConnection;
            float weight;
            Random rnd = new Random();
            Random rndSign = new Random();

            #region Input - First Hidden Synapyic Connection Creation Code
            RaiseTaskProgressEvent(this, 0.00f, "Creating Synaptic Connection Between Input - Hidden Layer No.: 1");
            sourceLayer = _InputLayer;
            targetLayer = _ListOfLayers[1];
            totalSourceNeurons = sourceLayer._ListOfNeurons.Count;
            totalTargetNeurons = targetLayer._ListOfNeurons.Count;
            for (sourceNeuronIndex = 0; sourceNeuronIndex < totalSourceNeurons; sourceNeuronIndex++)
            {
                sourceNeuron = sourceLayer._ListOfNeurons[sourceNeuronIndex];
                for (targetNeuronIndex = 0; targetNeuronIndex < totalTargetNeurons; targetNeuronIndex++)
                {
                    weight = (float)rnd.NextDouble();
                    if (((float)rndSign.NextDouble()) < 0.5)
                        weight = weight * -1;
                    
                    targetNeuron = targetLayer._ListOfNeurons[targetNeuronIndex];
                    synapticid++;
                    synapticConnection = new SynapticConnection(synapticid, sourceNeuron, targetNeuron, weight);
                    sourceNeuron._ListOfOutputSynaptics.Add(synapticConnection);
                    targetNeuron._ListOfInputSynaptics.Add(synapticConnection);
                    _ListOfSynapticConnections.Add(synapticConnection);
                    _SourceTargetNeuronSynapticDictionary.Add(sourceNeuron.ID.ToString() + "-" + targetNeuron.ID.ToString() ,synapticConnection);
                }
                progress = ((float)(sourceNeuronIndex + 1) / (float)(totalSourceNeurons)) * 100;
                RaiseTaskProgressEvent(this, progress, "");
            }
            #endregion Input - First Hidden Synapyic Connection Creation Code

            #region Hidden to Hidden Synapyic Connection Creation Code
            totalSourceLayer = _ListOfLayers.Count-3;
            totalTargetLayer = _ListOfLayers.Count-1;
            for (sourceLayerIndex = 1; sourceLayerIndex <= totalSourceLayer; sourceLayerIndex++)
            {
                sourceLayer = _ListOfLayers[sourceLayerIndex];
                //for (targetLayerIndex = sourceLayerIndex + 1; targetLayerIndex < totalTargetLayer; targetLayerIndex++)
                //{
                targetLayerIndex = sourceLayerIndex + 1;    
                RaiseTaskProgressEvent(this, 0.00f, "Creating Synaptic Connection Between Hidden Layer No.: " + sourceLayerIndex.ToString() + " - Hidden Layer No.: " + targetLayerIndex.ToString());
                    
                    targetLayer = _ListOfLayers[targetLayerIndex];
                    totalSourceNeurons = sourceLayer._ListOfNeurons.Count;
                    totalTargetNeurons = targetLayer._ListOfNeurons.Count;
                    for (sourceNeuronIndex = 0; sourceNeuronIndex < totalSourceNeurons; sourceNeuronIndex++)
                    {
                        sourceNeuron = sourceLayer._ListOfNeurons[sourceNeuronIndex];
                        for (targetNeuronIndex = 0; targetNeuronIndex < totalTargetNeurons; targetNeuronIndex++)
                        {
                            weight = (float)rnd.NextDouble();
                            if (((float)rndSign.NextDouble()) < 0.5)
                                weight = weight * -1;

                            targetNeuron = targetLayer._ListOfNeurons[targetNeuronIndex];
                            synapticid++;
                            synapticConnection = new SynapticConnection(synapticid, sourceNeuron, targetNeuron, weight);
                            sourceNeuron._ListOfOutputSynaptics.Add(synapticConnection);
                            targetNeuron._ListOfInputSynaptics.Add(synapticConnection);
                            _ListOfSynapticConnections.Add(synapticConnection);
                            _SourceTargetNeuronSynapticDictionary.Add(sourceNeuron.ID.ToString() + "-" + targetNeuron.ID.ToString() ,synapticConnection);
                        }
                   }
                //}
                   progress = ((float)(sourceLayerIndex) / (float)(totalSourceLayer)) * 100;
                   RaiseTaskProgressEvent(this, progress, "");
            }
            #endregion Hidden to Hidden Synapyic Connection Creation Code

            #region Hidden to Output Synapyic Connection Creation Code
            RaiseTaskProgressEvent(this, 0.00f, "Creating Synaptic Connection Between Last Hidden Layer and Output Layer");
            sourceLayer = _ListOfLayers[_ListOfLayers.Count-2];
            targetLayer = _OutputLayer;
            totalSourceNeurons = sourceLayer._ListOfNeurons.Count;
            totalTargetNeurons = targetLayer._ListOfNeurons.Count;
            for (sourceNeuronIndex = 0; sourceNeuronIndex < totalSourceNeurons; sourceNeuronIndex++)
            {
                sourceNeuron = sourceLayer._ListOfNeurons[sourceNeuronIndex];
                for (targetNeuronIndex = 0; targetNeuronIndex < totalTargetNeurons; targetNeuronIndex++)
                {
                    weight = (float)rnd.NextDouble();
                    if (((float)rndSign.NextDouble()) < 0.5)
                        weight = weight * -1;

                    targetNeuron = targetLayer._ListOfNeurons[targetNeuronIndex];
                    synapticid++;
                    synapticConnection = new SynapticConnection(synapticid, sourceNeuron, targetNeuron, weight);
                    sourceNeuron._ListOfOutputSynaptics.Add(synapticConnection);
                    targetNeuron._ListOfInputSynaptics.Add(synapticConnection);
                    _ListOfSynapticConnections.Add(synapticConnection);
                    _SourceTargetNeuronSynapticDictionary.Add(sourceNeuron.ID.ToString() + "-" + targetNeuron.ID.ToString() ,synapticConnection);
                }
                progress = ((float)(sourceNeuronIndex + 1) / (float)(totalSourceNeurons)) * 100;
                RaiseTaskProgressEvent(this, progress, "");
            }
            #endregion Hidden to Output Synapyic Connection Creation Code
            RaiseTaskProgressEvent(this, 0.00f, "Total Synaptic Connections in Network (Network ID = " + ID.ToString() +") are = " + _ListOfSynapticConnections.Count.ToString());
            RaiseTaskCompleted(this, null, "Topology Construction Completed...");
        }

        public void OverrideWeights(Dictionary<string, float> weightsConfiguration)
        {
            RaiseTaskStartedEvent(this, "Overriding Weights");
            SynapticConnection synapticConnection;
            float totalSynaptics = weightsConfiguration.Count; 
            float ctr = 1;
            float progress;
            float weight;
            foreach (string connectionKey in weightsConfiguration.Keys)
            { 
                synapticConnection = _SourceTargetNeuronSynapticDictionary[connectionKey];
                weight = weightsConfiguration[connectionKey];
                synapticConnection._Weight = weight;
                progress = ((ctr / totalSynaptics) * 100);
                RaiseTaskProgressEvent(this, progress, "Overriding connection (ID = " + synapticConnection.ID.ToString() + "): " + connectionKey + " by weight : " + weight.ToString());
                ctr++;
            }
            RaiseTaskCompleted(this, null, "All synaptic connection weights are updated");
        }

        internal void RaiseTaskStartedEvent(object sender, string userstate)
        {
            if (NeuralNetworkTaskStarted != null)
            {
                NeuralNetworkTaskStartedArgs.UserState = userstate;
                NeuralNetworkTaskStarted(sender,NeuralNetworkTaskStartedArgs);
            }
        }

        internal void RaiseTaskProgressEvent(object sender, float percentage, string userstate)
        {
            if (NeuralNetworkTaskProgress != null)
            {
                NeuralNetworkTaskProgressArgs.AssociatedData = null;
                NeuralNetworkTaskProgressArgs.ProgressPercentage = percentage;
                NeuralNetworkTaskProgressArgs.UserState = userstate;
                NeuralNetworkTaskProgress(sender, NeuralNetworkTaskProgressArgs);
            }
        }

        internal void RaiseTaskCompleted(object sender, object result, string userStateMessage)
        {
            if (NeuralNetworkTaskCompleted != null)
            {
                NeuralNetworkTaskCompletedArgs.Result = result;
                NeuralNetworkTaskCompletedArgs.UserStateMessage = userStateMessage;
                NeuralNetworkTaskCompleted(sender, NeuralNetworkTaskCompletedArgs);
            }
        }

        public DataTable GetWeightsDataTable()
        {
            DataTable dt = new DataTable("Weights DataTable");
            dt.Columns.Add("SynapticID");
            dt.Columns.Add("SourceLayerID");
            dt.Columns.Add("TargetLayerID");
            dt.Columns.Add("Weight");
            
            DataRow row;
            foreach (string id in _SourceTargetNeuronSynapticDictionary.Keys)
            {
                row = dt.NewRow();
                row["Weight"] = _SourceTargetNeuronSynapticDictionary[id]._Weight;
                row["SynapticID"] = id;
                row["SourceLayerID"] = _SourceTargetNeuronSynapticDictionary[id]._SourceNeuron._ContainerLayer.ID.ToString();
                row["TargetLayerID"] = _SourceTargetNeuronSynapticDictionary[id]._TargetNeuron._ContainerLayer.ID.ToString();
                dt.Rows.Add(row);
            }
            return dt;
        }
    }
}

