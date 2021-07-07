using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using OfficeOpenXml;
using PCLExt.FileStorage;
using PCLExt.FileStorage.Folders;

namespace ConcatenarPlanilhasCSV
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            /*string caminho = txtBoxCaminho.Text;
            var pastaArquivos = new FolderFromPath(caminho);
            List<IFile> arquivos = new List<IFile>();
            arquivos.AddRange(await pastaArquivos.GetFilesAsync());

            byte[] files;
            var t = arquivos[1].ReadAllBytes();

            MessageBox.Show(t.ToString());

            for(int i = 0; i < arquivos.Count; i++)
            {
                files = arquivos[i].ReadAllBytes();
            }*/

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            var excelPackage = new ExcelPackage();
            
                excelPackage.Workbook.Properties.Author = "guiborgesoficial";
                excelPackage.Workbook.Properties.Title = "Meu Excel";

                var sheet = excelPackage.Workbook.Worksheets.Add("Planilha 1");
                sheet.Name = "Planilha 1";
            sheet.Cells[1, 1].Value = "email";

                



                string t = @"D:\contacts2.csv";
                
            
            StreamReader rd = new StreamReader(@"D:\contacts.csv", Encoding.Default, true);

            string linha = await rd.ReadToEndAsync();
            
            string[] linhaseparada = linha.Split(',');
            
            for(int i = 2; i < linhaseparada.Length; i++)
            {
                if(linhaseparada[i].Contains("@"))
                {
                    sheet.Cells[i, 1].Value = linhaseparada[i];
                }
                if (i == 1000)
                {

                }
            }

            var file = new FileInfo(t);
            var format = new ExcelOutputTextFormat();
            await sheet.Cells["A1:A15999"].SaveToTextAsync(file, format);


        }
    }
}
