
namespace RealTimePlotting
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.MainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.StartPlottingButton = new System.Windows.Forms.Button();
            this.StopPlottingButton = new System.Windows.Forms.Button();
            this.SaveToFileCheckBox = new System.Windows.Forms.CheckBox();
            this.SelectPlottingSamplingComboBox = new System.Windows.Forms.ComboBox();
            this.SelectWriteSamplingComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RandomDataRadio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SelectPollSamplingComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainChart
            // 
            chartArea1.Name = "ChartArea1";
            this.MainChart.ChartAreas.Add(chartArea1);
            this.MainChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.MainChart.Legends.Add(legend1);
            this.MainChart.Location = new System.Drawing.Point(0, 0);
            this.MainChart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MainChart.Name = "MainChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.MainChart.Series.Add(series1);
            this.MainChart.Size = new System.Drawing.Size(700, 498);
            this.MainChart.TabIndex = 0;
            this.MainChart.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.MainChart);
            this.panel1.Location = new System.Drawing.Point(10, 37);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 498);
            this.panel1.TabIndex = 1;
            // 
            // StartPlottingButton
            // 
            this.StartPlottingButton.Location = new System.Drawing.Point(10, 9);
            this.StartPlottingButton.Name = "StartPlottingButton";
            this.StartPlottingButton.Size = new System.Drawing.Size(75, 23);
            this.StartPlottingButton.TabIndex = 2;
            this.StartPlottingButton.Text = "Start Plotting";
            this.StartPlottingButton.UseVisualStyleBackColor = true;
            this.StartPlottingButton.Click += new System.EventHandler(this.StartPlottingButton_Click);
            // 
            // StopPlottingButton
            // 
            this.StopPlottingButton.Enabled = false;
            this.StopPlottingButton.Location = new System.Drawing.Point(91, 9);
            this.StopPlottingButton.Name = "StopPlottingButton";
            this.StopPlottingButton.Size = new System.Drawing.Size(75, 23);
            this.StopPlottingButton.TabIndex = 3;
            this.StopPlottingButton.Text = "Stop Plotting";
            this.StopPlottingButton.UseVisualStyleBackColor = true;
            this.StopPlottingButton.Click += new System.EventHandler(this.StopPlottingButton_Click);
            // 
            // SaveToFileCheckBox
            // 
            this.SaveToFileCheckBox.AutoSize = true;
            this.SaveToFileCheckBox.Location = new System.Drawing.Point(172, 13);
            this.SaveToFileCheckBox.Name = "SaveToFileCheckBox";
            this.SaveToFileCheckBox.Size = new System.Drawing.Size(79, 17);
            this.SaveToFileCheckBox.TabIndex = 4;
            this.SaveToFileCheckBox.Text = "Save to file";
            this.SaveToFileCheckBox.UseVisualStyleBackColor = true;
            // 
            // SelectPlottingSamplingComboBox
            // 
            this.SelectPlottingSamplingComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectPlottingSamplingComboBox.FormattingEnabled = true;
            this.SelectPlottingSamplingComboBox.Location = new System.Drawing.Point(812, 99);
            this.SelectPlottingSamplingComboBox.Name = "SelectPlottingSamplingComboBox";
            this.SelectPlottingSamplingComboBox.Size = new System.Drawing.Size(121, 21);
            this.SelectPlottingSamplingComboBox.TabIndex = 5;
            // 
            // SelectWriteSamplingComboBox
            // 
            this.SelectWriteSamplingComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectWriteSamplingComboBox.FormattingEnabled = true;
            this.SelectWriteSamplingComboBox.Location = new System.Drawing.Point(812, 127);
            this.SelectWriteSamplingComboBox.Name = "SelectWriteSamplingComboBox";
            this.SelectWriteSamplingComboBox.Size = new System.Drawing.Size(121, 21);
            this.SelectWriteSamplingComboBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(728, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Plot frequency";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(728, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Write frequency";
            // 
            // RandomDataRadio
            // 
            this.RandomDataRadio.AutoSize = true;
            this.RandomDataRadio.Location = new System.Drawing.Point(6, 19);
            this.RandomDataRadio.Name = "RandomDataRadio";
            this.RandomDataRadio.Size = new System.Drawing.Size(89, 17);
            this.RandomDataRadio.TabIndex = 9;
            this.RandomDataRadio.TabStop = true;
            this.RandomDataRadio.Text = "Random data";
            this.RandomDataRadio.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.RandomDataRadio);
            this.groupBox1.Location = new System.Drawing.Point(769, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 47);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Source";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(728, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Poll frequency";
            // 
            // SelectPollSamplingComboBox
            // 
            this.SelectPollSamplingComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectPollSamplingComboBox.FormattingEnabled = true;
            this.SelectPollSamplingComboBox.Location = new System.Drawing.Point(812, 154);
            this.SelectPollSamplingComboBox.Name = "SelectPollSamplingComboBox";
            this.SelectPollSamplingComboBox.Size = new System.Drawing.Size(121, 21);
            this.SelectPollSamplingComboBox.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 547);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SelectPollSamplingComboBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectWriteSamplingComboBox);
            this.Controls.Add(this.SelectPlottingSamplingComboBox);
            this.Controls.Add(this.SaveToFileCheckBox);
            this.Controls.Add(this.StopPlottingButton);
            this.Controls.Add(this.StartPlottingButton);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Real Time Plotting";
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart MainChart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button StartPlottingButton;
        private System.Windows.Forms.Button StopPlottingButton;
        private System.Windows.Forms.CheckBox SaveToFileCheckBox;
        private System.Windows.Forms.ComboBox SelectPlottingSamplingComboBox;
        private System.Windows.Forms.ComboBox SelectWriteSamplingComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton RandomDataRadio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox SelectPollSamplingComboBox;
    }
}

