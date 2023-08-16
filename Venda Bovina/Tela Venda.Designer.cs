namespace Venda_Bovina
{
    partial class Tela_Venda
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_fotoBoi = new Button();
            lbl_nomeBoi = new Label();
            lbl_precoBoi = new Label();
            btn_comprar = new Button();
            label3 = new Label();
            lbl_detalhesBoi = new Label();
            label6 = new Label();
            label5 = new Label();
            lbl_localBoi = new Label();
            lbl_vendedorBoi = new Label();
            btn_voltar = new Button();
            SuspendLayout();
            // 
            // btn_fotoBoi
            // 
            btn_fotoBoi.Location = new Point(8, 124);
            btn_fotoBoi.Name = "btn_fotoBoi";
            btn_fotoBoi.Size = new Size(309, 209);
            btn_fotoBoi.TabIndex = 0;
            btn_fotoBoi.Text = "button1";
            btn_fotoBoi.UseVisualStyleBackColor = true;
            // 
            // lbl_nomeBoi
            // 
            lbl_nomeBoi.AutoSize = true;
            lbl_nomeBoi.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_nomeBoi.Location = new Point(8, 68);
            lbl_nomeBoi.Name = "lbl_nomeBoi";
            lbl_nomeBoi.Size = new Size(45, 19);
            lbl_nomeBoi.TabIndex = 1;
            lbl_nomeBoi.Text = "label1";
            // 
            // lbl_precoBoi
            // 
            lbl_precoBoi.AutoSize = true;
            lbl_precoBoi.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_precoBoi.Location = new Point(367, 136);
            lbl_precoBoi.Name = "lbl_precoBoi";
            lbl_precoBoi.Size = new Size(45, 19);
            lbl_precoBoi.TabIndex = 2;
            lbl_precoBoi.Text = "label2";
            // 
            // btn_comprar
            // 
            btn_comprar.Location = new Point(367, 273);
            btn_comprar.Name = "btn_comprar";
            btn_comprar.Size = new Size(123, 45);
            btn_comprar.TabIndex = 3;
            btn_comprar.Text = "Comprar";
            btn_comprar.UseVisualStyleBackColor = true;
            btn_comprar.Click += btn_comprar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(666, 23);
            label3.Name = "label3";
            label3.Size = new Size(64, 19);
            label3.TabIndex = 4;
            label3.Text = "Detalhes:";
            // 
            // lbl_detalhesBoi
            // 
            lbl_detalhesBoi.AutoSize = true;
            lbl_detalhesBoi.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_detalhesBoi.Location = new Point(666, 68);
            lbl_detalhesBoi.Name = "lbl_detalhesBoi";
            lbl_detalhesBoi.Size = new Size(45, 19);
            lbl_detalhesBoi.TabIndex = 5;
            lbl_detalhesBoi.Text = "label4";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 379);
            label6.Name = "label6";
            label6.Size = new Size(46, 19);
            label6.TabIndex = 7;
            label6.Text = "Local:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 410);
            label5.Name = "label5";
            label5.Size = new Size(71, 19);
            label5.TabIndex = 8;
            label5.Text = "Vendedor:";
            // 
            // lbl_localBoi
            // 
            lbl_localBoi.AutoSize = true;
            lbl_localBoi.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_localBoi.Location = new Point(64, 379);
            lbl_localBoi.Name = "lbl_localBoi";
            lbl_localBoi.Size = new Size(45, 19);
            lbl_localBoi.TabIndex = 9;
            lbl_localBoi.Text = "label2";
            // 
            // lbl_vendedorBoi
            // 
            lbl_vendedorBoi.AutoSize = true;
            lbl_vendedorBoi.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_vendedorBoi.Location = new Point(89, 410);
            lbl_vendedorBoi.Name = "lbl_vendedorBoi";
            lbl_vendedorBoi.Size = new Size(45, 19);
            lbl_vendedorBoi.TabIndex = 10;
            lbl_vendedorBoi.Text = "label2";
            // 
            // btn_voltar
            // 
            btn_voltar.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_voltar.Location = new Point(8, 1);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(50, 25);
            btn_voltar.TabIndex = 11;
            btn_voltar.Text = "<";
            btn_voltar.UseVisualStyleBackColor = true;
            btn_voltar.Click += button1_Click;
            // 
            // Tela_Venda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_voltar);
            Controls.Add(lbl_vendedorBoi);
            Controls.Add(lbl_localBoi);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(lbl_detalhesBoi);
            Controls.Add(label3);
            Controls.Add(btn_comprar);
            Controls.Add(lbl_precoBoi);
            Controls.Add(lbl_nomeBoi);
            Controls.Add(btn_fotoBoi);
            Name = "Tela_Venda";
            Text = "Tela_Venda";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_fotoBoi;
        private Label lbl_nomeBoi;
        private Label lbl_precoBoi;
        private Button btn_comprar;
        private Label label3;
        private Label lbl_detalhesBoi;
        private Label label6;
        private Label label5;
        private Label lbl_localBoi;
        private Label lbl_vendedorBoi;
        private Button btn_voltar;
    }
}