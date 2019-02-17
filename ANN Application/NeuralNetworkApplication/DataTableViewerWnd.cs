using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Qazi.MachineLearningModels.NeuralNetworks
{
    public partial class DataTableViewerWnd : Form
    {
        DataTable dtWeights;
        public DataTableViewerWnd(DataTable dtWeights)
        {
            InitializeComponent();
            this.dtWeights = dtWeights;
            dataGridView1.DataSource = dtWeights;
            lblCount.Text = dtWeights.ToString();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog(this);
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            DataSet ds = new DataSet("WeightsDataSet");
            ds.Tables.Add(dtWeights);
            ds.WriteXml(saveFileDialog1.FileName);
        }
    }
}