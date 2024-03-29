﻿namespace WinForms_PictureBoxDraw
{
    partial class DrawTestForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Panel_Header = new System.Windows.Forms.Panel();
            this.Button_Minimized = new System.Windows.Forms.Button();
            this.Button_Maximized = new System.Windows.Forms.Button();
            this.Button_Close = new System.Windows.Forms.Button();
            this.Tab_Pictures = new WindowsFormsCustomControlLibrary.TabControlEx();
            this.TabPage_Orizin = new System.Windows.Forms.TabPage();
            this.PictureBox_Orizin = new System.Windows.Forms.PictureBox();
            this.loadImageButton = new System.Windows.Forms.Button();
            this.TabPage_Binarization = new System.Windows.Forms.TabPage();
            this.Button_Binaryzation = new System.Windows.Forms.Button();
            this.Label_Binaryzation = new System.Windows.Forms.Label();
            this.TrackBar_Binaryzation = new System.Windows.Forms.TrackBar();
            this.PictureBox_Binaryzation = new System.Windows.Forms.PictureBox();
            this.tabPage_Chart = new System.Windows.Forms.TabPage();
            this.TestChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label_BMP = new System.Windows.Forms.Label();
            this.label_Blank = new System.Windows.Forms.Label();
            this.label_Rulud = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Panel_Header.SuspendLayout();
            this.Tab_Pictures.SuspendLayout();
            this.TabPage_Orizin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Orizin)).BeginInit();
            this.TabPage_Binarization.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_Binaryzation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Binaryzation)).BeginInit();
            this.tabPage_Chart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TestChart)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Image";
            this.openFileDialog.Filter = "Image Files (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";
            // 
            // Panel_Header
            // 
            this.Panel_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Panel_Header.Controls.Add(this.Button_Minimized);
            this.Panel_Header.Controls.Add(this.Button_Maximized);
            this.Panel_Header.Controls.Add(this.Button_Close);
            this.Panel_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Header.Location = new System.Drawing.Point(0, 0);
            this.Panel_Header.Name = "Panel_Header";
            this.Panel_Header.Size = new System.Drawing.Size(1290, 32);
            this.Panel_Header.TabIndex = 4;
            this.Panel_Header.DoubleClick += new System.EventHandler(this.Panel_Header_DoubleClick);
            this.Panel_Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_Header_MouseDown);
            this.Panel_Header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_Header_MouseMove);
            // 
            // Button_Minimized
            // 
            this.Button_Minimized.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Button_Minimized.BackgroundImage = global::WinForms_PictureBoxDraw.Properties.Resources.windowminimize;
            this.Button_Minimized.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button_Minimized.Dock = System.Windows.Forms.DockStyle.Right;
            this.Button_Minimized.FlatAppearance.BorderSize = 0;
            this.Button_Minimized.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Button_Minimized.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Button_Minimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Minimized.Font = new System.Drawing.Font("メイリオ", 20F);
            this.Button_Minimized.ForeColor = System.Drawing.Color.White;
            this.Button_Minimized.Location = new System.Drawing.Point(1128, 0);
            this.Button_Minimized.Name = "Button_Minimized";
            this.Button_Minimized.Size = new System.Drawing.Size(54, 32);
            this.Button_Minimized.TabIndex = 5;
            this.Button_Minimized.UseVisualStyleBackColor = false;
            this.Button_Minimized.Click += new System.EventHandler(this.Button_Minimized_Click);
            // 
            // Button_Maximized
            // 
            this.Button_Maximized.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Button_Maximized.BackgroundImage = global::WinForms_PictureBoxDraw.Properties.Resources.windowmaximize;
            this.Button_Maximized.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button_Maximized.Dock = System.Windows.Forms.DockStyle.Right;
            this.Button_Maximized.FlatAppearance.BorderSize = 0;
            this.Button_Maximized.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Button_Maximized.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Button_Maximized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Maximized.Font = new System.Drawing.Font("メイリオ", 20F);
            this.Button_Maximized.ForeColor = System.Drawing.Color.White;
            this.Button_Maximized.Location = new System.Drawing.Point(1182, 0);
            this.Button_Maximized.Name = "Button_Maximized";
            this.Button_Maximized.Size = new System.Drawing.Size(54, 32);
            this.Button_Maximized.TabIndex = 4;
            this.Button_Maximized.Text = " ";
            this.Button_Maximized.UseVisualStyleBackColor = false;
            this.Button_Maximized.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Button_Maximized_MouseClick);
            // 
            // Button_Close
            // 
            this.Button_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Button_Close.BackgroundImage = global::WinForms_PictureBoxDraw.Properties.Resources.windowclose;
            this.Button_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.Button_Close.FlatAppearance.BorderSize = 0;
            this.Button_Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.Button_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Close.Font = new System.Drawing.Font("メイリオ", 20F);
            this.Button_Close.ForeColor = System.Drawing.Color.White;
            this.Button_Close.Location = new System.Drawing.Point(1236, 0);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(54, 32);
            this.Button_Close.TabIndex = 3;
            this.Button_Close.UseVisualStyleBackColor = false;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // Tab_Pictures
            // 
            this.Tab_Pictures.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Tab_Pictures.AllowDrop = true;
            this.Tab_Pictures.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tab_Pictures.BackTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.Tab_Pictures.BorderColor = System.Drawing.Color.Transparent;
            this.Tab_Pictures.ClosingButtonColor = System.Drawing.Color.WhiteSmoke;
            this.Tab_Pictures.ClosingMessage = null;
            this.Tab_Pictures.Controls.Add(this.TabPage_Orizin);
            this.Tab_Pictures.Controls.Add(this.TabPage_Binarization);
            this.Tab_Pictures.Controls.Add(this.tabPage_Chart);
            this.Tab_Pictures.Font = new System.Drawing.Font("メイリオ", 12F);
            this.Tab_Pictures.HeaderColor = System.Drawing.Color.Transparent;
            this.Tab_Pictures.HorizontalLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Tab_Pictures.ItemSize = new System.Drawing.Size(240, 16);
            this.Tab_Pictures.Location = new System.Drawing.Point(0, 38);
            this.Tab_Pictures.Name = "Tab_Pictures";
            this.Tab_Pictures.SelectedIndex = 0;
            this.Tab_Pictures.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Tab_Pictures.ShowClosingButton = false;
            this.Tab_Pictures.ShowClosingMessage = false;
            this.Tab_Pictures.Size = new System.Drawing.Size(1290, 860);
            this.Tab_Pictures.TabIndex = 2;
            this.Tab_Pictures.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // TabPage_Orizin
            // 
            this.TabPage_Orizin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.TabPage_Orizin.Controls.Add(this.PictureBox_Orizin);
            this.TabPage_Orizin.Controls.Add(this.loadImageButton);
            this.TabPage_Orizin.Location = new System.Drawing.Point(4, 20);
            this.TabPage_Orizin.Name = "TabPage_Orizin";
            this.TabPage_Orizin.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Orizin.Size = new System.Drawing.Size(1282, 836);
            this.TabPage_Orizin.TabIndex = 0;
            this.TabPage_Orizin.Text = "オリジナル";
            // 
            // PictureBox_Orizin
            // 
            this.PictureBox_Orizin.BackColor = System.Drawing.Color.White;
            this.PictureBox_Orizin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureBox_Orizin.Location = new System.Drawing.Point(5, 5);
            this.PictureBox_Orizin.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.PictureBox_Orizin.Name = "PictureBox_Orizin";
            this.PictureBox_Orizin.Size = new System.Drawing.Size(955, 600);
            this.PictureBox_Orizin.TabIndex = 0;
            this.PictureBox_Orizin.TabStop = false;
            this.PictureBox_Orizin.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.PictureBox_Orizin.DoubleClick += new System.EventHandler(this.pictureBox_DoubleClick);
            this.PictureBox_Orizin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.PictureBox_Orizin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.PictureBox_Orizin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // loadImageButton
            // 
            this.loadImageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.loadImageButton.FlatAppearance.BorderSize = 0;
            this.loadImageButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.loadImageButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.loadImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadImageButton.Font = new System.Drawing.Font("メイリオ", 12F);
            this.loadImageButton.ForeColor = System.Drawing.Color.White;
            this.loadImageButton.Location = new System.Drawing.Point(990, 21);
            this.loadImageButton.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.loadImageButton.Name = "loadImageButton";
            this.loadImageButton.Size = new System.Drawing.Size(230, 92);
            this.loadImageButton.TabIndex = 1;
            this.loadImageButton.Text = "画像読み込み";
            this.loadImageButton.UseVisualStyleBackColor = false;
            this.loadImageButton.Click += new System.EventHandler(this.loadImageButton_Click);
            // 
            // TabPage_Binarization
            // 
            this.TabPage_Binarization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.TabPage_Binarization.Controls.Add(this.Button_Binaryzation);
            this.TabPage_Binarization.Controls.Add(this.Label_Binaryzation);
            this.TabPage_Binarization.Controls.Add(this.TrackBar_Binaryzation);
            this.TabPage_Binarization.Controls.Add(this.PictureBox_Binaryzation);
            this.TabPage_Binarization.Location = new System.Drawing.Point(4, 20);
            this.TabPage_Binarization.Name = "TabPage_Binarization";
            this.TabPage_Binarization.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Binarization.Size = new System.Drawing.Size(1282, 836);
            this.TabPage_Binarization.TabIndex = 1;
            this.TabPage_Binarization.Text = "2値化";
            // 
            // Button_Binaryzation
            // 
            this.Button_Binaryzation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Button_Binaryzation.FlatAppearance.BorderSize = 0;
            this.Button_Binaryzation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.Button_Binaryzation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Button_Binaryzation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Binaryzation.Font = new System.Drawing.Font("メイリオ", 12F);
            this.Button_Binaryzation.ForeColor = System.Drawing.Color.White;
            this.Button_Binaryzation.Location = new System.Drawing.Point(1027, 186);
            this.Button_Binaryzation.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Button_Binaryzation.Name = "Button_Binaryzation";
            this.Button_Binaryzation.Size = new System.Drawing.Size(230, 92);
            this.Button_Binaryzation.TabIndex = 4;
            this.Button_Binaryzation.Text = "2 値化";
            this.Button_Binaryzation.UseVisualStyleBackColor = false;
            this.Button_Binaryzation.Click += new System.EventHandler(this.Button_Binaryzation_Click);
            // 
            // Label_Binaryzation
            // 
            this.Label_Binaryzation.AutoSize = true;
            this.Label_Binaryzation.Font = new System.Drawing.Font("メイリオ", 15F);
            this.Label_Binaryzation.ForeColor = System.Drawing.Color.White;
            this.Label_Binaryzation.Location = new System.Drawing.Point(1170, 92);
            this.Label_Binaryzation.Name = "Label_Binaryzation";
            this.Label_Binaryzation.Size = new System.Drawing.Size(56, 30);
            this.Label_Binaryzation.TabIndex = 3;
            this.Label_Binaryzation.Text = "0.00";
            // 
            // TrackBar_Binaryzation
            // 
            this.TrackBar_Binaryzation.Location = new System.Drawing.Point(976, 20);
            this.TrackBar_Binaryzation.Maximum = 100;
            this.TrackBar_Binaryzation.Name = "TrackBar_Binaryzation";
            this.TrackBar_Binaryzation.Size = new System.Drawing.Size(298, 45);
            this.TrackBar_Binaryzation.TabIndex = 2;
            this.TrackBar_Binaryzation.TickFrequency = 10;
            this.TrackBar_Binaryzation.Value = 50;
            this.TrackBar_Binaryzation.ValueChanged += new System.EventHandler(this.TrackBar_Binaryzation_ValueChanged);
            // 
            // PictureBox_Binaryzation
            // 
            this.PictureBox_Binaryzation.BackColor = System.Drawing.Color.White;
            this.PictureBox_Binaryzation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureBox_Binaryzation.Location = new System.Drawing.Point(5, 5);
            this.PictureBox_Binaryzation.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.PictureBox_Binaryzation.Name = "PictureBox_Binaryzation";
            this.PictureBox_Binaryzation.Size = new System.Drawing.Size(955, 600);
            this.PictureBox_Binaryzation.TabIndex = 1;
            this.PictureBox_Binaryzation.TabStop = false;
            this.PictureBox_Binaryzation.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.PictureBox_Binaryzation.DoubleClick += new System.EventHandler(this.pictureBox_DoubleClick);
            this.PictureBox_Binaryzation.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.PictureBox_Binaryzation.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.PictureBox_Binaryzation.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // tabPage_Chart
            // 
            this.tabPage_Chart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.tabPage_Chart.Controls.Add(this.panel1);
            this.tabPage_Chart.Location = new System.Drawing.Point(4, 20);
            this.tabPage_Chart.Name = "tabPage_Chart";
            this.tabPage_Chart.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Chart.Size = new System.Drawing.Size(1282, 836);
            this.tabPage_Chart.TabIndex = 2;
            this.tabPage_Chart.Text = "チャート";
            // 
            // TestChart
            // 
            this.TestChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            chartArea2.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.None;
            chartArea2.AxisX.Interval = 1D;
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisY.Interval = 2D;
            chartArea2.AxisY.LabelStyle.Enabled = false;
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            chartArea2.AxisY.MajorTickMark.Enabled = false;
            chartArea2.AxisY.Maximum = 6D;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            chartArea2.BorderColor = System.Drawing.Color.White;
            chartArea2.Name = "ChartArea1";
            this.TestChart.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            legend2.ForeColor = System.Drawing.Color.White;
            legend2.HeaderSeparatorColor = System.Drawing.Color.White;
            legend2.ItemColumnSeparatorColor = System.Drawing.Color.White;
            legend2.Name = "Legend1";
            legend2.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            legend2.TitleForeColor = System.Drawing.Color.White;
            legend2.TitleSeparatorColor = System.Drawing.Color.White;
            this.TestChart.Legends.Add(legend2);
            this.TestChart.Location = new System.Drawing.Point(59, 0);
            this.TestChart.Name = "TestChart";
            this.TestChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series4.Legend = "Legend1";
            series4.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(136)))), ((int)(((byte)(0)))));
            series4.MarkerBorderWidth = 3;
            series4.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(136)))), ((int)(((byte)(0)))));
            series4.MarkerSize = 10;
            series4.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series4.Name = "BMP";
            series4.YValuesPerPoint = 6;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series5.Legend = "Legend1";
            series5.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(159)))), ((int)(((byte)(214)))));
            series5.MarkerBorderWidth = 3;
            series5.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(159)))), ((int)(((byte)(214)))));
            series5.MarkerSize = 10;
            series5.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series5.Name = "空白";
            series5.YValuesPerPoint = 6;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series6.Legend = "Legend1";
            series6.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(51)))), ((int)(((byte)(204)))));
            series6.MarkerBorderWidth = 3;
            series6.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(51)))), ((int)(((byte)(204)))));
            series6.MarkerSize = 10;
            series6.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series6.Name = "罫線";
            series6.YValuesPerPoint = 6;
            this.TestChart.Series.Add(series4);
            this.TestChart.Series.Add(series5);
            this.TestChart.Series.Add(series6);
            this.TestChart.Size = new System.Drawing.Size(742, 308);
            this.TestChart.TabIndex = 0;
            this.TestChart.Text = "chart1";
            // 
            // label_BMP
            // 
            this.label_BMP.AutoSize = true;
            this.label_BMP.ForeColor = System.Drawing.Color.White;
            this.label_BMP.Location = new System.Drawing.Point(39, 52);
            this.label_BMP.Name = "label_BMP";
            this.label_BMP.Size = new System.Drawing.Size(44, 24);
            this.label_BMP.TabIndex = 1;
            this.label_BMP.Text = "BMP";
            // 
            // label_Blank
            // 
            this.label_Blank.AutoSize = true;
            this.label_Blank.ForeColor = System.Drawing.Color.White;
            this.label_Blank.Location = new System.Drawing.Point(39, 133);
            this.label_Blank.Name = "label_Blank";
            this.label_Blank.Size = new System.Drawing.Size(42, 24);
            this.label_Blank.TabIndex = 2;
            this.label_Blank.Text = "空白";
            // 
            // label_Rulud
            // 
            this.label_Rulud.AutoSize = true;
            this.label_Rulud.ForeColor = System.Drawing.Color.White;
            this.label_Rulud.Location = new System.Drawing.Point(39, 221);
            this.label_Rulud.Name = "label_Rulud";
            this.label_Rulud.Size = new System.Drawing.Size(42, 24);
            this.label_Rulud.TabIndex = 3;
            this.label_Rulud.Text = "罫線";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_Rulud);
            this.panel1.Controls.Add(this.label_BMP);
            this.panel1.Controls.Add(this.label_Blank);
            this.panel1.Controls.Add(this.TestChart);
            this.panel1.Location = new System.Drawing.Point(216, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 309);
            this.panel1.TabIndex = 4;
            // 
            // DrawTestForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.ClientSize = new System.Drawing.Size(1290, 900);
            this.Controls.Add(this.Panel_Header);
            this.Controls.Add(this.Tab_Pictures);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "DrawTestForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DrawTestForm_Load);
            this.Resize += new System.EventHandler(this.DrawTestForm_Resize);
            this.Panel_Header.ResumeLayout(false);
            this.Tab_Pictures.ResumeLayout(false);
            this.TabPage_Orizin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Orizin)).EndInit();
            this.TabPage_Binarization.ResumeLayout(false);
            this.TabPage_Binarization.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_Binaryzation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Binaryzation)).EndInit();
            this.tabPage_Chart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TestChart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox_Orizin;
        private System.Windows.Forms.Button loadImageButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private WindowsFormsCustomControlLibrary.TabControlEx Tab_Pictures;
        private System.Windows.Forms.TabPage TabPage_Orizin;
        private System.Windows.Forms.TabPage TabPage_Binarization;
        private System.Windows.Forms.PictureBox PictureBox_Binaryzation;
        private System.Windows.Forms.Button Button_Close;
        private System.Windows.Forms.Panel Panel_Header;
        private System.Windows.Forms.Button Button_Minimized;
        private System.Windows.Forms.Button Button_Maximized;
        private System.Windows.Forms.TrackBar TrackBar_Binaryzation;
        private System.Windows.Forms.Label Label_Binaryzation;
        private System.Windows.Forms.Button Button_Binaryzation;
        private System.Windows.Forms.TabPage tabPage_Chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart TestChart;
        private System.Windows.Forms.Label label_Rulud;
        private System.Windows.Forms.Label label_Blank;
        private System.Windows.Forms.Label label_BMP;
        private System.Windows.Forms.Panel panel1;
    }
}

