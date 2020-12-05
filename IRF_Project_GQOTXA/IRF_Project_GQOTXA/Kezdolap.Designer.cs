namespace IRF_Project_GQOTXA
{
    partial class Kezdolap
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
            this.labelEMAIL = new System.Windows.Forms.Label();
            this.labelPASSWORD = new System.Windows.Forms.Label();
            this.labelTITLE = new System.Windows.Forms.Label();
            this.textBoxEMAIL = new System.Windows.Forms.TextBox();
            this.textBoxPASSWORD = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonGO = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelEMAIL
            // 
            this.labelEMAIL.AutoSize = true;
            this.labelEMAIL.Location = new System.Drawing.Point(197, 150);
            this.labelEMAIL.Name = "labelEMAIL";
            this.labelEMAIL.Size = new System.Drawing.Size(46, 17);
            this.labelEMAIL.TabIndex = 0;
            this.labelEMAIL.Text = "Email:";
            // 
            // labelPASSWORD
            // 
            this.labelPASSWORD.AutoSize = true;
            this.labelPASSWORD.Location = new System.Drawing.Point(191, 211);
            this.labelPASSWORD.Name = "labelPASSWORD";
            this.labelPASSWORD.Size = new System.Drawing.Size(52, 17);
            this.labelPASSWORD.TabIndex = 1;
            this.labelPASSWORD.Text = "Jelszó:";
            // 
            // labelTITLE
            // 
            this.labelTITLE.AutoSize = true;
            this.labelTITLE.Location = new System.Drawing.Point(343, 72);
            this.labelTITLE.Name = "labelTITLE";
            this.labelTITLE.Size = new System.Drawing.Size(114, 17);
            this.labelTITLE.TabIndex = 2;
            this.labelTITLE.Text = "Alkalmazás neve";
            // 
            // textBoxEMAIL
            // 
            this.textBoxEMAIL.Location = new System.Drawing.Point(261, 150);
            this.textBoxEMAIL.Name = "textBoxEMAIL";
            this.textBoxEMAIL.Size = new System.Drawing.Size(252, 22);
            this.textBoxEMAIL.TabIndex = 3;
            // 
            // textBoxPASSWORD
            // 
            this.textBoxPASSWORD.Location = new System.Drawing.Point(261, 211);
            this.textBoxPASSWORD.Name = "textBoxPASSWORD";
            this.textBoxPASSWORD.Size = new System.Drawing.Size(252, 22);
            this.textBoxPASSWORD.TabIndex = 4;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(171, 341);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(101, 37);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "Mégse";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonGO
            // 
            this.buttonGO.Location = new System.Drawing.Point(466, 341);
            this.buttonGO.Name = "buttonGO";
            this.buttonGO.Size = new System.Drawing.Size(101, 37);
            this.buttonGO.TabIndex = 6;
            this.buttonGO.Text = "Belépés";
            this.buttonGO.UseVisualStyleBackColor = true;
            this.buttonGO.Click += new System.EventHandler(this.buttonGO_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(872, 512);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Made by Tompai Áron";
            // 
            // Kezdolap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 538);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGO);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.textBoxPASSWORD);
            this.Controls.Add(this.textBoxEMAIL);
            this.Controls.Add(this.labelTITLE);
            this.Controls.Add(this.labelPASSWORD);
            this.Controls.Add(this.labelEMAIL);
            this.Name = "Kezdolap";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEMAIL;
        private System.Windows.Forms.Label labelPASSWORD;
        private System.Windows.Forms.Label labelTITLE;
        private System.Windows.Forms.TextBox textBoxEMAIL;
        private System.Windows.Forms.TextBox textBoxPASSWORD;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonGO;
        private System.Windows.Forms.Label label1;
    }
}

