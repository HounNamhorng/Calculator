using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace home_work_2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (labelDown.Text == "0")
                labelDown.Text = "";
            labelDown.Text+=((Button)sender).Text;
        }

        private void btndevide_Click(object sender, EventArgs e)
        {
            labelUP.Text += labelDown.Text + "" + ActiveControl.Text;
            labelDown.Text = "0";
        }

        private void btnpoint_Click(object sender, EventArgs e)
        {
            if (labelDown.Text.IndexOf('.') < 0)
                labelDown.Text += ".";
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            labelDown.Text = labelDown.Text.Remove(labelDown.Text.Length - 1, 1);
            if (labelDown.Text == " ")
                labelDown.Text = "0";
        }

        private void btn1x_Click(object sender, EventArgs e)
        {
            labelDown.Text = "0";
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            labelUP.Text = "";
            labelDown.Text = "0";
        }

        private void btnresult_Click(object sender, EventArgs e)
        {
            string chrOperator = labelUP.Text.Substring(labelUP.Text.Length - 1, 1);
            float num1 = float.Parse(labelUP.Text.Remove(labelUP.Text.Length - 1, 1));
            float num2 = float.Parse(labelDown.Text);
            switch (chrOperator)
            {
                case "+": labelDown.Text = (num1 + num2).ToString(); break;
                case "-": labelDown.Text = (num1 - num2).ToString(); break;
                case "×": labelDown.Text = (num1 * num2).ToString(); break;
                case "÷": labelDown.Text = (num1 / num2).ToString(); break;
                case "%": labelDown.Text = (num1 % num2).ToString(); break;
            }
        }

        private void btnminadd_Click(object sender, EventArgs e)
        {
            labelDown.Text = (float.Parse(labelDown.Text) * -1).ToString();
        }

        private void btnkare_Click(object sender, EventArgs e)
        {
            labelDown.Text = (Math.Sqrt(float.Parse(labelDown.Text))).ToString();
        }

        private void btnsin_Click(object sender, EventArgs e)
        {
            labelDown.Text = (Math.Sin(float.Parse(labelDown.Text))).ToString();
        }

        private void btncos_Click(object sender, EventArgs e)
        {
            labelDown.Text = (Math.Cos(float.Parse(labelDown.Text))).ToString();
        }


  
    }
}
