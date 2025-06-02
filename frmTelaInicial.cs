using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmTelaInicial: Form
    {
       

        public frmTelaInicial()
        {
            InitializeComponent();
        }


        //função para conseguir o caminho do arquivo
        string GetDirArquivo(string nomePasta, string nomeArquivo)
        {
            
            //conseguir o caminho do do aplicativo ou seja a pasta onde todo o projeto se encontra   
            string raizExe = AppDomain.CurrentDomain.BaseDirectory;


            return raizExe + nomePasta + nomeArquivo;
        }
      
        void CriarBingo(string caminho, string conteudo)
        {
            string pasta = Path.GetDirectoryName(caminho);
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }
            File.WriteAllText(caminho, conteudo);
        }

        string nome = "bingo" + ".text";
        void Salvar() {

            String Caminnho_Compl = GetDirArquivo("Historico", nome); 
        }

        void criararquivo(string texto) {

            string arquivos = AppDomain.CurrentDomain.BaseDirectory + "/arquivos";

            if (Directory.Exists(arquivos))
            { 
             Directory.CreateDirectory(arquivos);
            }

            File.WriteAllText(arquivos, texto);
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Form1 tela = new Form1();
            tela.ShowDialog();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            TxtListar = 
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            criararquivo(TxtGravar.Text);
            MessageBox.Show("arquivo salvo com sucesso!");

        }
    }
}
