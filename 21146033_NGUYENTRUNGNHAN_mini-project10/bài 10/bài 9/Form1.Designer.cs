namespace bài_10
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.picBoxHinhGoc = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Button = new System.Windows.Forms.Button();
            this.picBoxKenhY = new System.Windows.Forms.PictureBox();
            this.picBoxKenhCr = new System.Windows.Forms.PictureBox();
            this.picBoxKenhCb = new System.Windows.Forms.PictureBox();
            this.picBoxKenhYCrCb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHinhGoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxKenhY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxKenhCr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxKenhCb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxKenhYCrCb)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(283, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kênh Y:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(1113, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kênh YCrCb:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(560, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kênh Cr:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(836, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kênh Cb:";
            // 
            // picBoxHinhGoc
            // 
            this.picBoxHinhGoc.Location = new System.Drawing.Point(12, 37);
            this.picBoxHinhGoc.Name = "picBoxHinhGoc";
            this.picBoxHinhGoc.Size = new System.Drawing.Size(256, 256);
            this.picBoxHinhGoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxHinhGoc.TabIndex = 10;
            this.picBoxHinhGoc.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(12, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "HinhGocRGB:";
            // 
            // Button
            // 
            this.Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button.ForeColor = System.Drawing.Color.OrangeRed;
            this.Button.Location = new System.Drawing.Point(574, 337);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(178, 70);
            this.Button.TabIndex = 12;
            this.Button.Text = "RGB to YCrCb";
            this.Button.UseVisualStyleBackColor = true;
            // 
            // picBoxKenhY
            // 
            this.picBoxKenhY.Location = new System.Drawing.Point(287, 37);
            this.picBoxKenhY.Name = "picBoxKenhY";
            this.picBoxKenhY.Size = new System.Drawing.Size(256, 256);
            this.picBoxKenhY.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxKenhY.TabIndex = 13;
            this.picBoxKenhY.TabStop = false;
            // 
            // picBoxKenhCr
            // 
            this.picBoxKenhCr.Location = new System.Drawing.Point(564, 37);
            this.picBoxKenhCr.Name = "picBoxKenhCr";
            this.picBoxKenhCr.Size = new System.Drawing.Size(256, 256);
            this.picBoxKenhCr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxKenhCr.TabIndex = 14;
            this.picBoxKenhCr.TabStop = false;
            // 
            // picBoxKenhCb
            // 
            this.picBoxKenhCb.Location = new System.Drawing.Point(840, 37);
            this.picBoxKenhCb.Name = "picBoxKenhCb";
            this.picBoxKenhCb.Size = new System.Drawing.Size(256, 256);
            this.picBoxKenhCb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxKenhCb.TabIndex = 15;
            this.picBoxKenhCb.TabStop = false;
            // 
            // picBoxKenhYCrCb
            // 
            this.picBoxKenhYCrCb.Location = new System.Drawing.Point(1117, 37);
            this.picBoxKenhYCrCb.Name = "picBoxKenhYCrCb";
            this.picBoxKenhYCrCb.Size = new System.Drawing.Size(256, 256);
            this.picBoxKenhYCrCb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxKenhYCrCb.TabIndex = 16;
            this.picBoxKenhYCrCb.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 461);
            this.Controls.Add(this.picBoxKenhYCrCb);
            this.Controls.Add(this.picBoxKenhCb);
            this.Controls.Add(this.picBoxKenhCr);
            this.Controls.Add(this.picBoxKenhY);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.picBoxHinhGoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHinhGoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxKenhY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxKenhCr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxKenhCb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxKenhYCrCb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picBoxHinhGoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.PictureBox picBoxKenhY;
        private System.Windows.Forms.PictureBox picBoxKenhCr;
        private System.Windows.Forms.PictureBox picBoxKenhCb;
        private System.Windows.Forms.PictureBox picBoxKenhYCrCb;
    }
}

