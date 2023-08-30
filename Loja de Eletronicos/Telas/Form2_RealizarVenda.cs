using Eletros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Runtime.InteropServices;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Spreadsheet;

namespace Loja_de_Eletronicos
{
    public partial class Form2_RealizarVenda : Form
    {
        public Form2_RealizarVenda()
        {
            InitializeComponent();

            foreach (Produtos str in Program.listaProdutos)
            {
                box_nome.Items.Add(str.Nome);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            this.Visible = false;
            menu.ShowDialog();
            this.Visible = true;
        }


        private void combo_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProductName = box_nome.SelectedItem.ToString();
            Produtos selectedProduct = Program.listaProdutos.Find(prod => prod.Nome == selectedProductName);

            if (selectedProduct != null)
            {
                // Aqui você pode acessar os atributos do produto selecionado
                int id = selectedProduct.Id;
                string nome = selectedProduct.Nome;
                double preco = selectedProduct.Valor;

                // Atualiza os controles na interface com as informações do produto;
                txt_valor.Text = preco.ToString();
                txt_id.Text = id.ToString();
            }

        }
        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_lucro_TextChanged(object sender, EventArgs e)
        {


        }

        private void txt_valor_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            // Encontra o produto selecionado no ComboBox
            string selectedProductName = box_nome.SelectedItem.ToString();
            Produtos selectedProduct = Program.listaProdutos.Find(prod => prod.Nome == selectedProductName);

            if (selectedProduct != null)
            {
                int qtd = Convert.ToInt32(txt_qtd.Text);

                // Diminui a quantidade do produto em 1
                selectedProduct.Quantidade = selectedProduct.Quantidade - qtd;
                //era pra atuaç


            }
            Venda v = new Venda();
            try
            {
                v.Id = Convert.ToInt32(txt_id.Text);

            }

            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message + "\n Tente digitar novamente");
            }

            try
            {
                v.Nome = box_nome.Text;
            }

            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message + "\n Tente digitar novamente");
            }

            try
            {
                v.Valor = Convert.ToDouble(txt_valor.Text);
            }

            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message + "\n Tente digitar novamente");
            }


            try
            {
                v.Lucro = Convert.ToInt32(txt_lucro.Text);
            }

            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message + "\n Tente digitar novamente");
            }


            txt_venda.Text = v.ValorVenda(v.Valor, v.Lucro).ToString("");

        }

        private void txt_qtd_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            box_nome.Text = "";
            txt_id.Text = "";
            txt_valor.Text = "";
            txt_qtd.Text = "";
            txt_lucro.Clear();
            txt_venda.Clear();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
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