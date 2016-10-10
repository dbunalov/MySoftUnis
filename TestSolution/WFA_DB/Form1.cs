using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_DB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void newEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void новВоеннослужещToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void deleteEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Сигурни ли сте, че искате да изтривате военнослужещ?",
                      "Внимание!", MessageBoxButtons.YesNo);
        }

        private void преместванеНаВоеннослужещЩАБКОРАБToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void преместиВоеннослужещВЩабToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void изтриванеНаВоеннослужещToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Сигурни ли сте, че искате да изтривате военнослужещ?",
                     "Внимание!", MessageBoxButtons.YesNo);
        }

        private void изтрийДлъжностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Сигурни ли сте, че искате да изтривате длъжност?",
                     "Внимание!", MessageBoxButtons.YesNo);
        }

        private void deleteShipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Сигурни ли сте, че искате да изтривате кораб?",
                     "Внимание!", MessageBoxButtons.YesNo);
        }

        private void deleteDataInShipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Сигурни ли сте, че искате да изтривате всичките данни от кораб?",
                     "Внимание!", MessageBoxButtons.YesNo);
        }
    }
}
