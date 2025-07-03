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

        string SoNumero(string Texto)
        {
            string resultado = "";
            for (int i = 0; i < Texto.Length; i++)
            {
                if (char.IsDigit(Texto[i]))
                {
                    resultado += Texto[i];
                }
            }

            //Retorno o resultado
            return resultado;
        }
        // verificação se arqurvo existe 
        bool ArquivoExiste(string caminho)
        {
            //verifica se o arquivo existe, o nome do arquivo sera o CPF, 
            //portanto se já existir, o usuário já possui cadastro
            return File.Exists(caminho);
        }

        void GravarArquivo(string caminho, string conteudo)
        {
            //grava o conteudo no arquivo
            //se o arquivo não existir, ele será criado
            string pasta = Path.GetDirectoryName(caminho);

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }
            File.WriteAllText(caminho, conteudo);
        }

        string GetDirArquivo(string nomePasta, string nomeArquivo)
        {
            //O arquivo será montado: Diretório Raiz do Executavel
            // nome da pasta: será o tipo de cadastro
            // nome do arquivo: será o CPF

            string raizExe = AppDomain.CurrentDomain.BaseDirectory;
            return Path.Combine(raizExe, nomePasta, nomeArquivo + ".txt");
        }

        public string inicioBingo = DateTime.Now.ToShortTimeString();
        string GetCadastro()
        {

            //Iremos concatenar os dados do cadastro para gerear o conteudo do arquivo
            string cadastro = "Nome do Prêmio: " + txtPremio.Text + Environment.NewLine +
                            "Horário de início: " + inicioBingo;

            return cadastro;
        }

        public string caminhoArquivoAtual;

        // Método para salvar o cadastro
        public void Salvar()
        {
            string nome = DateTime.Now.ToShortDateString("");
            // coloca a data e hora atual em duas strings 
            string date = DateTime.Now.ToShortDateString();
            string time = DateTime.Now.ToShortTimeString();

            //cria o caminho completo do arquivo,             NOME DO ARQUIVO: Bingo_01_01_2023_12_00.txt
            string caminhoCompleto = GetDirArquivo("Bingo", ("Bingo_" + SoNumero(date) + "_" + SoNumero(time)));

            //verifica se o arquivo já existe
            if (ArquivoExiste(caminhoCompleto))
            {
                //se o arquivo já existe, o usuário já possui cadastro
                MessageBox.Show("Usuário já cadastrado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                //gravar o arquivo
                GravarArquivo(caminhoCompleto, GetCadastro());

                //se o arquivo foi gravado com sucesso, exibe uma mensagem de sucesso
                MessageBox.Show("Registro salvo com sucesso!" + Environment.NewLine + Environment.NewLine +
                    "Salvo em :" + caminhoCompleto, "Informção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar o cadastro." + Environment.NewLine + "Erro original: " + ex.Message,
                    "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            caminhoArquivoAtual = caminhoCompleto;

        }
        void abrir()

        {
         
            Form1 tela = new Form1();
            tela.ShowDialog();
        }
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Salvar();

            abrir();
        }


    }
}
