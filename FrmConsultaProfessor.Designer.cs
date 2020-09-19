namespace UNITPAC.Aula04
{
    partial class FrmConsultaProfessor
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
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.TxbPesquisa = new System.Windows.Forms.TextBox();
            this.LbDadosAPesquisar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.Location = new System.Drawing.Point(583, 53);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.BtnPesquisar.TabIndex = 5;
            this.BtnPesquisar.Text = "Pesquisar";
            this.BtnPesquisar.UseVisualStyleBackColor = true;
            // 
            // TxbPesquisa
            // 
            this.TxbPesquisa.Location = new System.Drawing.Point(141, 55);
            this.TxbPesquisa.Name = "TxbPesquisa";
            this.TxbPesquisa.Size = new System.Drawing.Size(425, 20);
            this.TxbPesquisa.TabIndex = 4;
            // 
            // LbDadosAPesquisar
            // 
            this.LbDadosAPesquisar.AutoSize = true;
            this.LbDadosAPesquisar.Location = new System.Drawing.Point(138, 28);
            this.LbDadosAPesquisar.Name = "LbDadosAPesquisar";
            this.LbDadosAPesquisar.Size = new System.Drawing.Size(155, 13);
            this.LbDadosAPesquisar.TabIndex = 3;
            this.LbDadosAPesquisar.Text = "Nome do Professor a Pesquisar";
            // 
            // FrmConsultaProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnPesquisar);
            this.Controls.Add(this.TxbPesquisa);
            this.Controls.Add(this.LbDadosAPesquisar);
            this.Name = "FrmConsultaProfessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Professores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.TextBox TxbPesquisa;
        private System.Windows.Forms.Label LbDadosAPesquisar;
    }
}