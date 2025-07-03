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
            this.components = new System.ComponentModel.Container();
            this.lblPremio = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPremio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPremio
            // 
            this.lblPremio.AutoSize = true;
            this.lblPremio.Location = new System.Drawing.Point(9, 9);
            this.lblPremio.Name = "lblPremio";
            this.lblPremio.Size = new System.Drawing.Size(44, 16);
            this.lblPremio.TabIndex = 1;
            this.lblPremio.Text = "nome ";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(10, 142);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(124, 23);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.Text = "Iniciar Bingo";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(494, 22);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Premio";
            // 
            // txtPremio
            // 
            this.txtPremio.Location = new System.Drawing.Point(12, 99);
            this.txtPremio.Name = "txtPremio";
            this.txtPremio.Size = new System.Drawing.Size(494, 22);
            this.txtPremio.TabIndex = 8;
            // 
            // frmTelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 292);
            this.Controls.Add(this.txtPremio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.lblPremio);
            this.Name = "frmTelaInicial";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPremio;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPremio;
    }
}