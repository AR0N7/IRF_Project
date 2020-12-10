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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxVALUE = new System.Windows.Forms.TextBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.labelOsszes = new System.Windows.Forms.Label();
            this.labelFT = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SelectedView = new System.Windows.Forms.DataGridView();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedView)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(55, 52);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "EUR";
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            this.comboBox1.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox1_Validating);
            // 
            // textBoxVALUE
            // 
            this.textBoxVALUE.Location = new System.Drawing.Point(55, 6);
            this.textBoxVALUE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxVALUE.Name = "textBoxVALUE";
            this.textBoxVALUE.Size = new System.Drawing.Size(136, 26);
            this.textBoxVALUE.TabIndex = 1;
            this.textBoxVALUE.TextChanged += new System.EventHandler(this.textBoxVALUE_TextChanged);
            this.textBoxVALUE.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxVALUE_Validating);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ButtonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonAdd.Location = new System.Drawing.Point(55, 111);
            this.ButtonAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(161, 65);
            this.ButtonAdd.TabIndex = 4;
            this.ButtonAdd.Text = "Hozzáad";
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // labelOsszes
            // 
            this.labelOsszes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelOsszes.AutoSize = true;
            this.labelOsszes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOsszes.ForeColor = System.Drawing.Color.Yellow;
            this.labelOsszes.Location = new System.Drawing.Point(52, 243);
            this.labelOsszes.Name = "labelOsszes";
            this.labelOsszes.Size = new System.Drawing.Size(65, 18);
            this.labelOsszes.TabIndex = 5;
            this.labelOsszes.Text = "Random";
            // 
            // labelFT
            // 
            this.labelFT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelFT.AutoSize = true;
            this.labelFT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFT.ForeColor = System.Drawing.Color.Yellow;
            this.labelFT.Location = new System.Drawing.Point(186, 243);
            this.labelFT.Name = "labelFT";
            this.labelFT.Size = new System.Drawing.Size(39, 18);
            this.labelFT.TabIndex = 6;
            this.labelFT.Text = "HUF";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(52, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Összes egyenleg:";
            // 
            // SelectedView
            // 
            this.SelectedView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectedView.Location = new System.Drawing.Point(276, 6);
            this.SelectedView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SelectedView.Name = "SelectedView";
            this.SelectedView.RowTemplate.Height = 24;
            this.SelectedView.Size = new System.Drawing.Size(548, 265);
            this.SelectedView.TabIndex = 8;
            // 
            // buttonBuy
            // 
            this.buttonBuy.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBuy.Location = new System.Drawing.Point(528, 302);
            this.buttonBuy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(132, 44);
            this.buttonBuy.TabIndex = 9;
            this.buttonBuy.Text = "Vásárlás";
            this.buttonBuy.UseVisualStyleBackColor = false;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDelete.ForeColor = System.Drawing.Color.Red;
            this.buttonDelete.Location = new System.Drawing.Point(323, 302);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(132, 44);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "Törlés";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // Valutavaltas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonBuy);
            this.Controls.Add(this.SelectedView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelFT);
            this.Controls.Add(this.labelOsszes);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.textBoxVALUE);
            this.Controls.Add(this.comboBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Valutavaltas";
            this.Size = new System.Drawing.Size(919, 660);
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
    }
}
