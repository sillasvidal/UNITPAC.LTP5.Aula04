using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNITPAC.Aula04
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        void ExibirFormulario(Form frm, bool permitirAbrirNovamente = false)
        {
            FormCollection fc = Application.OpenForms;

            if (!permitirAbrirNovamente)
            {
                foreach (Form item in fc)
                {
                    if (item.Name == frm.Name)
                    {
                        // se chegou aqui quer dizer que tem formulário aberto com o mesmo nome
                        MessageBox.Show(this, "Este formulário já está aberto.", "Alerta", MessageBoxButtons.OK);
                        return;
                    }
                }
            }

            frm.MdiParent = this;
            frm.Show();
        }

        private void cadastroDeAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroAluno frm = new FrmCadastroAluno();
            ExibirFormulario(frm);
        }

        private void editorDeTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditorTexto frm = new FrmEditorTexto();
            ExibirFormulario(frm, true);
        }

        private void consultarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaAluno frm = new FrmConsultaAluno();
            ExibirFormulario(frm);
        }

        private void consultarProfessorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaProfessor frm = new FrmConsultaProfessor();
            ExibirFormulario(frm);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
