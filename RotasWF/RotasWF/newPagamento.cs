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
    public partial class newPagamento : Form
    {
        public newPagamento()
        {
            Load();
        }

        public newPagamento(int id)
        {
            Load();
            var pagamento = Pagamentos.lista[id]; 
            comboBox1.SelectedIndex = pagamento.Status - 1;
            textBox1.Text = pagamento.Descricao;
            textBox2.Text = pagamento.Valor.ToString() ;
            textBox3.Text = pagamento.Id.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            comboBox1.SelectedValue = 0;
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            var id = Pagamentos.lista.Count > 0 ? Pagamentos.lista.Last().Id + 1 : 1;
            Pagamento pg = new Pagamento(id,
                                         textBox1.Text,
                                         decimal.Parse(textBox2.Text),
                                         (int)comboBox1.SelectedIndex + 1);
            Pagamentos pgFrm = new Pagamentos();
            var isNew = (
                from item in Pagamentos.lista
                where item.Id == int.Parse(textBox3.Text)
                select item).ToList();
            if (isNew.Count > 0)
            {
                pg.Id = isNew[0].Id;
                Pagamentos.lista.Remove(isNew[0]);
            }
            Pagamentos.lista.Add(pg);
            pgFrm.Show();
            this.Close();
        }

        public void Load() {

            this.TopLevel = true;
            this.TopMost = true;
            this.BringToFront();
            this.Show();
            this.Activate();
            this.Focus();
            InitializeComponent();
            comboBox1.Items.Insert(0, new { ID = 1, Name = "Pago" });
            comboBox1.Items.Insert(1, new { ID = 2, Name = "Devendo" });
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "ID";
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndex = 1;
            textBox3.Text = "0";
        }
    }
}
