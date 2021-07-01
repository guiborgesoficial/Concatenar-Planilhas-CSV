using System;
using System.Collections.Generic;
using System.Windows.Forms;
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
            string caminho = txtBoxCaminho.Text;
            var pastaArquivos = new FolderFromPath(caminho);
            List<IFile> arquivos = new List<IFile>();
            arquivos.AddRange(await pastaArquivos.GetFilesAsync());

            byte[] files;
            var t = arquivos[1].ReadAllBytes();

            MessageBox.Show(t.ToString());

            //for(int i = 0; i < arquivos.Count; i++)
            //{
                //files = arquivos[i].ReadAllBytes();
            //}


        }
    }
}
