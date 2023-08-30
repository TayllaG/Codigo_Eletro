using System;
using System.Collections.Generic;
using System.IO;
using Excel1 = Microsoft.Office.Interop.Excel;

namespace Loja_de_Eletronicos
{   
    internal static class Program
    {
        public static List<Produtos> listaProdutos = new List<Produtos>();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Chame a função para ler o arquivo Excel e adicionar à lista

            try
            {
                string caminhoArquivo = @"C:\Users\tayll\Desktop\Estoque.xlsx";

                LerArquivoExcel(caminhoArquivo); // Passe o caminho do arquivo como argumento
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro: {ex.Message}");

            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        static void LerArquivoExcel(string caminhoArquivo) // Receba o caminho do arquivo como argumento
        {
            Excel1.Application excelApp = new Excel1.Application();
            Excel1.Workbook workbook = excelApp.Workbooks.Open(caminhoArquivo);
            Excel1.Worksheet worksheet = workbook.Sheets[1];

            try
            {
                int linha = 2; // Começa da segunda linha assumindo que a primeira linha é cabeçalho

                while (worksheet.Cells[linha, 1].Value != null && !string.IsNullOrWhiteSpace(worksheet.Cells[linha, 1].Value.ToString()))
                {
                    int id = (int)worksheet.Cells[linha, 1].Value;
                    string nome = worksheet.Cells[linha, 2].Value.ToString();
                    double valor = (double)worksheet.Cells[linha, 3].Value;
                    string dataFabr = worksheet.Cells[linha, 4].Value.ToString();
                    int quantidade = (int)worksheet.Cells[linha, 5].Value;

                    listaProdutos.Add(new Produtos { Id = id, Nome = nome, Valor = valor, DataFabr = dataFabr, Quantidade = quantidade });

                    linha++;
                }

                // Feche e libere recursos
                workbook.Close(false);
                excelApp.Quit();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro: {ex.Message}");

            }
        }
    }
}
