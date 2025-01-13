namespace Miniproject1
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
            this.picBox_HinhHienThi = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.HienThiHinh = new System.Windows.Forms.PictureBox();
            this.picBox_RED = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picBox_GREEN = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picBox_BLUE = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HienThiHinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_RED)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_GREEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_BLUE)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox_HinhHienThi
            // 
            this.picBox_HinhHienThi.AutoSize = true;
            this.picBox_HinhHienThi.Location = new System.Drawing.Point(30, 9);
            this.picBox_HinhHienThi.Name = "picBox_HinhHienThi";
            this.picBox_HinhHienThi.Size = new System.Drawing.Size(120, 16);
            this.picBox_HinhHienThi.TabIndex = 0;
            this.picBox_HinhHienThi.Text = "Hình ảnh gốc RBG;";
            this.picBox_HinhHienThi.Click += new System.EventHandler(this.label1_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            // 
            // HienThiHinh
            // 
            this.HienThiHinh.Location = new System.Drawing.Point(33, 28);
            this.HienThiHinh.Name = "HienThiHinh";
            this.HienThiHinh.Size = new System.Drawing.Size(738, 529);
            this.HienThiHinh.TabIndex = 1;
            this.HienThiHinh.TabStop = false;
            this.HienThiHinh.Click += new System.EventHandler(this.HienThiHinh_Click);
            // 
            // picBox_RED
            // 
            this.picBox_RED.Location = new System.Drawing.Point(816, 28);
            this.picBox_RED.Name = "picBox_RED";
            this.picBox_RED.Size = new System.Drawing.Size(691, 529);
            this.picBox_RED.TabIndex = 3;
            this.picBox_RED.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(813, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kênh màu đỏ Red:";
            // 
            // picBox_GREEN
            // 
            this.picBox_GREEN.Location = new System.Drawing.Point(33, 579);
            this.picBox_GREEN.Name = "picBox_GREEN";
            this.picBox_GREEN.Size = new System.Drawing.Size(738, 512);
            this.picBox_GREEN.TabIndex = 5;
            this.picBox_GREEN.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 560);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kênh màu xanh lá cây";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // picBox_BLUE
            // 
            this.picBox_BLUE.Location = new System.Drawing.Point(816, 579);
            this.picBox_BLUE.Name = "picBox_BLUE";
            this.picBox_BLUE.Size = new System.Drawing.Size(691, 512);
            this.picBox_BLUE.TabIndex = 7;
            this.picBox_BLUE.TabStop = false;
            this.picBox_BLUE.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(813, 560);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kênh màu xanh nước biển";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1782, 1055);
            this.Controls.Add(this.picBox_BLUE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picBox_GREEN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picBox_RED);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HienThiHinh);
            this.Controls.Add(this.picBox_HinhHienThi);
            this.Name = "Form1";
            this.Text = "Tách ảnh màu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HienThiHinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_RED)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_GREEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_BLUE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label picBox_HinhHienThi;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.PictureBox HienThiHinh;
        private System.Windows.Forms.PictureBox picBox_BLUE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picBox_GREEN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picBox_RED;
        private System.Windows.Forms.Label label1;
    }
}

