using System;
using System.Windows.Forms;

namespace RotasWF
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opção Não Disponivel");
        }

        private void pagamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pagamentos pg = new Pagamentos();
            pg.ShowDialog();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Motoristas mt = new Motoristas();
            mt.ShowDialog();
        }

        private void alterarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Armazem ar = new Armazem();
            ar.ShowDialog();
        }

        private void rotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rotas form = new Rotas();
            form.ShowDialog();
        }

    }
}
