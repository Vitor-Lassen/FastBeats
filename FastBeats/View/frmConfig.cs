using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastBeats.View;
using FastBeats.DB;
using MetroFramework;


namespace FastBeats.View
{
    public partial class frmConfig : MetroFramework.Forms.MetroForm
    {
        frmPrincipal contexto = new frmPrincipal();
        OperacoesForm forms = new OperacoesForm();
        Temas temas = new Temas();
        FunLoginTema flt = new FunLoginTema();// flg iniciais da CLASSE!!!!
        int numTema,numCor;
        string cpf;
        public frmConfig(frmPrincipal contexto)
        {
            this.contexto = contexto;
            InitializeComponent();
            this.StyleManager = metroStyleManager;
            cpf = contexto.cpf;
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            forms.correcaoInicialForm(this);
            numCor = contexto.numCor;
            numTema = contexto.numTema;
            mcboCor.Text = temas.cores(numCor);
            mcboTema.Text = temas.tema(numTema);
            
            
        }

      
        private void mcboTema_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (mcboTema.SelectedIndex == 0)
            {
                numTema = 1;
                metroStyleManager.Theme = (MetroThemeStyle)numTema;
                contexto.numTema = 1;
                
            }
            else if (mcboTema.SelectedIndex == 1)
            {
                numTema = 2;
                metroStyleManager.Theme = (MetroThemeStyle)numTema;
                contexto.numTema = 2;
            }
            contexto.metroStyleManager.Theme = this.metroStyleManager.Theme;
            
        }

        private void mbtnConcluido_Click(object sender, EventArgs e)
        {
        }

        private void mcboCor_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
            metroStyleManager.Style = (MetroColorStyle)temas.cores(mcboCor.Text);
            contexto.metroStyleManager.Style = this.metroStyleManager.Style;
        }

        private void mTileVoltar_Click(object sender, EventArgs e)
        {

            flt.configTema(numTema, temas.cores(mcboCor.Text), cpf);
            frmMenuPrincipal principal = new frmMenuPrincipal(contexto);
            forms.chamarFrm(contexto, principal);
            principal.metroStyleManager.Theme = contexto.metroStyleManager.Theme;
            principal.metroStyleManager.Style = contexto.metroStyleManager.Style;
            Close();
        }




        
    }
}
