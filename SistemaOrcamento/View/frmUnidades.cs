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
    public partial class frmUnidades : Form
    {
        UnidadeModel UnidadeModel = new UnidadeModel();

        public frmUnidades()
        {
            InitializeComponent();
            Listar();
        }
        private void Listar()
        {
            try
            {
                dg.DataSource = UnidadeModel.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Listar os Dados " + ex.Message);
            }
        }
        private void Salvar(Unidades unidades)
        {
            if (txtUnidade.Text == "")
            {
                MessageBox.Show("Preencha o Campo Unidade!");
                return;
            }

            try
            {
                unidades.unidade = txtUnidade.Text;
                UnidadeModel.Salvar(unidades);

                MessageBox.Show("Registro salvo com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar " + ex.Message);
            }
        }
        public void Excluir(Unidades unidades)
        {
            try
            {
                unidades.IdUnidade = Convert.ToInt32(txtCodigo.Text);
                UnidadeModel.Excluir(unidades);
                MessageBox.Show("Registro excluido com Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Excluir " + ex.Message);
            }
        }
        public void Editar(Unidades unidades)
        {
            try
            {
                unidades.IdUnidade = Convert.ToInt32(txtCodigo.Text);
                unidades.unidade = txtUnidade.Text;

                UnidadeModel.Editar(unidades);
                MessageBox.Show("Registro Editado com Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Editar " + ex.Message);
            }
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtUnidade.Enabled = true;
            btnSalvar.Enabled = true;
            txtUnidade.Text = "";
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtUnidade.Text == "")
            {
                MessageBox.Show("Preencha o campo Unidade!");
                return;
            }
            Unidades unidades = new Unidades();
            Salvar(unidades);
            Listar();
            txtUnidade.Enabled = false;
            btnSalvar.Enabled = false;
            txtUnidade.Text = "";
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Selecione na tabela um registro para editar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Unidades unidades = new Unidades();
            Editar(unidades);
            Listar();
            txtUnidade.Enabled = false;
            btnSalvar.Enabled = false;
            txtUnidade.Text = "";

        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Selecione na tabela um registro para excluir", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Deseja Excluir a Unidade?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }

            Unidades unidades = new Unidades();
            Excluir(unidades);
            Listar();
            txtUnidade.Enabled = false;
            btnSalvar.Enabled = false;
            txtUnidade.Text = "";
        }
        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dg.CurrentRow.Cells[0].Value.ToString();
            txtUnidade.Text = dg.CurrentRow.Cells[1].Value.ToString();
            txtUnidade.Enabled = true;
        }
    }
}
