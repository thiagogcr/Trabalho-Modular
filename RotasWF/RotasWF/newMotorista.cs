using System;
using System.Windows.Forms;

namespace RotasWF
{
    public partial class newMotorista : Form
    {
        public newMotorista()
        {
            this.TopLevel = true;
            this.TopMost = true;
            this.BringToFront();
            this.Show();
            this.Activate();
            this.Focus();
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            maskedTextBox1.Text = string.Empty;
            maskedTextBox2.Text = string.Empty;
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
