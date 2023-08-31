using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Venda_Bovina
{
    public partial class FormInicial : Form
    {
        public FormInicial()
        {
            try
            {
                InitializeComponent();

                foreach (Fazendeiro str in Program.usuarios)
                {
                    lbl_nomeUsuario.Text = Fazendeiro.PrimeiroNome(str.Nome);
                    dataGridView1.Rows.Add(str.Nome, Fazendeiro.Cpf, str.Idade, str.Cnpj, str.PropriedadeR, str.CabecaG, str.Marca);
                }

                if (Program.botaoFotoUsuario.Count == 1)
                {
                    picture_fotoUsuario.BackgroundImage = Program.botaoFotoUsuario[0].BackgroundImage;
                    picture_fotoUsuario.BackgroundImageLayout = Program.botaoFotoUsuario[0].BackgroundImageLayout;

                }
                else
                {

                }
            }
            catch (Exception ex)
            {

            }
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
