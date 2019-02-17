namespace Qazi.MachineLearningModels.NeuralNetworks
{
    partial class NeuralNetworkMainConsole
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTrainingDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadValidationDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveNeuralNetworkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuralNetworkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.constructNeuralNetworkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.trainSingleStepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.validateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.openTrainingDataDlg = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openValidationDataDlg = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grdTrainingData = new System.Windows.Forms.DataGridView();
            this.lblTrainingDataCount = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grdValidationData = new System.Windows.Forms.DataGridView();
            this.lblValidationDataCount = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNegativeClassificationLevel = new System.Windows.Forms.TextBox();
            this.txtPredictionThreshold = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbOutputAttribute = new System.Windows.Forms.ComboBox();
            this.txtPostiveClassificationLevel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lstInputAttributes = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNumberOfOutputNeurons = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtHiddenLayerNeuronConfiguration = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtInputNeurons = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMomentum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLearningRate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAcceptableRMS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLearningIterations = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtAccuracyValidation = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtSpecificityValidation = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtSensitivityValidation = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtMCCValidation = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtRMSETraining = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtAccuracyTraining = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtSpecificityTraining = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtSensitivityTraining = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtMCCTraining = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtIteration = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.progressbar = new System.Windows.Forms.ProgressBar();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.saveNeuralNetworkConfiguration = new System.Windows.Forms.SaveFileDialog();
            this.opnNeuralNetworkConfiguration = new System.Windows.Forms.OpenFileDialog();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.showWeightsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTrainingData)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdValidationData)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.neuralNetworkToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1013, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadTrainingDataToolStripMenuItem,
            this.loadValidationDataToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveNeuralNetworkToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // loadTrainingDataToolStripMenuItem
            // 
            this.loadTrainingDataToolStripMenuItem.Name = "loadTrainingDataToolStripMenuItem";
            this.loadTrainingDataToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.loadTrainingDataToolStripMenuItem.Text = "Load Training Data";
            this.loadTrainingDataToolStripMenuItem.Click += new System.EventHandler(this.loadTrainingDataToolStripMenuItem_Click);
            // 
            // loadValidationDataToolStripMenuItem
            // 
            this.loadValidationDataToolStripMenuItem.Name = "loadValidationDataToolStripMenuItem";
            this.loadValidationDataToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.loadValidationDataToolStripMenuItem.Text = "Load Validation Data";
            this.loadValidationDataToolStripMenuItem.Click += new System.EventHandler(this.loadValidationDataToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(218, 6);
            // 
            // saveNeuralNetworkToolStripMenuItem
            // 
            this.saveNeuralNetworkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem});
            this.saveNeuralNetworkToolStripMenuItem.Name = "saveNeuralNetworkToolStripMenuItem";
            this.saveNeuralNetworkToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.saveNeuralNetworkToolStripMenuItem.Text = "Neural Network Archiecture";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // neuralNetworkToolStripMenuItem
            // 
            this.neuralNetworkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.constructNeuralNetworkToolStripMenuItem,
            this.toolStripSeparator2,
            this.trainSingleStepToolStripMenuItem,
            this.trainToolStripMenuItem,
            this.toolStripSeparator3,
            this.validateToolStripMenuItem,
            this.toolStripSeparator4,
            this.showWeightsToolStripMenuItem});
            this.neuralNetworkToolStripMenuItem.Name = "neuralNetworkToolStripMenuItem";
            this.neuralNetworkToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.neuralNetworkToolStripMenuItem.Text = "Neural Network";
            // 
            // constructNeuralNetworkToolStripMenuItem
            // 
            this.constructNeuralNetworkToolStripMenuItem.Name = "constructNeuralNetworkToolStripMenuItem";
            this.constructNeuralNetworkToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.constructNeuralNetworkToolStripMenuItem.Text = "Construct Neural Network";
            this.constructNeuralNetworkToolStripMenuItem.Click += new System.EventHandler(this.constructNeuralNetworkToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(209, 6);
            // 
            // trainSingleStepToolStripMenuItem
            // 
            this.trainSingleStepToolStripMenuItem.Name = "trainSingleStepToolStripMenuItem";
            this.trainSingleStepToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.trainSingleStepToolStripMenuItem.Text = "Train (Single Step)";
            this.trainSingleStepToolStripMenuItem.Click += new System.EventHandler(this.trainSingleStepToolStripMenuItem_Click);
            // 
            // trainToolStripMenuItem
            // 
            this.trainToolStripMenuItem.Name = "trainToolStripMenuItem";
            this.trainToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.trainToolStripMenuItem.Text = "Train";
            this.trainToolStripMenuItem.Click += new System.EventHandler(this.trainToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(209, 6);
            // 
            // validateToolStripMenuItem
            // 
            this.validateToolStripMenuItem.Name = "validateToolStripMenuItem";
            this.validateToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.validateToolStripMenuItem.Text = "Validate";
            this.validateToolStripMenuItem.Click += new System.EventHandler(this.validateToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 612);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1013, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(998, 17);
            this.lblStatus.Spring = true;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // openTrainingDataDlg
            // 
            this.openTrainingDataDlg.Filter = "XML File|*.XML";
            this.openTrainingDataDlg.Title = "Import Training Data";
            this.openTrainingDataDlg.FileOk += new System.ComponentModel.CancelEventHandler(this.openTrainingDataDlg_FileOk);
            // 
            // openValidationDataDlg
            // 
            this.openValidationDataDlg.Filter = "XML File|*.XML";
            this.openValidationDataDlg.Title = "Import Validation Data";
            this.openValidationDataDlg.FileOk += new System.ComponentModel.CancelEventHandler(this.openValidationDataDlg_FileOk);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdTrainingData);
            this.groupBox1.Controls.Add(this.lblTrainingDataCount);
            this.groupBox1.Location = new System.Drawing.Point(9, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 165);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Training Data";
            // 
            // grdTrainingData
            // 
            this.grdTrainingData.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.grdTrainingData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTrainingData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdTrainingData.Location = new System.Drawing.Point(3, 16);
            this.grdTrainingData.Name = "grdTrainingData";
            this.grdTrainingData.Size = new System.Drawing.Size(491, 133);
            this.grdTrainingData.TabIndex = 2;
            // 
            // lblTrainingDataCount
            // 
            this.lblTrainingDataCount.AutoSize = true;
            this.lblTrainingDataCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTrainingDataCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainingDataCount.Location = new System.Drawing.Point(3, 149);
            this.lblTrainingDataCount.Name = "lblTrainingDataCount";
            this.lblTrainingDataCount.Size = new System.Drawing.Size(170, 13);
            this.lblTrainingDataCount.TabIndex = 0;
            this.lblTrainingDataCount.Text = "Training Data Record Count:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdValidationData);
            this.groupBox2.Controls.Add(this.lblValidationDataCount);
            this.groupBox2.Location = new System.Drawing.Point(509, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(497, 165);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Validation Data";
            // 
            // grdValidationData
            // 
            this.grdValidationData.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.grdValidationData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdValidationData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdValidationData.Location = new System.Drawing.Point(3, 16);
            this.grdValidationData.Name = "grdValidationData";
            this.grdValidationData.Size = new System.Drawing.Size(491, 133);
            this.grdValidationData.TabIndex = 2;
            // 
            // lblValidationDataCount
            // 
            this.lblValidationDataCount.AutoSize = true;
            this.lblValidationDataCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblValidationDataCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidationDataCount.Location = new System.Drawing.Point(3, 149);
            this.lblValidationDataCount.Name = "lblValidationDataCount";
            this.lblValidationDataCount.Size = new System.Drawing.Size(180, 13);
            this.lblValidationDataCount.TabIndex = 0;
            this.lblValidationDataCount.Text = "Validation Data Record Count:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.txtNegativeClassificationLevel);
            this.groupBox3.Controls.Add(this.txtPredictionThreshold);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.cmbOutputAttribute);
            this.groupBox3.Controls.Add(this.txtPostiveClassificationLevel);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.lstInputAttributes);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtMomentum);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtLearningRate);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtAcceptableRMS);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtLearningIterations);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Navy;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(320, 384);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Configuration";
            // 
            // txtNegativeClassificationLevel
            // 
            this.txtNegativeClassificationLevel.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNegativeClassificationLevel.Location = new System.Drawing.Point(285, 356);
            this.txtNegativeClassificationLevel.Name = "txtNegativeClassificationLevel";
            this.txtNegativeClassificationLevel.Size = new System.Drawing.Size(29, 22);
            this.txtNegativeClassificationLevel.TabIndex = 19;
            this.txtNegativeClassificationLevel.Text = "0.1";
            // 
            // txtPredictionThreshold
            // 
            this.txtPredictionThreshold.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPredictionThreshold.Location = new System.Drawing.Point(124, 306);
            this.txtPredictionThreshold.Name = "txtPredictionThreshold";
            this.txtPredictionThreshold.Size = new System.Drawing.Size(66, 22);
            this.txtPredictionThreshold.TabIndex = 15;
            this.txtPredictionThreshold.Text = "0.5";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 359);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(274, 16);
            this.label13.TabIndex = 18;
            this.label13.Text = "Negative Classification Level Defined in Training Dataset:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 309);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 16);
            this.label11.TabIndex = 14;
            this.label11.Text = "Prediction Threshold:";
            // 
            // cmbOutputAttribute
            // 
            this.cmbOutputAttribute.FormattingEnabled = true;
            this.cmbOutputAttribute.Location = new System.Drawing.Point(159, 229);
            this.cmbOutputAttribute.Name = "cmbOutputAttribute";
            this.cmbOutputAttribute.Size = new System.Drawing.Size(155, 24);
            this.cmbOutputAttribute.TabIndex = 13;
            // 
            // txtPostiveClassificationLevel
            // 
            this.txtPostiveClassificationLevel.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostiveClassificationLevel.Location = new System.Drawing.Point(285, 332);
            this.txtPostiveClassificationLevel.Name = "txtPostiveClassificationLevel";
            this.txtPostiveClassificationLevel.Size = new System.Drawing.Size(29, 22);
            this.txtPostiveClassificationLevel.TabIndex = 17;
            this.txtPostiveClassificationLevel.Text = "0.9";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Output Attribute";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(11, 335);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(268, 16);
            this.label12.TabIndex = 16;
            this.label12.Text = "Positive Classification Level Defined in Training Dataset:";
            // 
            // lstInputAttributes
            // 
            this.lstInputAttributes.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstInputAttributes.FormattingEnabled = true;
            this.lstInputAttributes.Location = new System.Drawing.Point(6, 118);
            this.lstInputAttributes.Name = "lstInputAttributes";
            this.lstInputAttributes.Size = new System.Drawing.Size(147, 157);
            this.lstInputAttributes.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Input Attributes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtNumberOfOutputNeurons);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtHiddenLayerNeuronConfiguration);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtInputNeurons);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(159, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(154, 142);
            this.panel2.TabIndex = 9;
            // 
            // txtNumberOfOutputNeurons
            // 
            this.txtNumberOfOutputNeurons.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOfOutputNeurons.Location = new System.Drawing.Point(87, 115);
            this.txtNumberOfOutputNeurons.Name = "txtNumberOfOutputNeurons";
            this.txtNumberOfOutputNeurons.ReadOnly = true;
            this.txtNumberOfOutputNeurons.Size = new System.Drawing.Size(60, 22);
            this.txtNumberOfOutputNeurons.TabIndex = 13;
            this.txtNumberOfOutputNeurons.Text = "1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(32, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "No Of Output Neurons:";
            // 
            // txtHiddenLayerNeuronConfiguration
            // 
            this.txtHiddenLayerNeuronConfiguration.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHiddenLayerNeuronConfiguration.Location = new System.Drawing.Point(4, 71);
            this.txtHiddenLayerNeuronConfiguration.Name = "txtHiddenLayerNeuronConfiguration";
            this.txtHiddenLayerNeuronConfiguration.Size = new System.Drawing.Size(143, 22);
            this.txtHiddenLayerNeuronConfiguration.TabIndex = 11;
            this.txtHiddenLayerNeuronConfiguration.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Hidden Layer/Neuron Count:";
            // 
            // txtInputNeurons
            // 
            this.txtInputNeurons.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputNeurons.Location = new System.Drawing.Point(87, 27);
            this.txtInputNeurons.Name = "txtInputNeurons";
            this.txtInputNeurons.Size = new System.Drawing.Size(60, 22);
            this.txtInputNeurons.TabIndex = 9;
            this.txtInputNeurons.Text = "-1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(39, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "No Of Input Neurons:";
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(159, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Architecture";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMomentum
            // 
            this.txtMomentum.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMomentum.Location = new System.Drawing.Point(104, 70);
            this.txtMomentum.Name = "txtMomentum";
            this.txtMomentum.Size = new System.Drawing.Size(49, 22);
            this.txtMomentum.TabIndex = 7;
            this.txtMomentum.Text = "0.01";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Momentum:";
            // 
            // txtLearningRate
            // 
            this.txtLearningRate.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLearningRate.Location = new System.Drawing.Point(104, 44);
            this.txtLearningRate.Name = "txtLearningRate";
            this.txtLearningRate.Size = new System.Drawing.Size(49, 22);
            this.txtLearningRate.TabIndex = 5;
            this.txtLearningRate.Text = "0.25";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Learning Rate:";
            // 
            // txtAcceptableRMS
            // 
            this.txtAcceptableRMS.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcceptableRMS.Location = new System.Drawing.Point(124, 281);
            this.txtAcceptableRMS.Name = "txtAcceptableRMS";
            this.txtAcceptableRMS.Size = new System.Drawing.Size(66, 22);
            this.txtAcceptableRMS.TabIndex = 3;
            this.txtAcceptableRMS.Text = "0.2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Acceptable RMS Error:";
            // 
            // txtLearningIterations
            // 
            this.txtLearningIterations.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLearningIterations.Location = new System.Drawing.Point(104, 19);
            this.txtLearningIterations.Name = "txtLearningIterations";
            this.txtLearningIterations.Size = new System.Drawing.Size(49, 22);
            this.txtLearningIterations.TabIndex = 1;
            this.txtLearningIterations.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Learning Iteration:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.progressbar);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Location = new System.Drawing.Point(12, 208);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 394);
            this.panel1.TabIndex = 5;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Controls.Add(this.label26);
            this.groupBox4.Controls.Add(this.txtAccuracyValidation);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.txtSpecificityValidation);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.txtSensitivityValidation);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.txtMCCValidation);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.txtRMSETraining);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.txtAccuracyTraining);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.txtSpecificityTraining);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.txtSensitivityTraining);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.txtMCCTraining);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.txtIteration);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox4.Location = new System.Drawing.Point(328, 10);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(658, 218);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Learning/Training Performance Monitoring";
            // 
            // label26
            // 
            this.label26.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label26.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label26.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.DarkBlue;
            this.label26.Location = new System.Drawing.Point(408, 18);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(235, 22);
            this.label26.TabIndex = 25;
            this.label26.Text = "Performance During Validation";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAccuracyValidation
            // 
            this.txtAccuracyValidation.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtAccuracyValidation.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccuracyValidation.Location = new System.Drawing.Point(513, 184);
            this.txtAccuracyValidation.Name = "txtAccuracyValidation";
            this.txtAccuracyValidation.Size = new System.Drawing.Size(130, 22);
            this.txtAccuracyValidation.TabIndex = 22;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label21.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.DarkBlue;
            this.label21.Location = new System.Drawing.Point(408, 184);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(99, 22);
            this.label21.TabIndex = 21;
            this.label21.Text = "Accuracy:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSpecificityValidation
            // 
            this.txtSpecificityValidation.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtSpecificityValidation.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecificityValidation.Location = new System.Drawing.Point(513, 157);
            this.txtSpecificityValidation.Name = "txtSpecificityValidation";
            this.txtSpecificityValidation.Size = new System.Drawing.Size(130, 22);
            this.txtSpecificityValidation.TabIndex = 20;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label22.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.DarkBlue;
            this.label22.Location = new System.Drawing.Point(408, 157);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(99, 22);
            this.label22.TabIndex = 19;
            this.label22.Text = "Specificity:";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSensitivityValidation
            // 
            this.txtSensitivityValidation.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtSensitivityValidation.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSensitivityValidation.Location = new System.Drawing.Point(513, 129);
            this.txtSensitivityValidation.Name = "txtSensitivityValidation";
            this.txtSensitivityValidation.Size = new System.Drawing.Size(130, 22);
            this.txtSensitivityValidation.TabIndex = 18;
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label23.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.DarkBlue;
            this.label23.Location = new System.Drawing.Point(408, 129);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(99, 22);
            this.label23.TabIndex = 17;
            this.label23.Text = "Sensitivity:";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMCCValidation
            // 
            this.txtMCCValidation.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtMCCValidation.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMCCValidation.Location = new System.Drawing.Point(513, 101);
            this.txtMCCValidation.Name = "txtMCCValidation";
            this.txtMCCValidation.Size = new System.Drawing.Size(130, 22);
            this.txtMCCValidation.TabIndex = 16;
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label24.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.DarkBlue;
            this.label24.Location = new System.Drawing.Point(408, 101);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(99, 22);
            this.label24.TabIndex = 15;
            this.label24.Text = "MCC:";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label25.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.DarkBlue;
            this.label25.Location = new System.Drawing.Point(13, 18);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(305, 22);
            this.label25.TabIndex = 13;
            this.label25.Text = "Performance During Training";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRMSETraining
            // 
            this.txtRMSETraining.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtRMSETraining.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRMSETraining.Location = new System.Drawing.Point(188, 73);
            this.txtRMSETraining.Name = "txtRMSETraining";
            this.txtRMSETraining.Size = new System.Drawing.Size(130, 22);
            this.txtRMSETraining.TabIndex = 12;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label19.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.DarkBlue;
            this.label19.Location = new System.Drawing.Point(83, 73);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(99, 22);
            this.label19.TabIndex = 11;
            this.label19.Text = "RMSE:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAccuracyTraining
            // 
            this.txtAccuracyTraining.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtAccuracyTraining.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccuracyTraining.Location = new System.Drawing.Point(188, 184);
            this.txtAccuracyTraining.Name = "txtAccuracyTraining";
            this.txtAccuracyTraining.Size = new System.Drawing.Size(130, 22);
            this.txtAccuracyTraining.TabIndex = 10;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label18.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.DarkBlue;
            this.label18.Location = new System.Drawing.Point(83, 184);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(99, 22);
            this.label18.TabIndex = 9;
            this.label18.Text = "Accuracy:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSpecificityTraining
            // 
            this.txtSpecificityTraining.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtSpecificityTraining.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecificityTraining.Location = new System.Drawing.Point(188, 157);
            this.txtSpecificityTraining.Name = "txtSpecificityTraining";
            this.txtSpecificityTraining.Size = new System.Drawing.Size(130, 22);
            this.txtSpecificityTraining.TabIndex = 8;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.DarkBlue;
            this.label17.Location = new System.Drawing.Point(83, 157);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 22);
            this.label17.TabIndex = 7;
            this.label17.Text = "Specificity:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSensitivityTraining
            // 
            this.txtSensitivityTraining.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtSensitivityTraining.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSensitivityTraining.Location = new System.Drawing.Point(188, 129);
            this.txtSensitivityTraining.Name = "txtSensitivityTraining";
            this.txtSensitivityTraining.Size = new System.Drawing.Size(130, 22);
            this.txtSensitivityTraining.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label16.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DarkBlue;
            this.label16.Location = new System.Drawing.Point(83, 129);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(99, 22);
            this.label16.TabIndex = 5;
            this.label16.Text = "Sensitivity:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMCCTraining
            // 
            this.txtMCCTraining.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtMCCTraining.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMCCTraining.Location = new System.Drawing.Point(188, 101);
            this.txtMCCTraining.Name = "txtMCCTraining";
            this.txtMCCTraining.Size = new System.Drawing.Size(130, 22);
            this.txtMCCTraining.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DarkBlue;
            this.label15.Location = new System.Drawing.Point(83, 101);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 22);
            this.label15.TabIndex = 3;
            this.label15.Text = "MCC:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtIteration
            // 
            this.txtIteration.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtIteration.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIteration.Location = new System.Drawing.Point(118, 47);
            this.txtIteration.Name = "txtIteration";
            this.txtIteration.Size = new System.Drawing.Size(73, 22);
            this.txtIteration.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DarkBlue;
            this.label14.Location = new System.Drawing.Point(13, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 22);
            this.label14.TabIndex = 1;
            this.label14.Text = "Iteration:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressbar
            // 
            this.progressbar.Location = new System.Drawing.Point(329, 374);
            this.progressbar.Name = "progressbar";
            this.progressbar.Size = new System.Drawing.Size(658, 13);
            this.progressbar.TabIndex = 6;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.richTextBox1.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Lime;
            this.richTextBox1.Location = new System.Drawing.Point(329, 232);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(658, 138);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            this.richTextBox1.WordWrap = false;
            // 
            // saveNeuralNetworkConfiguration
            // 
            this.saveNeuralNetworkConfiguration.Filter = "Neural Network Archiecture|*.NNA";
            this.saveNeuralNetworkConfiguration.FileOk += new System.ComponentModel.CancelEventHandler(this.saveNeuralNetworkConfiguration_FileOk);
            // 
            // opnNeuralNetworkConfiguration
            // 
            this.opnNeuralNetworkConfiguration.Filter = "Neural Network Archiecture|*.NNA";
            this.opnNeuralNetworkConfiguration.Title = "Import Validation Data";
            this.opnNeuralNetworkConfiguration.FileOk += new System.ComponentModel.CancelEventHandler(this.opnNeuralNetworkConfiguration_FileOk);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(209, 6);
            // 
            // showWeightsToolStripMenuItem
            // 
            this.showWeightsToolStripMenuItem.Name = "showWeightsToolStripMenuItem";
            this.showWeightsToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.showWeightsToolStripMenuItem.Text = "Show Weights";
            this.showWeightsToolStripMenuItem.Click += new System.EventHandler(this.showWeightsToolStripMenuItem_Click);
            // 
            // NeuralNetworkMainConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 634);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "NeuralNetworkMainConsole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Neural Network Training Console";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTrainingData)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdValidationData)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadTrainingDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadValidationDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveNeuralNetworkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuralNetworkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validateToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.OpenFileDialog openTrainingDataDlg;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openValidationDataDlg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grdTrainingData;
        private System.Windows.Forms.Label lblTrainingDataCount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grdValidationData;
        private System.Windows.Forms.Label lblValidationDataCount;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ProgressBar progressbar;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAcceptableRMS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLearningIterations;
        private System.Windows.Forms.TextBox txtLearningRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMomentum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHiddenLayerNeuronConfiguration;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtInputNeurons;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumberOfOutputNeurons;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox lstInputAttributes;
        private System.Windows.Forms.ComboBox cmbOutputAttribute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem constructNeuralNetworkToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem trainSingleStepToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.TextBox txtPredictionThreshold;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNegativeClassificationLevel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPostiveClassificationLevel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.SaveFileDialog saveNeuralNetworkConfiguration;
        private System.Windows.Forms.OpenFileDialog opnNeuralNetworkConfiguration;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtSensitivityTraining;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtMCCTraining;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtIteration;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSpecificityTraining;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtAccuracyTraining;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtRMSETraining;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtAccuracyValidation;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtSpecificityValidation;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtSensitivityValidation;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtMCCValidation;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem showWeightsToolStripMenuItem;
    }
}

