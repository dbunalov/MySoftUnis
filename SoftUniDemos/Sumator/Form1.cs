using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sumator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
            try
            {
                var firstNumber = decimal.Parse(this.textBoxFirstNumber.Text);
                var secondNumber = decimal.Parse(this.textBoxSecondNumber.Text);
                var result = firstNumber + secondNumber;
                textBoxResult.Text = result.ToString();
            }
            catch (Exception)
            {
                textBoxResult.Text = "Error!";
            }
        }
    }
}
