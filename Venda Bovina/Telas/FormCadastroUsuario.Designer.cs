
namespace Venda_Bovina
{
    partial class FormCadastroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroUsuario));
            panelCabecalho = new Panel();
            label1 = new Label();
            button1 = new Button();
            btnFechar = new Button();
            btnRestaurar = new Button();
            btnMaximizar = new Button();
            panelMenu = new Panel();
            panelConteudo = new Panel();
            button3 = new Button();
            label9 = new Label();
            img_cnpj = new PictureBox();
            img_cpf = new PictureBox();
            button2 = new Button();
            btn_fotoUsuario = new Button();
            btnVendas = new Button();
            txt_quantidadeCabecas = new TextBox();
            txt_cnpj = new MaskedTextBox();
            txt_idade = new TextBox();
            txt_cpf = new MaskedTextBox();
            txt_marca = new TextBox();
            txt_areaTerreno = new TextBox();
            txt_nome = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            openFileDialog1 = new OpenFileDialog();
            label10 = new Label();
            txt_senha = new TextBox();
            panelCabecalho.SuspendLayout();
            panelConteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)img_cnpj).BeginInit();
            ((System.ComponentModel.ISupportInitialize)img_cpf).BeginInit();
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
            label1.Size = new Size(180, 30);
            label1.TabIndex = 2;
            label1.Text = "Cadastro Usuario";
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
            panelConteudo.Controls.Add(txt_senha);
            panelConteudo.Controls.Add(label10);
            panelConteudo.Controls.Add(button3);
            panelConteudo.Controls.Add(label9);
            panelConteudo.Controls.Add(img_cnpj);
            panelConteudo.Controls.Add(img_cpf);
            panelConteudo.Controls.Add(button2);
            panelConteudo.Controls.Add(btn_fotoUsuario);
            panelConteudo.Controls.Add(btnVendas);
            panelConteudo.Controls.Add(txt_quantidadeCabecas);
            panelConteudo.Controls.Add(txt_cnpj);
            panelConteudo.Controls.Add(txt_idade);
            panelConteudo.Controls.Add(txt_cpf);
            panelConteudo.Controls.Add(txt_marca);
            panelConteudo.Controls.Add(txt_areaTerreno);
            panelConteudo.Controls.Add(txt_nome);
            panelConteudo.Controls.Add(label8);
            panelConteudo.Controls.Add(label7);
            panelConteudo.Controls.Add(label6);
            panelConteudo.Controls.Add(label5);
            panelConteudo.Controls.Add(label4);
            panelConteudo.Controls.Add(label3);
            panelConteudo.Controls.Add(label2);
            panelConteudo.Dock = DockStyle.Fill;
            panelConteudo.Location = new Point(159, 46);
            panelConteudo.Margin = new Padding(4, 3, 4, 3);
            panelConteudo.Name = "panelConteudo";
            panelConteudo.Size = new Size(774, 567);
            panelConteudo.TabIndex = 2;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.AppWorkspace;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Black;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(364, 534);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(125, 30);
            button3.TabIndex = 23;
            button3.Text = "Logar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(0, 537);
            label9.Name = "label9";
            label9.Size = new Size(357, 21);
            label9.TabIndex = 22;
            label9.Text = "Ja possui conta?, Faça login no botão ao lado:";
            // 
            // img_cnpj
            // 
            img_cnpj.Location = new Point(224, 144);
            img_cnpj.Name = "img_cnpj";
            img_cnpj.Size = new Size(24, 23);
            img_cnpj.TabIndex = 21;
            img_cnpj.TabStop = false;
            // 
            // img_cpf
            // 
            img_cpf.BackgroundImageLayout = ImageLayout.Stretch;
            img_cpf.Image = (Image)resources.GetObject("img_cpf.Image");
            img_cpf.Location = new Point(153, 100);
            img_cpf.Name = "img_cpf";
            img_cpf.Size = new Size(24, 23);
            img_cpf.TabIndex = 20;
            img_cpf.TabStop = false;
            img_cpf.Click += img_cpf_Click;
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
            button2.Location = new Point(478, 43);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(101, 30);
            button2.TabIndex = 19;
            button2.Text = "Add Foto";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btn_fotoUsuario
            // 
            btn_fotoUsuario.Location = new Point(397, 79);
            btn_fotoUsuario.Name = "btn_fotoUsuario";
            btn_fotoUsuario.Size = new Size(267, 230);
            btn_fotoUsuario.TabIndex = 15;
            btn_fotoUsuario.UseVisualStyleBackColor = true;
            // 
            // btnVendas
            // 
            btnVendas.BackColor = SystemColors.AppWorkspace;
            btnVendas.FlatAppearance.BorderSize = 0;
            btnVendas.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            btnVendas.FlatStyle = FlatStyle.Flat;
            btnVendas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVendas.ForeColor = Color.Black;
            btnVendas.ImageAlign = ContentAlignment.MiddleLeft;
            btnVendas.Location = new Point(244, 365);
            btnVendas.Margin = new Padding(4, 3, 4, 3);
            btnVendas.Name = "btnVendas";
            btnVendas.Size = new Size(152, 45);
            btnVendas.TabIndex = 14;
            btnVendas.Text = "Cadastrar";
            btnVendas.UseVisualStyleBackColor = false;
            btnVendas.Click += btnVendas_Click;
            // 
            // txt_quantidadeCabecas
            // 
            txt_quantidadeCabecas.Location = new Point(214, 239);
            txt_quantidadeCabecas.Name = "txt_quantidadeCabecas";
            txt_quantidadeCabecas.Size = new Size(56, 23);
            txt_quantidadeCabecas.TabIndex = 13;
            txt_quantidadeCabecas.TextChanged += txt_quantidadeCabecas_TextChanged;
            // 
            // txt_cnpj
            // 
            txt_cnpj.Location = new Point(76, 144);
            txt_cnpj.Mask = "00,000,000/0001-00";
            txt_cnpj.Name = "txt_cnpj";
            txt_cnpj.Size = new Size(142, 23);
            txt_cnpj.TabIndex = 12;
            txt_cnpj.MaskInputRejected += txt_cnpj_MaskInputRejected;
            // 
            // txt_idade
            // 
            txt_idade.Location = new Point(76, 194);
            txt_idade.Name = "txt_idade";
            txt_idade.Size = new Size(101, 23);
            txt_idade.TabIndex = 11;
            txt_idade.TextChanged += txt_idade_TextChanged;
            // 
            // txt_cpf
            // 
            txt_cpf.Location = new Point(61, 100);
            txt_cpf.Mask = "000,000,000-00";
            txt_cpf.Name = "txt_cpf";
            txt_cpf.Size = new Size(86, 23);
            txt_cpf.TabIndex = 10;
            txt_cpf.MaskInputRejected += txt_cpf_MaskInputRejected;
            // 
            // txt_marca
            // 
            txt_marca.Enabled = false;
            txt_marca.Location = new Point(128, 331);
            txt_marca.Name = "txt_marca";
            txt_marca.Size = new Size(63, 23);
            txt_marca.TabIndex = 9;
            txt_marca.TextChanged += txt_marca_TextChanged;
            // 
            // txt_areaTerreno
            // 
            txt_areaTerreno.Location = new Point(241, 290);
            txt_areaTerreno.Name = "txt_areaTerreno";
            txt_areaTerreno.Size = new Size(109, 23);
            txt_areaTerreno.TabIndex = 8;
            txt_areaTerreno.TextChanged += txt_areaTerreno_TextChanged;
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(153, 10);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(187, 23);
            txt_nome.TabIndex = 7;
            txt_nome.TextChanged += txt_nome_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(17, 329);
            label8.Name = "label8";
            label8.Size = new Size(105, 21);
            label8.TabIndex = 6;
            label8.Text = "Marca Gado:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(17, 237);
            label7.Name = "label7";
            label7.Size = new Size(191, 21);
            label7.TabIndex = 5;
            label7.Text = "Quantidade de cabeças:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(17, 288);
            label6.Name = "label6";
            label6.Size = new Size(224, 21);
            label6.TabIndex = 4;
            label6.Text = "Area De Terreno (Alqueires):";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(17, 144);
            label5.Name = "label5";
            label5.Size = new Size(53, 21);
            label5.TabIndex = 3;
            label5.Text = "CNPJ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(17, 98);
            label4.Name = "label4";
            label4.Size = new Size(42, 21);
            label4.TabIndex = 2;
            label4.Text = "CPF:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(17, 192);
            label3.Name = "label3";
            label3.Size = new Size(57, 21);
            label3.TabIndex = 1;
            label3.Text = "Idade:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(7, 12);
            label2.Name = "label2";
            label2.Size = new Size(140, 21);
            label2.TabIndex = 0;
            label2.Text = "Nome Completo:";
            label2.Click += label2_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(7, 52);
            label10.Name = "label10";
            label10.Size = new Size(61, 21);
            label10.TabIndex = 24;
            label10.Text = "Senha:";
            label10.Click += label10_Click;
            // 
            // txt_senha
            // 
            txt_senha.Location = new Point(74, 54);
            txt_senha.Name = "txt_senha";
            txt_senha.Size = new Size(144, 23);
            txt_senha.TabIndex = 25;
            // 
            // FormCadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 613);
            Controls.Add(panelConteudo);
            Controls.Add(panelMenu);
            Controls.Add(panelCabecalho);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormCadastroUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panelCabecalho.ResumeLayout(false);
            panelCabecalho.PerformLayout();
            panelConteudo.ResumeLayout(false);
            panelConteudo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)img_cnpj).EndInit();
            ((System.ComponentModel.ISupportInitialize)img_cpf).EndInit();
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
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txt_quantidadeCabecas;
        private MaskedTextBox txt_cnpj;
        private TextBox txt_idade;
        private MaskedTextBox txt_cpf;
        private TextBox txt_marca;
        private TextBox txt_areaTerreno;
        private TextBox txt_nome;
        private Label label8;
        private Label label7;
        private Button btnVendas;
        private Button btn_fotoUsuario;
        private Button button2;
        private OpenFileDialog openFileDialog1;
        private PictureBox img_cnpj;
        private PictureBox img_cpf;
        private Button button3;
        private Label label9;
        private Label label10;
        private TextBox txt_senha;
    }
}