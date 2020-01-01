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
    public partial class frmClientes : Form
    {
        ClienteModel ClienteModel = new ClienteModel();

        public frmClientes()
        {
            InitializeComponent();
            Listar();
        }
        private void Listar()
        {
            try
            {
                dg.DataSource = ClienteModel.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Listar os Dados " + ex.Message);
            }
        }
        private void HabilitarCampos()
        {
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtTelefone.Enabled = true;
        }
        private void DesabilitarCampos()
        {
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            txtTelefone.Enabled = false;
        }
        private void Limpar()
        {
            txtNome.Text = "";
            txtEmail.Text = "";
            txtTelefone.Text = "";
            txtBuscarNome.Text = "";
            txtCodigo.Text = "";
        }
        private void Salvar(Clientes clientes)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Preencha o Campo Nome!");
                return;
            }

            try
            {
                clientes.Nome = txtNome.Text;
                clientes.Telefone = txtTelefone.Text;
                clientes.Email = txtEmail.Text;
                ClienteModel.Salvar(clientes);

                MessageBox.Show("Registro salvo com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar " + ex.Message);
            }
        }
        public void Buscar(Clientes clientes)
        {
            try
            {
                clientes.Nome = txtBuscarNome.Text;
                dg.DataSource = ClienteModel.Buscar(clientes);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Listar os Dados" + ex.Message);
            }
        }
        public void Excluir(Clientes clientes)
        {
            try
            {
                clientes.IdCliente = Convert.ToInt32(txtCodigo.Text);
                ClienteModel.Excluir(clientes);
                MessageBox.Show("Registro excluido com Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Excluir " + ex.Message);
            }
        }
        public void Editar(Clientes clientes)
        {
            try
            {
                clientes.IdCliente = Convert.ToInt32(txtCodigo.Text);
                clientes.Nome = txtNome.Text;
                clientes.Telefone = txtTelefone.Text;
                clientes.Email = txtEmail.Text;

                ClienteModel.Editar(clientes);
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
            if (txtNome.Text == "")
            {
                MessageBox.Show("Preencha o campo Nome");
                return;
            }
            Clientes clientes = new Clientes();
            Salvar(clientes);
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

            Clientes clientes = new Clientes();
            Editar(clientes);
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

            if (MessageBox.Show("Deseja Excluir o Cliente?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }

            Clientes clientes = new Clientes();
            Excluir(clientes);
            Listar();
            Limpar();
            DesabilitarCampos();
        }
        private void txtBuscarNome_TextChanged(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            Buscar(clientes);

            if (txtBuscarNome.Text == "")
            {
                Listar();
                return;
            }
        }
        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dg.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dg.CurrentRow.Cells[1].Value.ToString();
            txtTelefone.Text = dg.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = dg.CurrentRow.Cells[3].Value.ToString();
            HabilitarCampos();
        }
    }
}
