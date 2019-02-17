using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Qazi.MachineLearningModels.NeuralNetworks;
using Qazi.MachineLearningModels.MatthewsCorrelationCoefficientLib;
using Qazi.GUI.CommonDialogs;

namespace Qazi.MachineLearningModels.NeuralNetworks
{
    public partial class NeuralNetworkMainConsole : Form
    {
        private DataTable _TrainingDataTable;
        private DataTable _ValidationDataTable;
        private NeuralNetwork _NeuralNetwork;
        private TraintimeEngine _TraintimeEngine;
        private List<string> _ListOfInputAttributes;
        private ValidationEngine _ValidationEngine; 

        private int _TotalIterations;
        private int _IterationIndex;
       

        //Working Variables
        private float tolerableError;
        private float predictionThreshold;
        private float positivePredictionLimit;
        private float negativePredictionLimit;

        public NeuralNetworkMainConsole()
        {
            InitializeComponent();
            TotalIterations = 0;
            IterationIndex = 0;
        }

        private void loadTrainingDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openTrainingDataDlg.ShowDialog(this);
        }

        private void openTrainingDataDlg_FileOk(object sender, CancelEventArgs e)
        {

            DataTableSelectorWnd dts;
            DataSet ds;
            ds = new DataSet();
            ds.ReadXml(openTrainingDataDlg.FileName);
            dts = new DataTableSelectorWnd("Select Training DataTable", ds);
            dts.ShowDialog(this);
            lstInputAttributes.Items.Clear();
            cmbOutputAttribute.Items.Clear();
            _TrainingDataTable = ds.Tables[dts.TableName];
            grdTrainingData.DataSource = _TrainingDataTable;
            lblTrainingDataCount.Text = "Training Data Record Count: " +_TrainingDataTable.Rows.Count.ToString();
            int colCtr = 0;
            foreach (DataColumn col in _TrainingDataTable.Columns)
            {
                lstInputAttributes.Items.Add(col.ColumnName);
                lstInputAttributes.SetItemCheckState(colCtr, CheckState.Checked);
                cmbOutputAttribute.Items.Add(col.ColumnName);
                colCtr++;
            }

        }

        private void loadValidationDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openValidationDataDlg.ShowDialog(this);
        }

        private void openValidationDataDlg_FileOk(object sender, CancelEventArgs e)
        {
            DataTableSelectorWnd dts;
            DataSet ds;
            ds = new DataSet();
            ds.ReadXml(openValidationDataDlg.FileName);
            dts = new DataTableSelectorWnd("Select Validation DataTable", ds);
            dts.ShowDialog(this);
            _ValidationDataTable = ds.Tables[dts.TableName];
            grdValidationData.DataSource = _ValidationDataTable;
            lblValidationDataCount.Text = "Validation Data Record Count:" + _ValidationDataTable.Rows.Count.ToString();
        }

        private void constructNeuralNetworkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TotalIterations = int.Parse(txtLearningIterations.Text);
            IterationIndex = 0;
            predictionThreshold = float.Parse(txtPredictionThreshold.Text);
            positivePredictionLimit = float.Parse(txtPostiveClassificationLevel.Text);
            negativePredictionLimit = float.Parse(txtNegativeClassificationLevel.Text);
            richTextBox1.Text = "";
            txtInputNeurons.Text = lstInputAttributes.CheckedItems.Count.ToString();
            string topology = "";
            topology = txtInputNeurons.Text + "," + txtHiddenLayerNeuronConfiguration.Text + "," + txtNumberOfOutputNeurons.Text;

            _NeuralNetwork = new NeuralNetwork(1);
            _NeuralNetwork.NeuralNetworkTaskCompleted += new Qazi.Common.WorkerCompletedEventHandler(_NeuralNetwork_NeuralNetworkTaskCompleted);
            _NeuralNetwork.NeuralNetworkTaskProgress += new Qazi.Common.WorkerProgressUpdateEventHandler(_NeuralNetwork_NeuralNetworkTaskProgress);
            _NeuralNetwork.NeuralNetworkTaskStarted += new Qazi.Common.WorkerStartedWithStatusUpdateEventHandler(_NeuralNetwork_NeuralNetworkTaskStarted);    
            _NeuralNetwork.CreateNetwork(topology, float.Parse(txtLearningRate.Text));

            if (_ListOfInputAttributes != null){
                if (_ListOfInputAttributes.Count > 0)
                    _ListOfInputAttributes.Clear();
            }
            else
                _ListOfInputAttributes = new List<string>();

            foreach (object o in lstInputAttributes.CheckedItems) {
                _ListOfInputAttributes.Add(o.ToString());
            }
            _TraintimeEngine = new TraintimeEngine(1 ,_NeuralNetwork ,_ListOfInputAttributes ,cmbOutputAttribute.Text ,float.Parse(txtMomentum.Text) ,predictionThreshold ,positivePredictionLimit ,negativePredictionLimit);
            _ValidationEngine = new ValidationEngine(1 ,_NeuralNetwork ,_ListOfInputAttributes ,cmbOutputAttribute.Text ,predictionThreshold ,positivePredictionLimit ,negativePredictionLimit);
        }

        void _NeuralNetwork_NeuralNetworkTaskStarted(object sender, Qazi.Common.WorkerStartedEventArg e)
        {
            ShowConsoleMessage(e.UserState);
        }

        void _NeuralNetwork_NeuralNetworkTaskProgress(object sender, Qazi.Common.WorkerProgressEventArg e)
        {
            progressbar.Value = (int)e.ProgressPercentage;
            ShowConsoleMessage(e.UserState);
        }

        void _NeuralNetwork_NeuralNetworkTaskCompleted(object sender, Qazi.Common.WorkerCompletedEventArg e)
        {
            ShowConsoleMessage(e.UserStateMessage);
        }

        private void ShowConsoleMessage(string msg)
        {
            if (msg != "")
            {
               // richTextBox1.AppendText(msg + Environment.NewLine);
               // richTextBox1.ScrollToCaret();
                richTextBox1.Text = msg;
            }
            Application.DoEvents();
        }

        private void trainToolStripMenuItem_Click(object sender ,EventArgs e)
        {
            bool terminateLoop = false;
            ShowConsoleMessage("Staring training in 'batch' mode [CurrentIterationIndex = " + IterationIndex.ToString() );
            tolerableError = float.Parse(txtAcceptableRMS.Text);
            
            _TraintimeEngine.TrainingDataTable = _TrainingDataTable;
            TotalIterations = TotalIterations + int.Parse(txtLearningIterations.Text);
            
            //for (; IterationIndex <= TotalIterations; IterationIndex++)
            while(!terminateLoop)
            {
                _TraintimeEngine.Run();
                
                //ShowConsoleMessage("Error in Iteration No. " + IterationIndex.ToString() + " was: " + _TraintimeEngine._RMSE.ToString() + " and MCC was: " + _TraintimeEngine.PerformanceEvaluation.MCC.ToString() +  );
                DisplayClassifierPeformanceDuringTraining();

                if (_TraintimeEngine._RMSE <= tolerableError)
                    terminateLoop = true;

                if(IterationIndex == TotalIterations)
                    terminateLoop = true;

                if(terminateLoop == false)
                    IterationIndex++;

                progressbar.Value = (int)((((float)IterationIndex)/((float)TotalIterations)) * 100);
                Application.DoEvents();
            }
            ShowConsoleMessage("'Batch' mode training completed");
        }

        private void DisplayClassifierPeformanceDuringTraining()
        {
            txtIteration.Text = IterationIndex.ToString();
            txtMCCTraining.Text = _TraintimeEngine.PerformanceEvaluation.MCC.ToString();
            txtSensitivityTraining.Text = _TraintimeEngine.PerformanceEvaluation.Sensitivity.ToString();
            txtSpecificityTraining.Text = _TraintimeEngine.PerformanceEvaluation.Specificity.ToString();
            txtRMSETraining.Text = _TraintimeEngine._RMSE.ToString();
            txtAccuracyTraining.Text = _TraintimeEngine.PerformanceEvaluation.Accuracy.ToString();
        }

        private void trainSingleStepToolStripMenuItem_Click(object sender ,EventArgs e)
        {
            tolerableError = float.Parse(txtAcceptableRMS.Text);
            ShowConsoleMessage("Staring training in 'step' mode");
            if (_TraintimeEngine._RMSE > tolerableError){
                IterationIndex++;
                _TraintimeEngine.TrainingDataTable = _TrainingDataTable;
                _TraintimeEngine.Run();
            }
            //ShowConsoleMessage("Error in Iteration No. " + IterationIndex.ToString() + " was: " + _TraintimeEngine._RMSE.ToString() + " and MCC was: " + _TraintimeEngine.MCC.ToString());
            DisplayClassifierPeformanceDuringTraining();
            ShowConsoleMessage("'Step' mode training completed");
        }

        private int IterationIndex {
            get {
                return _IterationIndex;
            }
            set {
                _IterationIndex = value;
                lblStatus.Text = "Learning Iteration Status: " + _IterationIndex.ToString() + "/" + _TotalIterations.ToString();
            }
        }

        private int TotalIterations{
            get{
                return _TotalIterations;
            }
            set{
                _TotalIterations = value;
                lblStatus.Text = "Learning Iteration Status: " + _IterationIndex.ToString() + "/" + _TotalIterations.ToString();
            }
        }

        private void validateToolStripMenuItem_Click(object sender ,EventArgs e)
        {
            ShowConsoleMessage("Staring validation process");
            _ValidationEngine._ValidationDataTable = _ValidationDataTable;
            _ValidationEngine.Run();
            //ShowConsoleMessage("Validation process completed with MCC = " + _ValidationEngine.MCC.ToString());
            DisplayClassifierPeformanceDuringValidation();
        }

        private void DisplayClassifierPeformanceDuringValidation()
        {

            //txtIteration.Text = IterationIndex.ToString();
            txtMCCValidation.Text = _ValidationEngine.PerformanceEvaluation.MCC.ToString();
            txtSensitivityValidation.Text = _ValidationEngine.PerformanceEvaluation.Sensitivity.ToString();
            txtSpecificityValidation.Text = _ValidationEngine.PerformanceEvaluation.Specificity.ToString();
            txtAccuracyValidation.Text = _ValidationEngine.PerformanceEvaluation.Accuracy.ToString();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveNeuralNetworkConfiguration.ShowDialog();
        }

        private void saveNeuralNetworkConfiguration_FileOk(object sender, CancelEventArgs e)
        {
            NeuralNetworkConfiguration nnc = new NeuralNetworkConfiguration(_NeuralNetwork);
            NeuralNetworkSerializationManager.Save(nnc, saveNeuralNetworkConfiguration.FileName);
            MessageBox.Show("Archiecture Saved");
        }

        private void opnNeuralNetworkConfiguration_FileOk(object sender, CancelEventArgs e)
        {
            NeuralNetworkConfiguration nnc = NeuralNetworkSerializationManager.Open(opnNeuralNetworkConfiguration.FileName);
            if (_NeuralNetwork != null)
            {
                _NeuralNetwork.Dispose();
                _NeuralNetwork = null;
            }
        }

        private void showWeightsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = _NeuralNetwork.GetWeightsDataTable();
            DataTableViewerWnd dtvwnd = new DataTableViewerWnd(dt);
            dtvwnd.Show(this);
        }
    }
}