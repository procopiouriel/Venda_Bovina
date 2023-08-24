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
    public partial class FormRebanho : Form
    {
        public FormRebanho()
        {
            try
            {
                InitializeComponent();
                foreach (Cadastro_Rebanho str in Program.rebanho)
                {
                    dataGridView1.Rows.Add(Cadastro_Rebanho.Sexo(str.animal, str.sexo, str.idade), str.numeracao, str.raca, str.idade, str.comprimento, str.coloracao, str.registro, str.altura, str.marca, str.genetica, Cadastro_Rebanho.PrecoRebanho(str.peso, str.animal, str.sexo, str.idade, str.genetica).ToString("C2"), str.peso);
                }

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
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;

                if (index >= 0 && index < Program.botaoFoto.Count)
                {

                    btn_foto.BackgroundImage = Program.botaoFoto[index].BackgroundImage;
                    btn_foto.BackgroundImageLayout = Program.botaoFoto[index].BackgroundImageLayout;


                }
                else
                {
                    MessageBox.Show("Este animal não possui imagens registradas!");
                }
            }
        }
    }
}
