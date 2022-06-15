using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGE
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }        

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmCadLogin frmCadLog = new frmCadLogin();
            frmCadLog.ShowDialog();
        }

        private void btnCadastrarAluno_Click(object sender, EventArgs e)
        {
            frmDgvAluno frmCadDgvAluno = new frmDgvAluno();

            frmCadDgvAluno.ShowDialog();
        }
    }
}
