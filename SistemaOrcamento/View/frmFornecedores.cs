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
    public partial class frmFornecedores : Form
    {
        FornecedorModel fornecedorModel = new FornecedorModel();

        public frmFornecedores()
        {
            InitializeComponent();
            rbNome.Checked = true;
            Listar();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            btnSalvar.Enabled = true;
            Limpar();
        }

        private void HabilitarCampos()
        {
            txtNome.Enabled = true;
            txtCNPJ.Enabled = true;
            txtEndereco.Enabled = true;
            txtTelefone.Enabled = true;
        }

        private void DesabilitarCampos()
        {
            txtNome.Enabled = false;
            txtCNPJ.Enabled = false;
            txtEndereco.Enabled = false;
            txtTelefone.Enabled = false;
        }

        private void Limpar()
        {
            txtNome.Text = "";
            txtCNPJ.Text = "";
            txtEndereco.Text = "";
            txtTelefone.Text = "";
            txtBuscarNome.Text = "";
            txtCodigo.Text = "";

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Fornecedores fornecedores = new Fornecedores();
            Salvar(fornecedores);
            Listar();
            Limpar();
            DesabilitarCampos();
            btnSalvar.Enabled = false;
        }

        private void Listar()
        {
            try
            {
                dg.DataSource = fornecedorModel.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Listar os Dados " + ex.Message);
            }
        }

        private void Salvar(Fornecedores fornecedores)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Preencha o Campo Nome!");
                return;
            }

            try
            {
                fornecedores.Cnpj = txtCNPJ.Text;
                fornecedores.Nome = txtNome.Text;
                fornecedores.Telefone = txtTelefone.Text;
                fornecedores.Endereco = txtEndereco.Text;
                fornecedorModel.Salvar(fornecedores);

                MessageBox.Show("Registro salvo com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar " + ex.Message);
            }
        }

        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dg.CurrentRow.Cells[0].Value.ToString();
            txtCNPJ.Text = dg.CurrentRow.Cells[1].Value.ToString();
            txtNome.Text = dg.CurrentRow.Cells[2].Value.ToString();
            txtTelefone.Text = dg.CurrentRow.Cells[3].Value.ToString();
            txtEndereco.Text = dg.CurrentRow.Cells[4].Value.ToString();
            HabilitarCampos();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Fornecedores fornecedores = new Fornecedores();
            Buscar(fornecedores);

            if (txtBuscarNome.Text == "")
            {
                Listar();
                return;
            }
        }

        private void txtBuscarCNPJ_TextChanged(object sender, EventArgs e)
        {
            Fornecedores fornecedores = new Fornecedores();
            Buscar(fornecedores);

            if (txtBuscarCNPJ.Text == "")
            {
                Listar();
                return;
            }
        }

        public void Buscar(Fornecedores fornecedores)
        {
            try
            {
                fornecedores.Nome = txtBuscarNome.Text;
                fornecedores.Cnpj = txtBuscarCNPJ.Text;
                dg.DataSource = fornecedorModel.Buscar(fornecedores);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Listar os Dados" + ex.Message);
            }
        }

        private void rbCNPJ_CheckedChanged(object sender, EventArgs e)
        {
            txtBuscarCNPJ.Visible = true;
            txtBuscarNome.Visible = false;
            txtBuscarNome.Text = "?";
        }

        private void rbNome_CheckedChanged(object sender, EventArgs e)
        {
            txtBuscarCNPJ.Visible = false;
            txtBuscarNome.Visible = true;
            txtBuscarCNPJ.Text = "";
            txtBuscarNome.Text = "";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Selecione na tabela um registro para excluir", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Deseja Excluir o Fornecedor?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }

            Fornecedores fornecedores = new Fornecedores();
            Excluir(fornecedores);
            Listar();
            Limpar();
            DesabilitarCampos();
        }

        public void Excluir(Fornecedores fornecedores)
        {
            try
            {
                fornecedores.IdForncedor = Convert.ToInt32(txtCodigo.Text);
                fornecedorModel.Excluir(fornecedores);
                MessageBox.Show("Registro excluido com Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Excluir " + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Selecione na tabela um registro para editar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Fornecedores fornecedores = new Fornecedores();
            Editar(fornecedores);
            Listar();
            Limpar();
            DesabilitarCampos();
        }

        public void Editar(Fornecedores fornecedores)
        {
            try
            {
                fornecedores.IdForncedor = Convert.ToInt32(txtCodigo.Text);
                fornecedores.Nome = txtNome.Text;
                fornecedores.Telefone = txtTelefone.Text;
                fornecedores.Endereco = txtEndereco.Text;
                fornecedores.Cnpj = txtCNPJ.Text;

                fornecedorModel.Editar(fornecedores);
                MessageBox.Show("Registro Editado com Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Editar " + ex.Message);
            }
        }
    }
}
