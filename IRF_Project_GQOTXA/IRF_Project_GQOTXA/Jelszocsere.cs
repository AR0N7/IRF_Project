﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IRF_Project_GQOTXA.Unit_Test;

namespace IRF_Project_GQOTXA
{
    public partial class Jelszocsere : UserControl
    {
        private TestClass NewPassword = new TestClass();

        public Jelszocsere(string password)
        {
            InitializeComponent();
            labelMess.Visible = false;
            textBoxOld.PasswordChar = '*';
            textBoxNew1.PasswordChar = '*';
            textBoxNew2.PasswordChar = '*';
            labelPassword.Text = password;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxOld.Text==labelPassword.Text && textBoxNew1.Text==textBoxNew2.Text)
            {
                if (textBoxOld.Text==textBoxNew1.Text)
                {
                    MessageBox.Show("Az új jelszónak különböznie kell az előzőtől!", "Hiba");
                }
                else
                {
                    if (NewPassword.ValidatePassword(textBoxNew1.Text)==false)
                    {
                        MessageBox.Show("Az új jelszó nem megfelelő!", "Hiba");
                    }
                    else
                    {
                        labelPassword.Text = textBoxNew2.Text;
                        button1.Enabled = false;
                        labelMess.Visible = true;
                        timer1.Start();
                        MessageBox.Show("Sikeres jelszóváltoztatás!", "Siker");
                    }
                }
            }
            else
            {
                MessageBox.Show("Nem megfelelő jelszót adott meg!", "Hiba");
            }
        }

        //Egy perc után lehet újra jelszót cserélni
        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.Enabled = true;
            labelMess.Visible = false;
            timer1.Stop();
        }
    }
}
