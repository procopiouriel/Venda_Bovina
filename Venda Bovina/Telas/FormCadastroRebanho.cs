﻿using System;
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
using System.Xml;

namespace Venda_Bovina
{
    public partial class FormCadastroRebanho : Form
    {

        public FormCadastroRebanho()
        {
            try
            {
                InitializeComponent();
                Cadastro_Rebanho conexao = new Cadastro_Rebanho();
                txt_numeracao.Text = Cadastro_Rebanho.numeracao.ToString();
                MessageBox.Show(Cadastro_Rebanho.numeracao.ToString());
            }
            catch (Exception ex)
            {
                
            }

           
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
            FormInicial conexao = new FormInicial();
            this.Close();
            conexao.Visible = true;
            FormInicial.numeracao--;
            Cadastro_Rebanho.numeracao = FormInicial.numeracao;

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public void btnVendas_Click(object sender, EventArgs e)
        {
            Lista();
        }

        public void Lista()
        {
            try
            {
                string animal = combo_tipos.Text;
                string sexo = combo_sexo.Text;
                int numeracao = Convert.ToInt32(txt_numeracao.Text);
                string raca = txt_raca.Text;
                int idade = Convert.ToInt32(txt_idade.Text);

                double comprimento = Convert.ToDouble(txt_comprimento.Text);
                string coloracao = combo_coloracao.Text;
                string registro = combo_registro.Text;
                double altura = Convert.ToDouble(txt_altura.Text);
                string marca = txt_marca.Text;
                double genetica = Convert.ToDouble(txt_genetica.Text);
                double peso = Convert.ToDouble(txt_peso.Text);

                Cadastro_Rebanho conexao = new Cadastro_Rebanho(animal, sexo, numeracao, raca, idade, comprimento, coloracao, registro, altura, marca, genetica, peso);
                Program.rebanho.Add(conexao);

                MessageBox.Show("Animal registrado com exito!");

                FormRebanho conexao1 = new FormRebanho();
                this.Close();
                conexao1.ShowDialog();



            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
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

                    btn_imagem.BackgroundImage = Image.FromFile(destinoCompleto);
                    btn_imagem.BackgroundImageLayout = ImageLayout.Stretch;

                    Program.botaoFoto.Add(btn_imagem);
                    MessageBox.Show("Imagem adicionada com sucesso!");
                }
                else
                {
                    MessageBox.Show("Arquivo nao copiado!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void combo_animais_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (combo_tipos.Text == "Bovinos")
                {
                    combo_coloracao.Items.Clear();
                    combo_coloracao.Items.Add("Branco");
                    combo_coloracao.Items.Add("Preto");
                    combo_coloracao.Items.Add("Vermelho");
                    combo_coloracao.Items.Add("Amarelo");
                    combo_coloracao.Items.Add("Mestiço");
                }
                else if (combo_tipos.Text == "Equinos" || combo_tipos.Text == "Muares")
                {
                    combo_coloracao.Items.Clear();
                    combo_coloracao.Items.Add("Ruano");
                    combo_coloracao.Items.Add("Branco");
                    combo_coloracao.Items.Add("Baio");
                    combo_coloracao.Items.Add("Preto");
                    combo_coloracao.Items.Add("Pedrez");
                    combo_coloracao.Items.Add("Castanho");
                    combo_coloracao.Items.Add("Rosilha");
                }
            }
            catch (Exception ex)
            {

            }
            




        }

        private void combo_coloracao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_numeracao_TextChanged(object sender, EventArgs e)
        {

        }

        private void combo_animais_SelectedIndexChanged_1(object sender, EventArgs e)//AKSAISHHASJAS
        {

        }

        private void combo_registro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_idade_TextChanged(object sender, EventArgs e)
        {
        }
    }
}