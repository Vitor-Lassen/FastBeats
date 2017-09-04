using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using FastBeats.DB;
using System.Windows.Forms;
using MetroFramework;

namespace FastBeats.DB
{
    class Comanda
    {
        Conexao con = new Conexao();
        Limpar limpar = new Limpar();
         public void cadComanda(int codComanda)
        {
            
                SqlCommand cmd = new SqlCommand("insert into TB_COMANDA values (@codComanda)", con.conectarBD());
                cmd.Parameters.Add("@codComanda", SqlDbType.VarChar).Value = codComanda;
                
                cmd.ExecuteNonQuery();
            }
        public void cadUtiComanda(int codComanda, string cpfCli, int codRecepcao,  Panel p, Form contexto)
        {
            if (cpfCli == "")
            {
                SqlCommand cmd = new SqlCommand("insert into TB_UTILIDADE_COMANDA values (@codComanda,'0',@codRecepcao,null,1)", con.conectarBD());
                cmd.Parameters.Add("@codComanda", SqlDbType.VarChar).Value = codComanda;
                cmd.Parameters.Add("@codRecepcao", SqlDbType.VarChar).Value = codRecepcao;
                cmd.ExecuteNonQuery();
            }
            else
            {
                SqlCommand cmd = new SqlCommand("insert into TB_UTILIDADE_COMANDA values (@codComanda,@cpfCli,@codRecepcao,null,1)", con.conectarBD());
                cmd.Parameters.Add("@codComanda", SqlDbType.VarChar).Value = codComanda;
                cmd.Parameters.Add("@cpfCli", SqlDbType.VarChar).Value = cpfCli;
                cmd.Parameters.Add("@codRecepcao", SqlDbType.VarChar).Value = codRecepcao;
                cmd.ExecuteNonQuery();
            }
            con.desconectarBD();
            MetroMessageBox.Show(contexto, "Recepção finalizada!", "Cadastro Efetuado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpar.limpar(p);

        }
       
        public int codUtilidadeComanda(int codComanda)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select  COD_UTILIDADE_COMANDA from TB_UTILIDADE_COMANDA WHERE COD_COMANDA =" + codComanda + " AND ATIVO = 1", con.conectarBD());
                con.desconectarBD();
                DataSet ds = new DataSet();
                da.Fill(ds);
                return Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[0].ToString());
            }
            catch
            {
                return 0;
            }
        }
        public bool consCodComanda(int codComanda)
        {
            
                SqlDataAdapter da = new SqlDataAdapter("select * from TB_COMANDA WHERE COD_COMANDA =" + codComanda , con.conectarBD());
                con.desconectarBD();
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            
        }
        public string cliComanda(int codComanda)
        {
            SqlDataAdapter da = new SqlDataAdapter("select  * from TB_UTILIDADE_COMANDA WHERE COD_COMANDA =" + codComanda + " AND ATIVO = 1", con.conectarBD());
            con.desconectarBD();
            DataSet ds = new DataSet();
            da.Fill(ds);

            string cpfCli = ds.Tables[0].Rows[0].ItemArray[2].ToString();

            SqlDataAdapter da1 = new SqlDataAdapter("select  NOME_CLI from TB_CLIENTE WHERE CPF_CLI = '" + cpfCli + "'", con.conectarBD());
            con.desconectarBD();
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);

            if (ds1.Tables[0].Rows.Count > 0){
                return ds1.Tables[0].Rows[0].ItemArray[0].ToString();
            }
            else
            {
                return null;
            }

        }
        public void desativaComanda(int codUtiComanda,double valor)
        {
            SqlCommand cmd = new SqlCommand("update TB_UTILIDADE_COMANDA set ATIVO = 0,VALOR_TOTAL = @valor where COD_UTILIDADE_COMANDA= @codUtiComanda", con.conectarBD());
            cmd.Parameters.Add("@codUtiComanda", SqlDbType.VarChar).Value = codUtiComanda;
            cmd.Parameters.Add("@valor", SqlDbType.Money).Value = valor;
            
            cmd.ExecuteNonQuery();

            con.desconectarBD();
           

        }
        public DataSet comandasAtivas()
        {

            SqlDataAdapter da = new SqlDataAdapter("select TB_UTILIDADE_COMANDA.COD_COMANDA AS 'Comanda', TB_CLIENTE.NOME_CLI AS 'Nome Cliente' from TB_UTILIDADE_COMANDA, TB_CLIENTE WHERE TB_UTILIDADE_COMANDA.CPF_CLI=TB_CLIENTE.CPF_CLI and TB_UTILIDADE_COMANDA.ATIVO=1", con.conectarBD());
            DataSet ds = new DataSet();
            da.Fill(ds);

            con.desconectarBD();
            return ds;


        }
        public DataSet comandasAtivas(int codComanda)
        {

            SqlDataAdapter da = new SqlDataAdapter("select TB_UTILIDADE_COMANDA.COD_COMANDA AS 'Comanda', TB_CLIENTE.NOME_CLI AS 'Nome Cliente' from TB_UTILIDADE_COMANDA, TB_CLIENTE WHERE TB_UTILIDADE_COMANDA.CPF_CLI=TB_CLIENTE.CPF_CLI and TB_UTILIDADE_COMANDA.ATIVO=1 and TB_UTILIDADE_COMANDA.COD_COMANDA = "+codComanda, con.conectarBD());
            DataSet ds = new DataSet();
            da.Fill(ds);

            con.desconectarBD();
            return ds;


        }
        public DataSet consRecepcao(int codUtiComanda)
        {

            SqlDataAdapter da = new SqlDataAdapter("select COD_RECEPCAO from  TB_UTILIDADE_COMANDA where COD_UTILIDADE_COMANDA = " + codUtiComanda, con.conectarBD());
            DataSet ds = new DataSet();
            da.Fill(ds);

            con.desconectarBD();
            int codRecepcao = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[0].ToString());
            SqlDataAdapter da1 = new SqlDataAdapter("select * from TB_RECEPCAO where COD_RECEPCAO = " + codRecepcao , con.conectarBD());
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);

            con.desconectarBD();
            
            return ds1;


        }
    }
}
