namespace bài_8
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
            this.picBoxHinhGoc = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picBoxH = new System.Windows.Forms.PictureBox();
            this.picBoxS = new System.Windows.Forms.PictureBox();
            this.picBoxV = new System.Windows.Forms.PictureBox();
            this.picBoxHSV = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHinhGoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHSV)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxHinhGoc
            // 
            this.picBoxHinhGoc.Location = new System.Drawing.Point(12, 34);
            this.picBoxHinhGoc.Name = "picBoxHinhGoc";
            this.picBoxHinhGoc.Size = new System.Drawing.Size(256, 256);
            this.picBoxHinhGoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxHinhGoc.TabIndex = 0;
            this.picBoxHinhGoc.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "HinhGocRGB:";
            // 
            // picBoxH
            // 
            this.picBoxH.Location = new System.Drawing.Point(305, 34);
            this.picBoxH.Name = "picBoxH";
            this.picBoxH.Size = new System.Drawing.Size(256, 256);
            this.picBoxH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxH.TabIndex = 2;
            this.picBoxH.TabStop = false;
            // 
            // picBoxS
            // 
            this.picBoxS.Location = new System.Drawing.Point(594, 34);
            this.picBoxS.Name = "picBoxS";
            this.picBoxS.Size = new System.Drawing.Size(256, 256);
            this.picBoxS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxS.TabIndex = 3;
            this.picBoxS.TabStop = false;
            // 
            // picBoxV
            // 
            this.picBoxV.Location = new System.Drawing.Point(882, 34);
            this.picBoxV.Name = "picBoxV";
            this.picBoxV.Size = new System.Drawing.Size(256, 256);
            this.picBoxV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxV.TabIndex = 4;
            this.picBoxV.TabStop = false;
            // 
            // picBoxHSV
            // 
            this.picBoxHSV.Location = new System.Drawing.Point(1161, 34);
            this.picBoxHSV.Name = "picBoxHSV";
            this.picBoxHSV.Size = new System.Drawing.Size(256, 256);
            this.picBoxHSV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxHSV.TabIndex = 5;
            this.picBoxHSV.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(302, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "KenhHue:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(591, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "KenhSaturation:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(879, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "KenhValue:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(1158, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "HinhHSV:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(625, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 102);
            this.button1.TabIndex = 11;
            this.button1.Text = "RGB to HSV";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 661);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picBoxHSV);
            this.Controls.Add(this.picBoxV);
            this.Controls.Add(this.picBoxS);
            this.Controls.Add(this.picBoxH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBoxHinhGoc);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHinhGoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxHinhGoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBoxH;
        private System.Windows.Forms.PictureBox picBoxS;
        private System.Windows.Forms.PictureBox picBoxV;
        private System.Windows.Forms.PictureBox picBoxHSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}

