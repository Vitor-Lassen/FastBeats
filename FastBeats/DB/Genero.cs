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
    class Genero
    {
        Conexao con = new Conexao();
        Limpar limpar = new Limpar();
        public void cadGenero(string genero)
        {
            SqlCommand cmd = new SqlCommand("insert into TB_GENERO values (@genero)", con.conectarBD());
            cmd.Parameters.Add("@genero", SqlDbType.VarChar).Value = genero;
            cmd.ExecuteNonQuery();

            con.desconectarBD();

        }
        public DataSet consGenero()
        {
            SqlDataAdapter da = new SqlDataAdapter("select*from TB_GENERO", con.conectarBD());
            DataSet ds = new DataSet();
            da.Fill(ds);

            con.desconectarBD();
            return ds;

        }
    }
}
