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
using FastBeats.DB;


namespace FastBeats.View
{
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        OperacoesForm form = new OperacoesForm();
        frmPrincipal contexto = new frmPrincipal();
        Focus foco = new DB.Focus();
        FunLoginTema flt = new FunLoginTema();
        public int numTema,numCor;
        public frmLogin(frmPrincipal contexto)
        {
            this.contexto = contexto;
            InitializeComponent();
            this.StyleManager = metroStyleManager;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

            OperacoesForm form = new OperacoesForm();
            form.correcaoInicialForm(this);        
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (flt.login(mtxtLogin.Text, mtxtSenha.Text,contexto))
            {
                flt.aplicarTema(contexto.cpf, this);
                contexto.metroStyleManager.Theme = (MetroThemeStyle)numTema;
                contexto.metroStyleManager.Style = (MetroColorStyle)numCor;
                contexto.numCor = numCor;
                contexto.numTema = numTema;
                View.frmMenuPrincipal menu = new frmMenuPrincipal(contexto);

                menu.metroStyleManager.Theme = contexto.metroStyleManager.Theme;
                menu.metroStyleManager.Style = contexto.metroStyleManager.Style;

                form.chamarFrm(contexto, menu);
                this.Close();
            }
            else
            {
                mlblAvisos.Text = "Login ou senha inválidos";
            }
        }

 

        private void mtxtLogin_Enter(object sender, EventArgs e)
        {
            foco.foco(mtxtLogin, "Login");
        }

        private void mtxtLogin_Leave(object sender, EventArgs e)
        {
            foco.foraDeFoco(mtxtLogin, "Login");
        }

        private void mtxtSenha_Enter(object sender, EventArgs e)
        {
            foco.foco(mtxtSenha, "Senha");
        }

        private void mtxtSenha_Leave(object sender, EventArgs e)
        {
            foco.foraDeFoco(mtxtSenha, "Senha");
        }


 
        private void metroLink1_Click(object sender, EventArgs e)
        {
            frmRecuperarSenha recuSenha = new frmRecuperarSenha(contexto);
            
            form.chamarFrm(contexto, recuSenha);
            recuSenha.metroStyleManager.Theme = contexto.metroStyleManager.Theme;
            recuSenha.metroStyleManager.Style = contexto.metroStyleManager.Style;
            this.Close();
        }

        private void mtxtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }


       
    }
}
