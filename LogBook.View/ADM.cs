using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogBook.View
{
    public partial class ADM : Form
    {
        public ADM()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Salut  tout le monde!");
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FmmAddStudent().Show();
        }

        private void diariosDeBordoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Diary().Show();
        }
    }
}
