using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows;


namespace Project1
{
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e){}

        private void buttonAns_Click(object sender, EventArgs e)
        {
            double a, b, c, X1, X2;
            a = double.Parse(textBoxA.Text);
            b = double.Parse(textBoxB.Text);
            c = double.Parse(textBoxC.Text);
            try
            { 
            X1= -b + Math.Sqrt((Math.Pow(b,2))-(4*a*c));
            X1 = X1 / (2 * a);
            X2 = -b - Math.Sqrt((Math.Pow(b, 2)) - (4 * a * c));
            X2 = X2 / (2 * a);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                X1 = 0.0;
                X2 = 0.0;
            }
            labelAns1.Text = X1.ToString();
            labelAns2.Text = X2.ToString();

        }

        private void label1_Click_1(object sender, EventArgs e)
        {}

        private void labelAns1_Click(object sender, EventArgs e)
        { }

        private void labelAns2_Click(object sender, EventArgs e)
        {}

        private void labelX2_Click(object sender, EventArgs e)
        {}

        private void labelX1_Click(object sender, EventArgs e)
        { }

        private void tabPage1_Click(object sender, EventArgs e)
        {  }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Project1.Form2 form2 = new Project1.Form2();
            form2.ShowDialog();


        }
    }
}
