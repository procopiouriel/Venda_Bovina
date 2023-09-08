using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Venda_Bovina
{
    public partial class FormCadastroUsuario : Form
    {
        public Fazendeiro conexao1 = new Fazendeiro();
        public string fotoUser;
        public FormCadastroUsuario()
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

                string nome = txt_nome.Text;
                var senha = txt_senha.Text;
                int idade = Convert.ToInt32(txt_idade.Text);
                string cpf = txt_cpf.Text;
                string cnpj = txt_cnpj.Text;
                double areaTerreno = Convert.ToDouble(txt_areaTerreno.Text);
                int quantidadeCabecas = Convert.ToInt32(txt_quantidadeCabecas.Text);
                string marca = txt_marca.Text;

                if (ValidaCNPJ.IsCnpj(cnpj) == false || Validacoes.ValidaCPF(cpf) == false)//SE O CNPJ FOR FALSO
                {
                    MessageBox.Show("CNPJ ou CPF invalido!");

                }
                else
                {
                    if (marca == "")
                    {
                        MessageBox.Show("Preencha seu nome completo!");
                    }
                    else
                    {
                        Fazendeiro conexao = new Fazendeiro(fotoUser, nome, senha, idade, cpf, cnpj, areaTerreno, quantidadeCabecas, marca);
                        Program.usuarios.Add(conexao);
                        Program.usuarioOnline.Add(conexao);


                        if (conexao.JsonSerealizarListaUsuario(Program.usuarios, @"C:\Users\proco\source\repos\Venda Bovina\Venda Bovina\Banco Usuario.json"))
                            MessageBox.Show("Salvo");

                       

                        FormInicial conexao1 = new FormInicial();
                        this.Visible = false;
                        conexao1.ShowDialog();
                    }
                }




            }
            catch (Exception error)
            {

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {
            txt_marca.Text = conexao1.MarcaGado(txt_nome.Text);
        }

        private void txt_cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            try
            {
                while (true)
                {
                    if (txt_cpf.Text.Length == 14)
                    {

                        if (Validacoes.ValidaCPF(txt_cpf.Text) == true)
                        {
                            img_cpf.BackgroundImage = Properties.Resources.certo;
                            img_cpf.BackgroundImageLayout = ImageLayout.Stretch;

                        }
                        else
                        {
                            img_cpf.BackgroundImage = Properties.Resources.errado;
                            img_cpf.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    }
                }
            }
            catch (Exception ex)
            {

            }



        }

        private void txt_cnpj_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            try
            {
                while (true)
                {
                    if (txt_cnpj.Text.Length == 18)
                    {
                        if (ValidaCNPJ.IsCnpj(txt_cnpj.Text) == true)
                        {
                            img_cnpj.BackgroundImage = Properties.Resources.certo;
                            img_cnpj.BackgroundImageLayout = ImageLayout.Stretch;

                        }
                        else
                        {
                            img_cnpj.BackgroundImage = Properties.Resources.errado;
                            img_cnpj.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    }
                }
            }
            catch (Exception ex)
            {

            }



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
            try
            {
                string origemCompleto = "";
                string foto = "";
                string pastaDestino = "";
                string destinoCompleto = "";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    origemCompleto = openFileDialog1.FileName;//RETORNA O CAMINHO DO ARQUIVO
                    foto = openFileDialog1.SafeFileName;//RETORNA NOME DO ARQUIVO
                    destinoCompleto = pastaDestino + foto;
                }
                if (File.Exists(destinoCompleto))//SE O ARQUIVO DO ORIGEM COMPLETO EXISTE
                {
                    if (MessageBox.Show("Arquivo ja existe, deseja substituir?", "Substituir", MessageBoxButtons.YesNo) == DialogResult.No)
                    {//SE ELE DESEJA SUBSTITUIR O ARQUIVO CASO ELE EXISTA
                        return;
                    }
                }
                System.IO.File.Copy(origemCompleto, destinoCompleto, true);


                if (File.Exists(destinoCompleto))
                {

                    btn_fotoUsuario.BackgroundImage = Image.FromFile(origemCompleto);
                    btn_fotoUsuario.BackgroundImageLayout = ImageLayout.Stretch;
                    fotoUser = origemCompleto;
                    Program.botaoFotoUsuario.Add(btn_fotoUsuario);

                    MessageBox.Show("Imagem adicionada com sucesso!");
                }
                else
                {
                    MessageBox.Show("Arquivo nao copiado!");
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void img_cpf_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormLoginUsuario conexao = new FormLoginUsuario();
            this.Visible = false;
            conexao.ShowDialog();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
