using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            InicializarBingo();

        }

        List<int> NumerosRestantes = new List<int>();
        List<int> NumerosSorteados = new List<int>();
        List<Panel> bingoPanels = new List<Panel>();


       
        void InicializarBingo()
        {
            NumerosRestantes.Clear();
            NumerosSorteados.Clear();

            for (int i = 1; i <= 75; i++)
            {
                NumerosRestantes.Add(i);

                criarpanel(i);

            }
            lblNumeroAnterior.Text = "";
            lblNumeroAtual.Text = "";



        }

        void criarpanel(int i)
        {
            for (int coluna = 0; coluna < 15; coluna++) 

             if (coluna % 5 == 0 ){
                    for (int linha = i; linha < 5; linha++)
                    {
                        {
                            Panel celula = new Panel();
                            celula.Size = new Size(53, 20);

                            // Calculando posição manualmente
                            int x = coluna * (53 + 10);
                            int y = linha * (53 + 10);
                            celula.Location = new Point(x, y);

                            celula.BackColor = Color.FromArgb(230, 240, 255);
                            celula.BorderStyle = BorderStyle.FixedSingle;

                            // Adicionando rótulo com posição
                            Label lbl = new Label();
                            lbl.Text = $"[{linha},{coluna}]";
                            lbl.Location = new Point(5, 5);
                            lbl.AutoSize = true;

                            celula.Controls.Add(lbl);
                            this.Controls.Add(celula);
                        }
                    }

            }
        
      

        private void btn_sortear_Click_1(object sender, EventArgs e)
        {
            if (NumerosRestantes.Count == 0)
            {
                MessageBox.Show("Todos os números foram sorteados");
                return;
            }

            Random Sorteio = new Random();
            int numero = Sorteio.Next(NumerosRestantes.Count);
            int numSorteado = NumerosRestantes[numero];
            NumerosRestantes.RemoveAt(numero);
            if (NumerosSorteados.Count > 0)
            {
                lblNumeroAnterior.Text = NumerosSorteados[NumerosSorteados.Count - 1].ToString();
            }
            lblNumeroAtual.Text = numSorteado.ToString();
            NumerosSorteados.Add(numSorteado);
        }
    }
}
