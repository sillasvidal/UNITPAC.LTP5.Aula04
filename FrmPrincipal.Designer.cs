namespace UNITPAC.Aula04
{
    partial class FrmPrincipal
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
            this.MenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.cadastroDeAlunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorDeTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorDeTextoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarProfessorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeAlunosToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.Size = new System.Drawing.Size(800, 24);
            this.MenuPrincipal.TabIndex = 0;
            this.MenuPrincipal.Text = "menuStrip1";
            // 
            // cadastroDeAlunosToolStripMenuItem
            // 
            this.cadastroDeAlunosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editorDeTextoToolStripMenuItem,
            this.editorDeTextoToolStripMenuItem1,
            this.toolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.cadastroDeAlunosToolStripMenuItem.Name = "cadastroDeAlunosToolStripMenuItem";
            this.cadastroDeAlunosToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.cadastroDeAlunosToolStripMenuItem.Text = "Janelas";
            // 
            // editorDeTextoToolStripMenuItem
            // 
            this.editorDeTextoToolStripMenuItem.Name = "editorDeTextoToolStripMenuItem";
            this.editorDeTextoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editorDeTextoToolStripMenuItem.Text = "Cadastro de Alunos";
            this.editorDeTextoToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeAlunosToolStripMenuItem_Click);
            // 
            // editorDeTextoToolStripMenuItem1
            // 
            this.editorDeTextoToolStripMenuItem1.Name = "editorDeTextoToolStripMenuItem1";
            this.editorDeTextoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.editorDeTextoToolStripMenuItem1.Text = "Editor de Texto";
            this.editorDeTextoToolStripMenuItem1.Click += new System.EventHandler(this.editorDeTextoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarAlunoToolStripMenuItem,
            this.consultarProfessorToolStripMenuItem,
            this.toolStripMenuItem2});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // consultarAlunoToolStripMenuItem
            // 
            this.consultarAlunoToolStripMenuItem.Name = "consultarAlunoToolStripMenuItem";
            this.consultarAlunoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarAlunoToolStripMenuItem.Text = "Consultar Aluno";
            this.consultarAlunoToolStripMenuItem.Click += new System.EventHandler(this.consultarAlunoToolStripMenuItem_Click);
            // 
            // consultarProfessorToolStripMenuItem
            // 
            this.consultarProfessorToolStripMenuItem.Name = "consultarProfessorToolStripMenuItem";
            this.consultarProfessorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarProfessorToolStripMenuItem.Text = "Consultar Professor";
            this.consultarProfessorToolStripMenuItem.Click += new System.EventHandler(this.consultarProfessorToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MenuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuPrincipal;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UNITPAC - Aula 04";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MenuPrincipal.ResumeLayout(false);
            this.MenuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeAlunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorDeTextoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorDeTextoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarProfessorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    }
}

