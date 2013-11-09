using System;
using System.Windows.Forms;

namespace RotasWF
{
    public partial class Rotas : Form
    {
        public Rotas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            newRota np = new newRota();
            np.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Não existem itens para ser editados");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Não existem itens para ser Excluidos");
        }

        private void Motoristas_Load(object sender, EventArgs e)
        {

        }
    }
}
