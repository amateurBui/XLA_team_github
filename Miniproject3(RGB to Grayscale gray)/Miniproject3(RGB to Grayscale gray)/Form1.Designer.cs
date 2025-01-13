namespace Miniproject3_RGB_to_Grayscale_gray_
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
            this.lbl_HinhGoc = new System.Windows.Forms.Label();
            this.lbl_HinhAverage = new System.Windows.Forms.Label();
            this.lbl_HinhLightress = new System.Windows.Forms.Label();
            this.lbl_HinhLuminance = new System.Windows.Forms.Label();
            this.picBox_AnhGoc = new System.Windows.Forms.PictureBox();
            this.picBox_Lightress = new System.Windows.Forms.PictureBox();
            this.picBox_Luminance = new System.Windows.Forms.PictureBox();
            this.picBox_Average = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_AnhGoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Lightress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Luminance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Average)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_HinhGoc
            // 
            this.lbl_HinhGoc.AutoSize = true;
            this.lbl_HinhGoc.Location = new System.Drawing.Point(12, 9);
            this.lbl_HinhGoc.Name = "lbl_HinhGoc";
            this.lbl_HinhGoc.Size = new System.Drawing.Size(87, 16);
            this.lbl_HinhGoc.TabIndex = 0;
            this.lbl_HinhGoc.Text = "ảnh gốc RGB";
            this.lbl_HinhGoc.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_HinhAverage
            // 
            this.lbl_HinhAverage.AutoSize = true;
            this.lbl_HinhAverage.Location = new System.Drawing.Point(12, 534);
            this.lbl_HinhAverage.Name = "lbl_HinhAverage";
            this.lbl_HinhAverage.Size = new System.Drawing.Size(128, 16);
            this.lbl_HinhAverage.TabIndex = 3;
            this.lbl_HinhAverage.Text = "Grayscale_Average";
            // 
            // lbl_HinhLightress
            // 
            this.lbl_HinhLightress.AutoSize = true;
            this.lbl_HinhLightress.Location = new System.Drawing.Point(801, 9);
            this.lbl_HinhLightress.Name = "lbl_HinhLightress";
            this.lbl_HinhLightress.Size = new System.Drawing.Size(130, 16);
            this.lbl_HinhLightress.TabIndex = 5;
            this.lbl_HinhLightress.Text = "Grayscale_Lightress";
            this.lbl_HinhLightress.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_HinhLuminance
            // 
            this.lbl_HinhLuminance.AutoSize = true;
            this.lbl_HinhLuminance.Location = new System.Drawing.Point(801, 534);
            this.lbl_HinhLuminance.Name = "lbl_HinhLuminance";
            this.lbl_HinhLuminance.Size = new System.Drawing.Size(141, 16);
            this.lbl_HinhLuminance.TabIndex = 7;
            this.lbl_HinhLuminance.Text = "Grayscale_Luminance";
            // 
            // picBox_AnhGoc
            // 
            this.picBox_AnhGoc.Location = new System.Drawing.Point(12, 28);
            this.picBox_AnhGoc.Name = "picBox_AnhGoc";
            this.picBox_AnhGoc.Size = new System.Drawing.Size(774, 503);
            this.picBox_AnhGoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_AnhGoc.TabIndex = 8;
            this.picBox_AnhGoc.TabStop = false;
            // 
            // picBox_Lightress
            // 
            this.picBox_Lightress.Location = new System.Drawing.Point(804, 28);
            this.picBox_Lightress.Name = "picBox_Lightress";
            this.picBox_Lightress.Size = new System.Drawing.Size(774, 503);
            this.picBox_Lightress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_Lightress.TabIndex = 9;
            this.picBox_Lightress.TabStop = false;
            // 
            // picBox_Luminance
            // 
            this.picBox_Luminance.Location = new System.Drawing.Point(804, 553);
            this.picBox_Luminance.Name = "picBox_Luminance";
            this.picBox_Luminance.Size = new System.Drawing.Size(774, 503);
            this.picBox_Luminance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_Luminance.TabIndex = 10;
            this.picBox_Luminance.TabStop = false;
            // 
            // picBox_Average
            // 
            this.picBox_Average.Location = new System.Drawing.Point(15, 553);
            this.picBox_Average.Name = "picBox_Average";
            this.picBox_Average.Size = new System.Drawing.Size(774, 503);
            this.picBox_Average.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_Average.TabIndex = 11;
            this.picBox_Average.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.picBox_Average);
            this.Controls.Add(this.picBox_Luminance);
            this.Controls.Add(this.picBox_Lightress);
            this.Controls.Add(this.picBox_AnhGoc);
            this.Controls.Add(this.lbl_HinhLuminance);
            this.Controls.Add(this.lbl_HinhLightress);
            this.Controls.Add(this.lbl_HinhAverage);
            this.Controls.Add(this.lbl_HinhGoc);
            this.Name = "Form1";
            this.Text = "chuyển đổi ảnh RGB thành ảnh xám";
            ((System.ComponentModel.ISupportInitialize)(this.picBox_AnhGoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Lightress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Luminance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Average)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_HinhGoc;
        private System.Windows.Forms.Label lbl_HinhAverage;
        private System.Windows.Forms.Label lbl_HinhLightress;
        private System.Windows.Forms.Label lbl_HinhLuminance;
        private System.Windows.Forms.PictureBox picBox_AnhGoc;
        private System.Windows.Forms.PictureBox picBox_Lightress;
        private System.Windows.Forms.PictureBox picBox_Luminance;
        private System.Windows.Forms.PictureBox picBox_Average;
    }
}

