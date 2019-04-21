namespace SuperUtilities
{
    partial class ColorMatchingForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBackgroundR = new System.Windows.Forms.TextBox();
            this.trbBackgroundR = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBackgroundG = new System.Windows.Forms.TextBox();
            this.trbBackgroundG = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBackgroundB = new System.Windows.Forms.TextBox();
            this.trbBackgroundB = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtFontB = new System.Windows.Forms.TextBox();
            this.trbFontB = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFontG = new System.Windows.Forms.TextBox();
            this.trbFontG = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFontR = new System.Windows.Forms.TextBox();
            this.trbFontR = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSample = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbBackgroundR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbBackgroundG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbBackgroundB)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbFontB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbFontG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbFontR)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBackgroundB);
            this.groupBox1.Controls.Add(this.trbBackgroundB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBackgroundG);
            this.groupBox1.Controls.Add(this.trbBackgroundG);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBackgroundR);
            this.groupBox1.Controls.Add(this.trbBackgroundR);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 174);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Background";
            // 
            // txtBackgroundR
            // 
            this.txtBackgroundR.Location = new System.Drawing.Point(249, 26);
            this.txtBackgroundR.Name = "txtBackgroundR";
            this.txtBackgroundR.Size = new System.Drawing.Size(53, 26);
            this.txtBackgroundR.TabIndex = 2;
            this.txtBackgroundR.Text = "255";
            this.txtBackgroundR.TextChanged += new System.EventHandler(this.txtBackgroundR_TextChanged);
            // 
            // trbBackgroundR
            // 
            this.trbBackgroundR.LargeChange = 1;
            this.trbBackgroundR.Location = new System.Drawing.Point(40, 26);
            this.trbBackgroundR.Maximum = 255;
            this.trbBackgroundR.Name = "trbBackgroundR";
            this.trbBackgroundR.Size = new System.Drawing.Size(203, 45);
            this.trbBackgroundR.TabIndex = 1;
            this.trbBackgroundR.Value = 255;
            this.trbBackgroundR.Scroll += new System.EventHandler(this.trbBackgroundR_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "R:";
            // 
            // txtBackgroundG
            // 
            this.txtBackgroundG.Location = new System.Drawing.Point(249, 77);
            this.txtBackgroundG.Name = "txtBackgroundG";
            this.txtBackgroundG.Size = new System.Drawing.Size(53, 26);
            this.txtBackgroundG.TabIndex = 5;
            this.txtBackgroundG.Text = "255";
            this.txtBackgroundG.TextChanged += new System.EventHandler(this.txtBackgroundG_TextChanged);
            // 
            // trbBackgroundG
            // 
            this.trbBackgroundG.LargeChange = 1;
            this.trbBackgroundG.Location = new System.Drawing.Point(40, 77);
            this.trbBackgroundG.Maximum = 255;
            this.trbBackgroundG.Name = "trbBackgroundG";
            this.trbBackgroundG.Size = new System.Drawing.Size(203, 45);
            this.trbBackgroundG.TabIndex = 4;
            this.trbBackgroundG.Value = 255;
            this.trbBackgroundG.Scroll += new System.EventHandler(this.trbBackgroundG_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "G:";
            // 
            // txtBackgroundB
            // 
            this.txtBackgroundB.Location = new System.Drawing.Point(249, 128);
            this.txtBackgroundB.Name = "txtBackgroundB";
            this.txtBackgroundB.Size = new System.Drawing.Size(53, 26);
            this.txtBackgroundB.TabIndex = 8;
            this.txtBackgroundB.Text = "255";
            this.txtBackgroundB.TextChanged += new System.EventHandler(this.txtBackgroundB_TextChanged);
            // 
            // trbBackgroundB
            // 
            this.trbBackgroundB.LargeChange = 1;
            this.trbBackgroundB.Location = new System.Drawing.Point(40, 128);
            this.trbBackgroundB.Maximum = 255;
            this.trbBackgroundB.Name = "trbBackgroundB";
            this.trbBackgroundB.Size = new System.Drawing.Size(203, 45);
            this.trbBackgroundB.TabIndex = 7;
            this.trbBackgroundB.Value = 255;
            this.trbBackgroundB.Scroll += new System.EventHandler(this.trbBackgroundB_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "B:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtFontB);
            this.groupBox2.Controls.Add(this.trbFontB);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtFontG);
            this.groupBox2.Controls.Add(this.trbFontG);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtFontR);
            this.groupBox2.Controls.Add(this.trbFontR);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(13, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 173);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Font";
            // 
            // txtFontB
            // 
            this.txtFontB.Location = new System.Drawing.Point(249, 128);
            this.txtFontB.Name = "txtFontB";
            this.txtFontB.Size = new System.Drawing.Size(53, 26);
            this.txtFontB.TabIndex = 8;
            this.txtFontB.Text = "0";
            this.txtFontB.TextChanged += new System.EventHandler(this.txtFontB_TextChanged);
            // 
            // trbFontB
            // 
            this.trbFontB.LargeChange = 1;
            this.trbFontB.Location = new System.Drawing.Point(40, 128);
            this.trbFontB.Maximum = 255;
            this.trbFontB.Name = "trbFontB";
            this.trbFontB.Size = new System.Drawing.Size(203, 45);
            this.trbFontB.TabIndex = 7;
            this.trbFontB.Scroll += new System.EventHandler(this.trbFontB_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "B:";
            // 
            // txtFontG
            // 
            this.txtFontG.Location = new System.Drawing.Point(249, 77);
            this.txtFontG.Name = "txtFontG";
            this.txtFontG.Size = new System.Drawing.Size(53, 26);
            this.txtFontG.TabIndex = 5;
            this.txtFontG.Text = "0";
            this.txtFontG.TextChanged += new System.EventHandler(this.txtFontG_TextChanged);
            // 
            // trbFontG
            // 
            this.trbFontG.LargeChange = 1;
            this.trbFontG.Location = new System.Drawing.Point(40, 77);
            this.trbFontG.Maximum = 255;
            this.trbFontG.Name = "trbFontG";
            this.trbFontG.Size = new System.Drawing.Size(203, 45);
            this.trbFontG.TabIndex = 4;
            this.trbFontG.Scroll += new System.EventHandler(this.trbFontG_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "G:";
            // 
            // txtFontR
            // 
            this.txtFontR.Location = new System.Drawing.Point(249, 26);
            this.txtFontR.Name = "txtFontR";
            this.txtFontR.Size = new System.Drawing.Size(53, 26);
            this.txtFontR.TabIndex = 2;
            this.txtFontR.Text = "0";
            this.txtFontR.TextChanged += new System.EventHandler(this.txtFontR_TextChanged);
            // 
            // trbFontR
            // 
            this.trbFontR.LargeChange = 1;
            this.trbFontR.Location = new System.Drawing.Point(40, 26);
            this.trbFontR.Maximum = 255;
            this.trbFontR.Name = "trbFontR";
            this.trbFontR.Size = new System.Drawing.Size(203, 45);
            this.trbFontR.TabIndex = 1;
            this.trbFontR.Scroll += new System.EventHandler(this.trbFontR_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "R:";
            // 
            // lblSample
            // 
            this.lblSample.BackColor = System.Drawing.Color.White;
            this.lblSample.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSample.Location = new System.Drawing.Point(356, 13);
            this.lblSample.Name = "lblSample";
            this.lblSample.Size = new System.Drawing.Size(510, 353);
            this.lblSample.TabIndex = 10;
            this.lblSample.Text = "Sample";
            this.lblSample.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ColorMatchingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 388);
            this.Controls.Add(this.lblSample);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ColorMatchingForm";
            this.Text = "Color Matching";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbBackgroundR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbBackgroundG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbBackgroundB)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbFontB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbFontG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbFontR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar trbBackgroundR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBackgroundR;
        private System.Windows.Forms.TextBox txtBackgroundB;
        private System.Windows.Forms.TrackBar trbBackgroundB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBackgroundG;
        private System.Windows.Forms.TrackBar trbBackgroundG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtFontB;
        private System.Windows.Forms.TrackBar trbFontB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFontG;
        private System.Windows.Forms.TrackBar trbFontG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFontR;
        private System.Windows.Forms.TrackBar trbFontR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSample;
    }
}