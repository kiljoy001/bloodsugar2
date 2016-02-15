namespace bloodsugar_2
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
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBTestResults = new System.Windows.Forms.GroupBox();
            this.testDate = new System.Windows.Forms.DateTimePicker();
            this.listBResult = new System.Windows.Forms.ListBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnShowDict = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnResult = new System.Windows.Forms.Button();
            this.lblEnterData = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grpBTestResults.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.manualToolStripMenuItem.Text = "Manual";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // grpBTestResults
            // 
            this.grpBTestResults.BackColor = System.Drawing.SystemColors.Menu;
            this.grpBTestResults.Controls.Add(this.testDate);
            this.grpBTestResults.Controls.Add(this.listBResult);
            this.grpBTestResults.Controls.Add(this.lblDate);
            this.grpBTestResults.Location = new System.Drawing.Point(12, 174);
            this.grpBTestResults.Name = "grpBTestResults";
            this.grpBTestResults.Size = new System.Drawing.Size(210, 177);
            this.grpBTestResults.TabIndex = 13;
            this.grpBTestResults.TabStop = false;
            this.grpBTestResults.Text = "Past Test Results";
            // 
            // testDate
            // 
            this.testDate.Location = new System.Drawing.Point(6, 55);
            this.testDate.Name = "testDate";
            this.testDate.Size = new System.Drawing.Size(188, 20);
            this.testDate.TabIndex = 1;
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
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chart1);
            this.groupBox2.Location = new System.Drawing.Point(240, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(611, 365);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recorded Levels Over Time";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(862, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(9, 71);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(185, 42);
            this.btnResult.TabIndex = 6;
            this.btnResult.Text = "Enter Result";
            this.btnResult.UseVisualStyleBackColor = true;
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
            this.groupBox1.Controls.Add(this.btnResult);
            this.groupBox1.Controls.Add(this.lblEnterData);
            this.groupBox1.Controls.Add(this.txtResult);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 126);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Blood Sugar Levels";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(7, 16);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(598, 343);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 436);
            this.Controls.Add(this.grpBTestResults);
            this.Controls.Add(this.btnShowDict);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpBTestResults.ResumeLayout(false);
            this.grpBTestResults.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpBTestResults;
        private System.Windows.Forms.DateTimePicker testDate;
        private System.Windows.Forms.ListBox listBResult;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnShowDict;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Label lblEnterData;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

