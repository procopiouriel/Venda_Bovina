using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Venda_Bovina
{
    public partial class FormInicial : Form
    {
        public static int numeracao = 1;
        Cadastro_Rebanho conexao = new Cadastro_Rebanho();
        public FormInicial()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {

            this.Close();



        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                FormCadastroRebanho conexao1 = new FormCadastroRebanho();
                this.Visible = false;
                conexao1.ShowDialog();
                Cadastro_Rebanho.numeracao = numeracao;

                numeracao++;
            }
            catch (Exception ex)
            {

            }

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormRebanho conexao1 = new FormRebanho();
            this.Visible = false;
            conexao1.ShowDialog();
        }
    }
}
