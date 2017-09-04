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
    class RecuperarSenha
    {
        Conexao con = new Conexao();
        Limpar limpar = new Limpar();
        public bool recuperarSenha1(string email, string cod)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from  TB_FUNCIONARIO where EMAIL = '" + email + "'", con.conectarBD());
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                string cpf = ds.Tables[0].Rows[0].ItemArray[0].ToString();
                SqlCommand cmd = new SqlCommand("update TB_LOGIN set RECUP_SENHA=@cod where CPF_FUNC=@cpf ", con.conectarBD());
                cmd.Parameters.Add("@cod", SqlDbType.VarChar).Value = cod;
                cmd.Parameters.Add("@cpf", SqlDbType.VarChar).Value = cpf;
                cmd.ExecuteNonQuery();
                return true;
            }
            con.desconectarBD();
            return false;

        }
        public bool recuperarSenha2(string cod)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from  TB_LOGIN where RECUP_SENHA = '" + cod + "'", con.conectarBD());
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        public void recuperarSenha3(string senha, string cod)
        {
            SqlCommand cmd = new SqlCommand("update TB_LOGIN set SENHA=@senha,RECUP_SENHA= null where RECUP_SENHA=@cod ", con.conectarBD());
            cmd.Parameters.Add("@cod", SqlDbType.VarChar).Value = cod;
            cmd.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;
            cmd.ExecuteNonQuery();
        }
    }
}
