using SistemaOrcamento.Entities;
using SistemaOrcamento.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaOrcamento.View
{
    public partial class frmOrcamentos : Form
    {
        OrcamentoModel orcamentoModel = new OrcamentoModel();
        ProdutoModel produtoModel = new ProdutoModel();
        ClienteModel clienteModel = new ClienteModel();

        public frmOrcamentos()
        {
            InitializeComponent();
            Listar();
            PreencherCB();
            rbCliente.Checked = true;
        }
        private void PreencherCB()
        {
            cbProduto.DataSource = produtoModel.ListarProdutos();
            cbProduto.ValueMember = "id_produto";
            cbProduto.DisplayMember = "nome";

            cbCliente.DataSource = clienteModel.Listar();
            cbCliente.ValueMember = "id_cliente";
            cbCliente.DisplayMember = "nome";
        }
        private void Listar()
        {
            try
            {
                dg.DataSource = orcamentoModel.ListarOrcamento();
                dg.Columns[0].Visible = false;
                dg.Columns[8].Visible = false;
                dg.Columns[9].Visible = false;
                dg.Columns[1].HeaderText = "Número Orçamento";
                dg.Columns[2].HeaderText = "Produto";
                dg.Columns[4].HeaderText = "Cliente";
                dg.Columns[5].HeaderText = "Quantidade";
                dg.Columns[6].HeaderText = "Valor Total";
                dg.Columns[7].HeaderText = "Data";
                dg.Columns[3].HeaderText = "Valor Unitário";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Listar os Dados " + ex.Message);
            }
        }
        private void HabilitarCampos()
        {
            txtNOrcamento.Enabled = true;
            //txtQuantidade.Enabled = true;
            cbCliente.Enabled = true;
            cbProduto.Enabled = true;
        }
        private void DesabilitarCampos()
        {
            txtNOrcamento.Enabled = false;
            txtQuantidade.Enabled = false;
            cbCliente.Enabled = false;
            cbProduto.Enabled = false;
        }
        private void Limpar()
        {
            txtNOrcamento.Text = "";
            txtQuantidade.Text = "";
            txtCodigo.Text = "";
            lbTotal.Text = "";
            txtValor.Text = "";
        }
        private void Salvar(Orcamentos orcamentos)
        {
            //if (txtNome.Text == "")
            //{
            //    MessageBox.Show("Preencha o Campo Nome!");
            //    return;
            //}

            try
            {
                orcamentos.NumOrcamento = txtNOrcamento.Text;
                orcamentos.Quantidade = Convert.ToInt32(txtQuantidade.Text);
                orcamentos.IdProduto = Convert.ToInt32(cbProduto.SelectedValue);
                orcamentos.IdCliente = Convert.ToInt32(cbCliente.SelectedValue);
                orcamentos.ValorTotal = Convert.ToDecimal(lbTotal.Text);
                orcamentos.Data = DateTime.Today;
                orcamentoModel.Salvar(orcamentos);

                MessageBox.Show("Registro salvo com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar " + ex.Message);
            }
        }
        public void Buscar(Orcamentos orcamentos)
        {
            try
            {
                orcamentos.NumOrcamento = txtNOrcamento.Text;
                //orcamentos.IdCliente = Convert.ToInt32(cbBuscarCliente.SelectedValue);
                //orcamentos.Data = Convert.ToDateTime(dtBuscar.Text);
                dg.DataSource = orcamentoModel.Buscar(orcamentos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Listar os Dados" + ex.Message);
            }
        }
        public void BuscarDT(Orcamentos orcamentos)
        {
            try
            {
                //orcamentos.NumOrcamento = txtNOrcamento.Text;
                //orcamentos.IdCliente = Convert.ToInt32(cbBuscarCliente.SelectedValue);
                orcamentos.Data = Convert.ToDateTime(dtBuscar.Text);
                dg.DataSource = orcamentoModel.Buscar(orcamentos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Listar os Dados" + ex.Message);
            }
        }
        public void BuscarCB(Orcamentos orcamentos)
        {
            try
            {
                //orcamentos.NumOrcamento = txtNOrcamento.Text;
                orcamentos.IdCliente = Convert.ToInt32(cbBuscarCliente.SelectedValue);
                //orcamentos.Data = Convert.ToDateTime(dtBuscar.Text);
                dg.DataSource = orcamentoModel.Buscar(orcamentos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Listar os Dados" + ex.Message);
            }
        }
        public void BuscarValor(Produtos produtos)
        {
            try
            {
                produtos.IdProduto = Convert.ToInt32(cbProduto.SelectedValue);

                dgValor.DataSource = produtoModel.BuscarValor(produtos);
                txtValor.Text = dgValor.CurrentRow.Cells[0].Value.ToString();
                //txtValor.Text = produtoModel.BuscarValor(produtos).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Listar os Dados" + ex.Message);
            }
        }
        public void Excluir(Orcamentos orcamentos)
        {
            try
            {
                orcamentos.IdOrcamento = Convert.ToInt32(txtCodigo.Text);
                orcamentoModel.Excluir(orcamentos);
                MessageBox.Show("Registro excluido com Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Excluir " + ex.Message);
            }
        }
        public void Editar(Orcamentos orcamentos)
        {
            try
            {
                orcamentos.IdOrcamento = Convert.ToInt32(txtCodigo.Text);
                orcamentos.NumOrcamento = txtNOrcamento.Text;
                orcamentos.IdProduto = Convert.ToInt32(cbProduto.SelectedValue);
                orcamentos.IdCliente = Convert.ToInt32(cbCliente.SelectedValue);
                orcamentos.ValorTotal = Convert.ToDecimal(lbTotal.Text);
                orcamentos.Data = DateTime.Today;
                orcamentos.Quantidade = Convert.ToInt32(txtQuantidade.Text);
                //orcamentoModel.Salvar(orcamentos);

                orcamentoModel.Editar(orcamentos);
                MessageBox.Show("Registro Editado com Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Editar " + ex.Message);
            }
        }
        private decimal ValorTotal()
        {
            decimal total = 0;
            int i = 0;

            for (i = 0; i < dg.Rows.Count; i++)
            {
                total = total + Convert.ToDecimal(dg.Rows[i].Cells[6].Value);
            }
            return total;
        }

        private void cbProduto_SelectionChangeCommitted(object sender, EventArgs e)
        {

            txtQuantidade.Enabled = true;
            Produtos produtos = new Produtos();
            BuscarValor(produtos);
        }

        private void rbCliente_CheckedChanged(object sender, EventArgs e)
        {
            cbBuscarCliente.Visible = true;
            txtBuscarNOrcamento.Visible = false;
            dtBuscar.Visible = false;
            txtBuscarNOrcamento.Text = "";
            cbBuscarCliente.Enabled = true;
        }

        private void rbNOrcamento_CheckedChanged(object sender, EventArgs e)
        {
            cbBuscarCliente.Visible = false;
            txtBuscarNOrcamento.Visible = true;
            dtBuscar.Visible = false;
            txtBuscarNOrcamento.Text = "";
            cbBuscarCliente.Enabled = true;

        }

        private void rbData_CheckedChanged(object sender, EventArgs e)
        {
            cbBuscarCliente.Visible = false;
            txtBuscarNOrcamento.Visible = false;
            dtBuscar.Visible = true;
            txtBuscarNOrcamento.Text = "";
            cbBuscarCliente.Enabled = true;
        }

        private void txtBuscarNOrcamento_TextChanged(object sender, EventArgs e)
        {
            Orcamentos orcamentos = new Orcamentos();
            Buscar(orcamentos);
            txtTotalOrcamento.Text = ValorTotal().ToString();
        }

        private void cbBuscarCliente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Orcamentos orcamentos = new Orcamentos();
            BuscarCB(orcamentos);
            txtTotalOrcamento.Text = ValorTotal().ToString();
        }

        private void dtBuscar_ValueChanged(object sender, EventArgs e)
        {
            Orcamentos orcamentos = new Orcamentos();
            BuscarDT(orcamentos);
            txtTotalOrcamento.Text = ValorTotal().ToString();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            btnSalvar.Enabled = true;
            Limpar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNOrcamento.Text == "")
            {
                MessageBox.Show("Preencha o campo Codigo");
                return;
            }
            Orcamentos orcamentos = new Orcamentos();
            Salvar(orcamentos);
            Listar();
            Limpar();
            DesabilitarCampos();
            btnSalvar.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Selecione na tabela um registro para editar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Orcamentos orcamentos = new Orcamentos();
            Editar(orcamentos);
            Listar();
            Limpar();
            DesabilitarCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Selecione na tabela um registro para excluir", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Deseja Excluir o Produto?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }

            Orcamentos orcamentos = new Orcamentos();
            Excluir(orcamentos);
            Listar();
            Limpar();
            DesabilitarCampos();
        }

        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Produtos dados = new Produtos();
            BuscarValor(dados);

            txtCodigo.Text = dg.CurrentRow.Cells[0].Value.ToString();
            txtNOrcamento.Text = dg.CurrentRow.Cells[1].Value.ToString();
            cbProduto.SelectedValue = dg.CurrentRow.Cells[8].Value.ToString();
            cbCliente.SelectedValue = dg.CurrentRow.Cells[9].Value.ToString();
            txtQuantidade.Text = dg.CurrentRow.Cells[5].Value.ToString();
            lbTotal.Text = dg.CurrentRow.Cells[6].Value.ToString();

            HabilitarCampos();
        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantidade.Text == "")
            {
                lbTotal.Text = "";
                return;
            }

            decimal total = Convert.ToDecimal(txtQuantidade.Text) * Convert.ToDecimal(txtValor.Text);
            lbTotal.Text = total.ToString();
        }

        private void cbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Produtos produtos = new Produtos();
            //BuscarValor(produtos);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtQuantidade.Text == "")
            {
                return;
            }
            Orcamentos orcamentos = new Orcamentos();
            Salvar(orcamentos);
            Listar();

            cbCliente.Enabled = false;
            txtNOrcamento.Enabled = false;
            txtQuantidade.Text = "";
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            cbProduto.Enabled = true;
        }
    }
}
