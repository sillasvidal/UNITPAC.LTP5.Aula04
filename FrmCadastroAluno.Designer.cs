namespace UNITPAC.Aula04
{
    partial class FrmCadastroAluno
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
            this.LbNome = new System.Windows.Forms.Label();
            this.LbIdade = new System.Windows.Forms.Label();
            this.LbEmail = new System.Windows.Forms.Label();
            this.LbSenha = new System.Windows.Forms.Label();
            this.TxbNome = new System.Windows.Forms.TextBox();
            this.TxbIdade = new System.Windows.Forms.TextBox();
            this.TxbEmail = new System.Windows.Forms.TextBox();
            this.TxbSenha = new System.Windows.Forms.TextBox();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbNome
            // 
            this.LbNome.AutoSize = true;
            this.LbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNome.Location = new System.Drawing.Point(27, 31);
            this.LbNome.Name = "LbNome";
            this.LbNome.Size = new System.Drawing.Size(68, 25);
            this.LbNome.TabIndex = 0;
            this.LbNome.Text = "Nome";
            // 
            // LbIdade
            // 
            this.LbIdade.AutoSize = true;
            this.LbIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbIdade.Location = new System.Drawing.Point(27, 119);
            this.LbIdade.Name = "LbIdade";
            this.LbIdade.Size = new System.Drawing.Size(65, 25);
            this.LbIdade.TabIndex = 1;
            this.LbIdade.Text = "Idade";
            // 
            // LbEmail
            // 
            this.LbEmail.AutoSize = true;
            this.LbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEmail.Location = new System.Drawing.Point(27, 207);
            this.LbEmail.Name = "LbEmail";
            this.LbEmail.Size = new System.Drawing.Size(72, 25);
            this.LbEmail.TabIndex = 2;
            this.LbEmail.Text = "E-mail";
            // 
            // LbSenha
            // 
            this.LbSenha.AutoSize = true;
            this.LbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSenha.Location = new System.Drawing.Point(27, 290);
            this.LbSenha.Name = "LbSenha";
            this.LbSenha.Size = new System.Drawing.Size(74, 25);
            this.LbSenha.TabIndex = 3;
            this.LbSenha.Text = "Senha";
            // 
            // TxbNome
            // 
            this.TxbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbNome.Location = new System.Drawing.Point(32, 59);
            this.TxbNome.Name = "TxbNome";
            this.TxbNome.Size = new System.Drawing.Size(223, 26);
            this.TxbNome.TabIndex = 4;
            // 
            // TxbIdade
            // 
            this.TxbIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbIdade.Location = new System.Drawing.Point(32, 147);
            this.TxbIdade.Name = "TxbIdade";
            this.TxbIdade.Size = new System.Drawing.Size(223, 26);
            this.TxbIdade.TabIndex = 5;
            // 
            // TxbEmail
            // 
            this.TxbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbEmail.Location = new System.Drawing.Point(32, 235);
            this.TxbEmail.Name = "TxbEmail";
            this.TxbEmail.Size = new System.Drawing.Size(223, 26);
            this.TxbEmail.TabIndex = 6;
            // 
            // TxbSenha
            // 
            this.TxbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbSenha.Location = new System.Drawing.Point(32, 318);
            this.TxbSenha.Name = "TxbSenha";
            this.TxbSenha.Size = new System.Drawing.Size(223, 26);
            this.TxbSenha.TabIndex = 7;
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastrar.Location = new System.Drawing.Point(32, 374);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(157, 35);
            this.BtnCadastrar.TabIndex = 8;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // FrmCadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(785, 450);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.TxbSenha);
            this.Controls.Add(this.TxbEmail);
            this.Controls.Add(this.TxbIdade);
            this.Controls.Add(this.TxbNome);
            this.Controls.Add(this.LbSenha);
            this.Controls.Add(this.LbEmail);
            this.Controls.Add(this.LbIdade);
            this.Controls.Add(this.LbNome);
            this.Name = "FrmCadastroAluno";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Aluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbNome;
        private System.Windows.Forms.Label LbIdade;
        private System.Windows.Forms.Label LbEmail;
        private System.Windows.Forms.Label LbSenha;
        private System.Windows.Forms.TextBox TxbNome;
        private System.Windows.Forms.TextBox TxbIdade;
        private System.Windows.Forms.TextBox TxbEmail;
        private System.Windows.Forms.TextBox TxbSenha;
        private System.Windows.Forms.Button BtnCadastrar;
    }
}