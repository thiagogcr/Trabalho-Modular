using System;
using System.Windows.Forms;

namespace RotasWF
{
    public partial class newRota : Form
    {
        public newRota()
        {
            this.TopLevel = true;
            this.TopMost = true;
            this.BringToFront();
            this.Show();
            this.Activate();
            this.Focus();
            InitializeComponent();
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
