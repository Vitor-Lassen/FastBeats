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
using MetroFramework;

namespace FastBeats.View
{
    public partial class frmCaixa : MetroFramework.Forms.MetroForm
    {

        frmPrincipal contexto = new frmPrincipal();
        OperacoesForm forms = new OperacoesForm();
        Temas temas = new Temas();
        Comanda coman = new Comanda();
        itemVenda iVenda = new itemVenda();
        Cardapio card = new Cardapio();
        Produto prod = new Produto();

        decimal valorTotal = 0;
        public frmCaixa(frmPrincipal contexto)
        {
            
            InitializeComponent();
            this.contexto = contexto;
            this.StyleManager = metroStyleManager;
        }

        public frmCaixa()
        {
            // TODO: Complete member initialization
        }

        private void frmCaixa_Load(object sender, EventArgs e)
        {
            forms.correcaoInicialForm(this);
        }

        private void mTileVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal voltar = new frmMenuPrincipal(contexto);

            forms.chamarFrm(contexto, voltar);
            voltar.metroStyleManager.Theme = contexto.metroStyleManager.Theme;
            voltar.metroStyleManager.Style = contexto.metroStyleManager.Style;
            this.Close();
        }

        private void mbtnAddComan_Click(object sender, EventArgs e)
        {
            if (mtxtComanda.Text != "")
            {
                bool repetComan = false;
                for (int i = 0; i < mdgvComandas.Rows.Count; i++)
                {
                    if (mdgvComandas.Rows[i].Cells[0].Value.ToString() == mtxtComanda.Text)
                    {
                        repetComan = true;
                    }
                }
                if (repetComan)
                {
                    MetroMessageBox.Show(contexto, "Comanda Já registrada nessa venda \n Não é possivel inserir a mesma comanda mais de uma vez na mesma Venda", "Comanda já Registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        int codUtiComan = coman.codUtilidadeComanda(Convert.ToInt32(mtxtComanda.Text));
                        
                        mdgvComandas.Rows.Add(mtxtComanda.Text, codUtiComan, coman.cliComanda(Convert.ToInt32(mtxtComanda.Text)));
                    DataSet ds = iVenda.consItens(codUtiComan);
                    DataSet dsRecepcao = new DataSet();
                    dsRecepcao = coman.consRecepcao(codUtiComan);
                    mdgvItensVenda.Rows.Add(dsRecepcao.Tables[0].Rows[0].ItemArray[2].ToString(), Convert.ToDecimal(dsRecepcao.Tables[0].Rows[0].ItemArray[3].ToString()).ToString("#.00"));
                        
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        DataSet dsItem = new DataSet();
                        string nomeItem = "";
                        decimal valor = 0;
                        if (ds.Tables[0].Rows[i].ItemArray[3].ToString() != "")
                        {
                            dsItem = card.consCardCod(Convert.ToInt32(ds.Tables[0].Rows[i].ItemArray[3].ToString()));
                            nomeItem = dsItem.Tables[0].Rows[0].ItemArray[1].ToString();
                            valor = Convert.ToDecimal(dsItem.Tables[0].Rows[0].ItemArray[2].ToString());
                        }
                        else if (ds.Tables[0].Rows[i].ItemArray[4].ToString() != "")
                        {
                            dsItem = prod.consProdCod(Convert.ToInt32(ds.Tables[0].Rows[i].ItemArray[4].ToString()));
                            nomeItem = dsItem.Tables[0].Rows[0].ItemArray[1].ToString();
                            valor = Convert.ToDecimal(dsItem.Tables[0].Rows[0].ItemArray[5].ToString());
                        }
                        mdgvItensVenda.Rows.Add(nomeItem, valor.ToString("#.00"));
                       
                        
                    }
                    decimal valorUnit = 0;
                    for (int i = 0; i < mdgvItensVenda.Rows.Count; i++)
                    {
                        valorUnit = Convert.ToDecimal(mdgvItensVenda.Rows[i].Cells[1].Value);
                        valorTotal += valorUnit;
                        mtxtValorTotal.Text = valorTotal.ToString();
                                              
                    }
                    mtxtValorTotal.Text = double.Parse(mtxtValorTotal.Text).ToString("C2");
                    mlblAvisos.Text = "";
                    }
                    catch
                    {
                        mlblAvisos.Text = "A comanda de número: " + mtxtComanda.Text + " não está ativa.";
                    }
                    mtxtComanda.Clear();
                }
            }
            else
            {
                mlblAvisos.Text = "Digite o numero da comanda.";
            }

        }

        private void mbtnFinalizar_Click(object sender, EventArgs e)
        {
            if (mdgvComandas.Rows.Count > 0)
            {
                frmPagamento pgto = new frmPagamento(this, contexto);
                pgto.mtxtValorTotal.Text = mtxtValorTotal.Text;
                pgto.metroStyleManager.Theme = this.metroStyleManager.Theme;
                pgto.metroStyleManager.Style = this.metroStyleManager.Style;
                pgto.ShowDialog();
                mlblAvisos.Text = "";
            }
            else
            {
                mlblAvisos.Text = "Para prosseguir adicione uma comanda.";
            }
        }

      

      
    }
}
