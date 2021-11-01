using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealTimePlotting
{
    public partial class Form1 : Form
    {

        public bool isPlottingActive = false;

        public Form1()
        {
            InitializeComponent();
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
                SelectWritingSamplingComboBox.Enabled = false;
            } else
            {
                StartPlottingButton.Enabled = true;
                StopPlottingButton.Enabled = false;
                SaveToFileCheckBox.Enabled = true;
                SelectPlottingSamplingComboBox.Enabled = true;
                SelectWritingSamplingComboBox.Enabled = true;
            }

        }

        private void StopPlottingButton_Click(object sender, EventArgs e)
        {
            isPlottingActive = false;
            updatePlottingControls();
        }
    }
}
