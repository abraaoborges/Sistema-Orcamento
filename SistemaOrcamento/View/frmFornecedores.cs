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
        public frmFornecedores()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
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
            txtBuscar.Text = "";
        }
    }
}
