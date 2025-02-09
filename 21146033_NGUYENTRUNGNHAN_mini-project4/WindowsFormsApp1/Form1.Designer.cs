namespace WindowsFormsApp1
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
            this.lblHinhXamLuminance = new System.Windows.Forms.Label();
            this.picBoxHinhXamLuminance = new System.Windows.Forms.PictureBox();
            this.lblHinhXamAverage = new System.Windows.Forms.Label();
            this.picBoxHinhXamAverage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picBoxHinhXamLightness = new System.Windows.Forms.PictureBox();
            this.lblHinhGoc = new System.Windows.Forms.Label();
            this.picBoxHinhGoc = new System.Windows.Forms.PictureBox();
            this.lblHinhNhiPhan = new System.Windows.Forms.Label();
            this.picBoxHinhNhiPhan = new System.Windows.Forms.PictureBox();
            this.vScrollBarHinhNhiPhan = new System.Windows.Forms.VScrollBar();
            this.lblThreshold = new System.Windows.Forms.Label();
            this.lblNguong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHinhXamLuminance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHinhXamAverage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHinhXamLightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHinhGoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHinhNhiPhan)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHinhXamLuminance
            // 
            this.lblHinhXamLuminance.AutoSize = true;
            this.lblHinhXamLuminance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHinhXamLuminance.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblHinhXamLuminance.Location = new System.Drawing.Point(414, 436);
            this.lblHinhXamLuminance.Name = "lblHinhXamLuminance";
            this.lblHinhXamLuminance.Size = new System.Drawing.Size(220, 22);
            this.lblHinhXamLuminance.TabIndex = 15;
            this.lblHinhXamLuminance.Text = "Hình mức xám Luminance:";
            // 
            // picBoxHinhXamLuminance
            // 
            this.picBoxHinhXamLuminance.Location = new System.Drawing.Point(418, 461);
            this.picBoxHinhXamLuminance.Name = "picBoxHinhXamLuminance";
            this.picBoxHinhXamLuminance.Size = new System.Drawing.Size(400, 400);
            this.picBoxHinhXamLuminance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxHinhXamLuminance.TabIndex = 14;
            this.picBoxHinhXamLuminance.TabStop = false;
            // 
            // lblHinhXamAverage
            // 
            this.lblHinhXamAverage.AutoSize = true;
            this.lblHinhXamAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHinhXamAverage.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblHinhXamAverage.Location = new System.Drawing.Point(8, 436);
            this.lblHinhXamAverage.Name = "lblHinhXamAverage";
            this.lblHinhXamAverage.Size = new System.Drawing.Size(200, 22);
            this.lblHinhXamAverage.TabIndex = 13;
            this.lblHinhXamAverage.Text = "Hình mức xám Average:";
            // 
            // picBoxHinhXamAverage
            // 
            this.picBoxHinhXamAverage.Location = new System.Drawing.Point(12, 461);
            this.picBoxHinhXamAverage.Name = "picBoxHinhXamAverage";
            this.picBoxHinhXamAverage.Size = new System.Drawing.Size(400, 400);
            this.picBoxHinhXamAverage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxHinhXamAverage.TabIndex = 12;
            this.picBoxHinhXamAverage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(414, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Hình mức xám Lightness:";
            // 
            // picBoxHinhXamLightness
            // 
            this.picBoxHinhXamLightness.Location = new System.Drawing.Point(418, 31);
            this.picBoxHinhXamLightness.Name = "picBoxHinhXamLightness";
            this.picBoxHinhXamLightness.Size = new System.Drawing.Size(400, 400);
            this.picBoxHinhXamLightness.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxHinhXamLightness.TabIndex = 10;
            this.picBoxHinhXamLightness.TabStop = false;
            // 
            // lblHinhGoc
            // 
            this.lblHinhGoc.AutoSize = true;
            this.lblHinhGoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHinhGoc.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblHinhGoc.Location = new System.Drawing.Point(8, 6);
            this.lblHinhGoc.Name = "lblHinhGoc";
            this.lblHinhGoc.Size = new System.Drawing.Size(86, 22);
            this.lblHinhGoc.TabIndex = 9;
            this.lblHinhGoc.Text = "Hình gốc:";
            // 
            // picBoxHinhGoc
            // 
            this.picBoxHinhGoc.Location = new System.Drawing.Point(12, 31);
            this.picBoxHinhGoc.Name = "picBoxHinhGoc";
            this.picBoxHinhGoc.Size = new System.Drawing.Size(400, 400);
            this.picBoxHinhGoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxHinhGoc.TabIndex = 8;
            this.picBoxHinhGoc.TabStop = false;
            // 
            // lblHinhNhiPhan
            // 
            this.lblHinhNhiPhan.AutoSize = true;
            this.lblHinhNhiPhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHinhNhiPhan.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblHinhNhiPhan.Location = new System.Drawing.Point(820, 8);
            this.lblHinhNhiPhan.Name = "lblHinhNhiPhan";
            this.lblHinhNhiPhan.Size = new System.Drawing.Size(126, 22);
            this.lblHinhNhiPhan.TabIndex = 17;
            this.lblHinhNhiPhan.Text = "Hình nhị phân:";
            // 
            // picBoxHinhNhiPhan
            // 
            this.picBoxHinhNhiPhan.Location = new System.Drawing.Point(824, 31);
            this.picBoxHinhNhiPhan.Name = "picBoxHinhNhiPhan";
            this.picBoxHinhNhiPhan.Size = new System.Drawing.Size(400, 400);
            this.picBoxHinhNhiPhan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxHinhNhiPhan.TabIndex = 16;
            this.picBoxHinhNhiPhan.TabStop = false;
            // 
            // vScrollBarHinhNhiPhan
            // 
            this.vScrollBarHinhNhiPhan.Location = new System.Drawing.Point(1245, 31);
            this.vScrollBarHinhNhiPhan.Maximum = 255;
            this.vScrollBarHinhNhiPhan.Name = "vScrollBarHinhNhiPhan";
            this.vScrollBarHinhNhiPhan.Size = new System.Drawing.Size(74, 400);
            this.vScrollBarHinhNhiPhan.TabIndex = 18;
            this.vScrollBarHinhNhiPhan.ValueChanged += new System.EventHandler(this.vScrollBarHinhNhiPhan_ValueChanged);
            // 
            // lblThreshold
            // 
            this.lblThreshold.AutoSize = true;
            this.lblThreshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThreshold.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblThreshold.Location = new System.Drawing.Point(1241, 6);
            this.lblThreshold.Name = "lblThreshold";
            this.lblThreshold.Size = new System.Drawing.Size(78, 22);
            this.lblThreshold.TabIndex = 19;
            this.lblThreshold.Text = "Ngưỡng:";
            // 
            // lblNguong
            // 
            this.lblNguong.AutoSize = true;
            this.lblNguong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNguong.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblNguong.Location = new System.Drawing.Point(1322, 31);
            this.lblNguong.Name = "lblNguong";
            this.lblNguong.Size = new System.Drawing.Size(0, 22);
            this.lblNguong.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1984, 1061);
            this.Controls.Add(this.lblNguong);
            this.Controls.Add(this.lblThreshold);
            this.Controls.Add(this.vScrollBarHinhNhiPhan);
            this.Controls.Add(this.lblHinhNhiPhan);
            this.Controls.Add(this.picBoxHinhNhiPhan);
            this.Controls.Add(this.lblHinhXamLuminance);
            this.Controls.Add(this.picBoxHinhXamLuminance);
            this.Controls.Add(this.lblHinhXamAverage);
            this.Controls.Add(this.picBoxHinhXamAverage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBoxHinhXamLightness);
            this.Controls.Add(this.lblHinhGoc);
            this.Controls.Add(this.picBoxHinhGoc);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHinhXamLuminance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHinhXamAverage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHinhXamLightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHinhGoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHinhNhiPhan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHinhXamLuminance;
        private System.Windows.Forms.PictureBox picBoxHinhXamLuminance;
        private System.Windows.Forms.Label lblHinhXamAverage;
        private System.Windows.Forms.PictureBox picBoxHinhXamAverage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBoxHinhXamLightness;
        private System.Windows.Forms.Label lblHinhGoc;
        private System.Windows.Forms.PictureBox picBoxHinhGoc;
        private System.Windows.Forms.Label lblHinhNhiPhan;
        private System.Windows.Forms.PictureBox picBoxHinhNhiPhan;
        private System.Windows.Forms.VScrollBar vScrollBarHinhNhiPhan;
        private System.Windows.Forms.Label lblThreshold;
        private System.Windows.Forms.Label lblNguong;
    }
}

