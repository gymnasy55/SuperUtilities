namespace SuperUtilities
{
    partial class NewGuidForm
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
            this.txtGuid = new System.Windows.Forms.TextBox();
            this.btnNewGuid = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtGuid
            // 
            this.txtGuid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGuid.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtGuid.Location = new System.Drawing.Point(24, 37);
            this.txtGuid.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtGuid.Name = "txtGuid";
            this.txtGuid.Size = new System.Drawing.Size(511, 27);
            this.txtGuid.TabIndex = 0;
            // 
            // btnNewGuid
            // 
            this.btnNewGuid.Location = new System.Drawing.Point(22, 117);
            this.btnNewGuid.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnNewGuid.Name = "btnNewGuid";
            this.btnNewGuid.Size = new System.Drawing.Size(513, 60);
            this.btnNewGuid.TabIndex = 1;
            this.btnNewGuid.Text = "New Guid";
            this.btnNewGuid.UseVisualStyleBackColor = true;
            this.btnNewGuid.Click += new System.EventHandler(this.btnNewGuid_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Generated Guid:";
            // 
            // NewGuidForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 207);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNewGuid);
            this.Controls.Add(this.txtGuid);
            this.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "NewGuidForm";
            this.Text = "NewGuidForm";
            this.Load += new System.EventHandler(this.NewGuidForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGuid;
        private System.Windows.Forms.Button btnNewGuid;
        private System.Windows.Forms.Label label1;
    }
}