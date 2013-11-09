using System;
using System.Windows.Forms;

namespace RotasWF
{
    public partial class newArmazem : Form
    {
        public newArmazem()
        {
            this.TopLevel = true;
            this.TopMost = true;
            this.BringToFront();
            this.Show();
            this.Activate();
            this.Focus();
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textBoxEndereco.Text = string.Empty;
            textBoxDescricao.Text = string.Empty;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
