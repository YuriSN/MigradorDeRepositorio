using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Migração
{
    public partial class CaixaDeDialogo : Form
    {
        public CaixaDeDialogo()
        {
            InitializeComponent();
        }

        private void CaixaDeDialogo_Load(object sender, EventArgs e)
        {

        }

        private void cmdVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            Migração abre = new Migração();
            abre.ShowDialog();
        }

        private void cmdCopiarArquivo_Click(object sender, EventArgs e)
        {
            Migração destino = new Migração();

            using (var openFile = new OpenFileDialog())
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                    destino.Origem = Convert.ToString(openFile.FileName);//Caminho do arquivo selecionado
                    destino.ShowDialog();
            }
        }

        private void cmdCopiarPasta_Click(object sender, EventArgs e)
        {
            Migração destino = new Migração();

            using (var openFolder = new FolderBrowserDialog())
            {
                if (openFolder.ShowDialog() == DialogResult.OK)
                    destino.Origem = Convert.ToString(openFolder.SelectedPath);//Caminho da pasta selecionado
                    destino.ShowDialog();
            }
        }
    }
}
