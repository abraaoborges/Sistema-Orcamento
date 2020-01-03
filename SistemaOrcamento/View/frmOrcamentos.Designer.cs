namespace SistemaOrcamento.View
{
    partial class frmOrcamentos
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
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.cbProduto = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNOrcamento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuscarNOrcamento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dg = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbCliente = new System.Windows.Forms.RadioButton();
            this.rbNOrcamento = new System.Windows.Forms.RadioButton();
            this.rbData = new System.Windows.Forms.RadioButton();
            this.cbBuscarCliente = new System.Windows.Forms.ComboBox();
            this.dtBuscar = new System.Windows.Forms.DateTimePicker();
            this.dgValor = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtTotalOrcamento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgValor)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCliente
            // 
            this.cbCliente.Enabled = false;
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(572, 133);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(189, 24);
            this.cbCliente.TabIndex = 69;
            // 
            // cbProduto
            // 
            this.cbProduto.Enabled = false;
            this.cbProduto.FormattingEnabled = true;
            this.cbProduto.Location = new System.Drawing.Point(194, 133);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(189, 24);
            this.cbProduto.TabIndex = 68;
            this.cbProduto.SelectedIndexChanged += new System.EventHandler(this.cbProduto_SelectedIndexChanged);
            this.cbProduto.SelectionChangeCommitted += new System.EventHandler(this.cbProduto_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 67;
            this.label7.Text = "Produto:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(433, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 66;
            this.label8.Text = "Cliente:";
            // 
            // txtNOrcamento
            // 
            this.txtNOrcamento.Enabled = false;
            this.txtNOrcamento.Location = new System.Drawing.Point(194, 94);
            this.txtNOrcamento.Name = "txtNOrcamento";
            this.txtNOrcamento.Size = new System.Drawing.Size(189, 22);
            this.txtNOrcamento.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 64;
            this.label3.Text = "N° Orçamento:";
            // 
            // txtBuscarNOrcamento
            // 
            this.txtBuscarNOrcamento.Location = new System.Drawing.Point(521, 16);
            this.txtBuscarNOrcamento.Name = "txtBuscarNOrcamento";
            this.txtBuscarNOrcamento.Size = new System.Drawing.Size(189, 22);
            this.txtBuscarNOrcamento.TabIndex = 63;
            this.txtBuscarNOrcamento.TextChanged += new System.EventHandler(this.txtBuscarNOrcamento_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 62;
            this.label2.Text = "Buscar Por:";
            // 
            // dg
            // 
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(74, 235);
            this.dg.Name = "dg";
            this.dg.RowHeadersWidth = 51;
            this.dg.RowTemplate.Height = 24;
            this.dg.Size = new System.Drawing.Size(1024, 310);
            this.dg.TabIndex = 61;
            this.dg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellClick);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(521, 610);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(123, 47);
            this.btnExcluir.TabIndex = 60;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(385, 610);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(123, 47);
            this.btnEditar.TabIndex = 59;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Location = new System.Drawing.Point(249, 610);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(123, 47);
            this.btnSalvar.TabIndex = 58;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(113, 610);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(123, 47);
            this.btnNovo.TabIndex = 57;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(454, -25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 55;
            this.label1.Text = "Buscar:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Enabled = false;
            this.txtQuantidade.Location = new System.Drawing.Point(572, 96);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(189, 22);
            this.txtQuantidade.TabIndex = 54;
            this.txtQuantidade.TextChanged += new System.EventHandler(this.txtQuantidade_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(433, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 53;
            this.label4.Text = "Quantidade:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(1348, 12);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(56, 22);
            this.txtCodigo.TabIndex = 70;
            this.txtCodigo.Visible = false;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(653, 566);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(40, 17);
            this.lbTotal.TabIndex = 71;
            this.lbTotal.Text = "Total";
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Location = new System.Drawing.Point(194, 174);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(189, 22);
            this.txtValor.TabIndex = 73;
            this.txtValor.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 17);
            this.label5.TabIndex = 72;
            this.label5.Text = "Valor do Produto:";
            // 
            // rbCliente
            // 
            this.rbCliente.AutoSize = true;
            this.rbCliente.Location = new System.Drawing.Point(194, 16);
            this.rbCliente.Name = "rbCliente";
            this.rbCliente.Size = new System.Drawing.Size(72, 21);
            this.rbCliente.TabIndex = 74;
            this.rbCliente.TabStop = true;
            this.rbCliente.Text = "Cliente";
            this.rbCliente.UseVisualStyleBackColor = true;
            this.rbCliente.CheckedChanged += new System.EventHandler(this.rbCliente_CheckedChanged);
            // 
            // rbNOrcamento
            // 
            this.rbNOrcamento.AutoSize = true;
            this.rbNOrcamento.Location = new System.Drawing.Point(282, 16);
            this.rbNOrcamento.Name = "rbNOrcamento";
            this.rbNOrcamento.Size = new System.Drawing.Size(114, 21);
            this.rbNOrcamento.TabIndex = 75;
            this.rbNOrcamento.TabStop = true;
            this.rbNOrcamento.Text = "Nº Orçameno";
            this.rbNOrcamento.UseVisualStyleBackColor = true;
            this.rbNOrcamento.CheckedChanged += new System.EventHandler(this.rbNOrcamento_CheckedChanged);
            // 
            // rbData
            // 
            this.rbData.AutoSize = true;
            this.rbData.Location = new System.Drawing.Point(415, 16);
            this.rbData.Name = "rbData";
            this.rbData.Size = new System.Drawing.Size(59, 21);
            this.rbData.TabIndex = 76;
            this.rbData.TabStop = true;
            this.rbData.Text = "Data";
            this.rbData.UseVisualStyleBackColor = true;
            this.rbData.CheckedChanged += new System.EventHandler(this.rbData_CheckedChanged);
            // 
            // cbBuscarCliente
            // 
            this.cbBuscarCliente.FormattingEnabled = true;
            this.cbBuscarCliente.Location = new System.Drawing.Point(521, 16);
            this.cbBuscarCliente.Name = "cbBuscarCliente";
            this.cbBuscarCliente.Size = new System.Drawing.Size(189, 24);
            this.cbBuscarCliente.TabIndex = 77;
            this.cbBuscarCliente.SelectionChangeCommitted += new System.EventHandler(this.cbBuscarCliente_SelectionChangeCommitted);
            // 
            // dtBuscar
            // 
            this.dtBuscar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBuscar.Location = new System.Drawing.Point(521, 18);
            this.dtBuscar.Name = "dtBuscar";
            this.dtBuscar.Size = new System.Drawing.Size(189, 22);
            this.dtBuscar.TabIndex = 78;
            this.dtBuscar.ValueChanged += new System.EventHandler(this.dtBuscar_ValueChanged);
            // 
            // dgValor
            // 
            this.dgValor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgValor.Location = new System.Drawing.Point(1132, 235);
            this.dgValor.Name = "dgValor";
            this.dgValor.RowHeadersWidth = 51;
            this.dgValor.RowTemplate.Height = 24;
            this.dgValor.Size = new System.Drawing.Size(272, 310);
            this.dgValor.TabIndex = 79;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1023, 176);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 53);
            this.btnAdd.TabIndex = 80;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtTotalOrcamento
            // 
            this.txtTotalOrcamento.Enabled = false;
            this.txtTotalOrcamento.Location = new System.Drawing.Point(572, 176);
            this.txtTotalOrcamento.Name = "txtTotalOrcamento";
            this.txtTotalOrcamento.Size = new System.Drawing.Size(189, 22);
            this.txtTotalOrcamento.TabIndex = 82;
            this.txtTotalOrcamento.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(431, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 21);
            this.label6.TabIndex = 81;
            this.label6.Text = "Total do Orçamento:";
            // 
            // frmOrcamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1535, 741);
            this.Controls.Add(this.txtTotalOrcamento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgValor);
            this.Controls.Add(this.dtBuscar);
            this.Controls.Add(this.cbBuscarCliente);
            this.Controls.Add(this.rbData);
            this.Controls.Add(this.rbNOrcamento);
            this.Controls.Add(this.rbCliente);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.cbProduto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNOrcamento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBuscarNOrcamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label4);
            this.MaximizeBox = false;
            this.Name = "frmOrcamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário de Orçamentos";
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgValor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.ComboBox cbProduto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNOrcamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBuscarNOrcamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbCliente;
        private System.Windows.Forms.RadioButton rbNOrcamento;
        private System.Windows.Forms.RadioButton rbData;
        private System.Windows.Forms.ComboBox cbBuscarCliente;
        private System.Windows.Forms.DateTimePicker dtBuscar;
        private System.Windows.Forms.DataGridView dgValor;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtTotalOrcamento;
        private System.Windows.Forms.Label label6;
    }
}