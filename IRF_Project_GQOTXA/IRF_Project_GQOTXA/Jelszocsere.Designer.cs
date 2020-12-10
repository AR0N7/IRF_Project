namespace IRF_Project_GQOTXA
{
    partial class Jelszocsere
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxOld = new System.Windows.Forms.TextBox();
            this.textBoxNew1 = new System.Windows.Forms.TextBox();
            this.textBoxNew2 = new System.Windows.Forms.TextBox();
            this.Old = new System.Windows.Forms.Label();
            this.New1 = new System.Windows.Forms.Label();
            this.New2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelMess = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // textBoxOld
            // 
            this.textBoxOld.Location = new System.Drawing.Point(211, 69);
            this.textBoxOld.Name = "textBoxOld";
            this.textBoxOld.Size = new System.Drawing.Size(219, 22);
            this.textBoxOld.TabIndex = 0;
            // 
            // textBoxNew1
            // 
            this.textBoxNew1.Location = new System.Drawing.Point(211, 113);
            this.textBoxNew1.Name = "textBoxNew1";
            this.textBoxNew1.Size = new System.Drawing.Size(219, 22);
            this.textBoxNew1.TabIndex = 1;
            // 
            // textBoxNew2
            // 
            this.textBoxNew2.Location = new System.Drawing.Point(211, 155);
            this.textBoxNew2.Name = "textBoxNew2";
            this.textBoxNew2.Size = new System.Drawing.Size(219, 22);
            this.textBoxNew2.TabIndex = 2;
            // 
            // Old
            // 
            this.Old.AutoSize = true;
            this.Old.Location = new System.Drawing.Point(113, 72);
            this.Old.Name = "Old";
            this.Old.Size = new System.Drawing.Size(77, 17);
            this.Old.TabIndex = 3;
            this.Old.Text = "Régi jelszó";
            // 
            // New1
            // 
            this.New1.AutoSize = true;
            this.New1.Location = new System.Drawing.Point(129, 116);
            this.New1.Name = "New1";
            this.New1.Size = new System.Drawing.Size(61, 17);
            this.New1.TabIndex = 4;
            this.New1.Text = "Új jelszó";
            // 
            // New2
            // 
            this.New2.AutoSize = true;
            this.New2.Location = new System.Drawing.Point(92, 158);
            this.New2.Name = "New2";
            this.New2.Size = new System.Drawing.Size(98, 17);
            this.New2.TabIndex = 5;
            this.New2.Text = "Új jelszó ismét";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 49);
            this.button1.TabIndex = 6;
            this.button1.Text = "Megváltoztatás";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(466, 69);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(69, 17);
            this.labelPassword.TabIndex = 7;
            this.labelPassword.Text = "Password";
            this.labelPassword.Visible = false;
            // 
            // labelMess
            // 
            this.labelMess.AutoSize = true;
            this.labelMess.ForeColor = System.Drawing.Color.Red;
            this.labelMess.Location = new System.Drawing.Point(129, 280);
            this.labelMess.Name = "labelMess";
            this.labelMess.Size = new System.Drawing.Size(364, 17);
            this.labelMess.TabIndex = 12;
            this.labelMess.Text = "Két jelszócsere között el kell telnie legalább egy percnek";
            this.labelMess.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Jelszocsere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelMess);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.New2);
            this.Controls.Add(this.New1);
            this.Controls.Add(this.Old);
            this.Controls.Add(this.textBoxNew2);
            this.Controls.Add(this.textBoxNew1);
            this.Controls.Add(this.textBoxOld);
            this.Name = "Jelszocsere";
            this.Size = new System.Drawing.Size(1083, 575);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOld;
        private System.Windows.Forms.TextBox textBoxNew1;
        private System.Windows.Forms.TextBox textBoxNew2;
        private System.Windows.Forms.Label Old;
        private System.Windows.Forms.Label New1;
        private System.Windows.Forms.Label New2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelMess;
        private System.Windows.Forms.Timer timer1;
    }
}
