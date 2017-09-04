using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastBeats.DB;
using MetroFramework;


namespace FastBeats.View
{
    public partial class frmRecuperarSenha : MetroFramework.Forms.MetroForm
    {
        OperacoesForm form = new OperacoesForm();

        frmPrincipal contexto = new frmPrincipal();
        Focus foco = new Focus();
        Email email = new Email();
        RecuperarSenha recuSen = new RecuperarSenha();
        string cod;
        public frmRecuperarSenha(frmPrincipal contexto)
        {
            InitializeComponent();
            this.contexto = contexto;
            this.StyleManager = metroStyleManager;
            
        }

        private void mtxtEmail_Enter(object sender, EventArgs e)
        {
            foco.foco(mtxtEmail, "Email");
        }
        private void mtxtEmail_Leave(object sender, EventArgs e)
        {
            foco.foraDeFoco(mtxtEmail, "Email");
        }
        private void mtxtCodigo_Enter(object sender, EventArgs e)
        {
            foco.foco(mtxtCodigo, "Código de recuperação");
        }
        private void mtxtCodigo_Leave(object sender, EventArgs e)
        {
            foco.foraDeFoco(mtxtCodigo, "Código de recuperação");
        }
        private void mtxtSenha_Enter(object sender, EventArgs e)
        {
            foco.foco(mtxtSenha, "Senha");
        }
        private void mtxtSenha_Leave(object sender, EventArgs e)
        {
            foco.foraDeFoco(mtxtSenha, "Senha");
        }
        private void mtxtConfirmaSenha_Enter(object sender, EventArgs e)
        {
            foco.foco(mtxtConfirmaSenha, "Senha");
        }
        private void mtxtConfirmaSenha_Leave(object sender, EventArgs e)
        {
            foco.foraDeFoco(mtxtConfirmaSenha, "Senha");
        }

        private void frmRecuperarSenha_Load(object sender, EventArgs e)
        {
            form.correcaoInicialForm(this);    
        }

        private void mbtnProximo1_Click(object sender, EventArgs e)
        {
            
            mtxtCodigo.Focus();
            Random r = new Random();
            int valor = r.Next(1500, 2000);
            string data = DateTime.Now.ToShortDateString(), hora = DateTime.Now.ToShortTimeString();
            cod = data + hora + valor;
            
            if(recuSen.recuperarSenha1(mtxtEmail.Text,cod))
            {
            email.enviarEmail(contexto, mtxtEmail.Text, "Recuperação de senha, do Fast Beats", "Seu código de recuperação de senha é:\n\n                  " + cod + "\n\ncopie este código e cole no local indicado no sistema para prosseguir com a recuperação de senha\n\n Fast Beats");
            MetroMessageBox.Show(contexto, "Email de recuperação enviado! \n verifique sua caixa de email","Enviado com Sucesso!");
            mpanel2Confirmacao.Visible = true;
            }
            else
            {
                MetroMessageBox.Show(contexto, "Email não cadastrado! certifique-se o email foi digitado corretamente. ", "Email Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void mlinkJaPossueCod_Click(object sender, EventArgs e)
        {
            mpanel2Confirmacao.Visible = true;
        }

        private void mTileVoltar_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin(contexto);

            form.chamarFrm(contexto, login);
            login.metroStyleManager.Theme = contexto.metroStyleManager.Theme;
            login.metroStyleManager.Style = contexto.metroStyleManager.Style;
            this.Close();
        }

        private void mbtnProximo2_Click(object sender, EventArgs e)
        {
            if (recuSen.recuperarSenha2(mtxtCodigo.Text))
            {
                mpainel3Senha.Visible = true;
            }
            else
            {
                MetroMessageBox.Show(contexto, "Código Inválido, certifique que copiou o codigo corretamente.", "Código Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mtxtConfirmaSenha_TextChanged(object sender, EventArgs e)
        {
            if (mtxtSenha.Text != mtxtConfirmaSenha.Text)
            {
                mlblAvisos.Text = "As senhas não conferem";
            }
            else 
            {

                mlblAvisos.Text = "";
            }
        }

        private void mbtnConcluir_Click(object sender, EventArgs e)
        {
            if ((mtxtSenha.Text == mtxtConfirmaSenha.Text)||(mtxtSenha.Text == ""))
            {
                recuSen.recuperarSenha3(mtxtSenha.Text, mtxtCodigo.Text);
                MetroMessageBox.Show(contexto, "", "Senha alterada com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }
            else
            {
                MetroMessageBox.Show(contexto, "", "Senhas não conferem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

     


    }
}
