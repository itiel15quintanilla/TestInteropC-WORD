using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;

namespace TestInteropC_WORD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnWord_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialogo = new SaveFileDialog();
            if (dialogo.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            string ruta = dialogo.FileName;
            var wordApp = new Word.Application();
            wordApp.Visible = true;
            wordApp.Documents.Add();
            string dato = txtDato.Text;

            wordApp.Selection.TypeText(dato);
            wordApp.ActiveDocument.SaveAs2(ruta);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialogo = new SaveFileDialog();
            if (dialogo.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            string ruta = dialogo.FileName;
            var excelApp = new Excel.Application();
            excelApp.Visible = true;
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.ActiveSheet;
            worksheet.Cells[1, 1] = txtDatoE.Text;

            workbook.SaveAs(ruta);
        }
    }
    
}
