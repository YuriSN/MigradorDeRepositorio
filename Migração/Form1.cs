using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace Migração
{

    public partial class Migração : Form
    {
        string caminho = @"C:\";

        public string Origem
        {
            set { txtOrigem.Text = value; }
        }

        public Migração()
        {
            InitializeComponent();
        }

        private void Migração_Load(object sender, EventArgs e)
        {

        }

        private void lblOrigem_Click(object sender, EventArgs e)
        {

        }

        private void txtOrigem_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void lblDestino_Click(object sender, EventArgs e)
        {

        }

        private void txtDestino_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void cmdCopiar_Click(object sender, EventArgs e)
        {
            
            if (txtOrigem.Text.Contains(".pdf") || txtOrigem.Text.Contains(".png") || txtOrigem.Text.Contains(".jpg") || txtOrigem.Text.Contains(".txt") || txtOrigem.Text.Contains(".doc") || txtOrigem.Text.Contains(".docx")
                 || txtOrigem.Text.Contains(".ptt") || txtOrigem.Text.Contains(".xls") || txtOrigem.Text.Contains(".rar") || txtOrigem.Text.Contains(".zip") || txtOrigem.Text.Contains(".css") || txtOrigem.Text.Contains(".exe")
                  || txtOrigem.Text.Contains(".js") || txtOrigem.Text.Contains(".svg") || txtOrigem.Text.Contains(".sql") || txtOrigem.Text.Contains(".sln") || txtOrigem.Text.Contains(".resx") || txtOrigem.Text.Contains(".cs"))
            {
                try
                {
                    if (File.Exists(txtDestino.Text))
                    {
                        if (MessageBox.Show("Arquivo já existe! \n Deseja sobrepor?", "Copiar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            var texto1 = txtOrigem.Text.Split('\\');
                            var tamanhoTexto = texto1.Length;
                            var nomeArquivo = texto1[tamanhoTexto - 1];
                            var duplica = nomeArquivo.Split('.');
                            var iniciotexto = duplica[0];
                            var finaltexto = duplica[1];

                            string newPath = "";

                            for (int i = 1; i < 10; i++)
                            {
                                string str = txtDestino.Text;


                                string newName = iniciotexto + "(" + i + ")" + "." + finaltexto;

                                newPath = str.Replace(nomeArquivo, newName);

                                if (!File.Exists(newPath))
                                    break;
                            }
                            File.Copy(txtOrigem.Text, newPath, true);
                            MessageBox.Show("Arquivo duplicado com sucesso!", "Aviso.");
                        }
                    }
                    else
                    {
                        File.Copy(txtOrigem.Text, txtDestino.Text);
                        MessageBox.Show("Arquivo cópiado com sucesso!", "Aviso.");

                        txtDestino.Text = "";
                        ActiveControl = txtOrigem;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha: " + ex.Message);
                }
            }
            else
                CopiarPasta(txtOrigem.Text, txtDestino.Text, true);
        }

        //Criando método copiar pasta:
        private void CopiarPasta(string sourceDirName, string destDirName, bool copySubDirs)
        {
            { 
                var dir = new DirectoryInfo(sourceDirName);
                var dirs = dir.GetDirectories();

                // Se o diretório de origem não existir, lance uma exceção.
                if (!dir.Exists)
                {
                    throw new DirectoryNotFoundException(
                        "O diretório de origem não existe ou não foi encontrado: "
                        + sourceDirName);
                }

                // Se o diretório de destino não existir, crie-o.
                if (!Directory.Exists(destDirName))
                {
                    Directory.CreateDirectory(destDirName);
                }


                // Obtenha o conteúdo do arquivo do diretório a ser copiado.
                var files = dir.GetFiles();

                foreach (var file in files)
                {
                    toolStripStatusLabel1.Text = Convert.ToString(file);
                    statusStrip1.Refresh();
                    // Crie o caminho para a nova cópia do arquivo.
                    var temppath = Path.Combine(destDirName, file.Name);
                    Thread.Sleep(5);

                    // Copie o arquivo.
                    file.CopyTo(temppath, true);
                }

                // Se copySubDirs for true, copie os subdiretórios.
                if (!copySubDirs) return;

                foreach (var subdir in dirs)
                {
                    toolStripStatusLabel1.Text = Convert.ToString(subdir);
                    statusStrip1.Refresh();
                    // Crie o subdiretório.
                    var temppath = Path.Combine(destDirName, subdir.Name);
                    Thread.Sleep(5);

                    // Copie os subdiretórios.
                    CopiarPasta(subdir.FullName, temppath, copySubDirs);
                }
                toolStripStatusLabel1.Text = "Pronto " + dirs.Count() + " subpastas copiadas!";
            }
        }

        private void cmdMover_Click(object sender, EventArgs e)
        {
            try
            {
                File.Move(txtOrigem.Text, txtDestino.Text);
                MessageBox.Show("Arquivo movido com sucesso!", "Aviso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha: " + ex.Message);
            }
        }

        private void txtDestino_DoubleClick(object sender, EventArgs e)
        {
            //Selecionar caminho:
            using (var openDlg = new FolderBrowserDialog())
            {
                openDlg.SelectedPath = caminho;

                //Definindo nome do arquivo
                var texto = txtOrigem.Text.Split('\\');
                var tamanhoTexto = texto.Length;
                var nomeArquivo = texto[tamanhoTexto - 1];

                if (openDlg.ShowDialog() == DialogResult.OK)
                    txtDestino.Text = openDlg.SelectedPath + "\\" + nomeArquivo; //Caminho da pasta selecionada.
            }

        }

        private void txtOrigem_DoubleClick(object sender, EventArgs e)
        {
            this.Hide();
            CaixaDeDialogo boxDialogue = new CaixaDeDialogo();
            boxDialogue.ShowDialog();
        }

        private void txtOrigem_Enter(object sender, EventArgs e)
        {
            if(txtOrigem.Text == "Dois cliques para abrir diretório")
            {
                txtOrigem.Text = "";
                txtOrigem.ForeColor = Color.Black;
            }
        }

        private void txtOrigem_Leave(object sender, EventArgs e)
        {
            if (txtOrigem.Text == "")
            {
                txtOrigem.Text = "Dois cliques para abrir diretório";
                txtOrigem.ForeColor = Color.Silver;
            }
        }

        private void txtDestino_Enter(object sender, EventArgs e)
        {
            if (txtDestino.Text == "Dois cliques para escolher diretório")
            {
                txtDestino.Text = "";
                txtDestino.ForeColor = Color.Black;
            }
        }

        private void txtDestino_Leave(object sender, EventArgs e)
        {
            if (txtDestino.Text == "")
            {
                txtDestino.Text = "Dois cliques para escolher diretório";
                txtDestino.ForeColor = Color.Silver;
            }
        }
    }
}