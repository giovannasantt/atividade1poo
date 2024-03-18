using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade1
{
    public partial class Atividade1 : Form
    {
        public Atividade1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double salarioN, comissao, carros, vendas, salarioF, salarioT, porcentagem;
            salarioN = Convert.ToDouble(txtsalario.Text);
            comissao = Convert.ToDouble(txtcomissao.Text);
            carros = Convert.ToDouble(txtvendaT.Text);
            vendas = Convert.ToDouble(txtvalorT.Text);
            salarioF = salarioN + vendas + comissao;
            porcentagem = (vendas * 5) / 100;
            salarioT = salarioN + comissao + vendas + porcentagem;
            txtsalarioS.Text = salarioF.ToString();
            txtporcentagem.Text = porcentagem.ToString();
            txtsalarioF.Text = salarioT.ToString();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtsalario.Clear();
            txtcomissao.Clear();
            txtvendaT.Clear();
            txtvalorT.Clear();
            txtporcentagem.Clear();
            txtsalarioS.Clear();
            txtsalarioF.Clear();
            txtsalario.Focus();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
