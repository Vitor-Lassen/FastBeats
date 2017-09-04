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
    public partial class frmConsultarAgenda : MetroFramework.Forms.MetroForm
    {
        frmPrincipal contexto = new frmPrincipal();
        OperacoesForm forms = new OperacoesForm();
        Temas temas = new Temas();
        Agenda agen = new Agenda();
        Artista art = new Artista();
        frmAgenda contextoAgenda = new frmAgenda();
        public frmConsultarAgenda(frmPrincipal contexto, frmAgenda contextoAgenda)
        {
            InitializeComponent();
            this.contexto = contexto;
            this.contextoAgenda = contextoAgenda;
            this.StyleManager = metroStyleManager;
        }

        private void frmConsultarAgenda_Load(object sender, EventArgs e)
        {
            forms.correcaoInicialForm(this);
            mtxtEvento_TextChanged(sender, e);

        }

        private void mTileVoltar_Click(object sender, EventArgs e)
        {
            Close();
            forms.retornarFrm(contexto);
        }

        private void mtxtEvento_TextChanged(object sender, EventArgs e)
        {
            mdgvEventos.DataSource = agen.consEventoNome(mtxtEvento.Text).Tables[0];

        }

        private void mdgvEventos_DoubleClick(object sender, EventArgs e)
        {
            int codEvento = agen.consEventoCodigo(mdgvEventos.CurrentRow.Cells[0].Value.ToString(), mdgvEventos.CurrentRow.Cells[2].Value.ToString());
            contextoAgenda.codEvento = codEvento;
            contextoAgenda.mtxtEvento.Text = mdgvEventos.CurrentRow.Cells[0].Value.ToString();
            contextoAgenda.mtxtDescricao.Text = mdgvEventos.CurrentRow.Cells[1].Value.ToString();
            contextoAgenda.mdtpData.Text = mdgvEventos.CurrentRow.Cells[2].Value.ToString();
            DataSet ds = new DataSet();
            ds = agen.consEventoArtista(codEvento);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                int codArtista = Convert.ToInt32(ds.Tables[0].Rows[i].ItemArray[1].ToString());
                DataSet ds1 = new DataSet();
                ds1 = art.consArtista(codArtista);
                contextoAgenda.mdgvArtista.Rows.Add(ds1.Tables[0].Rows[0].ItemArray[0].ToString(), ds1.Tables[0].Rows[0].ItemArray[1].ToString(), ds1.Tables[0].Rows[0].ItemArray[4].ToString(), ds.Tables[0].Rows[i].ItemArray[0].ToString());
            }
            ds = agen.consAgendaEvento(codEvento);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                contextoAgenda.mdgvAgenda.Rows.Add(ds.Tables[0].Rows[i].ItemArray[2].ToString(), ds.Tables[0].Rows[i].ItemArray[3].ToString(), ds.Tables[0].Rows[i].ItemArray[4].ToString(), ds.Tables[0].Rows[i].ItemArray[5].ToString(), ds.Tables[0].Rows[i].ItemArray[6].ToString(), ds.Tables[0].Rows[i].ItemArray[7].ToString(), ds.Tables[0].Rows[i].ItemArray[0].ToString(), ds.Tables[0].Rows[i].ItemArray[1].ToString());
            }


               
                contextoAgenda.mbtnAtualizar.Visible = true;
            contextoAgenda.mbtnNovo.Visible = true;
            contextoAgenda.mbtnCadastrar.Visible = false;
            Close();
            forms.retornarFrm(contexto);
        }

        private void mdtpData_ValueChanged(object sender, EventArgs e)
        {
            mdgvEventos.DataSource = agen.consEventoData(mdtpData.Value).Tables[0];
        }

    }
}
