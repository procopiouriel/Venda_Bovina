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


                foreach (Fazendeiro str2 in Program.usuarioOnline)
                {
                    lbl_nomeUsuario.Text = Fazendeiro.PrimeiroNome(str2.Nome);
                    
                    dataGridView1.Rows.Add(str2.Nome, str2.Cpf, str2.Idade, str2.Cnpj, str2.PropriedadeR, str2.CabecaG, str2.Marca);
                    if (str2.Foto != null)
                    {
                        picture_fotoUsuario.BackgroundImage = Image.FromFile(str2.Foto);
                        picture_fotoUsuario.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }



                
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
