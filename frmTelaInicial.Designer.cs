namespace WindowsFormsApp1
{
    partial class frmTelaInicial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbPremio = new System.Windows.Forms.ComboBox();
            this.lblPremio = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.TxtGravar = new System.Windows.Forms.TextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.TxtListar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbPremio
            // 
            this.cbPremio.FormattingEnabled = true;
            this.cbPremio.Items.AddRange(new object[] {
            "leitoa",
            "1000,00",
            "5000,00"});
            this.cbPremio.Location = new System.Drawing.Point(121, 40);
            this.cbPremio.Name = "cbPremio";
            this.cbPremio.Size = new System.Drawing.Size(255, 24);
            this.cbPremio.TabIndex = 0;
            // 
            // lblPremio
            // 
            this.lblPremio.AutoSize = true;
            this.lblPremio.Location = new System.Drawing.Point(118, 21);
            this.lblPremio.Name = "lblPremio";
            this.lblPremio.Size = new System.Drawing.Size(50, 16);
            this.lblPremio.TabIndex = 1;
            this.lblPremio.Text = "Prêmio";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(121, 70);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.Text = "Iniciar Bingo";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // TxtGravar
            // 
            this.TxtGravar.Location = new System.Drawing.Point(521, 210);
            this.TxtGravar.Multiline = true;
            this.TxtGravar.Name = "TxtGravar";
            this.TxtGravar.Size = new System.Drawing.Size(160, 115);
            this.TxtGravar.TabIndex = 3;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(533, 350);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 4;
            this.btnGravar.Text = "gravar ";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(355, 350);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 5;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // TxtListar
            // 
            this.TxtListar.Location = new System.Drawing.Point(315, 210);
            this.TxtListar.Multiline = true;
            this.TxtListar.Name = "TxtListar";
            this.TxtListar.Size = new System.Drawing.Size(140, 115);
            this.TxtListar.TabIndex = 6;
            // 
            // frmTelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtListar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.TxtGravar);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.lblPremio);
            this.Controls.Add(this.cbPremio);
            this.Name = "frmTelaInicial";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPremio;
        private System.Windows.Forms.Label lblPremio;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.TextBox TxtGravar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.TextBox TxtListar;
    }
}