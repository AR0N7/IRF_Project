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
            this.buttonValuta = new System.Windows.Forms.Button();
            this.InvisibleLabel = new System.Windows.Forms.Label();
            this.buttonPwChange = new System.Windows.Forms.Button();
            this.Passwordlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonArfolyamok
            // 
            this.buttonArfolyamok.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonArfolyamok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonArfolyamok.Location = new System.Drawing.Point(12, 153);
            this.buttonArfolyamok.Name = "buttonArfolyamok";
            this.buttonArfolyamok.Size = new System.Drawing.Size(172, 54);
            this.buttonArfolyamok.TabIndex = 0;
            this.buttonArfolyamok.Text = "Árfolyamok";
            this.buttonArfolyamok.UseVisualStyleBackColor = false;
            this.buttonArfolyamok.Click += new System.EventHandler(this.buttonArfolyamok_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonClose.ForeColor = System.Drawing.Color.Red;
            this.buttonClose.Location = new System.Drawing.Point(1050, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(120, 53);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Bezárás";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.ForeColor = System.Drawing.Color.Yellow;
            this.labelTitle.Location = new System.Drawing.Point(451, 12);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(298, 39);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Online Valutaváltó";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEmail.ForeColor = System.Drawing.Color.Yellow;
            this.labelEmail.Location = new System.Drawing.Point(12, 30);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(39, 17);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "Email";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Location = new System.Drawing.Point(190, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 461);
            this.panel1.TabIndex = 4;
            // 
            // buttonValuta
            // 
            this.buttonValuta.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonValuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonValuta.Location = new System.Drawing.Point(12, 75);
            this.buttonValuta.Name = "buttonValuta";
            this.buttonValuta.Size = new System.Drawing.Size(172, 54);
            this.buttonValuta.TabIndex = 5;
            this.buttonValuta.Text = "Valutaváltás";
            this.buttonValuta.UseVisualStyleBackColor = false;
            this.buttonValuta.Click += new System.EventHandler(this.buttonValuta_Click);
            // 
            // InvisibleLabel
            // 
            this.InvisibleLabel.AutoSize = true;
            this.InvisibleLabel.Location = new System.Drawing.Point(12, 522);
            this.InvisibleLabel.Name = "InvisibleLabel";
            this.InvisibleLabel.Size = new System.Drawing.Size(129, 17);
            this.InvisibleLabel.TabIndex = 6;
            this.InvisibleLabel.Text = "LáthatatlanLegyen!";
            this.InvisibleLabel.Visible = false;
            // 
            // buttonPwChange
            // 
            this.buttonPwChange.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonPwChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPwChange.Location = new System.Drawing.Point(12, 231);
            this.buttonPwChange.Name = "buttonPwChange";
            this.buttonPwChange.Size = new System.Drawing.Size(172, 70);
            this.buttonPwChange.TabIndex = 7;
            this.buttonPwChange.Text = "Jelszó megváltoztatása";
            this.buttonPwChange.UseVisualStyleBackColor = false;
            this.buttonPwChange.Click += new System.EventHandler(this.buttonPwChange_Click);
            // 
            // Passwordlabel
            // 
            this.Passwordlabel.AutoSize = true;
            this.Passwordlabel.ForeColor = System.Drawing.Color.Navy;
            this.Passwordlabel.Location = new System.Drawing.Point(12, 522);
            this.Passwordlabel.Name = "Passwordlabel";
            this.Passwordlabel.Size = new System.Drawing.Size(129, 17);
            this.Passwordlabel.TabIndex = 8;
            this.Passwordlabel.Text = "LáthatatlanLegyen!";
            this.Passwordlabel.Visible = false;
            // 
            // Nyitooldal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1182, 548);
            this.Controls.Add(this.Passwordlabel);
            this.Controls.Add(this.buttonPwChange);
            this.Controls.Add(this.InvisibleLabel);
            this.Controls.Add(this.buttonValuta);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonArfolyamok);
            this.Name = "Nyitooldal";
            this.Text = "Kezdőlap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonArfolyamok;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonValuta;
        private System.Windows.Forms.Label InvisibleLabel;
        private System.Windows.Forms.Button buttonPwChange;
        private System.Windows.Forms.Label Passwordlabel;
    }
}