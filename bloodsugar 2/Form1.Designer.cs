//Bloodsugar Recorder - Simple program to record and monitor bloodsugar levels over time.
//Copyright(C) 2016 Scott Guyton

//This program is free software; you can redistribute it and/or
//modify it under the terms of the GNU General Public License
//as published by the Free Software Foundation; either version 2
//of the License, or(at your option) any later version.

//This program is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
//GNU General Public License for more details.

//You should have received a copy of the GNU General Public License
//along with this program; if not, write to the Free Software
//Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.

namespace bloodsugar_2
{
    partial class mainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.grpBTestResults = new System.Windows.Forms.GroupBox();
            this.findDate = new System.Windows.Forms.DateTimePicker();
            this.listBResult = new System.Windows.Forms.ListBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnShowDict = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chartResults = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnResult = new System.Windows.Forms.Button();
            this.lblEnterData = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoFasting = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBTestResults.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResults)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBTestResults
            // 
            this.grpBTestResults.BackColor = System.Drawing.SystemColors.Menu;
            this.grpBTestResults.Controls.Add(this.findDate);
            this.grpBTestResults.Controls.Add(this.listBResult);
            this.grpBTestResults.Controls.Add(this.lblDate);
            this.grpBTestResults.Location = new System.Drawing.Point(12, 174);
            this.grpBTestResults.Name = "grpBTestResults";
            this.grpBTestResults.Size = new System.Drawing.Size(210, 177);
            this.grpBTestResults.TabIndex = 13;
            this.grpBTestResults.TabStop = false;
            this.grpBTestResults.Text = "Past Test Results";
            // 
            // findDate
            // 
            this.findDate.Location = new System.Drawing.Point(6, 55);
            this.findDate.Name = "findDate";
            this.findDate.Size = new System.Drawing.Size(188, 20);
            this.findDate.TabIndex = 1;
            this.findDate.ValueChanged += new System.EventHandler(this.searchDateOnChange);
            // 
            // listBResult
            // 
            this.listBResult.FormattingEnabled = true;
            this.listBResult.Location = new System.Drawing.Point(6, 81);
            this.listBResult.Name = "listBResult";
            this.listBResult.Size = new System.Drawing.Size(188, 82);
            this.listBResult.TabIndex = 7;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(6, 39);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(73, 13);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Select A Date";
            // 
            // btnShowDict
            // 
            this.btnShowDict.Location = new System.Drawing.Point(12, 357);
            this.btnShowDict.Name = "btnShowDict";
            this.btnShowDict.Size = new System.Drawing.Size(210, 35);
            this.btnShowDict.TabIndex = 8;
            this.btnShowDict.Text = "Show All Previous Results";
            this.btnShowDict.UseVisualStyleBackColor = true;
            this.btnShowDict.Click += new System.EventHandler(this.btnShowDict_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chartResults);
            this.groupBox2.Location = new System.Drawing.Point(240, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(611, 365);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recorded Levels Over Time";
            // 
            // chartResults
            // 
            chartArea2.Name = "ChartArea1";
            this.chartResults.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartResults.Legends.Add(legend2);
            this.chartResults.Location = new System.Drawing.Point(7, 16);
            this.chartResults.Name = "chartResults";
            this.chartResults.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartResults.Series.Add(series2);
            this.chartResults.Size = new System.Drawing.Size(598, 343);
            this.chartResults.TabIndex = 0;
            this.chartResults.Text = "chart1";
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(9, 83);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(70, 42);
            this.btnResult.TabIndex = 6;
            this.btnResult.Text = "Enter Result";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // lblEnterData
            // 
            this.lblEnterData.AutoSize = true;
            this.lblEnterData.Location = new System.Drawing.Point(6, 16);
            this.lblEnterData.Name = "lblEnterData";
            this.lblEnterData.Size = new System.Drawing.Size(175, 26);
            this.lblEnterData.TabIndex = 5;
            this.lblEnterData.Text = "Please enter the results of your test\r\n in milligrams per a liter (mg/l) below:";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(9, 45);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(185, 20);
            this.txtResult.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoFasting);
            this.groupBox1.Controls.Add(this.btnResult);
            this.groupBox1.Controls.Add(this.lblEnterData);
            this.groupBox1.Controls.Add(this.txtResult);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 141);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Blood Sugar Levels";
            // 
            // rdoFasting
            // 
            this.rdoFasting.AutoSize = true;
            this.rdoFasting.Location = new System.Drawing.Point(135, 96);
            this.rdoFasting.Name = "rdoFasting";
            this.rdoFasting.Size = new System.Drawing.Size(59, 17);
            this.rdoFasting.TabIndex = 7;
            this.rdoFasting.TabStop = true;
            this.rdoFasting.Text = "Fasting";
            this.rdoFasting.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(862, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click_1);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(149, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 436);
            this.Controls.Add(this.grpBTestResults);
            this.Controls.Add(this.btnShowDict);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "Blood Sugar Recorder ";
            this.grpBTestResults.ResumeLayout(false);
            this.grpBTestResults.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartResults)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpBTestResults;
        private System.Windows.Forms.DateTimePicker findDate;
        private System.Windows.Forms.ListBox listBResult;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnShowDict;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Label lblEnterData;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResults;
        private System.Windows.Forms.RadioButton rdoFasting;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

