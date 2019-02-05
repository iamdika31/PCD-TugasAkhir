namespace Projek2
{
    partial class FormMain
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
            this.openGambar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnBiner = new System.Windows.Forms.Button();
            this.btnErosi = new System.Windows.Forms.Button();
            this.btnDilasi = new System.Windows.Forms.Button();
            this.labelObj = new System.Windows.Forms.Label();
            this.btnEroHor = new System.Windows.Forms.Button();
            this.BtnDetectFinal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // openGambar
            // 
            this.openGambar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openGambar.Location = new System.Drawing.Point(34, 56);
            this.openGambar.Name = "openGambar";
            this.openGambar.Size = new System.Drawing.Size(75, 23);
            this.openGambar.TabIndex = 0;
            this.openGambar.Text = "Open";
            this.openGambar.UseVisualStyleBackColor = true;
            this.openGambar.Click += new System.EventHandler(this.openGambar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(34, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(354, 405);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPEG|*.jpg|BMP|*.bmp|PNG|*.png";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(407, 85);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(354, 405);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // btnBiner
            // 
            this.btnBiner.Location = new System.Drawing.Point(115, 56);
            this.btnBiner.Name = "btnBiner";
            this.btnBiner.Size = new System.Drawing.Size(75, 23);
            this.btnBiner.TabIndex = 3;
            this.btnBiner.Text = "Binerisasi";
            this.btnBiner.UseVisualStyleBackColor = true;
            this.btnBiner.Click += new System.EventHandler(this.btnBiner_Click);
            // 
            // btnErosi
            // 
            this.btnErosi.Location = new System.Drawing.Point(196, 56);
            this.btnErosi.Name = "btnErosi";
            this.btnErosi.Size = new System.Drawing.Size(75, 23);
            this.btnErosi.TabIndex = 4;
            this.btnErosi.Text = "Erosi";
            this.btnErosi.UseVisualStyleBackColor = true;
            this.btnErosi.Click += new System.EventHandler(this.btnErosi_Click);
            // 
            // btnDilasi
            // 
            this.btnDilasi.Location = new System.Drawing.Point(277, 56);
            this.btnDilasi.Name = "btnDilasi";
            this.btnDilasi.Size = new System.Drawing.Size(75, 23);
            this.btnDilasi.TabIndex = 5;
            this.btnDilasi.Text = "Dilasi";
            this.btnDilasi.UseVisualStyleBackColor = true;
            this.btnDilasi.Click += new System.EventHandler(this.btnDilasi_Click);
            // 
            // labelObj
            // 
            this.labelObj.AutoSize = true;
            this.labelObj.Location = new System.Drawing.Point(360, 9);
            this.labelObj.Name = "labelObj";
            this.labelObj.Size = new System.Drawing.Size(72, 13);
            this.labelObj.TabIndex = 8;
            this.labelObj.Text = "Object Count:";
            // 
            // btnEroHor
            // 
            this.btnEroHor.Location = new System.Drawing.Point(196, 27);
            this.btnEroHor.Name = "btnEroHor";
            this.btnEroHor.Size = new System.Drawing.Size(75, 23);
            this.btnEroHor.TabIndex = 11;
            this.btnEroHor.Text = "Erosi Final";
            this.btnEroHor.UseVisualStyleBackColor = true;
            this.btnEroHor.Click += new System.EventHandler(this.btnEroHor_Click);
            // 
            // BtnDetectFinal
            // 
            this.BtnDetectFinal.Location = new System.Drawing.Point(407, 56);
            this.BtnDetectFinal.Name = "BtnDetectFinal";
            this.BtnDetectFinal.Size = new System.Drawing.Size(75, 23);
            this.BtnDetectFinal.TabIndex = 13;
            this.BtnDetectFinal.Text = "Detect";
            this.BtnDetectFinal.UseVisualStyleBackColor = true;
            this.BtnDetectFinal.Click += new System.EventHandler(this.BtnDetectFinal_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 507);
            this.Controls.Add(this.BtnDetectFinal);
            this.Controls.Add(this.btnEroHor);
            this.Controls.Add(this.labelObj);
            this.Controls.Add(this.btnDilasi);
            this.Controls.Add(this.btnErosi);
            this.Controls.Add(this.btnBiner);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.openGambar);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openGambar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnBiner;
        private System.Windows.Forms.Button btnErosi;
        private System.Windows.Forms.Button btnDilasi;
        private System.Windows.Forms.Label labelObj;
        private System.Windows.Forms.Button btnEroHor;
        private System.Windows.Forms.Button BtnDetectFinal;
    }
}

