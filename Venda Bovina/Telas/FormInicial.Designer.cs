
namespace Venda_Bovina
{
    partial class FormInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicial));
            panelCabecalho = new Panel();
            btnFechar = new Button();
            btnRestaurar = new Button();
            btnMaximizar = new Button();
            panelMenu = new Panel();
            button3 = new Button();
            button2 = new Button();
            panelConteudo = new Panel();
            picture_fotoUsuario = new PictureBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            label3 = new Label();
            lbl_nomeUsuario = new Label();
            label1 = new Label();
            label2 = new Label();
            panelCabecalho.SuspendLayout();
            panelMenu.SuspendLayout();
            panelConteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture_fotoUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelCabecalho
            // 
            panelCabecalho.BackColor = Color.Goldenrod;
            panelCabecalho.Controls.Add(label2);
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
            panelMenu.Controls.Add(button3);
            panelMenu.Controls.Add(button2);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 46);
            panelMenu.Margin = new Padding(4, 3, 4, 3);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(199, 567);
            panelMenu.TabIndex = 1;
            // 
            // button3
            // 
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Transparent;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(7, 148);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(184, 45);
            button3.TabIndex = 3;
            button3.Text = "Cadastrar Rebanho";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Transparent;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(7, 199);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(184, 45);
            button2.TabIndex = 2;
            button2.Text = "Meu Rebanho";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panelConteudo
            // 
            panelConteudo.Controls.Add(picture_fotoUsuario);
            panelConteudo.Controls.Add(dataGridView1);
            panelConteudo.Controls.Add(label3);
            panelConteudo.Controls.Add(lbl_nomeUsuario);
            panelConteudo.Controls.Add(label1);
            panelConteudo.Dock = DockStyle.Fill;
            panelConteudo.Location = new Point(199, 46);
            panelConteudo.Margin = new Padding(4, 3, 4, 3);
            panelConteudo.Name = "panelConteudo";
            panelConteudo.Size = new Size(734, 567);
            panelConteudo.TabIndex = 2;
            // 
            // picture_fotoUsuario
            // 
            picture_fotoUsuario.Location = new Point(599, 0);
            picture_fotoUsuario.Name = "picture_fotoUsuario";
            picture_fotoUsuario.Size = new Size(135, 119);
            picture_fotoUsuario.TabIndex = 5;
            picture_fotoUsuario.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridView1.Location = new Point(0, 503);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(734, 64);
            dataGridView1.TabIndex = 4;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nome";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "CPF";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Idade";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "CNPJ";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Alqueires";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Cabeças";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Marca";
            Column7.Name = "Column7";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(0, 479);
            label3.Name = "label3";
            label3.Size = new Size(107, 21);
            label3.TabIndex = 3;
            label3.Text = "Meus Dados:";
            // 
            // lbl_nomeUsuario
            // 
            lbl_nomeUsuario.AutoSize = true;
            lbl_nomeUsuario.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nomeUsuario.Location = new Point(254, 3);
            lbl_nomeUsuario.Name = "lbl_nomeUsuario";
            lbl_nomeUsuario.Size = new Size(92, 45);
            lbl_nomeUsuario.TabIndex = 1;
            lbl_nomeUsuario.Text = "label";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(7, 3);
            label1.Name = "label1";
            label1.Size = new Size(250, 45);
            label1.TabIndex = 0;
            label1.Text = "Seja bem vindo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(128, 64, 0);
            label2.Location = new Point(19, 9);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(102, 30);
            label2.TabIndex = 3;
            label2.Text = "TecnoBoi";
            // 
            // FormInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 613);
            Controls.Add(panelConteudo);
            Controls.Add(panelMenu);
            Controls.Add(panelCabecalho);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panelCabecalho.ResumeLayout(false);
            panelCabecalho.PerformLayout();
            panelMenu.ResumeLayout(false);
            panelConteudo.ResumeLayout(false);
            panelConteudo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picture_fotoUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Label lbl_nomeUsuario;
        private Label label1;
        private Button button2;
        private Button button3;
        private Label label3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private PictureBox picture_fotoUsuario;
        private Label label2;
    }
}