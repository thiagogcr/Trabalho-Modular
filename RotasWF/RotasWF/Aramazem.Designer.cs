namespace RotasWF
{
    partial class Armazem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Armazem));
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdicionarArmazem = new System.Windows.Forms.Button();
            this.btnEditarArmazem = new System.Windows.Forms.Button();
            this.btnExcluirArmazem = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Tag";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tag";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // btnAdicionarArmazem
            // 
            this.btnAdicionarArmazem.Location = new System.Drawing.Point(102, 12);
            this.btnAdicionarArmazem.Name = "btnAdicionarArmazem";
            this.btnAdicionarArmazem.Size = new System.Drawing.Size(111, 23);
            this.btnAdicionarArmazem.TabIndex = 7;
            this.btnAdicionarArmazem.Text = "Adicionar Armazém";
            this.btnAdicionarArmazem.UseVisualStyleBackColor = true;
            this.btnAdicionarArmazem.Click += new System.EventHandler(this.btnAdicionarArmazem_Click);
            // 
            // btnEditarArmazem
            // 
            this.btnEditarArmazem.Location = new System.Drawing.Point(224, 12);
            this.btnEditarArmazem.Name = "btnEditarArmazem";
            this.btnEditarArmazem.Size = new System.Drawing.Size(111, 23);
            this.btnEditarArmazem.TabIndex = 6;
            this.btnEditarArmazem.Text = "Editar Armazém";
            this.btnEditarArmazem.UseVisualStyleBackColor = true;
            this.btnEditarArmazem.Click += new System.EventHandler(this.btnEditarArmazem_Click);
            // 
            // btnExcluirArmazem
            // 
            this.btnExcluirArmazem.Location = new System.Drawing.Point(345, 12);
            this.btnExcluirArmazem.Name = "btnExcluirArmazem";
            this.btnExcluirArmazem.Size = new System.Drawing.Size(111, 23);
            this.btnExcluirArmazem.TabIndex = 5;
            this.btnExcluirArmazem.Text = "Excluir Armazém";
            this.btnExcluirArmazem.UseVisualStyleBackColor = true;
            this.btnExcluirArmazem.Click += new System.EventHandler(this.btnExcluirArmazem_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView2.Location = new System.Drawing.Point(12, 55);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(444, 375);
            this.dataGridView2.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn2.HeaderText = "Id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 41;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Endereço";
            this.dataGridViewTextBoxColumn4.HeaderText = "Endereço";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 78;
            // 
            // Armazem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 442);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnAdicionarArmazem);
            this.Controls.Add(this.btnEditarArmazem);
            this.Controls.Add(this.btnExcluirArmazem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Armazem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Armazéns";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btnAdicionarArmazem;
        private System.Windows.Forms.Button btnEditarArmazem;
        private System.Windows.Forms.Button btnExcluirArmazem;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

    }
}