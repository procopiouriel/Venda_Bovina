using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_ModerUI;

namespace Venda_Bovina
{
    public partial class Tela_Venda : Form
    {
        FormMenu tela = new FormMenu();
        public Tela_Venda()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//VOLTAR
        {
            this.Close();
            tela.Show();
        }

        private void btn_comprar_Click(object sender, EventArgs e)
        {

        }
    }
}
