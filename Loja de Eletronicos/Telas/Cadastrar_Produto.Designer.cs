namespace Loja_de_Eletronicos
{
    partial class Cadastrar_Produto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastrar_Produto));
            but_salvar = new Button();
            label1 = new Label();
            box_valor = new TextBox();
            label2 = new Label();
            box_nome = new TextBox();
            label3 = new Label();
            label4 = new Label();
            box_id = new TextBox();
            box_df = new MaskedTextBox();
            tx_qtd = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            button1 = new Button();
            label11 = new Label();
            label12 = new Label();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // but_salvar
            // 
            but_salvar.BackColor = Color.LightGreen;
            but_salvar.FlatStyle = FlatStyle.Popup;
            but_salvar.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            but_salvar.ForeColor = SystemColors.ActiveCaptionText;
            but_salvar.Location = new Point(140, 405);
            but_salvar.Margin = new Padding(4);
            but_salvar.Name = "but_salvar";
            but_salvar.Size = new Size(181, 56);
            but_salvar.TabIndex = 0;
            but_salvar.Text = "Salvar";
            but_salvar.UseVisualStyleBackColor = false;
            but_salvar.Click += but_salvar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(59, 149);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 38);
            label1.TabIndex = 1;
            // 
            // box_valor
            // 
            box_valor.BackColor = SystemColors.InactiveCaption;
            box_valor.BorderStyle = BorderStyle.FixedSingle;
            box_valor.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            box_valor.Location = new Point(194, 341);
            box_valor.Margin = new Padding(4);
            box_valor.Name = "box_valor";
            box_valor.Size = new Size(351, 31);
            box_valor.TabIndex = 4;
            box_valor.TextChanged += box_valor_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(59, 255);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 38);
            label2.TabIndex = 3;
            // 
            // box_nome
            // 
            box_nome.BackColor = SystemColors.InactiveCaption;
            box_nome.BorderStyle = BorderStyle.FixedSingle;
            box_nome.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            box_nome.Location = new Point(226, 283);
            box_nome.Margin = new Padding(4);
            box_nome.Name = "box_nome";
            box_nome.Size = new Size(319, 31);
            box_nome.TabIndex = 6;
            box_nome.TextChanged += box_nome_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(59, 201);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 38);
            label3.TabIndex = 5;
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(278, 259);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 38);
            label4.TabIndex = 7;
            // 
            // box_id
            // 
            box_id.BackColor = SystemColors.InactiveCaption;
            box_id.BorderStyle = BorderStyle.FixedSingle;
            box_id.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            box_id.Location = new Point(154, 171);
            box_id.Margin = new Padding(4);
            box_id.Name = "box_id";
            box_id.Size = new Size(206, 31);
            box_id.TabIndex = 2;
            box_id.TextChanged += box_id_TextChanged;
            // 
            // box_df
            // 
            box_df.BackColor = SystemColors.InactiveCaption;
            box_df.BorderStyle = BorderStyle.FixedSingle;
            box_df.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            box_df.Location = new Point(457, 173);
            box_df.Margin = new Padding(4);
            box_df.Mask = "00/00/0000";
            box_df.Name = "box_df";
            box_df.Size = new Size(88, 31);
            box_df.TabIndex = 9;
            box_df.ValidatingType = typeof(DateTime);
            box_df.MaskInputRejected += box_df_MaskInputRejected;
            // 
            // tx_qtd
            // 
            tx_qtd.BackColor = SystemColors.InactiveCaption;
            tx_qtd.BorderStyle = BorderStyle.FixedSingle;
            tx_qtd.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tx_qtd.Location = new Point(275, 227);
            tx_qtd.Margin = new Padding(4);
            tx_qtd.Name = "tx_qtd";
            tx_qtd.Size = new Size(270, 31);
            tx_qtd.TabIndex = 11;
            tx_qtd.TextChanged += tx_qtd_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(194, 152);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(0, 38);
            label5.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.LightSteelBlue;
            label6.Location = new Point(99, 341);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(95, 29);
            label6.TabIndex = 13;
            label6.Text = "Valor:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.LightSteelBlue;
            label7.Location = new Point(99, 283);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(129, 29);
            label7.TabIndex = 14;
            label7.Text = "Produto:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.LightSteelBlue;
            label8.Location = new Point(99, 227);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(168, 29);
            label8.TabIndex = 15;
            label8.Text = "Quantidade:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.LightSteelBlue;
            label9.Location = new Point(99, 173);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(47, 29);
            label9.TabIndex = 16;
            label9.Text = "Id:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.LightSteelBlue;
            label10.Location = new Point(368, 172);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(81, 29);
            label10.TabIndex = 17;
            label10.Text = "Data:";
            // 
            // button1
            // 
            button1.BackColor = Color.LightCoral;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(364, 404);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(181, 56);
            button1.TabIndex = 18;
            button1.Text = "Cancelar\r\n";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(345, 152);
            label11.Name = "label11";
            label11.Size = new Size(0, 25);
            label11.TabIndex = 19;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.LightSteelBlue;
            label12.Location = new Point(125, 90);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(391, 43);
            label12.TabIndex = 20;
            label12.Text = "CADASTRAR PRODUTO";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.AppWorkspace;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(140, 486);
            button2.Name = "button2";
            button2.Size = new Size(181, 56);
            button2.TabIndex = 21;
            button2.Text = "menu";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.AntiqueWhite;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(410, 492);
            button3.Name = "button3";
            button3.Size = new Size(135, 44);
            button3.TabIndex = 22;
            button3.Text = "sair";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Cadastrar_Produto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(647, 602);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(tx_qtd);
            Controls.Add(label5);
            Controls.Add(box_df);
            Controls.Add(label4);
            Controls.Add(box_nome);
            Controls.Add(label3);
            Controls.Add(box_valor);
            Controls.Add(label2);
            Controls.Add(box_id);
            Controls.Add(label1);
            Controls.Add(but_salvar);
            Margin = new Padding(4);
            Name = "Cadastrar_Produto";
            Text = "Cadastrar_Produto";
            Load += Cadastrar_Produto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button but_salvar;
        private Label label1;
        private TextBox box_valor;
        private Label label2;
        private TextBox box_nome;
        private Label label3;
        private Label label4;
        private TextBox box_id;
        private MaskedTextBox box_df;
        private TextBox tx_qtd;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button button1;
        private Label label11;
        private Label label12;
        private Button button2;
        private Button button3;
    }
}