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
    public partial class FrmCadastroAluno : Form
    {
        public FrmCadastroAluno()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aluno Cadastrado com Sucesso.", "Confirmação");
        }
    }
}
