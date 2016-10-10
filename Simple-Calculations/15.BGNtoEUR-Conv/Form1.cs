using System;
using System.Windows.Forms;

namespace _15.BGNtoEUR_Conv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ConvertCurrency()
        {
            var amountBGN = this.numericUpDownAmount.Value;
            var amountEUR = amountBGN / 1.95583m;
            this.labelResult.Text = amountBGN + " BGN = " + Math.Round(amountEUR, 2) + " EUR";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ConvertCurrency();
        }

        private void numericUpDownAmount_ValueChanged(object sender, EventArgs e)
        {
            ConvertCurrency();
        }

        private void numericUpDownAmount_KeyUp(object sender, KeyEventArgs e)
        {
            ConvertCurrency();
        }
    }
}
