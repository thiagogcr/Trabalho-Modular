using System;
using System.Windows.Forms;

namespace RotasWF
{
    public partial class Armazem : Form
    {
        public Armazem()
        {
            InitializeComponent();
        }

        private void btnExcluirArmazem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Não existem itens para ser Excluidos");
        }

        private void btnEditarArmazem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Não existem itens para ser editados");
        }

        private void btnAdicionarArmazem_Click(object sender, EventArgs e)
        {
            this.Hide();
            newArmazem np = new newArmazem();
            np.Show();
        }
    }
}
