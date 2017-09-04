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
    public partial class frmFormaPagamento : MetroFramework.Forms.MetroForm
    {
        Pagamento pgto = new Pagamento();
        frmPagamento contextoPgto = new frmPagamento();
        public frmFormaPagamento(frmPagamento contextoPgto)
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager;
            this.contextoPgto = contextoPgto;
        }

        private void mtxtFormaPgto_TextChanged(object sender, EventArgs e)
        {
          mdgvFormaPgto.DataSource=   pgto.consPagamento(mtxtFormaPgto.Text).Tables[0];
          if (pgto.consPagamentoC(mtxtFormaPgto.Text) <= 0)
          {
              mbtnCadastrar.Visible = true;
          }
          else
          {
              mbtnCadastrar.Visible = false;
          }
        }

        private void mTileVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mbtnCadastrar_Click(object sender, EventArgs e)
        {
            pgto.cadFormaPagamento(mtxtFormaPgto.Text);
            contextoPgto.mcboFormaPgto.DataSource = pgto.consPagamento().Tables[0];
            contextoPgto.mcboFormaPgto.DisplayMember = "FORMA_PAGAMENTO";
            contextoPgto.mcboFormaPgto.ValueMember = "FORMA_PAGAMENTO";
            contextoPgto.mcboFormaPgto.Text = mtxtFormaPgto.Text;
            Close();
        }

        private void frmFormaPagamento_Load(object sender, EventArgs e)
        {
          
        }

      
    }
}
