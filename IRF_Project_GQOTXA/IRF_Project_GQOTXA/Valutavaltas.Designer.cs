namespace IRF_Project_GQOTXA
{
    partial class Valutavaltas
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxVALUE = new System.Windows.Forms.TextBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.labelOsszes = new System.Windows.Forms.Label();
            this.labelFT = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SelectedView = new System.Windows.Forms.DataGridView();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelMess = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedView)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(176, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            this.comboBox1.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox1_Validating);
            // 
            // textBoxVALUE
            // 
            this.textBoxVALUE.Location = new System.Drawing.Point(49, 3);
            this.textBoxVALUE.Name = "textBoxVALUE";
            this.textBoxVALUE.Size = new System.Drawing.Size(121, 22);
            this.textBoxVALUE.TabIndex = 1;
            this.textBoxVALUE.TextChanged += new System.EventHandler(this.textBoxVALUE_TextChanged);
            this.textBoxVALUE.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxVALUE_Validating);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(93, 54);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(143, 52);
            this.ButtonAdd.TabIndex = 4;
            this.ButtonAdd.Text = "Hozzáad";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // labelOsszes
            // 
            this.labelOsszes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelOsszes.AutoSize = true;
            this.labelOsszes.Location = new System.Drawing.Point(46, 296);
            this.labelOsszes.Name = "labelOsszes";
            this.labelOsszes.Size = new System.Drawing.Size(61, 17);
            this.labelOsszes.TabIndex = 5;
            this.labelOsszes.Text = "Random";
            // 
            // labelFT
            // 
            this.labelFT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelFT.AutoSize = true;
            this.labelFT.Location = new System.Drawing.Point(183, 296);
            this.labelFT.Name = "labelFT";
            this.labelFT.Size = new System.Drawing.Size(36, 17);
            this.labelFT.TabIndex = 6;
            this.labelFT.Text = "HUF";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Összes egyenleg:";
            // 
            // SelectedView
            // 
            this.SelectedView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectedView.Location = new System.Drawing.Point(327, 5);
            this.SelectedView.Name = "SelectedView";
            this.SelectedView.RowTemplate.Height = 24;
            this.SelectedView.Size = new System.Drawing.Size(487, 212);
            this.SelectedView.TabIndex = 8;
            // 
            // buttonBuy
            // 
            this.buttonBuy.Location = new System.Drawing.Point(609, 261);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(143, 52);
            this.buttonBuy.TabIndex = 9;
            this.buttonBuy.Text = "Vásárlás";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(372, 261);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(143, 52);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "Törlés";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 3600000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelMess
            // 
            this.labelMess.AutoSize = true;
            this.labelMess.ForeColor = System.Drawing.Color.Red;
            this.labelMess.Location = new System.Drawing.Point(347, 343);
            this.labelMess.Name = "labelMess";
            this.labelMess.Size = new System.Drawing.Size(425, 17);
            this.labelMess.TabIndex = 11;
            this.labelMess.Text = "Sajnáljuk, de két vásárlás között el kell telnie legalább egy órának!";
            // 
            // Valutavaltas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelMess);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonBuy);
            this.Controls.Add(this.SelectedView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelFT);
            this.Controls.Add(this.labelOsszes);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.textBoxVALUE);
            this.Controls.Add(this.comboBox1);
            this.Name = "Valutavaltas";
            this.Size = new System.Drawing.Size(817, 528);
            ((System.ComponentModel.ISupportInitialize)(this.SelectedView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxVALUE;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Label labelOsszes;
        private System.Windows.Forms.Label labelFT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView SelectedView;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelMess;
    }
}
