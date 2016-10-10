using System;
using System.Drawing;
using System.Windows.Forms;

namespace _16.CatchMe
{
    public partial class CatchTheButton : Form
    {
        public CatchTheButton()
        {
            InitializeComponent();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            Random rand = new Random();
            var maxWidth = this.ClientSize.Width - buttonCatchMe.ClientSize.Width;
            var maxHeight = this.ClientSize.Height - buttonCatchMe.ClientSize.Height;
            this.buttonCatchMe.Location = new Point(rand.Next(maxWidth), rand.Next(maxHeight));
        }

        private void buttonCatchMe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You win the game","G A M E   O V E R!");
        }
    }
}
