namespace IRF_Project_GQOTXA
{
    partial class Nyitooldal
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
            this.buttonArfolyamok = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // buttonArfolyamok
            // 
            this.buttonArfolyamok.Location = new System.Drawing.Point(12, 84);
            this.buttonArfolyamok.Name = "buttonArfolyamok";
            this.buttonArfolyamok.Size = new System.Drawing.Size(123, 54);
            this.buttonArfolyamok.TabIndex = 0;
            this.buttonArfolyamok.Text = "Árfolyamok";
            this.buttonArfolyamok.UseVisualStyleBackColor = true;
            this.buttonArfolyamok.Click += new System.EventHandler(this.buttonArfolyamok_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(902, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(120, 53);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Bezárás";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(402, 12);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(114, 17);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Alkalmazás neve";
            // 
            // labelEmail
            // 
            this.labelEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(435, 39);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(42, 17);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "Email";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(156, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 461);
            this.panel1.TabIndex = 4;
            // 
            // Nyitooldal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 548);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonArfolyamok);
            this.Name = "Nyitooldal";
            this.Text = "Nyitooldal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonArfolyamok;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Panel panel1;
    }
}