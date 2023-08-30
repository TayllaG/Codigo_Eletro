using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel1 = Microsoft.Office.Interop.Excel;

public class Excel
{
    public void ExcelAdd(int id, string nome, double valor, string df, int quantidade)
    {

        //Excel1.Application excelApp: Isso cria uma instância da aplicação Microsoft Excel.
        //Essa instância permite que você interaja com a aplicação Excel, criando ou abrindo
        //pastas de trabalho e planilhas.

        Excel1.Application excelApp = new Excel1.Application();

        //Excel1.Workbook excelWorkbook: Isso representa uma pasta de trabalho no Excel.
        //Uma pasta de trabalho é o arquivo principal do Excel que pode conter várias planilhas.
        Excel1.Workbook excelWorkbook = null;

        //Excel1.Worksheet excelWorksheet: Isso representa uma planilha dentro de uma pasta de trabalho.
        //Você pode realizar operações específicas nessa planilha, como adicionar dados, formatar células
        //e muito mais.
        //Null: está sinalizando que ela ainda não possui nenhum objeto associado.
        Excel1.Worksheet excelWorksheet = null;

        

        try
        {
            // Abrindo um objeto na pasta de trabalho;
            excelWorkbook = excelApp.Workbooks.Open(@"C:\Users\tayll\Desktop\Estoque.xlsx");

            // Escolha a planilha que você deseja ler (neste caso, a primeira planilha)
            excelWorksheet = excelWorkbook.Sheets[1];

            // Encontre a última linha preenchida na coluna "A"
            int lastRow = excelWorksheet.Cells[excelWorksheet.Rows.Count, 1].End[Excel1.XlDirection.xlUp].Row;

            // Calcule a próxima linha disponível para adicionar os novos dados
            int newRow = lastRow + 1;

            // Adicione os dados à próxima linha disponível
            excelWorksheet.Cells[newRow, 1].Value2 = id;
            excelWorksheet.Cells[newRow, 2].Value2 = nome;
            excelWorksheet.Cells[newRow, 3].Value2 = valor;
            excelWorksheet.Cells[newRow, 4].Value2 = df;
            excelWorksheet.Cells[newRow, 5].Value2 = quantidade;
            //COLUNAS
            excelWorksheet.Cells[1, 1].Value2 = "Id";
            excelWorksheet.Cells[1, 2].Value2 = "Produto";
            excelWorksheet.Cells[1, 3].Value2 = "Valor";
            excelWorksheet.Cells[1, 4].Value2 = "DataFabricação";
            excelWorksheet.Cells[1, 5].Value2 = "Quantidade";

            // Salve as alterações no arquivo
            excelWorkbook.Save();

            excelWorkbook.Close(true);
            Marshal.ReleaseComObject(excelWorkbook);
            excelApp.Quit();
            Marshal.ReleaseComObject(excelApp);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Ocorreu um erro inesperado");
        }
    }
}



            
