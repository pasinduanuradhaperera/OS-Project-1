namespace Final_Project
{
    partial class Form1
    {
        /// <summary>
        /// required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// clean up any resources being used.
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
        /// Required method for Designer support - dont modify
        /// The contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pCpu = new System.Diagnostics.PerformanceCounter();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pRam = new System.Diagnostics.PerformanceCounter();
            this.pDiskR = new System.Diagnostics.PerformanceCounter();
            this.pDiskW = new System.Diagnostics.PerformanceCounter();
            this.pRamAval = new System.Diagnostics.PerformanceCounter();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btn_ram = new System.Windows.Forms.Button();
            this.btn_disk = new System.Windows.Forms.Button();
            this.btn_cpu = new System.Windows.Forms.Button();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_ramB = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_cpu1 = new System.Windows.Forms.Label();
            this.lb_diskWrite = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_ram = new System.Windows.Forms.Label();
            this.lb_diskRead = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cCPU = new CircularProgressBar.CircularProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pCpu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDiskR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDiskW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRamAval)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelDesktopPane.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // pCpu
            // 
            this.pCpu.CategoryName = "Processor";
            this.pCpu.CounterName = "% Processor Time";
            this.pCpu.InstanceName = "_total";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // pRam
            // 
            this.pRam.CategoryName = "Memory";
            this.pRam.CounterName = "% Committed Bytes in Use";
            // 
            // pDiskR
            // 
            this.pDiskR.CategoryName = "PhysicalDisk";
            this.pDiskR.CounterName = "Disk Reads/sec";
            this.pDiskR.InstanceName = "_Total";
            // 
            // pDiskW
            // 
            this.pDiskW.CategoryName = "PhysicalDisk";
            this.pDiskW.CounterName = "Disk Writes/sec";
            this.pDiskW.InstanceName = "_Total";
            // 
            // pRamAval
            // 
            this.pRamAval.CategoryName = "Memory";
            this.pRamAval.CounterName = "Available Bytes";
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btn_ram);
            this.panelMenu.Controls.Add(this.btn_disk);
            this.panelMenu.Controls.Add(this.btn_cpu);
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(51, 412);
            this.panelMenu.TabIndex = 7;
            // 
            // btn_ram
            // 
            this.btn_ram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btn_ram.FlatAppearance.BorderSize = 0;
            this.btn_ram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ram.ForeColor = System.Drawing.Color.White;
            this.btn_ram.Image = global::Final_Project.Properties.Resources.MEMORY;
            this.btn_ram.Location = new System.Drawing.Point(1, 128);
            this.btn_ram.Name = "btn_ram";
            this.btn_ram.Size = new System.Drawing.Size(49, 49);
            this.btn_ram.TabIndex = 3;
            this.btn_ram.UseVisualStyleBackColor = false;
            this.btn_ram.Click += new System.EventHandler(this.btn_ram_Click);
            // 
            // btn_disk
            // 
            this.btn_disk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btn_disk.FlatAppearance.BorderSize = 0;
            this.btn_disk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_disk.ForeColor = System.Drawing.Color.White;
            this.btn_disk.Image = global::Final_Project.Properties.Resources.DISK;
            this.btn_disk.Location = new System.Drawing.Point(1, 175);
            this.btn_disk.Name = "btn_disk";
            this.btn_disk.Size = new System.Drawing.Size(49, 49);
            this.btn_disk.TabIndex = 1;
            this.btn_disk.UseVisualStyleBackColor = false;
            this.btn_disk.Click += new System.EventHandler(this.btn_disk_Click);
            // 
            // btn_cpu
            // 
            this.btn_cpu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btn_cpu.FlatAppearance.BorderSize = 0;
            this.btn_cpu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cpu.ForeColor = System.Drawing.Color.White;
            this.btn_cpu.Image = global::Final_Project.Properties.Resources.CPU;
            this.btn_cpu.Location = new System.Drawing.Point(1, 81);
            this.btn_cpu.Name = "btn_cpu";
            this.btn_cpu.Size = new System.Drawing.Size(49, 49);
            this.btn_cpu.TabIndex = 0;
            this.btn_cpu.UseVisualStyleBackColor = false;
            this.btn_cpu.Click += new System.EventHandler(this.btn_cpu_Click);
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Controls.Add(this.panel1);
            this.panelDesktopPane.Location = new System.Drawing.Point(50, 0);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(582, 412);
            this.panelDesktopPane.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Controls.Add(this.cCPU);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 412);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lb_ramB);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lb_cpu1);
            this.panel2.Controls.Add(this.lb_diskWrite);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lb_ram);
            this.panel2.Controls.Add(this.lb_diskRead);
            this.panel2.Location = new System.Drawing.Point(4, 300);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(252, 106);
            this.panel2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "DISK -";
            // 
            // lb_ramB
            // 
            this.lb_ramB.AutoSize = true;
            this.lb_ramB.BackColor = System.Drawing.Color.Transparent;
            this.lb_ramB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ramB.Location = new System.Drawing.Point(180, 33);
            this.lb_ramB.Name = "lb_ramB";
            this.lb_ramB.Size = new System.Drawing.Size(64, 15);
            this.lb_ramB.TabIndex = 8;
            this.lb_ramB.Text = "4000 MB";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "RAM -";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(130, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "AvB -";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "W -";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "CPU -";
            // 
            // lb_cpu1
            // 
            this.lb_cpu1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_cpu1.AutoSize = true;
            this.lb_cpu1.BackColor = System.Drawing.Color.Transparent;
            this.lb_cpu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cpu1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lb_cpu1.Location = new System.Drawing.Point(57, 9);
            this.lb_cpu1.Name = "lb_cpu1";
            this.lb_cpu1.Size = new System.Drawing.Size(43, 15);
            this.lb_cpu1.TabIndex = 2;
            this.lb_cpu1.Text = "100%";
            this.lb_cpu1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_diskWrite
            // 
            this.lb_diskWrite.AutoSize = true;
            this.lb_diskWrite.BackColor = System.Drawing.Color.Transparent;
            this.lb_diskWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_diskWrite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lb_diskWrite.Location = new System.Drawing.Point(86, 78);
            this.lb_diskWrite.Name = "lb_diskWrite";
            this.lb_diskWrite.Size = new System.Drawing.Size(67, 15);
            this.lb_diskWrite.TabIndex = 10;
            this.lb_diskWrite.Text = "100 MB/s";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "R  -";
            // 
            // lb_ram
            // 
            this.lb_ram.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_ram.AutoSize = true;
            this.lb_ram.BackColor = System.Drawing.Color.Transparent;
            this.lb_ram.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ram.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lb_ram.Location = new System.Drawing.Point(57, 32);
            this.lb_ram.Name = "lb_ram";
            this.lb_ram.Size = new System.Drawing.Size(43, 15);
            this.lb_ram.TabIndex = 4;
            this.lb_ram.Text = "100%";
            this.lb_ram.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_diskRead
            // 
            this.lb_diskRead.AutoSize = true;
            this.lb_diskRead.BackColor = System.Drawing.Color.Transparent;
            this.lb_diskRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_diskRead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lb_diskRead.Location = new System.Drawing.Point(86, 59);
            this.lb_diskRead.Name = "lb_diskRead";
            this.lb_diskRead.Size = new System.Drawing.Size(67, 15);
            this.lb_diskRead.TabIndex = 9;
            this.lb_diskRead.Text = "100 MB/s";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "CPU";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(527, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "0s";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(261, 390);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "60s";
            // 
            // chart1
            // 
            this.chart1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorTickMark.LineWidth = 2;
            chartArea1.AxisX.Maximum = 60D;
            chartArea1.AxisX.MaximumAutoSize = 60F;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MinorGrid.LineWidth = 2;
            chartArea1.AxisX2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.IsMarginVisible = false;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Bisque;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.Maximum = 100D;
            chartArea1.AxisY.MaximumAutoSize = 100F;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY2.InterlacedColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY2.LineWidth = 5;
            chartArea1.AxisY2.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY2.MajorGrid.LineWidth = 3;
            chartArea1.AxisY2.MajorTickMark.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY2.MajorTickMark.LineWidth = 4;
            chartArea1.AxisY2.MajorTickMark.Size = 2F;
            chartArea1.AxisY2.Maximum = 100D;
            chartArea1.AxisY2.MaximumAutoSize = 100F;
            chartArea1.AxisY2.Minimum = 0D;
            chartArea1.AxisY2.MinorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY2.MinorTickMark.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY2.TitleForeColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Black;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(259, 0);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))))};
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "CPU";
            series1.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series1.YValuesPerPoint = 2;
            series2.BorderWidth = 5;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "disk";
            series2.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(343, 408);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // for cCPU
            // 
            this.cCPU.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cCPU.AnimationSpeed = 500;
            this.cCPU.BackColor = System.Drawing.Color.Transparent;
            this.cCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cCPU.ForeColor = System.Drawing.Color.White;
            this.cCPU.InnerColor = System.Drawing.Color.Transparent;
            this.cCPU.InnerMargin = 2;
            this.cCPU.InnerWidth = -1;
            this.cCPU.Location = new System.Drawing.Point(10, 54);
            this.cCPU.MarqueeAnimationSpeed = 2000;
            this.cCPU.Name = "cCPU";
            this.cCPU.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.cCPU.OuterMargin = -25;
            this.cCPU.OuterWidth = 26;
            this.cCPU.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cCPU.ProgressWidth = 25;
            this.cCPU.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cCPU.Size = new System.Drawing.Size(240, 240);
            this.cCPU.StartAngle = 270;
            this.cCPU.SubscriptColor = System.Drawing.Color.White;
            this.cCPU.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cCPU.SubscriptText = "";
            this.cCPU.SuperscriptColor = System.Drawing.Color.DimGray;
            this.cCPU.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cCPU.SuperscriptText = "%";
            this.cCPU.TabIndex = 3;
            this.cCPU.Text = "60";
            this.cCPU.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cCPU.Value = 68;
            // 
            // for Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(631, 411);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelMenu);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Performane Monitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pCpu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDiskR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDiskW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRamAval)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelDesktopPane.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Diagnostics.PerformanceCounter pCpu;
        private System.Windows.Forms.Timer timer;
        private System.Diagnostics.PerformanceCounter pRam;
        private System.Diagnostics.PerformanceCounter pDiskR;
        private System.Diagnostics.PerformanceCounter pDiskW;
        private System.Diagnostics.PerformanceCounter pRamAval;
        private System.Windows.Forms.Button btn_ram;
        private System.Windows.Forms.Button btn_disk;
        private System.Windows.Forms.Button btn_cpu;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_ramB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_cpu1;
        private System.Windows.Forms.Label lb_diskWrite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_ram;
        private System.Windows.Forms.Label lb_diskRead;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private CircularProgressBar.CircularProgressBar cCPU;
    }
}

