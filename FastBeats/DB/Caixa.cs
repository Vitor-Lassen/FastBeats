using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace FastBeats.DB
{
    class Caixa
    {
        Conexao con = new Conexao();
        public int cadCaixa(string cpf, string valor)
        {
            SqlCommand cmd = new SqlCommand("insert into  TB_CAIXA values (@cpf,@valor,@data)", con.conectarBD());
            cmd.Parameters.Add("@cpf", SqlDbType.VarChar).Value = cpf;
            cmd.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor;
            cmd.Parameters.Add("@data", SqlDbType.Date).Value = DateTime.Now.ToShortDateString();

            cmd.ExecuteNonQuery();

            con.desconectarBD();

            SqlDataAdapter da = new SqlDataAdapter("select Max( COD_CAIXA)  from TB_CAIXA  ", con.conectarBD());
            DataSet ds = new DataSet();
            da.Fill(ds);
            
            con.desconectarBD();
            return Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[0].ToString());
            
        }
        public void cadComandaCaixa(int codCaixa, int codUtiComan)
        {
            SqlCommand cmd = new SqlCommand("insert into  TB_COMANDA_CAIXA values (@codCaixa,@codUtiComan)", con.conectarBD());
            cmd.Parameters.Add("@codCaixa", SqlDbType.VarChar).Value = codCaixa;
            cmd.Parameters.Add("@codUtiComan", SqlDbType.VarChar).Value = codUtiComan;
            cmd.ExecuteNonQuery();

            con.desconectarBD();
        }
        public DataSet consCaixa(DateTime dataIni, DateTime dataFim)
        {

            SqlDataAdapter da = new SqlDataAdapter("select TB_FUNCIONARIO.NOME_FUNC AS 'Nome Funcionário',TB_CAIXA.VALOR_TOTAL as 'Total (R$)',TB_CAIXA.DATA as 'Data' from TB_CAIXA,TB_FUNCIONARIO where TB_CAIXA.CPF_FUNC = TB_FUNCIONARIO.CPF_FUNC and TB_CAIXA.DATA >= '"+dataIni+"' and TB_CAIXA.DATA <= '"+dataFim+"'", con.conectarBD());
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.desconectarBD();
            return ds;
        }
        public DataSet consCaixa(DateTime dataIni, DateTime dataFim , string CPF)
        {

            SqlDataAdapter da = new SqlDataAdapter("select TB_FUNCIONARIO.NOME_FUNC AS 'Nome Funcionário',TB_CAIXA.VALOR_TOTAL as 'Total (R$)',TB_CAIXA.DATA as 'Data' from TB_CAIXA,TB_FUNCIONARIO where TB_CAIXA.CPF_FUNC = TB_FUNCIONARIO.CPF_FUNC and TB_CAIXA.DATA >= '" + dataIni + "' and TB_CAIXA.DATA <= '" + dataFim + "' and TB_CAIXA.CPF_FUNC = '"+CPF+"'", con.conectarBD());
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.desconectarBD();
            return ds;
        }


    }
}
