using System;
using System.Windows.Forms;

namespace RotasWF
{
    public partial class Motoristas : Form
    {
        public Motoristas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            newMotorista np = new newMotorista();
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
    }
}
