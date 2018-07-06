using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Arduino.Open();
            MessageBox.Show("Arduino Connected");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Arduino.WriteLine("1");
        }


        private void OFF_Click(object sender, EventArgs e)
        {
            Arduino.WriteLine("3");
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           Arduino.WriteLine("2");
           //label1.Text = Arduino.ReadLine();
           // label1.Text = data;
           label1.Invoke(new EventHandler(delegate { label1.Text = Arduino.ReadLine(); } ));

        }
    }
}
