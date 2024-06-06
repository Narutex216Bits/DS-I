using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEmpresa
{
    public partial class FrmMENU : Form
    {
        public FrmMENU()
        {
            InitializeComponent();
        }

        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // se formularios abertos do tipo <nomeForm> maior que zero
            if (Application.OpenForms.OfType<FrmDepartamento>().Count() > 0)

                // deixa o formulario ja aberto em primeiro plano
                Application.OpenForms.OfType<FrmDepartamento>().First().Focus();
            else
            {
                var frmDep = new FrmDepartamento(); // cria uma instância para o frmDepartamento

                frmDep.MdiParent = this;// Define que FrmMenu (this) é o form "pai"

                frmDep.Show(); // exibe o form
            }
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // se formularios abertos do tipo <nomeForm> maior que zero
            if (Application.OpenForms.OfType<FrmDepartamento>().Count() > 0)

                // deixa o formulario ja aberto em primeiro plano
                Application.OpenForms.OfType<FrmDepartamento>().First().Focus();
            else
            {
                var frmFunc = new FrmFuncionario(); 
                frmFunc.MdiParent = this;
                frmFunc.Show(); 
            }
        }
    }
}
