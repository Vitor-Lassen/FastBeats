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
using System.Data.SqlClient;

namespace FastBeats.View
{
    public partial class frmAgenda : MetroFramework.Forms.MetroForm

    {
        frmPrincipal contexto = new frmPrincipal();
        OperacoesForm forms = new OperacoesForm();
        Temas temas = new Temas();
        Agenda agen = new Agenda();
        Artista art = new Artista();
        Limpar limpar = new Limpar();

        DataSet dsArtista = new DataSet();
        DataSet dsAgenda = new DataSet();
        
        
         public int  codEvento;

        public frmAgenda(frmPrincipal contexto)
        {
            InitializeComponent();
            this.contexto = contexto;
            this.StyleManager = metroStyleManager;
        }

        public frmAgenda()
        {
            // TODO: Complete member initialization
        }

        private void frmAgenda_Load(object sender, EventArgs e)
        {
            forms.correcaoInicialForm(this);
            temas.temaComponente(cboArtista,contexto.numTema);
            temas.temaComponente(numHoraIni, contexto.numTema);
            temas.temaComponente(numHoraTer, contexto.numTema);
            temas.temaComponente(numMinIni, contexto.numTema);
            temas.temaComponente(numMinTer, contexto.numTema);

            
            cboArtista.DataSource = art.consArtista().Tables[0];
            cboArtista.DisplayMember = "ARTISTA";
            cboArtista.ValueMember = "COD_ARTISTA";

            dsArtista.Tables.Add();
            dsArtista.Tables[0].Columns.Add();
            dsAgenda.Tables.Add();
            dsAgenda.Tables[0].Columns.Add();

          

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

        private void mbtnCadastrar_Click(object sender, EventArgs e)
        {
            if (mtxtEvento.Text != "")
            {
                codEvento = agen.cadEvento(mtxtEvento.Text, mtxtDescricao.Text, mdtpData.Value);
                for (int i = 0; i < mdgvArtista.Rows.Count; i++)
                {
                    agen.cadEventoArt(Convert.ToInt32(mdgvArtista.Rows[i].Cells[0].Value.ToString()), codEvento);
                }
                for (int i = 0; i < mdgvAgenda.Rows.Count; i++)
                {
                    agen.cadAgenda(codEvento.ToString(), mdgvAgenda.Rows[i].Cells[0].Value.ToString().Replace(",", "."), mdgvAgenda.Rows[i].Cells[1].Value.ToString().Replace(",", "."), mdgvAgenda.Rows[i].Cells[2].Value.ToString().Replace(",", "."), mdgvAgenda.Rows[i].Cells[3].Value.ToString().Replace(",", "."), mdgvAgenda.Rows[i].Cells[4].Value.ToString().Replace(",", "."), mdgvAgenda.Rows[i].Cells[5].Value.ToString().Replace(",", "."));
                }
                MetroMessageBox.Show(contexto, "Agenda Cadastrada Com Sucesso!", "Cadastro Efetuado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                limpar.limpar(mPanel);
                limpar.limpar(mPanel1);
                mlblAvisos.Text = "";

            }
            else
            {
                mlblAvisos.Text = "Os campos com * são obrigatórios!";
            }

        }

        private void mbtnAdicionar_Click(object sender, EventArgs e)
        {
            if (mtxtEvento.Text != "")
            {
                bool repetArt = false;
                for (int i = 0; i < mdgvArtista.Rows.Count; i++)
                {
                    if (mdgvArtista.Rows[i].Cells[1].Value.ToString() == cboArtista.Text)
                    {
                        repetArt = true;
                    }
                }
                if (repetArt)
                {
                    mlblAvisos.Text = "Artista já Cadastrado no evento!";
                }
                else
                {
                    DataSet ds = new DataSet();
                    ds = art.consArtistaAgenda(cboArtista.Text);
                    mdgvArtista.Rows.Add(ds.Tables[0].Rows[0].ItemArray[0].ToString(), cboArtista.Text, ds.Tables[0].Rows[0].ItemArray[4].ToString());
                    mlblAvisos.Text = "";
                }
            }
            else
            {
                mlblAvisos.Text = "Os campos com * são obrigatórios!";
            }

          
        }

        private void mbtnConsultar_Click(object sender, EventArgs e)
        {
            frmConsultarAgenda consAgenda = new frmConsultarAgenda(contexto, this);
            forms.chamarFrm(contexto, consAgenda);
            consAgenda.metroStyleManager.Theme = contexto.metroStyleManager.Theme;
            consAgenda.metroStyleManager.Style = contexto.metroStyleManager.Style;
            limpar.limpar(mPanel);
            limpar.limpar(mPanel1);
            mlblAvisos.Text = "";

        }

        private void mbtnAdicionar2_Click(object sender, EventArgs e)
        {
            string hora, minuto, horaF, minutoF;
           
            if (numHoraIni.Value <= 9)
            {
                hora = "0" + numHoraIni.Value.ToString();

            }
            else
            {
                hora = numHoraIni.Value.ToString();
            }
            if (numHoraTer.Value <= 9)
            {
                horaF = "0" + numHoraTer.Value.ToString();

            }
                else
            {
                horaF = numHoraTer.Value.ToString();
            }
           
            if (numMinIni.Value <= 9)
            {
                minuto = "0" + numMinIni.Value.ToString();

            }
            else
            {
                minuto = numMinIni.Value.ToString();
            }
            if (numMinTer.Value <= 9)
            {
                minutoF = "0" + numMinTer.Value.ToString();

            }
            else
            {
                minutoF = numMinTer.Value.ToString();
            }

            if ((mtxtMulherP.Text != "") && (mtxtMulherV.Text != "") && (mtxtHomemP.Text != "") && (mtxtHomemV.Text != "") && (numHoraIni.Value.ToString() + ":" + numMinIni.Value.ToString() != "") && (numHoraTer.Value.ToString() + ":" + numMinTer.Value.ToString() != "") && (mdtpDataInicio.Text != "") && (mdtpDataTermino.Text != ""))
            {
                mdgvAgenda.Rows.Add(Convert.ToDecimal(mtxtHomemV.Text).ToString("#.00"), Convert.ToDecimal(mtxtHomemP.Text).ToString("#.00"), Convert.ToDecimal(mtxtMulherV.Text).ToString("#.00"), Convert.ToDecimal(mtxtMulherP.Text).ToString("#.00"), mdtpDataInicio.Text + " " + hora + ":" + minuto, mdtpDataTermino.Text + " " + horaF + ":" + minutoF);

            }
            else
            {
                mlblAvisos.Text = "Os campos com * são obrigatórios!";
            }
           
        }

        private void mbtnAtualizar_Click(object sender, EventArgs e)
        {
            agen.atuaEvento(mtxtEvento.Text, mtxtDescricao.Text, mdtpData.Value, codEvento);
            for (int i = 0; i < dsArtista.Tables[0].Rows.Count; i++)
            {
                agen.delEventoArt(Convert.ToInt32(dsArtista.Tables[0].Rows[i].ItemArray[0].ToString()));
                dsArtista.Tables[0].Rows.RemoveAt(i);
            }
            for (int i = 0; i < mdgvArtista.Rows.Count; i++)
            {
                if (mdgvArtista.Rows[i].Cells[3].Value == null)
                {
                    agen.cadEventoArt(Convert.ToInt32(mdgvArtista.Rows[i].Cells[0].Value), codEvento);
                }
            }
            for (int i = 0; i < dsAgenda.Tables[0].Rows.Count; i++)
            {
                agen.delAgenda(Convert.ToInt32(dsAgenda.Tables[0].Rows[i].ItemArray[0].ToString()));
                dsAgenda.Tables[0].Rows.RemoveAt(i);
            }
            for (int i = 0; i < mdgvAgenda.Rows.Count; i++)
            {
                if (mdgvAgenda.Rows[i].Cells[6].Value == null)
                {
                    agen.cadAgenda(codEvento.ToString(), mdgvAgenda.Rows[i].Cells[0].Value.ToString().Replace(",", "."), mdgvAgenda.Rows[i].Cells[1].Value.ToString().Replace(",", "."), mdgvAgenda.Rows[i].Cells[2].Value.ToString().Replace(",", "."), mdgvAgenda.Rows[i].Cells[3].Value.ToString().Replace(",", "."), mdgvAgenda.Rows[i].Cells[4].Value.ToString().Replace(",", "."), mdgvAgenda.Rows[i].Cells[5].Value.ToString().Replace(",", "."));
                }
            }
            limpar.limpar(mPanel);
            limpar.limpar(mPanel1);
            mlblAvisos.Text = "";

            MetroMessageBox.Show(contexto, "Agenda Atualizada Com Sucesso!", "Altereções Salvas", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void mbtnNovo_Click(object sender, EventArgs e)
        {
            limpar.limpar(mPanel1);
            limpar.limpar(mPanel);
            mlblAvisos.Text = "";
            mbtnAtualizar.Visible = false;
            mbtnNovo.Visible = false;
            mbtnCadastrar.Visible = true;

        }

        private void mdgvArtista_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (mdgvArtista.CurrentRow.Cells[3].Value != null)
            {
                
                dsArtista.Tables[0].Rows.Add(mdgvArtista.CurrentRow.Cells[3].Value.ToString());
            }
            
        }

        private void mdgvAgenda_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (mdgvAgenda.CurrentRow.Cells[6].Value != null)
            {

                dsAgenda.Tables[0].Rows.Add(mdgvAgenda.CurrentRow.Cells[6].Value.ToString());
            }
        }

       
    }
}
