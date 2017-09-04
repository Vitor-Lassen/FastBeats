using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;


namespace FastBeats
{
    public partial class frmPrincipal : MetroFramework.Forms.MetroForm
    {
        public int numTema,numCor;
        public string cpf;
        
        public frmPrincipal()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager;
            
        }
        
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            
            View.frmLogin login = new View.frmLogin(this);
            OperacoesForm form = new OperacoesForm();

            form.chamarFrm(this, login);
            
            
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToShortTimeString();
            lblData.Text = DateTime.Now.ToLongDateString();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MetroMessageBox.Show(this, "Deseja mesmo sair do FastBeats?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.No)
            {
                e.Cancel = true;
            }
            
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void mlblNivel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblData_Click(object sender, EventArgs e)
        {

        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }
           
    }
}
