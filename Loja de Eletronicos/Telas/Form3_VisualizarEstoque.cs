using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;





namespace Loja_de_Eletronicos
{
    public partial class Form3_VisualizarEstoque : Form
    {
        public Form3_VisualizarEstoque()
        {
            InitializeComponent();

            foreach (Produtos str in Program.listaProdutos)
            {
                dataGridView1.Rows.Add(str.Id, str.Nome, str.Valor, str.DataFabr, str.Quantidade);

            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                dataGridView1.Rows.RemoveAt(index);
                Program.listaProdutos.RemoveAt(index);
                //Para salvar as modificações: AcceptChanges();

            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Cadastrar_Produto RV = new Cadastrar_Produto();
            this.Visible = false;
            RV.ShowDialog();
            this.Visible = true;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Cadastrar_Produto produto = new Cadastrar_Produto();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 voltarMenu = new Form1();
            this.Visible = false;
            voltarMenu.ShowDialog();
            this.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialg = new DialogResult();
            dialg = MessageBox.Show("Deseja mesmo sair?", "Alerta!", MessageBoxButtons.YesNo);

            if (dialg == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
             
            }
       
        }
    }
}
