using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int endIndex = richTextBox1.Text.Length;
            string sendString = "thank you!";
            richTextBox1.AppendText("thank you!");
            //richTextBox1.SelectionColor = Color.Green;
            richTextBox1.SelectionColor = Color.Red;
            richTextBox1.Select();
            richTextBox1.AppendText("thank you!");
            richTextBox1.SelectionColor = Color.Black;
            richTextBox1.AppendText("thank you!");
        }
    }
}
