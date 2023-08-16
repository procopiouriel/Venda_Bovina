using System.Drawing;

namespace Venda_Bovina
{
    public partial class Form1 : Form
    {


        Venda conexao = new Venda();

        public Form1()
        {
            InitializeComponent();
            lbl_saldo.Text = conexao.saldo.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tela_Venda tela = new Tela_Venda();
            
            this.Visible = false;
            tela.ShowDialog();
            



            /*double valor = 5000;
            conexao.valorAnimal = valor;

            conexao.Comercio();

            lbl_saldo.Text = Convert.ToString(conexao.saldo);*/
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}