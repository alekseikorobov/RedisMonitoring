namespace RedisMonitoring;

partial class FormMain
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
        System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
        System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
        System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
        System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
        System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
        this.statusStrip1 = new System.Windows.Forms.StatusStrip();
        this.menuStrip1 = new System.Windows.Forms.MenuStrip();
        this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.connectionStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
        this.tabPage2 = new System.Windows.Forms.TabPage();
        this.tabPage1 = new System.Windows.Forms.TabPage();
        this.tabControl1 = new System.Windows.Forms.TabControl();
        this.timer1 = new System.Windows.Forms.Timer(this.components);
        this.memoryChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
        this.serverTextBox = new System.Windows.Forms.TextBox();
        this.connectionStatusValueLabel = new System.Windows.Forms.ToolStripStatusLabel();
        this.memoryLabel = new System.Windows.Forms.Label();
        this.memoryLabelValue = new System.Windows.Forms.Label();
        this.cpuLabelValue = new System.Windows.Forms.Label();
        this.cpuLabel = new System.Windows.Forms.Label();
        this.tabPage3 = new System.Windows.Forms.TabPage();
        this.statsTextBox = new System.Windows.Forms.TextBox();
        this.stopTimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.tabPage4 = new System.Windows.Forms.TabPage();
        this.persistenceTextBox = new System.Windows.Forms.TextBox();
        this.tabPage5 = new System.Windows.Forms.TabPage();
        this.clientsTextBox = new System.Windows.Forms.TextBox();
        this.tabPage6 = new System.Windows.Forms.TabPage();
        this.replicationTextBox = new System.Windows.Forms.TextBox();
        this.tabPage7 = new System.Windows.Forms.TabPage();
        this.memoryTextBox = new System.Windows.Forms.TextBox();
        this.cpuChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
        this.statusStrip1.SuspendLayout();
        this.menuStrip1.SuspendLayout();
        this.tabPage2.SuspendLayout();
        this.tabPage1.SuspendLayout();
        this.tabControl1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.memoryChart)).BeginInit();
        this.tabPage3.SuspendLayout();
        this.tabPage4.SuspendLayout();
        this.tabPage5.SuspendLayout();
        this.tabPage6.SuspendLayout();
        this.tabPage7.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.cpuChart)).BeginInit();
        this.SuspendLayout();
        // 
        // statusStrip1
        // 
        this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionStatusLabel,
            this.connectionStatusValueLabel});
        this.statusStrip1.Location = new System.Drawing.Point(0, 478);
        this.statusStrip1.Name = "statusStrip1";
        this.statusStrip1.Size = new System.Drawing.Size(844, 22);
        this.statusStrip1.TabIndex = 1;
        this.statusStrip1.Text = "statusStrip1";
        // 
        // menuStrip1
        // 
        this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
        this.menuStrip1.Location = new System.Drawing.Point(0, 0);
        this.menuStrip1.Name = "menuStrip1";
        this.menuStrip1.Size = new System.Drawing.Size(844, 24);
        this.menuStrip1.TabIndex = 2;
        this.menuStrip1.Text = "menuStrip1";
        // 
        // fileToolStripMenuItem
        // 
        this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configToolStripMenuItem,
            this.stopTimerToolStripMenuItem});
        this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
        this.fileToolStripMenuItem.Text = "File";
        // 
        // configToolStripMenuItem
        // 
        this.configToolStripMenuItem.Name = "configToolStripMenuItem";
        this.configToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
        this.configToolStripMenuItem.Text = "Config";
        this.configToolStripMenuItem.Click += new System.EventHandler(this.configToolStripMenuItem_Click);
        // 
        // connectionStatusLabel
        // 
        this.connectionStatusLabel.Name = "connectionStatusLabel";
        this.connectionStatusLabel.Size = new System.Drawing.Size(104, 17);
        this.connectionStatusLabel.Text = "ConnectionStatus:";
        // 
        // tabPage2
        // 
        this.tabPage2.Controls.Add(this.serverTextBox);
        this.tabPage2.Location = new System.Drawing.Point(4, 22);
        this.tabPage2.Name = "tabPage2";
        this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
        this.tabPage2.Size = new System.Drawing.Size(836, 370);
        this.tabPage2.TabIndex = 1;
        this.tabPage2.Text = "Server";
        this.tabPage2.UseVisualStyleBackColor = true;
        // 
        // tabPage1
        // 
        this.tabPage1.Controls.Add(this.cpuChart);
        this.tabPage1.Controls.Add(this.cpuLabelValue);
        this.tabPage1.Controls.Add(this.cpuLabel);
        this.tabPage1.Controls.Add(this.memoryLabelValue);
        this.tabPage1.Controls.Add(this.memoryLabel);
        this.tabPage1.Controls.Add(this.memoryChart);
        this.tabPage1.Location = new System.Drawing.Point(4, 22);
        this.tabPage1.Name = "tabPage1";
        this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
        this.tabPage1.Size = new System.Drawing.Size(836, 422);
        this.tabPage1.TabIndex = 0;
        this.tabPage1.Text = "Info";
        this.tabPage1.UseVisualStyleBackColor = true;
        // 
        // tabControl1
        // 
        this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
        | System.Windows.Forms.AnchorStyles.Left)
        | System.Windows.Forms.AnchorStyles.Right)));
        this.tabControl1.Controls.Add(this.tabPage1);
        this.tabControl1.Controls.Add(this.tabPage2);
        this.tabControl1.Controls.Add(this.tabPage3);
        this.tabControl1.Controls.Add(this.tabPage4);
        this.tabControl1.Controls.Add(this.tabPage5);
        this.tabControl1.Controls.Add(this.tabPage6);
        this.tabControl1.Controls.Add(this.tabPage7);
        this.tabControl1.Location = new System.Drawing.Point(0, 27);
        this.tabControl1.Name = "tabControl1";
        this.tabControl1.SelectedIndex = 0;
        this.tabControl1.Size = new System.Drawing.Size(844, 448);
        this.tabControl1.TabIndex = 0;
        // 
        // timer1
        // 
        this.timer1.Interval = 1000;
        this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
        // 
        // memoryChart
        // 
        this.memoryChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
        | System.Windows.Forms.AnchorStyles.Right)));
        chartArea2.AxisX.IsMarksNextToAxis = false;
        chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
        chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
        chartArea2.Name = "ChartArea1";
        this.memoryChart.ChartAreas.Add(chartArea2);
        legend2.Name = "Legend1";
        this.memoryChart.Legends.Add(legend2);
        this.memoryChart.Location = new System.Drawing.Point(219, 21);
        this.memoryChart.Name = "memoryChart";
        this.memoryChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
        this.memoryChart.RightToLeft = System.Windows.Forms.RightToLeft.No;
        series2.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.TopRight;
        series2.ChartArea = "ChartArea1";
        series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
        series2.Legend = "Legend1";
        series2.Name = "Series1";
        this.memoryChart.Series.Add(series2);
        this.memoryChart.Size = new System.Drawing.Size(609, 113);
        this.memoryChart.TabIndex = 0;
        this.memoryChart.Text = "memoryChart";
        // 
        // serverTextBox
        // 
        this.serverTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
        this.serverTextBox.Location = new System.Drawing.Point(3, 3);
        this.serverTextBox.Multiline = true;
        this.serverTextBox.Name = "serverTextBox";
        this.serverTextBox.Size = new System.Drawing.Size(830, 364);
        this.serverTextBox.TabIndex = 0;
        // 
        // connectionStatusValueLabel
        // 
        this.connectionStatusValueLabel.Name = "connectionStatusValueLabel";
        this.connectionStatusValueLabel.Size = new System.Drawing.Size(0, 17);
        // 
        // memoryLabel
        // 
        this.memoryLabel.AutoSize = true;
        this.memoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.memoryLabel.Location = new System.Drawing.Point(8, 3);
        this.memoryLabel.Name = "memoryLabel";
        this.memoryLabel.Size = new System.Drawing.Size(83, 25);
        this.memoryLabel.TabIndex = 1;
        this.memoryLabel.Text = "Memory";
        // 
        // memoryLabelValue
        // 
        this.memoryLabelValue.AutoSize = true;
        this.memoryLabelValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.memoryLabelValue.Location = new System.Drawing.Point(13, 32);
        this.memoryLabelValue.Name = "memoryLabelValue";
        this.memoryLabelValue.Size = new System.Drawing.Size(161, 102);
        this.memoryLabelValue.TabIndex = 2;
        this.memoryLabelValue.Text = "used_memory: 0\r\nused_memory_rss: 0\r\nused_memory_peak: 0\r\ntotal_system_memory: 0\r\n" +
"used_memory_lua: 0\r\nmaxmemory: 0";
        // 
        // cpuLabelValue
        // 
        this.cpuLabelValue.AutoSize = true;
        this.cpuLabelValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.cpuLabelValue.Location = new System.Drawing.Point(13, 189);
        this.cpuLabelValue.Name = "cpuLabelValue";
        this.cpuLabelValue.Size = new System.Drawing.Size(180, 68);
        this.cpuLabelValue.TabIndex = 5;
        this.cpuLabelValue.Text = "used_cpu_sys: 0\r\nused_cpu_user: 0\r\nused_cpu_sys_children: 0\r\nused_cpu_user_childr" +
"en: 0";
        // 
        // cpuLabel
        // 
        this.cpuLabel.AutoSize = true;
        this.cpuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.cpuLabel.Location = new System.Drawing.Point(8, 160);
        this.cpuLabel.Name = "cpuLabel";
        this.cpuLabel.Size = new System.Drawing.Size(54, 25);
        this.cpuLabel.TabIndex = 4;
        this.cpuLabel.Text = "CPU";
        // 
        // tabPage3
        // 
        this.tabPage3.Controls.Add(this.statsTextBox);
        this.tabPage3.Location = new System.Drawing.Point(4, 22);
        this.tabPage3.Name = "tabPage3";
        this.tabPage3.Size = new System.Drawing.Size(836, 370);
        this.tabPage3.TabIndex = 2;
        this.tabPage3.Text = "Stats";
        this.tabPage3.UseVisualStyleBackColor = true;
        // 
        // statsTextBox
        // 
        this.statsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
        this.statsTextBox.Location = new System.Drawing.Point(0, 0);
        this.statsTextBox.Multiline = true;
        this.statsTextBox.Name = "statsTextBox";
        this.statsTextBox.Size = new System.Drawing.Size(836, 370);
        this.statsTextBox.TabIndex = 0;
        // 
        // stopTimerToolStripMenuItem
        // 
        this.stopTimerToolStripMenuItem.Name = "stopTimerToolStripMenuItem";
        this.stopTimerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
        this.stopTimerToolStripMenuItem.Text = "StopTimer";
        this.stopTimerToolStripMenuItem.Click += new System.EventHandler(this.stopTimerToolStripMenuItem_Click);
        // 
        // tabPage4
        // 
        this.tabPage4.Controls.Add(this.persistenceTextBox);
        this.tabPage4.Location = new System.Drawing.Point(4, 22);
        this.tabPage4.Name = "tabPage4";
        this.tabPage4.Size = new System.Drawing.Size(836, 370);
        this.tabPage4.TabIndex = 3;
        this.tabPage4.Text = "Persistence";
        this.tabPage4.UseVisualStyleBackColor = true;
        // 
        // persistenceTextBox
        // 
        this.persistenceTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
        this.persistenceTextBox.Location = new System.Drawing.Point(0, 0);
        this.persistenceTextBox.Multiline = true;
        this.persistenceTextBox.Name = "persistenceTextBox";
        this.persistenceTextBox.Size = new System.Drawing.Size(836, 370);
        this.persistenceTextBox.TabIndex = 0;
        // 
        // tabPage5
        // 
        this.tabPage5.Controls.Add(this.clientsTextBox);
        this.tabPage5.Location = new System.Drawing.Point(4, 22);
        this.tabPage5.Name = "tabPage5";
        this.tabPage5.Size = new System.Drawing.Size(836, 370);
        this.tabPage5.TabIndex = 4;
        this.tabPage5.Text = "Clients";
        this.tabPage5.UseVisualStyleBackColor = true;
        // 
        // clientsTextBox
        // 
        this.clientsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
        this.clientsTextBox.Location = new System.Drawing.Point(0, 0);
        this.clientsTextBox.Multiline = true;
        this.clientsTextBox.Name = "clientsTextBox";
        this.clientsTextBox.Size = new System.Drawing.Size(836, 370);
        this.clientsTextBox.TabIndex = 0;
        // 
        // tabPage6
        // 
        this.tabPage6.Controls.Add(this.replicationTextBox);
        this.tabPage6.Location = new System.Drawing.Point(4, 22);
        this.tabPage6.Name = "tabPage6";
        this.tabPage6.Size = new System.Drawing.Size(836, 370);
        this.tabPage6.TabIndex = 5;
        this.tabPage6.Text = "Replication";
        this.tabPage6.UseVisualStyleBackColor = true;
        // 
        // replicationTextBox
        // 
        this.replicationTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
        this.replicationTextBox.Location = new System.Drawing.Point(0, 0);
        this.replicationTextBox.Multiline = true;
        this.replicationTextBox.Name = "replicationTextBox";
        this.replicationTextBox.Size = new System.Drawing.Size(836, 370);
        this.replicationTextBox.TabIndex = 0;
        // 
        // tabPage7
        // 
        this.tabPage7.Controls.Add(this.memoryTextBox);
        this.tabPage7.Location = new System.Drawing.Point(4, 22);
        this.tabPage7.Name = "tabPage7";
        this.tabPage7.Size = new System.Drawing.Size(836, 370);
        this.tabPage7.TabIndex = 6;
        this.tabPage7.Text = "Memory";
        this.tabPage7.UseVisualStyleBackColor = true;
        // 
        // memoryTextBox
        // 
        this.memoryTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
        this.memoryTextBox.Location = new System.Drawing.Point(0, 0);
        this.memoryTextBox.Multiline = true;
        this.memoryTextBox.Name = "memoryTextBox";
        this.memoryTextBox.Size = new System.Drawing.Size(836, 370);
        this.memoryTextBox.TabIndex = 0;
        // 
        // cpuChart
        // 
        this.cpuChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
        | System.Windows.Forms.AnchorStyles.Right)));
        chartArea1.AxisX.IsMarksNextToAxis = false;
        chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
        chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
        chartArea1.Name = "ChartArea1";
        this.cpuChart.ChartAreas.Add(chartArea1);
        legend1.Name = "Legend1";
        this.cpuChart.Legends.Add(legend1);
        this.cpuChart.Location = new System.Drawing.Point(219, 160);
        this.cpuChart.Name = "cpuChart";
        this.cpuChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
        this.cpuChart.RightToLeft = System.Windows.Forms.RightToLeft.No;
        series1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.TopRight;
        series1.ChartArea = "ChartArea1";
        series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
        series1.Legend = "Legend1";
        series1.Name = "Series1";
        this.cpuChart.Series.Add(series1);
        this.cpuChart.Size = new System.Drawing.Size(609, 113);
        this.cpuChart.TabIndex = 6;
        this.cpuChart.Text = "chart1";
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(844, 500);
        this.Controls.Add(this.statusStrip1);
        this.Controls.Add(this.menuStrip1);
        this.Controls.Add(this.tabControl1);
        this.MainMenuStrip = this.menuStrip1;
        this.Name = "Form1";
        this.Text = "Redis Monitoring";
        this.statusStrip1.ResumeLayout(false);
        this.statusStrip1.PerformLayout();
        this.menuStrip1.ResumeLayout(false);
        this.menuStrip1.PerformLayout();
        this.tabPage2.ResumeLayout(false);
        this.tabPage2.PerformLayout();
        this.tabPage1.ResumeLayout(false);
        this.tabPage1.PerformLayout();
        this.tabControl1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.memoryChart)).EndInit();
        this.tabPage3.ResumeLayout(false);
        this.tabPage3.PerformLayout();
        this.tabPage4.ResumeLayout(false);
        this.tabPage4.PerformLayout();
        this.tabPage5.ResumeLayout(false);
        this.tabPage5.PerformLayout();
        this.tabPage6.ResumeLayout(false);
        this.tabPage6.PerformLayout();
        this.tabPage7.ResumeLayout(false);
        this.tabPage7.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.cpuChart)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripStatusLabel connectionStatusLabel;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.DataVisualization.Charting.Chart memoryChart;
    private System.Windows.Forms.TextBox serverTextBox;
    private System.Windows.Forms.ToolStripStatusLabel connectionStatusValueLabel;
    private System.Windows.Forms.Label memoryLabel;
    private System.Windows.Forms.Label memoryLabelValue;
    private System.Windows.Forms.Label cpuLabelValue;
    private System.Windows.Forms.Label cpuLabel;
    private System.Windows.Forms.TabPage tabPage3;
    private System.Windows.Forms.TextBox statsTextBox;
    private System.Windows.Forms.ToolStripMenuItem stopTimerToolStripMenuItem;
    private System.Windows.Forms.TabPage tabPage4;
    private System.Windows.Forms.TextBox persistenceTextBox;
    private System.Windows.Forms.TabPage tabPage5;
    private System.Windows.Forms.TextBox clientsTextBox;
    private System.Windows.Forms.TabPage tabPage6;
    private System.Windows.Forms.TextBox replicationTextBox;
    private System.Windows.Forms.TabPage tabPage7;
    private System.Windows.Forms.TextBox memoryTextBox;
    private System.Windows.Forms.DataVisualization.Charting.Chart cpuChart;
    #endregion
}
