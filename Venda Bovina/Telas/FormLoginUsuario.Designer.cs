
namespace Venda_Bovina
{
    partial class FormLoginUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoginUsuario));
            panelCabecalho = new Panel();
            label1 = new Label();
            button1 = new Button();
            btnFechar = new Button();
            btnRestaurar = new Button();
            btnMaximizar = new Button();
            panelMenu = new Panel();
            txt_aviso = new Label();
            panelConteudo = new Panel();
            button2 = new Button();
            label3 = new Label();
            txt_senha = new TextBox();
            label2 = new Label();
            btnVendas = new Button();
            txt_cpf = new MaskedTextBox();
            label4 = new Label();
            openFileDialog1 = new OpenFileDialog();
            panelCabecalho.SuspendLayout();
            panelMenu.SuspendLayout();
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
            label1.Size = new Size(150, 30);
            label1.TabIndex = 2;
            label1.Text = "Login Usuario";
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
            panelMenu.Controls.Add(txt_aviso);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 46);
            panelMenu.Margin = new Padding(4, 3, 4, 3);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(159, 567);
            panelMenu.TabIndex = 1;
            // 
            // txt_aviso
            // 
            txt_aviso.AutoSize = true;
            txt_aviso.ForeColor = Color.Red;
            txt_aviso.Location = new Point(12, 16);
            txt_aviso.Name = "txt_aviso";
            txt_aviso.Size = new Size(38, 15);
            txt_aviso.TabIndex = 25;
            txt_aviso.Text = "label5";
            // 
            // panelConteudo
            // 
            panelConteudo.Controls.Add(button2);
            panelConteudo.Controls.Add(label3);
            panelConteudo.Controls.Add(txt_senha);
            panelConteudo.Controls.Add(label2);
            panelConteudo.Controls.Add(btnVendas);
            panelConteudo.Controls.Add(txt_cpf);
            panelConteudo.Controls.Add(label4);
            panelConteudo.Dock = DockStyle.Fill;
            panelConteudo.Location = new Point(159, 46);
            panelConteudo.Margin = new Padding(4, 3, 4, 3);
            panelConteudo.Name = "panelConteudo";
            panelConteudo.Size = new Size(774, 567);
            panelConteudo.TabIndex = 2;
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
            button2.Location = new Point(391, 522);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(152, 45);
            button2.TabIndex = 24;
            button2.Text = "Cadastrar-se";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(0, 537);
            label3.Name = "label3";
            label3.Size = new Size(383, 21);
            label3.TabIndex = 23;
            label3.Text = "Não possui conta? Cadastre-se  no botão ao lado:";
            // 
            // txt_senha
            // 
            txt_senha.Location = new Point(299, 64);
            txt_senha.Name = "txt_senha";
            txt_senha.Size = new Size(116, 23);
            txt_senha.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(237, 66);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 21;
            label2.Text = "Senha:";
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
            btnVendas.Location = new Point(263, 141);
            btnVendas.Margin = new Padding(4, 3, 4, 3);
            btnVendas.Name = "btnVendas";
            btnVendas.Size = new Size(152, 45);
            btnVendas.TabIndex = 14;
            btnVendas.Text = "Login";
            btnVendas.UseVisualStyleBackColor = false;
            btnVendas.Click += btnVendas_Click;
            // 
            // txt_cpf
            // 
            txt_cpf.Location = new Point(299, 30);
            txt_cpf.Mask = "000,000,000-00";
            txt_cpf.Name = "txt_cpf";
            txt_cpf.Size = new Size(116, 23);
            txt_cpf.TabIndex = 10;
            txt_cpf.MaskInputRejected += txt_cpf_MaskInputRejected;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(237, 30);
            label4.Name = "label4";
            label4.Size = new Size(51, 25);
            label4.TabIndex = 2;
            label4.Text = "CPF:";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormLoginUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 613);
            Controls.Add(panelConteudo);
            Controls.Add(panelMenu);
            Controls.Add(panelCabecalho);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormLoginUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panelCabecalho.ResumeLayout(false);
            panelCabecalho.PerformLayout();
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
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
        private Label label4;
        private MaskedTextBox txt_cpf;
        private Button btnVendas;
        private OpenFileDialog openFileDialog1;
        private TextBox txt_senha;
        private Label label2;
        private Button button2;
        private Label label3;
        private Label txt_aviso;
    }
}