using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Venda_Bovina;

namespace WF_ModerUI
{
    public partial class FormMenu : Form
    {

        Venda conexao = new Venda();


        public FormMenu()
        {
            InitializeComponent();
            lbl_saldo.Text = conexao.saldo.ToString("C2");
        }



        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = true;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormVenda tela = new FormVenda();

            this.Visible = false;
            tela.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
