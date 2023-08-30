namespace Loja_de_Eletronicos
{
    partial class Form2_RealizarVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2_RealizarVenda));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txt_id = new TextBox();
            txt_valor = new TextBox();
            txt_lucro = new TextBox();
            txt_venda = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            box_nome = new ComboBox();
            txt_qtd = new TextBox();
            label7 = new Label();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.LightSteelBlue;
            label1.Location = new Point(97, 160);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(85, 29);
            label1.TabIndex = 0;
            label1.Text = "NOME:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.LightSteelBlue;
            label2.Location = new Point(97, 210);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(47, 29);
            label2.TabIndex = 1;
            label2.Text = "ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.LightSteelBlue;
            label3.Location = new Point(97, 303);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(95, 29);
            label3.TabIndex = 2;
            label3.Text = "VALOR:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.LightSteelBlue;
            label4.Location = new Point(97, 349);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(306, 29);
            label4.TabIndex = 3;
            label4.Text = "PORCENTAGEM DE LUCRO:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.LightSteelBlue;
            label5.Location = new Point(97, 393);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(213, 29);
            label5.TabIndex = 4;
            label5.Text = "VALOR DA VENDA:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.LightSteelBlue;
            label6.Location = new Point(186, 88);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(307, 43);
            label6.TabIndex = 5;
            label6.Text = "REALIZAR VENDA";
            label6.Click += label6_Click_1;
            // 
            // txt_id
            // 
            txt_id.BackColor = SystemColors.InactiveCaption;
            txt_id.BorderStyle = BorderStyle.FixedSingle;
            txt_id.Enabled = false;
            txt_id.Location = new Point(148, 208);
            txt_id.Margin = new Padding(2);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(396, 31);
            txt_id.TabIndex = 6;
            txt_id.TextChanged += txt_nome_TextChanged;
            // 
            // txt_valor
            // 
            txt_valor.BackColor = SystemColors.InactiveCaption;
            txt_valor.BorderStyle = BorderStyle.FixedSingle;
            txt_valor.Enabled = false;
            txt_valor.Location = new Point(196, 303);
            txt_valor.Margin = new Padding(2);
            txt_valor.Name = "txt_valor";
            txt_valor.Size = new Size(348, 31);
            txt_valor.TabIndex = 8;
            txt_valor.TextChanged += txt_valor_TextChanged;
            // 
            // txt_lucro
            // 
            txt_lucro.BackColor = SystemColors.InactiveCaption;
            txt_lucro.BorderStyle = BorderStyle.FixedSingle;
            txt_lucro.Location = new Point(407, 347);
            txt_lucro.Margin = new Padding(2);
            txt_lucro.Name = "txt_lucro";
            txt_lucro.Size = new Size(137, 31);
            txt_lucro.TabIndex = 9;
            txt_lucro.TextChanged += txt_lucro_TextChanged;
            // 
            // txt_venda
            // 
            txt_venda.BackColor = SystemColors.InactiveCaption;
            txt_venda.BorderStyle = BorderStyle.FixedSingle;
            txt_venda.Enabled = false;
            txt_venda.Location = new Point(314, 391);
            txt_venda.Margin = new Padding(2);
            txt_venda.Name = "txt_venda";
            txt_venda.Size = new Size(230, 31);
            txt_venda.TabIndex = 10;
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = Color.LightGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(128, 438);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(114, 51);
            button1.TabIndex = 11;
            button1.Text = "VENDER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button2.BackColor = Color.LightCoral;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(262, 438);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(141, 51);
            button2.TabIndex = 12;
            button2.Text = "CANCELAR";
            button2.TextAlign = ContentAlignment.TopCenter;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button3.BackColor = SystemColors.AppWorkspace;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(430, 438);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(114, 51);
            button3.TabIndex = 13;
            button3.Text = "MENU";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // box_nome
            // 
            box_nome.BackColor = SystemColors.InactiveCaption;
            box_nome.FormattingEnabled = true;
            box_nome.Location = new Point(186, 159);
            box_nome.Margin = new Padding(4);
            box_nome.Name = "box_nome";
            box_nome.Size = new Size(358, 33);
            box_nome.TabIndex = 14;
            box_nome.SelectedIndexChanged += combo_id_SelectedIndexChanged;
            // 
            // txt_qtd
            // 
            txt_qtd.BackColor = SystemColors.InactiveCaption;
            txt_qtd.BorderStyle = BorderStyle.FixedSingle;
            txt_qtd.Location = new Point(266, 257);
            txt_qtd.Margin = new Padding(2);
            txt_qtd.Name = "txt_qtd";
            txt_qtd.Size = new Size(278, 31);
            txt_qtd.TabIndex = 16;
            txt_qtd.TextChanged += txt_qtd_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.LightSteelBlue;
            label7.Location = new Point(97, 257);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(165, 29);
            label7.TabIndex = 15;
            label7.Text = "Qualtidade:";
            label7.Click += label7_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.AntiqueWhite;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(432, 506);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 17;
            button4.Text = "sair";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Form2_RealizarVenda
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(642, 611);
            Controls.Add(button4);
            Controls.Add(txt_qtd);
            Controls.Add(label7);
            Controls.Add(box_nome);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txt_venda);
            Controls.Add(txt_lucro);
            Controls.Add(txt_valor);
            Controls.Add(txt_id);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Form2_RealizarVenda";
            Text = "Form2_cadastroProduto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_id;
        private TextBox txt_valor;
        private TextBox txt_lucro;
        private TextBox txt_venda;
        private Button button1;
        private Button button2;
        private Button button3;
        private ComboBox box_nome;
        private TextBox txt_qtd;
        private Label label7;
        private Button button4;
    }
}