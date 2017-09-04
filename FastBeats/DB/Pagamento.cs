using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MetroFramework;
using System.Windows.Forms;
using FastBeats.View;
using FastBeats.DB;

namespace FastBeats.DB
{
    class Pagamento
    {
        Conexao con = new Conexao();
        public DataSet consPagamento()
        {
            SqlDataAdapter da = new SqlDataAdapter("select*from TB_FORMA_PAGAMENTO", con.conectarBD());
            DataSet ds = new DataSet();
            da.Fill(ds);

            con.desconectarBD();
            return ds;

        }
        public DataSet consPagamento(string formaPgto)
        {
            SqlDataAdapter da = new SqlDataAdapter("select FORMA_PAGAMENTO as 'Forma de Pagamento' from TB_FORMA_PAGAMENTO where FORMA_PAGAMENTO LIKE '%" + formaPgto + "%'", con.conectarBD());
            DataSet ds = new DataSet();
            da.Fill(ds);

            con.desconectarBD();
            return ds;

        }
        public int consPagamentoC(string formaPgto)
        {
            SqlDataAdapter da = new SqlDataAdapter("select FORMA_PAGAMENTO as 'Forma de Pagamento' from TB_FORMA_PAGAMENTO where FORMA_PAGAMENTO = '" + formaPgto +"'", con.conectarBD());
            DataSet ds = new DataSet();
            da.Fill(ds);

            con.desconectarBD();
            return Convert.ToInt32(ds.Tables[0].Rows.Count.ToString());
            

        }

        public void cadFormaPagamento(string formaPgto)
        {
            SqlCommand cmd = new SqlCommand("insert into  TB_FORMA_PAGAMENTO values (@FormaPgto)", con.conectarBD());
            cmd.Parameters.Add("@FormaPgto", SqlDbType.VarChar).Value = formaPgto;
            cmd.ExecuteNonQuery();

            con.desconectarBD();
        }
        public void cadPagamento(string formaPgto, double valor, int codCaixa)
        {
            SqlCommand cmd = new SqlCommand("insert into  TB_PAGAMENTO values (@formaPgto,@valor,@codCaixa)", con.conectarBD());
            cmd.Parameters.Add("@formaPgto", SqlDbType.VarChar).Value = formaPgto;
            cmd.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor;
            cmd.Parameters.Add("@codCaixa", SqlDbType.VarChar).Value = codCaixa;
            cmd.ExecuteNonQuery();

            con.desconectarBD();
        }


 
    }
}
