using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Venda_Bovina
{
    public partial class FormLoginUsuario : Form
    {
        public Fazendeiro conexao1 = new Fazendeiro();
        public FormLoginUsuario()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            try
            {
                string cpf = txt_cpf.Text;
                var senha = txt_senha.Text;

                foreach (Fazendeiro str in Program.usuarios)
                {
                    //MessageBox.Show(str.Cpf);
                    if (str.Cpf == cpf && str.Senha == senha)
                    {
                        Program.usuarioOnline.Add(str);
                        FormInicial conexao = new FormInicial();
                        this.Visible = false;
                        conexao.ShowDialog();
                    }
                    else
                    {
                        txt_aviso.Text = "Senha ou CPF incorretos!";
                    }
                }








            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {




        }

        private void txt_cnpj_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {


        }

        private void txt_idade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_quantidadeCabecas_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_areaTerreno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_marca_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void img_cpf_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FormCadastroUsuario conexao = new FormCadastroUsuario();
            this.Visible = false;
            conexao.ShowDialog();
        }
    }
}
