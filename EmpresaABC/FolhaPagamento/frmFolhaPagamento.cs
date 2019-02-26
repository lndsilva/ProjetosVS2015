using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolhaPagamento
{
    public partial class frmFolhaPagamento : Form
    {
        public frmFolhaPagamento()
        {
            InitializeComponent();
            carregaClube();
        }

        private void frmFolhaPagamento_Load(object sender, EventArgs e)
        {

        }
        public void carregaClube()
        {
            cboDataFolha.Items.Add("Clube A - R$ 100,00");
            cboDataFolha.Items.Add("Clube B - R$  50,00");
            cboDataFolha.Items.Add("Clube C - R$  10,00");

        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {
            txtSalarioFolha.Text = txtSalario.Text;
        }

        private void ckbPlanoSaude_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbPlanoSaude.CheckState == CheckState.Checked)
            {
                txtSalarioFolha.Text = (Double.Parse(txtSalarioFolha.Text) - 150.00).ToString();
            }
            else
            {
                ckbPlanoSaude.Enabled = false;

            }

        }

        private void cboDataFolha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDataFolha.SelectedIndex == 0)
            {
                txtSalarioFolha.Text = Convert.ToString(Double.Parse(txtSalario.Text) - 100.00);
            }
            if (cboDataFolha.SelectedIndex == 1)
            {
                txtSalarioFolha.Text = Convert.ToString(Double.Parse(txtSalario.Text) - 50.00);
            }
            if (cboDataFolha.SelectedIndex == 2)
            {
                txtSalarioFolha.Text = Convert.ToString(Double.Parse(txtSalario.Text) - 10.00);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double salarioFolha = Double.Parse(txtSalarioFolha.Text), salarioLiquido = 0.0, impostoRenda = 0.0;

            if (salarioFolha >= 1903.99 && salarioFolha <= 2826.65)
            {
                impostoRenda = (salarioFolha * 7.5 / 100);
                salarioLiquido = salarioFolha - impostoRenda;
            }
            if (salarioFolha >= 2826.66 && salarioFolha <= 3751.05)
            {
                impostoRenda = (salarioFolha * 15.0 / 100);
                salarioLiquido = salarioFolha - impostoRenda;
            }
            if (salarioFolha >= 3751.05 && salarioFolha <= 4664.68)
            {
                impostoRenda = (salarioFolha * 22.50 / 100);
                salarioLiquido = salarioFolha - impostoRenda;
            }
            if (salarioFolha > 4664.68)
            {
                impostoRenda = (salarioFolha * 27.50 / 100);
                salarioLiquido = salarioFolha - impostoRenda;
            }

            txtImpostoRenda.Text = impostoRenda.ToString();
            txtSalarioLiquido.Text = salarioLiquido.ToString();
        }
    }
}
