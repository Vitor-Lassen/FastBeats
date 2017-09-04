using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Components;
using MetroFramework;
using FastBeats.View;


namespace FastBeats.View
{
    public partial class frmMenuPrincipal : MetroFramework.Forms.MetroForm
    {
       public MetroStyleManager msm8;
        frmPrincipal contexto = new frmPrincipal();
        OperacoesForm forms = new OperacoesForm();
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        public frmMenuPrincipal(frmPrincipal contexto)
        {
            // TODO: Complete member initialization
            this.contexto = contexto;

            InitializeComponent();
            this.StyleManager = metroStyleManager;
            if (contexto.mlblNivel.Text == "Bar") {
                mTileAgenda.Visible = false;
                mTileArtistas.Visible = false;
                mTileCaixa.Visible = false;
                mTileClientes.Visible = false;
                mTileFuncionarios.Visible = false;
                mTileRecepcao.Visible = false;
                mTileRelatorios.Visible = false;

            }
            else if (contexto.mlblNivel.Text == "Atendente")
            {
                mTileAgenda.Visible = false;
                mTileArtistas.Visible = false;
                mTileProdutos.Visible = false;
                mTileClientes.Visible = false;
                mTileFuncionarios.Visible = false;
                mTileCardapio.Visible = false;
                mTileVenda.Visible = false;
                mTileRelatorios.Visible = false;
                
            }
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            
                forms.correcaoInicialForm(this);
                if (contexto.numTema == 1)
                {
                    picBoxIcone.Image = Properties.Resources.icone;
                }
                else
                {
                    picBoxIcone.Image = Properties.Resources.icone_branco0;
                }
            
        }

        private void metroTileLogoff_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(contexto, "Deseja fazer o logoff?", "Logoff", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                frmLogin login = new frmLogin(contexto);
                forms.chamarFrm(contexto, login);
                contexto.metroStyleManager.Theme = (MetroThemeStyle)1;
                contexto.metroStyleManager.Style = (MetroColorStyle)4;
                contexto.mlblNivel.Text = "";
                contexto.mlblNome.Text = "";
                login.metroStyleManager.Theme = contexto.metroStyleManager.Theme;
                login.metroStyleManager.Style = contexto.metroStyleManager.Style;
                contexto.mlblNivel.Text = "";
                contexto.mlblNome.Text = "";
                this.Close();
            }

        }

        private void metroTileConfig_Click(object sender, EventArgs e)
        {
            frmConfig config = new frmConfig (contexto);
            forms.chamarFrm(contexto, config);
            config.metroStyleManager.Theme = contexto.metroStyleManager.Theme;
            config.metroStyleManager.Style = contexto.metroStyleManager.Style;
            Close();

        }

        private void mTileFuncionarios_Click(object sender, EventArgs e)
        {
            frmFuncionario func = new frmFuncionario(contexto);
            forms.chamarFrm(contexto, func);
            func.metroStyleManager.Theme = contexto.metroStyleManager.Theme;
            func.metroStyleManager.Style = contexto.metroStyleManager.Style;
            Close();
        }

        private void mTileClientes_Click(object sender, EventArgs e)
        {
            frmClientes cli = new frmClientes(contexto);
            forms.chamarFrm(contexto, cli);
            cli.metroStyleManager.Theme = contexto.metroStyleManager.Theme;
            cli.metroStyleManager.Style = contexto.metroStyleManager.Style;
            Close();
        }

        private void mTileArtistas_Click(object sender, EventArgs e)
        {
            frmArtistas art = new frmArtistas(contexto);
            forms.chamarFrm(contexto, art);
            art.metroStyleManager.Theme = contexto.metroStyleManager.Theme;
            art.metroStyleManager.Style = contexto.metroStyleManager.Style;
            Close();
        }

        private void mTileProdutos_Click_1(object sender, EventArgs e)
        {
            frmProdutos prod = new frmProdutos(contexto);
            forms.chamarFrm(contexto, prod);
            prod.metroStyleManager.Theme = contexto.metroStyleManager.Theme;
            prod.metroStyleManager.Style = contexto.metroStyleManager.Style;
            Close();
        }

        private void mTileVenda_Click(object sender, EventArgs e)
        {
            frmVenda vend = new frmVenda(contexto);
            forms.chamarFrm(contexto, vend);
            vend.metroStyleManager.Theme = contexto.metroStyleManager.Theme;
            vend.metroStyleManager.Style = contexto.metroStyleManager.Style;
            Close();
        }

        private void mTileCardapio_Click(object sender, EventArgs e)
        {
            frmCardapio card = new frmCardapio(contexto);
            forms.chamarFrm(contexto, card);
            card.metroStyleManager.Theme = contexto.metroStyleManager.Theme;
            card.metroStyleManager.Style = contexto.metroStyleManager.Style;
            Close();
        }

        private void mTileCaixa_Click(object sender, EventArgs e)
        {
            frmCaixa caixa = new frmCaixa(contexto);
            forms.chamarFrm(contexto, caixa);
            caixa.metroStyleManager.Theme = contexto.metroStyleManager.Theme;
            caixa.metroStyleManager.Style = contexto.metroStyleManager.Style;
            Close();
        }

        private void mTileAgenda_Click(object sender, EventArgs e)
        {
            frmAgenda agen = new frmAgenda(contexto);
            forms.chamarFrm(contexto, agen);
            agen.metroStyleManager.Theme = contexto.metroStyleManager.Theme;
            agen.metroStyleManager.Style = contexto.metroStyleManager.Style;
            Close();
        }

        private void mTileRecepcao_Click(object sender, EventArgs e)
        {
            frmRecepcao recep = new frmRecepcao(contexto);
            forms.chamarFrm(contexto, recep);
            recep.metroStyleManager.Theme = contexto.metroStyleManager.Theme;
            recep.metroStyleManager.Style = contexto.metroStyleManager.Style;
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmSobre sobre = new frmSobre(contexto);
            forms.chamarFrm(contexto, sobre);
            sobre.metroStyleManager.Theme = contexto.metroStyleManager.Theme;
            sobre.metroStyleManager.Style = contexto.metroStyleManager.Style;
            Close();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            frmRelatorios rela = new frmRelatorios(contexto);
            forms.chamarFrm(contexto, rela);
            rela.metroStyleManager.Theme = contexto.metroStyleManager.Theme;
            rela.metroStyleManager.Style = contexto.metroStyleManager.Style;
            Close();
        }


  

    }
}
