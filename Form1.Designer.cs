namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFinalizarBingo = new System.Windows.Forms.Button();
            this.btnBingo = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumeroAnterior = new System.Windows.Forms.Label();
            this.lblNumeroAtual = new System.Windows.Forms.Label();
            this.btn_sortear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFinalizarBingo
            // 
            this.btnFinalizarBingo.BackColor = System.Drawing.Color.Red;
            this.btnFinalizarBingo.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarBingo.ForeColor = System.Drawing.SystemColors.Window;
            this.btnFinalizarBingo.Location = new System.Drawing.Point(1005, 164);
            this.btnFinalizarBingo.Name = "btnFinalizarBingo";
            this.btnFinalizarBingo.Size = new System.Drawing.Size(260, 59);
            this.btnFinalizarBingo.TabIndex = 81;
            this.btnFinalizarBingo.Text = "Finalizar Bingo";
            this.btnFinalizarBingo.UseVisualStyleBackColor = false;
            // 
            // btnBingo
            // 
            this.btnBingo.BackColor = System.Drawing.Color.Blue;
            this.btnBingo.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBingo.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBingo.Location = new System.Drawing.Point(677, 164);
            this.btnBingo.Name = "btnBingo";
            this.btnBingo.Size = new System.Drawing.Size(215, 59);
            this.btnBingo.TabIndex = 80;
            this.btnBingo.Text = " Bingo!";
            this.btnBingo.UseVisualStyleBackColor = false;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(698, 429);
            this.lbl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(154, 25);
            this.lbl2.TabIndex = 86;
            this.lbl2.Text = "Número Anterior";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(698, 337);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 85;
            this.label1.Text = "Número Atual";
            // 
            // lblNumeroAnterior
            // 
            this.lblNumeroAnterior.AutoSize = true;
            this.lblNumeroAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroAnterior.Location = new System.Drawing.Point(775, 473);
            this.lblNumeroAnterior.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroAnterior.Name = "lblNumeroAnterior";
            this.lblNumeroAnterior.Size = new System.Drawing.Size(64, 25);
            this.lblNumeroAnterior.TabIndex = 84;
            this.lblNumeroAnterior.Text = "label2";
            // 
            // lblNumeroAtual
            // 
            this.lblNumeroAtual.AutoSize = true;
            this.lblNumeroAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroAtual.Location = new System.Drawing.Point(775, 386);
            this.lblNumeroAtual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroAtual.Name = "lblNumeroAtual";
            this.lblNumeroAtual.Size = new System.Drawing.Size(64, 25);
            this.lblNumeroAtual.TabIndex = 83;
            this.lblNumeroAtual.Text = "label1";
            // 
            // btn_sortear
            // 
            this.btn_sortear.BackColor = System.Drawing.Color.Lime;
            this.btn_sortear.Location = new System.Drawing.Point(247, 164);
            this.btn_sortear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sortear.Name = "btn_sortear";
            this.btn_sortear.Size = new System.Drawing.Size(152, 59);
            this.btn_sortear.TabIndex = 82;
            this.btn_sortear.Text = "SORTEAR";
            this.btn_sortear.UseVisualStyleBackColor = false;
            this.btn_sortear.Click += new System.EventHandler(this.btn_sortear_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1733, 798);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNumeroAnterior);
            this.Controls.Add(this.lblNumeroAtual);
            this.Controls.Add(this.btn_sortear);
            this.Controls.Add(this.btnFinalizarBingo);
            this.Controls.Add(this.btnBingo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFinalizarBingo;
        private System.Windows.Forms.Button btnBingo;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumeroAnterior;
        private System.Windows.Forms.Label lblNumeroAtual;
        private System.Windows.Forms.Button btn_sortear;
    }
}

