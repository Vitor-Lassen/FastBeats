using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using FastBeats.Utilities;
using FastBeats.DB;

namespace FastBeats.DB
{
    class Recepcao
    {
        Conexao con = new Conexao();
        public int cadRecepcao(string cpfFun, string descricao, string preco, string data, int codAgen)
        {
            SqlCommand cmd = new SqlCommand("insert into TB_RECEPCAO values (@cpfFun,@descricao,@preco,@data,@codAgen)", con.conectarBD());
            cmd.Parameters.Add("@cpfFun", SqlDbType.VarChar).Value = cpfFun;
            cmd.Parameters.Add("@descricao", SqlDbType.VarChar).Value = descricao;
            cmd.Parameters.Add("@preco", SqlDbType.VarChar).Value = preco;
            cmd.Parameters.Add("@data", SqlDbType.VarChar).Value = data;
            cmd.Parameters.Add("@codAgen", SqlDbType.VarChar).Value = codAgen;
            cmd.ExecuteNonQuery();

            con.desconectarBD();

            SqlDataAdapter da = new SqlDataAdapter("select max(COD_RECEPCAO) from TB_RECEPCAO", con.conectarBD());
            con.desconectarBD();
            DataSet ds = new DataSet();
            da.Fill(ds);
            return Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[0].ToString());

        }
      

    }
}
