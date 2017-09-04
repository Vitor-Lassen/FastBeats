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


namespace FastBeats.View
{
    public partial class frmConsultarCliente :MetroFramework.Forms.MetroForm
    {
        frmPrincipal contexto = new frmPrincipal();
        OperacoesForm forms = new OperacoesForm();
        Temas temas = new Temas();
        Cliente cli = new Cliente();
        frmClientes contextoCli = new frmClientes();
        public frmConsultarCliente(frmPrincipal contexto,frmClientes contextoCli)
        {
            InitializeComponent();
            this.contexto = contexto;
            this.contextoCli = contextoCli;
            this.StyleManager = metroStyleManager;
        }

        private void frmConsultarCliente_Load(object sender, EventArgs e)
        {
            forms.correcaoInicialForm(this);
            temas.temaComponente(mskCPF, contexto.numTema);
            mtxtNome_TextChanged(sender, e);
        }

        private void mTileVoltar_Click(object sender, EventArgs e)
        {
            
            Close();
            forms.retornarFrm(contexto);
        }

        private void mtxtNome_TextChanged(object sender, EventArgs e)
        {

            mdgvClientes.DataSource = cli.consCliente(mtxtNome.Text).Tables[0];
            
            
                
            
        }

        private void mskCPF_TextChanged(object sender, EventArgs e)
        {
            mdgvClientes.DataSource = cli.consClienteCPF(mskCPF.Text).Tables[0];
           
                
            
        }

        private void mdgvClientes_DoubleClick(object sender, EventArgs e)
        {
            contextoCli.mskCPF.ReadOnly = true;
            contextoCli.mskCPF.Text= mdgvClientes.CurrentRow.Cells[0].Value.ToString();
            contextoCli.mtxtNome.Text = mdgvClientes.CurrentRow.Cells[1].Value.ToString();
            contextoCli.mtxtRG.Text = mdgvClientes.CurrentRow.Cells[2].Value.ToString();
            contextoCli.mskTel.Text = mdgvClientes.CurrentRow.Cells[3].Value.ToString();
            contextoCli.mskCel.Text = mdgvClientes.CurrentRow.Cells[4].Value.ToString();
            contextoCli.mbtnAtualizar.Visible = true;
            contextoCli.mbtnNovo.Visible = true;
            contextoCli.mbtnCadastrar.Visible = false;
            Close();
            forms.retornarFrm(contexto);
        }

        private void mtxtNome_Enter(object sender, EventArgs e)
        {
            mskCPF.Clear();
        }

        private void mskCPF_Enter(object sender, EventArgs e)
        {
            mtxtNome.Clear();
        }




   
    }
}
