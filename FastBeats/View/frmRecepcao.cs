using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastBeats.Utilities;
using FastBeats.DB;

namespace FastBeats.View
{
    public partial class frmRecepcao : MetroFramework.Forms.MetroForm
    {
        
        frmPrincipal contexto = new frmPrincipal();
        OperacoesForm forms = new OperacoesForm();
        Temas temas = new Temas();
        Cliente cli = new Cliente();
        Agenda agen = new Agenda();
        DataSet dsAgen = new DataSet();
        Recepcao recep = new Recepcao();
        Comanda coman = new Comanda();
        PropriedadesTextBox propTXT = new PropriedadesTextBox();
        public frmRecepcao(frmPrincipal contexto)
        {
            InitializeComponent();
            this.contexto = contexto;
            this.StyleManager = metroStyleManager;
            
        }

        public frmRecepcao()
        {
            // TODO: Complete member initialization
        }

        private void mTileVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal voltar = new frmMenuPrincipal(contexto);

            forms.chamarFrm(contexto, voltar);
            voltar.metroStyleManager.Theme = contexto.metroStyleManager.Theme;
            voltar.metroStyleManager.Style = contexto.metroStyleManager.Style;
            this.Close();
            mlblAvisos.Text = "";

        }

        private void frmRecepção_Load(object sender, EventArgs e)
        {
            forms.correcaoInicialForm(this);
            temas.temaComponente(cboClientes,contexto.numTema);
            temas.temaComponente(mskCPF,contexto.numTema);
            cboClientes.DataSource = cli.consCliente().Tables[0];
            cboClientes.DisplayMember = "NOME_CLI";
            cboClientes.ValueMember = "CPF_CLI";
            
            cboClientes.SelectedIndex = -1;
            mskCPF.Clear();

            propTXT.aplicarDinheiro(mtxtValor);

        }

        private void cboClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                mskCPF.Text = cboClientes.SelectedValue.ToString();
            }
            catch
            {

            }
           
        }

        private void cboClientes_TextChanged(object sender, EventArgs e)
        {
            mskCPF.Clear();
        }

        private void mcboIngresso_SelectedIndexChanged(object sender, EventArgs e)
        {
            dsAgen = agen.consPrecos(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString());
            if (dsAgen.Tables[0].Rows.Count > 0)
            {
                if (mcboIngresso.SelectedIndex == 0)
                {
                    mtxtValor.Text = Convert.ToDecimal(
                        dsAgen.Tables[0].Rows[0].ItemArray[3].ToString()).ToString("#.##");
                }
                else if (mcboIngresso.SelectedIndex == 1)
                {
                    mtxtValor.Text = Convert.ToDecimal(
                        dsAgen.Tables[0].Rows[0].ItemArray[5].ToString()).ToString("#.##");
                }
                else if (mcboIngresso.SelectedIndex == 2)
                {
                    mtxtValor.Text = Convert.ToDecimal(
                        dsAgen.Tables[0].Rows[0].ItemArray[2].ToString()).ToString("#.##");
                }
                else if (mcboIngresso.SelectedIndex == 3)
                {
                    mtxtValor.Text = Convert.ToDecimal(
                        dsAgen.Tables[0].Rows[0].ItemArray[4].ToString()).ToString("#.##");
                }
                mtxtValor.Text = double.Parse(mtxtValor.Text).ToString("C2");
                mlblAvisos.Text = "";
            }
            else
           {
               mlblAvisos.Text = "nenhum evento programado.";
          
                   
                    mcboIngresso.SelectedIndex = -1;
            }
        }

        private void mbnFinalizar_Click(object sender, EventArgs e)
        {
            if ((mcboIngresso.SelectedIndex != -1)&&(mtxtComanda.Text !=""))
            {
                if (coman.codUtilidadeComanda(Convert.ToInt32(mtxtComanda.Text)) == 0)
                {
                    if (coman.consCodComanda(Convert.ToInt32(mtxtComanda.Text)))
                    {
                        propTXT.tirarMascara(mtxtValor);
                        int codRecep = recep.cadRecepcao(contexto.cpf, mcboIngresso.Text, mtxtValor.Text, DateTime.Now.ToShortDateString(), Convert.ToInt32(dsAgen.Tables[0].Rows[0].ItemArray[0].ToString()));

                        coman.cadUtiComanda(Convert.ToInt32(mtxtComanda.Text), mskCPF.Text, codRecep, mPanel, contexto);
                        mlblAvisos.Text = "";
                    }
                    else
                    {
                        mlblAvisos.Text = "Comanda Inválida";
                    }
                }
                else
                {
                    mlblAvisos.Text = "Comanda sendo usada.";
                }
            }
            else
            {
                mlblAvisos.Text = "Os campos com * são obrigatórios.";
            }
        }

        private void mTileAddComanda_Click(object sender, EventArgs e)
        {
            frmComanda comanda = new frmComanda(this,contexto);
            

            comanda.metroStyleManager.Theme = contexto.metroStyleManager.Theme;
            comanda.metroStyleManager.Style = contexto.metroStyleManager.Style;
            comanda.ShowDialog();
            mlblAvisos.Text = "";

        }

       

  


    }
}
