using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework;

namespace RotasWF
{
    public partial class Pagamentos : Form
    {
        public static List<Pagamento> lista = new List<Pagamento>();

        public Pagamentos()
        {
            InitializeComponent();
            this.dataGridView1.AutoGenerateColumns = true;
            this.dataGridView1.DataSource = lista;
            this.dataGridView1.Refresh();
        }

        private void AddPagamento(Pagamento pagamento)
        {
            lista.Add(pagamento);
            this.dataGridView1.AutoGenerateColumns = true;
            pagamentoBindingSource.Clear();
            foreach (var item in lista)
                pagamentoBindingSource.Add(item);
            this.dataGridView1.DataSource = pagamentoBindingSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            newPagamento np = new newPagamento();
            np.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {   
            int id = 0;
            try
            {
                id = (int)dataGridView1.CurrentRow.Cells[0].RowIndex;
            }
            catch { }
            this.Hide();
            newPagamento np = new newPagamento(id);
            np.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells[0].RowIndex;
            lista.RemoveAt(id);
            pagamentoBindingSource.Clear();
            foreach (var item in lista)
                pagamentoBindingSource.Add(item);
            this.dataGridView1.DataSource = pagamentoBindingSource;
            this.dataGridView1.Refresh();
        }
    }
}
