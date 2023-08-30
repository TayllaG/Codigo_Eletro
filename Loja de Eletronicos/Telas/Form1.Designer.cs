namespace Loja_de_Eletronicos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Elephant", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.LightSteelBlue;
            label1.Location = new Point(168, 116);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(340, 46);
            label1.TabIndex = 4;
            label1.Text = "Loja de Etrônicos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Elephant", 9.999999F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.LightSteelBlue;
            label2.Location = new Point(283, 90);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 26);
            label2.TabIndex = 5;
            label2.Text = "MENU";
            label2.Click += label2_Click;
            // 
            // button4
            // 
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Stencil", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.LightSteelBlue;
            button4.Location = new Point(340, 195);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(226, 110);
            button4.TabIndex = 3;
            button4.Text = "REALIZAR\r\nVENDA";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_2;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Stencil", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.LightSteelBlue;
            button3.Location = new Point(209, 341);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(226, 110);
            button3.TabIndex = 2;
            button3.Text = "VISUALIZAR\r\nESTOQUE";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Stencil", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.LightSteelBlue;
            button1.Location = new Point(89, 195);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(226, 110);
            button1.TabIndex = 0;
            button1.Text = "CADASTRAR \r\nPRODUTO";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_2;
            // 
            // button2
            // 
            button2.BackColor = Color.AntiqueWhite;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(440, 480);
            button2.Name = "button2";
            button2.Size = new Size(119, 47);
            button2.TabIndex = 6;
            button2.Text = "sair";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(645, 600);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Menu";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Button button4;
        private Button button3;
        private Button button1;
        private Button button2;
    }
}