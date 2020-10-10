namespace WinForms_PictureBoxDraw
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
            this.loadImageButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Tab_Pictures = new WindowsFormsCustomControlLibrary.TabControlEx();
            this.TabPage_Orizin = new System.Windows.Forms.TabPage();
            this.PictureBox_Orizin = new System.Windows.Forms.PictureBox();
            this.TabPage_Binarization = new System.Windows.Forms.TabPage();
            this.PictureBox_Binaryzation = new System.Windows.Forms.PictureBox();
            this.Tab_Pictures.SuspendLayout();
            this.TabPage_Orizin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Orizin)).BeginInit();
            this.TabPage_Binarization.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Binaryzation)).BeginInit();
            this.SuspendLayout();
            // 
            // loadImageButton
            // 
            this.loadImageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.loadImageButton.ForeColor = System.Drawing.Color.White;
            this.loadImageButton.Location = new System.Drawing.Point(10, 11);
            this.loadImageButton.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.loadImageButton.Name = "loadImageButton";
            this.loadImageButton.Size = new System.Drawing.Size(112, 40);
            this.loadImageButton.TabIndex = 1;
            this.loadImageButton.Text = "画像読み込み";
            this.loadImageButton.UseVisualStyleBackColor = false;
            this.loadImageButton.Click += new System.EventHandler(this.loadImageButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Image";
            this.openFileDialog.Filter = "Image Files (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";
            // 
            // Tab_Pictures
            // 
            this.Tab_Pictures.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Tab_Pictures.AllowDrop = true;
            this.Tab_Pictures.BackTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Tab_Pictures.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Tab_Pictures.ClosingButtonColor = System.Drawing.Color.WhiteSmoke;
            this.Tab_Pictures.ClosingMessage = null;
            this.Tab_Pictures.Controls.Add(this.TabPage_Orizin);
            this.Tab_Pictures.Controls.Add(this.TabPage_Binarization);
            this.Tab_Pictures.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Tab_Pictures.HorizontalLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Tab_Pictures.ItemSize = new System.Drawing.Size(240, 16);
            this.Tab_Pictures.Location = new System.Drawing.Point(12, 73);
            this.Tab_Pictures.Name = "Tab_Pictures";
            this.Tab_Pictures.SelectedIndex = 0;
            this.Tab_Pictures.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Tab_Pictures.ShowClosingButton = false;
            this.Tab_Pictures.ShowClosingMessage = false;
            this.Tab_Pictures.Size = new System.Drawing.Size(1860, 995);
            this.Tab_Pictures.TabIndex = 2;
            this.Tab_Pictures.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // TabPage_Orizin
            // 
            this.TabPage_Orizin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.TabPage_Orizin.Controls.Add(this.PictureBox_Orizin);
            this.TabPage_Orizin.Location = new System.Drawing.Point(4, 20);
            this.TabPage_Orizin.Name = "TabPage_Orizin";
            this.TabPage_Orizin.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Orizin.Size = new System.Drawing.Size(1852, 971);
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
            // TabPage_Binarization
            // 
            this.TabPage_Binarization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.TabPage_Binarization.Controls.Add(this.PictureBox_Binaryzation);
            this.TabPage_Binarization.Location = new System.Drawing.Point(4, 20);
            this.TabPage_Binarization.Name = "TabPage_Binarization";
            this.TabPage_Binarization.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Binarization.Size = new System.Drawing.Size(1852, 971);
            this.TabPage_Binarization.TabIndex = 1;
            this.TabPage_Binarization.Text = "2値化";
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
            // DrawTestForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.Tab_Pictures);
            this.Controls.Add(this.loadImageButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.MinimumSize = new System.Drawing.Size(1918, 1048);
            this.Name = "DrawTestForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DrawTestForm_Load);
            this.Resize += new System.EventHandler(this.DrawTestForm_Resize);
            this.Tab_Pictures.ResumeLayout(false);
            this.TabPage_Orizin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Orizin)).EndInit();
            this.TabPage_Binarization.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Binaryzation)).EndInit();
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
    }
}

