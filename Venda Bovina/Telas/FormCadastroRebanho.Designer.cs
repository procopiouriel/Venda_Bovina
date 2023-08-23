
namespace Venda_Bovina
{
    partial class FormCadastroRebanho
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroRebanho));
            panelCabecalho = new Panel();
            label1 = new Label();
            button1 = new Button();
            btnFechar = new Button();
            btnRestaurar = new Button();
            btnMaximizar = new Button();
            panelMenu = new Panel();
            panelConteudo = new Panel();
            combo_coloracao = new ComboBox();
            combo_registro = new ComboBox();
            txt_marca = new TextBox();
            txt_peso = new TextBox();
            txt_raca = new TextBox();
            txt_idade = new TextBox();
            txt_altura = new TextBox();
            txt_comprimento = new TextBox();
            txt_genetica = new TextBox();
            txt_numeracao = new TextBox();
            combo_sexo = new ComboBox();
            label14 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            button2 = new Button();
            btn_imagem = new Button();
            combo_tipos = new ComboBox();
            label2 = new Label();
            btn_cadastrar = new Button();
            openFileDialog1 = new OpenFileDialog();
            panelCabecalho.SuspendLayout();
            panelConteudo.SuspendLayout();
            SuspendLayout();
            // 
            // panelCabecalho
            // 
            panelCabecalho.BackColor = Color.Goldenrod;
            panelCabecalho.Controls.Add(label1);
            panelCabecalho.Controls.Add(button1);
            panelCabecalho.Controls.Add(btnFechar);
            panelCabecalho.Controls.Add(btnRestaurar);
            panelCabecalho.Controls.Add(btnMaximizar);
            panelCabecalho.Dock = DockStyle.Top;
            panelCabecalho.Location = new Point(0, 0);
            panelCabecalho.Margin = new Padding(4, 3, 4, 3);
            panelCabecalho.Name = "panelCabecalho";
            panelCabecalho.Size = new Size(933, 46);
            panelCabecalho.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(128, 64, 0);
            label1.Location = new Point(68, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(192, 30);
            label1.TabIndex = 2;
            label1.Text = "Cadastro Rebanho";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            button1.FlatAppearance.MouseOverBackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(731, 4);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(47, 39);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnFechar
            // 
            btnFechar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFechar.BackgroundImage = (Image)resources.GetObject("btnFechar.BackgroundImage");
            btnFechar.BackgroundImageLayout = ImageLayout.Center;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnFechar.FlatAppearance.MouseOverBackColor = Color.Red;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Location = new Point(883, 3);
            btnFechar.Margin = new Padding(4, 3, 4, 3);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(47, 39);
            btnFechar.TabIndex = 0;
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestaurar.BackgroundImage = (Image)resources.GetObject("btnRestaurar.BackgroundImage");
            btnRestaurar.BackgroundImageLayout = ImageLayout.Center;
            btnRestaurar.FlatAppearance.BorderSize = 0;
            btnRestaurar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnRestaurar.FlatAppearance.MouseOverBackColor = Color.Red;
            btnRestaurar.FlatStyle = FlatStyle.Flat;
            btnRestaurar.Location = new Point(776, 3);
            btnRestaurar.Margin = new Padding(4, 3, 4, 3);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(47, 39);
            btnRestaurar.TabIndex = 0;
            btnRestaurar.UseVisualStyleBackColor = true;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.BackgroundImage = (Image)resources.GetObject("btnMaximizar.BackgroundImage");
            btnMaximizar.BackgroundImageLayout = ImageLayout.Center;
            btnMaximizar.FlatAppearance.BorderSize = 0;
            btnMaximizar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnMaximizar.FlatAppearance.MouseOverBackColor = Color.Red;
            btnMaximizar.FlatStyle = FlatStyle.Flat;
            btnMaximizar.Location = new Point(830, 3);
            btnMaximizar.Margin = new Padding(4, 3, 4, 3);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(47, 39);
            btnMaximizar.TabIndex = 0;
            btnMaximizar.UseVisualStyleBackColor = true;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(37, 46, 59);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 46);
            panelMenu.Margin = new Padding(4, 3, 4, 3);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(159, 567);
            panelMenu.TabIndex = 1;
            // 
            // panelConteudo
            // 
            panelConteudo.Controls.Add(combo_coloracao);
            panelConteudo.Controls.Add(combo_registro);
            panelConteudo.Controls.Add(txt_marca);
            panelConteudo.Controls.Add(txt_peso);
            panelConteudo.Controls.Add(txt_raca);
            panelConteudo.Controls.Add(txt_idade);
            panelConteudo.Controls.Add(txt_altura);
            panelConteudo.Controls.Add(txt_comprimento);
            panelConteudo.Controls.Add(txt_genetica);
            panelConteudo.Controls.Add(txt_numeracao);
            panelConteudo.Controls.Add(combo_sexo);
            panelConteudo.Controls.Add(label14);
            panelConteudo.Controls.Add(label12);
            panelConteudo.Controls.Add(label11);
            panelConteudo.Controls.Add(label10);
            panelConteudo.Controls.Add(label9);
            panelConteudo.Controls.Add(label8);
            panelConteudo.Controls.Add(label7);
            panelConteudo.Controls.Add(label6);
            panelConteudo.Controls.Add(label5);
            panelConteudo.Controls.Add(label4);
            panelConteudo.Controls.Add(label3);
            panelConteudo.Controls.Add(button2);
            panelConteudo.Controls.Add(btn_imagem);
            panelConteudo.Controls.Add(combo_tipos);
            panelConteudo.Controls.Add(label2);
            panelConteudo.Controls.Add(btn_cadastrar);
            panelConteudo.Dock = DockStyle.Fill;
            panelConteudo.Location = new Point(159, 46);
            panelConteudo.Margin = new Padding(4, 3, 4, 3);
            panelConteudo.Name = "panelConteudo";
            panelConteudo.Size = new Size(774, 567);
            panelConteudo.TabIndex = 2;
            // 
            // combo_coloracao
            // 
            combo_coloracao.FormattingEnabled = true;
            combo_coloracao.Location = new Point(96, 165);
            combo_coloracao.Name = "combo_coloracao";
            combo_coloracao.Size = new Size(108, 23);
            combo_coloracao.TabIndex = 44;
            combo_coloracao.SelectedIndexChanged += combo_coloracao_SelectedIndexChanged;
            // 
            // combo_registro
            // 
            combo_registro.FormattingEnabled = true;
            combo_registro.Items.AddRange(new object[] { "Sim", "Não" });
            combo_registro.Location = new Point(111, 124);
            combo_registro.Name = "combo_registro";
            combo_registro.Size = new Size(93, 23);
            combo_registro.TabIndex = 43;
            combo_registro.SelectedIndexChanged += combo_registro_SelectedIndexChanged;
            // 
            // txt_marca
            // 
            txt_marca.Location = new Point(355, 206);
            txt_marca.Name = "txt_marca";
            txt_marca.Size = new Size(136, 23);
            txt_marca.TabIndex = 42;
            // 
            // txt_peso
            // 
            txt_peso.Location = new Point(344, 169);
            txt_peso.Name = "txt_peso";
            txt_peso.Size = new Size(147, 23);
            txt_peso.TabIndex = 41;
            // 
            // txt_raca
            // 
            txt_raca.Location = new Point(344, 128);
            txt_raca.Name = "txt_raca";
            txt_raca.Size = new Size(147, 23);
            txt_raca.TabIndex = 40;
            // 
            // txt_idade
            // 
            txt_idade.Location = new Point(355, 85);
            txt_idade.Name = "txt_idade";
            txt_idade.Size = new Size(136, 23);
            txt_idade.TabIndex = 39;
            txt_idade.TextChanged += txt_idade_TextChanged;
            // 
            // txt_altura
            // 
            txt_altura.Location = new Point(355, 46);
            txt_altura.Name = "txt_altura";
            txt_altura.Size = new Size(136, 23);
            txt_altura.TabIndex = 38;
            // 
            // txt_comprimento
            // 
            txt_comprimento.Location = new Point(414, 3);
            txt_comprimento.Name = "txt_comprimento";
            txt_comprimento.Size = new Size(77, 23);
            txt_comprimento.TabIndex = 37;
            // 
            // txt_genetica
            // 
            txt_genetica.Location = new Point(96, 200);
            txt_genetica.Name = "txt_genetica";
            txt_genetica.Size = new Size(108, 23);
            txt_genetica.TabIndex = 35;
            // 
            // txt_numeracao
            // 
            txt_numeracao.Enabled = false;
            txt_numeracao.Location = new Point(116, 81);
            txt_numeracao.Name = "txt_numeracao";
            txt_numeracao.Size = new Size(88, 23);
            txt_numeracao.TabIndex = 32;
            txt_numeracao.TextChanged += txt_numeracao_TextChanged;
            // 
            // combo_sexo
            // 
            combo_sexo.FormattingEnabled = true;
            combo_sexo.Items.AddRange(new object[] { "Macho", "Femea" });
            combo_sexo.Location = new Point(56, 42);
            combo_sexo.Name = "combo_sexo";
            combo_sexo.Size = new Size(148, 23);
            combo_sexo.TabIndex = 31;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(292, 167);
            label14.Name = "label14";
            label14.Size = new Size(50, 21);
            label14.TabIndex = 30;
            label14.Text = "Peso:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(9, 200);
            label12.Name = "label12";
            label12.Size = new Size(81, 21);
            label12.TabIndex = 28;
            label12.Text = "Genética:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(292, 204);
            label11.Name = "label11";
            label11.Size = new Size(61, 21);
            label11.TabIndex = 27;
            label11.Text = "Marca:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(292, 44);
            label10.Name = "label10";
            label10.Size = new Size(61, 21);
            label10.TabIndex = 26;
            label10.Text = "Altura:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(9, 122);
            label9.Name = "label9";
            label9.Size = new Size(96, 21);
            label9.TabIndex = 25;
            label9.Text = "Registrado:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(8, 163);
            label8.Name = "label8";
            label8.Size = new Size(91, 21);
            label8.TabIndex = 24;
            label8.Text = "Coloração:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(292, 3);
            label7.Name = "label7";
            label7.Size = new Size(120, 21);
            label7.TabIndex = 23;
            label7.Text = "Comprimento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(292, 83);
            label6.Name = "label6";
            label6.Size = new Size(57, 21);
            label6.TabIndex = 22;
            label6.Text = "Idade:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(292, 126);
            label5.Name = "label5";
            label5.Size = new Size(50, 21);
            label5.TabIndex = 21;
            label5.Text = "Raça:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(7, 79);
            label4.Name = "label4";
            label4.Size = new Size(103, 21);
            label4.TabIndex = 20;
            label4.Text = "Numeração:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(8, 40);
            label3.Name = "label3";
            label3.Size = new Size(51, 21);
            label3.TabIndex = 19;
            label3.Text = "Sexo:";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.AppWorkspace;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(602, 35);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(101, 30);
            button2.TabIndex = 18;
            button2.Text = "Add Foto";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btn_imagem
            // 
            btn_imagem.Location = new Point(521, 83);
            btn_imagem.Name = "btn_imagem";
            btn_imagem.Size = new Size(250, 255);
            btn_imagem.TabIndex = 17;
            btn_imagem.UseVisualStyleBackColor = true;
            // 
            // combo_tipos
            // 
            combo_tipos.FormattingEnabled = true;
            combo_tipos.Items.AddRange(new object[] { "Bovinos", "Muares", "Equinos" });
            combo_tipos.Location = new Point(56, 1);
            combo_tipos.Name = "combo_tipos";
            combo_tipos.Size = new Size(148, 23);
            combo_tipos.TabIndex = 16;
            combo_tipos.SelectedIndexChanged += combo_animais_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(8, 3);
            label2.Name = "label2";
            label2.Size = new Size(48, 21);
            label2.TabIndex = 15;
            label2.Text = "Tipo:";
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.BackColor = SystemColors.AppWorkspace;
            btn_cadastrar.FlatAppearance.BorderSize = 0;
            btn_cadastrar.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            btn_cadastrar.FlatStyle = FlatStyle.Flat;
            btn_cadastrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cadastrar.ForeColor = Color.Black;
            btn_cadastrar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_cadastrar.Location = new Point(167, 278);
            btn_cadastrar.Margin = new Padding(4, 3, 4, 3);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(182, 60);
            btn_cadastrar.TabIndex = 14;
            btn_cadastrar.Text = "Cadastrar";
            btn_cadastrar.UseVisualStyleBackColor = false;
            btn_cadastrar.Click += btnVendas_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormCadastroRebanho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 613);
            Controls.Add(panelConteudo);
            Controls.Add(panelMenu);
            Controls.Add(panelCabecalho);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormCadastroRebanho";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panelCabecalho.ResumeLayout(false);
            panelCabecalho.PerformLayout();
            panelConteudo.ResumeLayout(false);
            panelConteudo.PerformLayout();
            ResumeLayout(false);
        }


        #region Windows Form Designer generated code
        private System.Windows.Forms.Panel panelCabecalho;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelConteudo;


        #endregion

        private Button button1;
        private Label label1;
        private Button btn_cadastrar;
        private ComboBox combo_tipos;
        private Label label2;
        public OpenFileDialog openFileDialog1;
        public Button btn_imagem;
        private Button button2;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label11;
        private Label label12;
        private Label label14;
        private TextBox txt_marca;
        private TextBox txt_peso;
        private TextBox txt_raca;
        private TextBox txt_idade;
        private TextBox txt_altura;
        private TextBox txt_comprimento;
        private TextBox txt_genetica;
        private TextBox txt_numeracao;
        private ComboBox combo_sexo;
        private ComboBox combo_registro;
        private ComboBox combo_coloracao;
    }
}