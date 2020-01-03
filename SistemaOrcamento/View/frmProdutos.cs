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
    public partial class frmProdutos : Form
    {
        ProdutoModel ProdutoModel = new ProdutoModel();
        FornecedorModel fornecedorModel = new FornecedorModel();
        UnidadeModel unidadeModel = new UnidadeModel();

        public frmProdutos()
        {
            InitializeComponent();
            Listar();
            PreencherCB();
        }
        private void PreencherCB()
        {
            cbUnidade.DataSource = unidadeModel.Listar();
            cbUnidade.ValueMember = "id_unidade";
            cbUnidade.DisplayMember = "unidade";

            cbFornecedor.DataSource = fornecedorModel.Listar();
            cbFornecedor.ValueMember = "id_fornecedor";
            cbFornecedor.DisplayMember = "nome";
        }
        private void Listar()
        {
            try
            {
                dg.DataSource = ProdutoModel.Listar();
                dg.Columns[0].Visible = false;
                dg.Columns[1].HeaderText = "Código";
                dg.Columns[2].HeaderText = "Fornecedor";
                dg.Columns[3].HeaderText = "Nome";
                dg.Columns[4].HeaderText = "Descrição";
                dg.Columns[5].HeaderText = "Unidade";
                dg.Columns[6].HeaderText = "Valor";

                dg.Columns[3].Width = 120;
                dg.Columns[4].Width = 150;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Listar os Dados " + ex.Message);
            }
        }
        private void HabilitarCampos()
        {
            txtNome.Enabled = true;
            txtValor.Enabled = true;
            txtCodigo.Enabled = true;
            txtDescricao.Enabled = true;
            txtCodProduto.Enabled = true;
           // txtBuscarNome.Enabled = true;
            cbFornecedor.Enabled = true;
            cbUnidade.Enabled = true;
        }
        private void DesabilitarCampos()
        {
            txtNome.Enabled = false;
            txtValor.Enabled = false;
            txtCodigo.Enabled = false;
            txtDescricao.Enabled = false;
            txtCodProduto.Enabled = false;
            //txtBuscarNome.Enabled = false;
            cbFornecedor.Enabled = false;
            cbUnidade.Enabled = false;
        }
        private void Limpar()
        {
            txtNome.Text = "";
            txtValor.Text = "";
            txtCodigo.Text = "";
            txtDescricao.Text = "";
            txtCodProduto.Text = "";
            txtBuscarNome.Text = "";
        }
        private void Salvar(Produtos produtos)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Preencha o Campo Nome!");
                return;
            }

            try
            {
                produtos.Codigo = txtCodProduto.Text;
                produtos.Nome = txtNome.Text;
                produtos.Descricao = txtDescricao.Text;
                produtos.IdFornecedor = Convert.ToInt32(cbFornecedor.SelectedValue);
                produtos.IdUnidade = Convert.ToInt32(cbUnidade.SelectedValue);
                produtos.Valor = Convert.ToDecimal(txtValor.Text);
                ProdutoModel.Salvar(produtos);

                MessageBox.Show("Registro salvo com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar " + ex.Message);
            }
        }
        public void Buscar(Produtos produtos)
        {
            try
            {
                produtos.Nome = txtBuscarNome.Text;
                produtos.Codigo = txtBuscarNome.Text;
                dg.DataSource = ProdutoModel.Buscar(produtos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Listar os Dados" + ex.Message);
            }
        }
        public void Excluir(Produtos produtos)
        {
            try
            {
                produtos.IdProduto = Convert.ToInt32(txtCodigo.Text);
                ProdutoModel.Excluir(produtos);
                MessageBox.Show("Registro excluido com Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Excluir " + ex.Message);
            }
        }
        public void Editar(Produtos produtos)
        {
            try
            {
                produtos.IdProduto = Convert.ToInt32(txtCodigo.Text);
                produtos.Codigo = txtCodProduto.Text;
                produtos.Nome = txtNome.Text;
                produtos.Descricao = txtDescricao.Text;
                produtos.IdFornecedor = Convert.ToInt32(cbFornecedor.SelectedValue);
                produtos.IdUnidade = Convert.ToInt32(cbUnidade.SelectedValue);
                produtos.Valor = Convert.ToDecimal(txtValor.Text);
                //ProdutoModel.Salvar(produtos);

                ProdutoModel.Editar(produtos);
                MessageBox.Show("Registro Editado com Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Editar " + ex.Message);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            btnSalvar.Enabled = true;
            Limpar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtCodProduto.Text == "")
            {
                MessageBox.Show("Preencha o campo Codigo");
                return;
            }
            Produtos produtos = new Produtos();
            Salvar(produtos);
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

            Produtos produtos = new Produtos();
            Editar(produtos);
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

            Produtos produtos = new Produtos();
            Excluir(produtos);
            Listar();
            Limpar();
            DesabilitarCampos();
        }

        private void txtBuscarNome_TextChanged(object sender, EventArgs e)
        {
            Produtos produtos = new Produtos();
            Buscar(produtos);

            if (txtBuscarNome.Text == "")
            {
                Listar();
                return;
            }
        }

        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dg.CurrentRow.Cells[0].Value.ToString();
            txtCodProduto.Text = dg.CurrentRow.Cells[1].Value.ToString();
            cbFornecedor.Text = dg.CurrentRow.Cells[2].Value.ToString();
            txtNome.Text = dg.CurrentRow.Cells[3].Value.ToString();
            txtDescricao.Text = dg.CurrentRow.Cells[4].Value.ToString();
            cbUnidade.Text = dg.CurrentRow.Cells[5].Value.ToString();
            txtValor.Text = dg.CurrentRow.Cells[6].Value.ToString();
            HabilitarCampos();            
        }
    }
}
