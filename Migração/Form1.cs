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

namespace Migração
{

    public partial class Migração : Form
    {
        string caminho = @"C:\";
        int sdf = 654;
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
                        MessageBox.Show("Arquivo duplicado com sucesso!");
                        
                    }

                }
                else {
                    File.Copy(txtOrigem.Text, txtDestino.Text);
                    MessageBox.Show("Arquivo cópiado com sucesso!");
                    
                    txtDestino.Text = "";
                    ActiveControl = txtOrigem;
                }
                
            }

            
            catch (Exception ex)
            {
                MessageBox.Show("Falha: " + ex.Message);
            }

            
            
        }


        private void cmdMover_Click(object sender, EventArgs e)
        {

        }

        private void cmdRenomear_Click(object sender, EventArgs e)
        {

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
            //Caixa de diálogo:
            using (var openFile = new OpenFileDialog())
            {

                if (openFile.ShowDialog() == DialogResult.OK)
                    txtOrigem.Text = openFile.FileName;//Caminho da pasta selecionada.
            }

        }
    }
}