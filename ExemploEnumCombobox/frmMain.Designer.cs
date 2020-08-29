namespace ExemploEnumCombobox
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDiasSemana = new System.Windows.Forms.ComboBox();
            this.btnSelecionaQuinta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escolha um dia da semana";
            // 
            // cmbDiasSemana
            // 
            this.cmbDiasSemana.FormattingEnabled = true;
            this.cmbDiasSemana.Location = new System.Drawing.Point(16, 46);
            this.cmbDiasSemana.Name = "cmbDiasSemana";
            this.cmbDiasSemana.Size = new System.Drawing.Size(166, 21);
            this.cmbDiasSemana.TabIndex = 1;
            // 
            // btnSelecionaQuinta
            // 
            this.btnSelecionaQuinta.Location = new System.Drawing.Point(202, 44);
            this.btnSelecionaQuinta.Name = "btnSelecionaQuinta";
            this.btnSelecionaQuinta.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionaQuinta.TabIndex = 2;
            this.btnSelecionaQuinta.Text = "Quinta-Feira";
            this.btnSelecionaQuinta.UseVisualStyleBackColor = true;
            this.btnSelecionaQuinta.Click += new System.EventHandler(this.btnSelecionaQuinta_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 97);
            this.Controls.Add(this.btnSelecionaQuinta);
            this.Controls.Add(this.cmbDiasSemana);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enumerador em Combobox";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDiasSemana;
        private System.Windows.Forms.Button btnSelecionaQuinta;
    }
}

