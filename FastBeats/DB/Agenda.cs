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
    class Agenda
    {
        Conexao con = new Conexao();
        Limpar limpar = new Limpar();
        // COD_AGENDA; COD_EVENTO; PRECO_HOMEM_VIP; PRECO_HOMEM_PISTA; PRECO_MULHER_VIP; PRECO_MULHER_PISTA; DATA_HORA_INICIO; DATA_HORA_FIM
        public void cadAgenda(string codEvento, string precoHomVip, string precoHomPis, string precoMulVip, string precoMulPis, string dataHoraIni, string dataHoraFim)
        {
            SqlCommand cmd = new SqlCommand("insert into TB_AGENDA values (@codEvento,@precoHomVip,@precoHomPis,@precoMulVip,@precoMulPis,@dataHoraIni,@dataHoraFim)", con.conectarBD());
            cmd.Parameters.Add("@codEvento", SqlDbType.VarChar).Value = codEvento;
            cmd.Parameters.Add("@precoHomVip", SqlDbType.VarChar).Value = precoHomVip;
            cmd.Parameters.Add("@precoHomPis", SqlDbType.VarChar).Value = precoHomPis;
            cmd.Parameters.Add("@precoMulVip", SqlDbType.VarChar).Value = precoMulVip;
            cmd.Parameters.Add("@precoMulPis", SqlDbType.VarChar).Value = precoMulPis;
            cmd.Parameters.Add("@dataHoraIni", SqlDbType.VarChar).Value = dataHoraIni;
            cmd.Parameters.Add("@dataHoraFim", SqlDbType.VarChar).Value = dataHoraFim;

            cmd.ExecuteNonQuery();

            con.desconectarBD();

        }
        public int cadEvento(string nomeEvento, string descricao, DateTime data)
        {
            SqlCommand cmd = new SqlCommand("insert into TB_EVENTO values (@nomeEvento,@descricao,@data)", con.conectarBD());
            cmd.Parameters.Add("@nomeEvento", SqlDbType.VarChar).Value = nomeEvento;
            cmd.Parameters.Add("@descricao", SqlDbType.VarChar).Value = descricao;
            cmd.Parameters.Add("@data", SqlDbType.VarChar).Value = data;

            cmd.ExecuteNonQuery();

            con.desconectarBD();


            SqlDataAdapter da = new SqlDataAdapter("select MAX (COD_EVENTO) from  TB_EVENTO ", con.conectarBD());

            DataSet ds = new DataSet();
            da.Fill(ds);
            con.desconectarBD();
            return Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[0].ToString());


        }
        public void atuaEvento(string nomeEvento, string descricao, DateTime data, int codEvento)
        {
            SqlCommand cmd = new SqlCommand("update TB_EVENTO set NOME_EVENTO = @nomeEvento, DESCRICAO = @descricao, DATA_EVENTO = @data where  COD_EVENTO = @cod", con.conectarBD());
            cmd.Parameters.Add("@nomeEvento", SqlDbType.VarChar).Value = nomeEvento;
            cmd.Parameters.Add("@descricao", SqlDbType.VarChar).Value = descricao;
            cmd.Parameters.Add("@data", SqlDbType.VarChar).Value = data;
            cmd.Parameters.Add("@cod", SqlDbType.VarChar).Value = codEvento;

            cmd.ExecuteNonQuery();

            con.desconectarBD();
        }
        public void cadEventoArt(int codArtista, int codEvento)
        {
            SqlCommand cmd = new SqlCommand("insert into TB_EVENTO_ARTISTA values (@codArtista,@codEvento)", con.conectarBD());
            cmd.Parameters.Add("@codArtista", SqlDbType.VarChar).Value = codArtista;
            cmd.Parameters.Add("@codEvento", SqlDbType.VarChar).Value = codEvento;

            cmd.ExecuteNonQuery();

            con.desconectarBD();

        }

        public void delEventoArt(int codEventoArtista)
        {

            SqlCommand cmd = new SqlCommand("delete from TB_EVENTO_ARTISTA where COD_EVENTO_ARTISTA  = @codEventoArtista", con.conectarBD());
            cmd.Parameters.Add("@codEventoArtista", SqlDbType.VarChar).Value = codEventoArtista;
            

            cmd.ExecuteNonQuery();

            con.desconectarBD();
        }
        public void atuaAgenda(string codAgenda, string codEvento, string precoHomVip, string precoHomPis, string precoMulVip, string precoMulPis, string dataHoraIni, string dataHoraFim, Panel p, Form contexto)
        {
            SqlCommand cmd = new SqlCommand("update TB_AGENDA set COD_EVENTO = @codEvento,PRECO_HOMEM_VIP=@precoHomVip,PRECO_HOMEM_PISTA=@precoHomPis,PRECO_MULHER_VIP=@precoMulVip,PRECO_MULHER_PISTA=@precoMulPis,DATA_HORA_INICIO=@dataHoraIni,DATA_HORA_FIM=@dataHoraFim where COD_AGENDA = @codAgenda", con.conectarBD());
            cmd.Parameters.Add("@codEvento", SqlDbType.VarChar).Value = codEvento;
            cmd.Parameters.Add("@precoHomVip", SqlDbType.VarChar).Value = precoHomVip;
            cmd.Parameters.Add("@precoHomPis", SqlDbType.VarChar).Value = precoHomPis;
            cmd.Parameters.Add("@precoMulVip", SqlDbType.VarChar).Value = precoMulVip;
            cmd.Parameters.Add("@precoMulPis", SqlDbType.VarChar).Value = precoMulPis;
            cmd.Parameters.Add("@dataHoraIni", SqlDbType.VarChar).Value = dataHoraIni;
            cmd.Parameters.Add("@dataHoraFim", SqlDbType.VarChar).Value = dataHoraFim;
            cmd.Parameters.Add("@codAgenda", SqlDbType.VarChar).Value = codAgenda;
            cmd.ExecuteNonQuery();

            con.desconectarBD();
            MetroMessageBox.Show(contexto, "Agenda Atualizada Com Sucesso!", "Cadastro Efetuado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpar.limpar(p);

        }
        public void delAgenda(int codAgenda)
        {

            SqlCommand cmd = new SqlCommand("delete from TB_AGENDA where COD_AGENDA  = @codAgenda", con.conectarBD());
            cmd.Parameters.Add("@codAgenda", SqlDbType.VarChar).Value = codAgenda;


            cmd.ExecuteNonQuery();

            con.desconectarBD();
        }


        public DataSet consEventoNome(string nome)
        {

            SqlDataAdapter da = new SqlDataAdapter("select NOME_EVENTO as 'Evento', DESCRICAO as 'Descrição', DATA_EVENTO as 'Data' from  TB_EVENTO where NOME_EVENTO like'%" + nome + "%'", con.conectarBD());
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.desconectarBD();
            return ds;
        }
        public DataSet consEventoData(DateTime data)
        {

            SqlDataAdapter da = new SqlDataAdapter("select NOME_EVENTO as 'Evento', DESCRICAO as 'Descrição', DATA_EVENTO as 'Data' from  TB_EVENTO where DATA_EVENTO = '" + data + "'", con.conectarBD());
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.desconectarBD();
            return ds;
        }
        public int consEventoCodigo(string nome, string data)
        {

            SqlDataAdapter da = new SqlDataAdapter("select COD_EVENTO from  TB_EVENTO where NOME_EVENTO ='" + nome + "'and DATA_EVENTO ='" + data + "'", con.conectarBD());
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.desconectarBD();
            return Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[0].ToString());
        }
        public DataSet consEventoArtista(int codEvento)
        {

            SqlDataAdapter da = new SqlDataAdapter("select * from  TB_EVENTO_ARTISTA where COD_EVENTO = '" + codEvento + "'", con.conectarBD());
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.desconectarBD();
            return ds;

        }
        public DataSet consAgendaEvento(int codEvento)
        {

            SqlDataAdapter da = new SqlDataAdapter("select * from  TB_AGENDA where COD_EVENTO = '" + codEvento + "'", con.conectarBD());
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.desconectarBD();
            return ds;
        }
        public DataSet consPrecos(string data)
        {

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TB_AGENDA WHERE (DATA_HORA_INICIO < '" + data + "') AND (DATA_HORA_FIM > '" + data + "')", con.conectarBD());
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.desconectarBD();
            return ds;
        }
    }
}
