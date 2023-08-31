
namespace Venda_Bovina
{
    partial class FormRebanho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRebanho));
            panelCabecalho = new Panel();
            label1 = new Label();
            button1 = new Button();
            btnFechar = new Button();
            btnRestaurar = new Button();
            btnMaximizar = new Button();
            panelMenu = new Panel();
            btn_foto = new Button();
            panelConteudo = new Panel();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewTextBoxColumn();
            panelCabecalho.SuspendLayout();
            panelMenu.SuspendLayout();
            panelConteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            label1.Text = "Meu Rebanho";
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
            panelMenu.Controls.Add(btn_foto);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 46);
            panelMenu.Margin = new Padding(4, 3, 4, 3);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(286, 567);
            panelMenu.TabIndex = 1;
            // 
            // btn_foto
            // 
            btn_foto.Location = new Point(12, 6);
            btn_foto.Name = "btn_foto";
            btn_foto.Size = new Size(267, 230);
            btn_foto.TabIndex = 0;
            btn_foto.UseVisualStyleBackColor = true;
            // 
            // panelConteudo
            // 
            panelConteudo.Controls.Add(button2);
            panelConteudo.Controls.Add(button3);
            panelConteudo.Controls.Add(dataGridView1);
            panelConteudo.Dock = DockStyle.Fill;
            panelConteudo.Location = new Point(286, 46);
            panelConteudo.Margin = new Padding(4, 3, 4, 3);
            panelConteudo.Name = "panelConteudo";
            panelConteudo.Size = new Size(647, 567);
            panelConteudo.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.Gray;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(460, 510);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(184, 45);
            button2.TabIndex = 5;
            button2.Text = "Excluir";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Gray;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Black;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(4, 510);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(184, 45);
            button3.TabIndex = 4;
            button3.Text = "Selecionar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column4, Column3, Column5, Column6, Column7, Column8, Column9, Column10, Column11, Column12, Column13 });
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(774, 443);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Animal";
            Column1.Name = "Column1";
            // 
            // Column4
            // 
            Column4.HeaderText = "Numeração";
            Column4.Name = "Column4";
            // 
            // Column3
            // 
            Column3.HeaderText = "Raça";
            Column3.Name = "Column3";
            // 
            // Column5
            // 
            Column5.HeaderText = "Idade (Meses)";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Comprimento";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Coloração";
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.HeaderText = "Registro";
            Column8.Name = "Column8";
            // 
            // Column9
            // 
            Column9.HeaderText = "Altura";
            Column9.Name = "Column9";
            // 
            // Column10
            // 
            Column10.HeaderText = "Marca";
            Column10.Name = "Column10";
            // 
            // Column11
            // 
            Column11.HeaderText = "Genética";
            Column11.Name = "Column11";
            // 
            // Column12
            // 
            Column12.HeaderText = "Preço";
            Column12.Name = "Column12";
            // 
            // Column13
            // 
            Column13.HeaderText = "Peso";
            Column13.Name = "Column13";
            // 
            // FormRebanho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 613);
            Controls.Add(panelConteudo);
            Controls.Add(panelMenu);
            Controls.Add(panelCabecalho);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormRebanho";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panelCabecalho.ResumeLayout(false);
            panelCabecalho.PerformLayout();
            panelMenu.ResumeLayout(false);
            panelConteudo.ResumeLayout(false);
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

        private Button button1;
        private Label label1;
        public DataGridView dataGridView1;
        private Button btn_foto;
        private Button button3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private Button button2;
    }
}