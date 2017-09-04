using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MetroFramework;


namespace FastBeats.DB
{
    class itemVenda
    {
        Conexao con = new Conexao();
        Limpar limpar = new Limpar();
        public void cadItemVenda(int codUtilidadeComanda, string CPFFun, int codCardapio, int codProd)
        {

            if (codCardapio == 0)
            {
                SqlCommand cmd = new SqlCommand("insert into TB_ITEM_VENDA values (@codUtilidadeComanda,@cpffun,null,@codProd)", con.conectarBD());
                cmd.Parameters.Add("@codUtilidadeComanda", SqlDbType.VarChar).Value = codUtilidadeComanda;
                cmd.Parameters.Add("@cpffun", SqlDbType.VarChar).Value = CPFFun;
                cmd.Parameters.Add("@codProd", SqlDbType.VarChar).Value = codProd;
                cmd.ExecuteNonQuery();
            }
            else if (codProd == 0)
            {
                SqlCommand cmd = new SqlCommand("insert into TB_ITEM_VENDA values (@codUtilidadeComanda,@cpffun,@codCardapio,null)", con.conectarBD());
                cmd.Parameters.Add("@codUtilidadeComanda", SqlDbType.VarChar).Value = codUtilidadeComanda;
                cmd.Parameters.Add("@cpffun", SqlDbType.VarChar).Value = CPFFun;
                cmd.Parameters.Add("@codCardapio", SqlDbType.VarChar).Value = codCardapio;
                cmd.ExecuteNonQuery();
            }

            

        }
        public DataSet consItens(int codUtiComan)
        {
            
            SqlDataAdapter da = new SqlDataAdapter("select * from TB_ITEM_VENDA where COD_UTILIDADE_COMANDA = "+ codUtiComan, con.conectarBD());
            DataSet ds = new DataSet();
            da.Fill(ds);

            con.desconectarBD();
            return ds;

        
        }


    }
}
