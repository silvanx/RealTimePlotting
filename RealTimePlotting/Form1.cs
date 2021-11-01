using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace RealTimePlotting
{
    public partial class Form1 : Form
    {

        public bool isPlottingActive = false;
        Queue<float> sensorData = new Queue<float>();

        public Form1()
        {
            InitializeComponent();
            RandomDataRadio.Select();
        }

        private void StartPlottingButton_Click(object sender, EventArgs e)
        {
            isPlottingActive = true;
            updatePlottingControls();
        }

        private void updatePlottingControls()
        {
            if (isPlottingActive)
            {
                StartPlottingButton.Enabled = false;
                StopPlottingButton.Enabled = true;
                SaveToFileCheckBox.Enabled = false;
                SelectPlottingSamplingComboBox.Enabled = false;
                SelectWriteSamplingComboBox.Enabled = false;
                SelectPollSamplingComboBox.Enabled = false;
            } else
            {
                StartPlottingButton.Enabled = true;
                StopPlottingButton.Enabled = false;
                SaveToFileCheckBox.Enabled = true;
                SelectPlottingSamplingComboBox.Enabled = true;
                SelectWriteSamplingComboBox.Enabled = true;
                SelectPollSamplingComboBox.Enabled = true;
            }

        }

        private void StopPlottingButton_Click(object sender, EventArgs e)
        {
            isPlottingActive = false;
            updatePlottingControls();
        }
    }
}
