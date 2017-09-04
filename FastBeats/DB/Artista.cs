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
    class Artista
    {
        Conexao con = new Conexao();
        Limpar limpar = new Limpar();
        public void cadArtista(string nome, string tel, string email, string genero, string nomeempresario, Panel p, Form contexto)
        {
            SqlCommand cmd = new SqlCommand("insert into TB_ARTISTA values (@nome,@tel,@email,@genero,@nomeempresario)", con.conectarBD());
            cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
            cmd.Parameters.Add("@tel", SqlDbType.VarChar).Value = tel;
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@genero", SqlDbType.VarChar).Value = genero;
            cmd.Parameters.Add("@nomeempresario", SqlDbType.VarChar).Value = nomeempresario;
            cmd.ExecuteNonQuery();

            con.desconectarBD();
            MetroMessageBox.Show(contexto, "Artista Cadastrado Com Sucesso!", "Cadastro Efetuado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpar.limpar(p);

        }
        public void atuaArtista(string nome, string tel, string email, string genero, string nomeempresario, int cod, Panel p, Form contexto)
        {
            SqlCommand cmd = new SqlCommand("update TB_ARTISTA set ARTISTA = @nome, TEL_EMPRESA = @tel,EMAIL_EMPRESA=@email,GENERO=@genero,NOME_EMPRESA=@nomeempresario where COD_ARTISTA= @cod", con.conectarBD());
            cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
            cmd.Parameters.Add("@tel", SqlDbType.VarChar).Value = tel;
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@genero", SqlDbType.VarChar).Value = genero;
            cmd.Parameters.Add("@nomeempresario", SqlDbType.VarChar).Value = nomeempresario;
            cmd.Parameters.Add("@cod", SqlDbType.Int).Value = cod;
            cmd.ExecuteNonQuery();

            con.desconectarBD();
            MetroMessageBox.Show(contexto, "Artista Atualizado Com Sucesso!", "Cadastro Efetuado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpar.limpar(p);

        }
        public DataSet consArtista(string nome)
        {

            SqlDataAdapter da = new SqlDataAdapter("select COD_ARTISTA as 'Código', ARTISTA as 'Nome', TEL_EMPRESA as 'Telefone do Empresário', EMAIL_EMPRESA as 'E-mail do Empresário', GENERO as 'Gênero Musical do Artista', NOME_EMPRESA as 'Nome do Empresário' from  TB_ARTISTA where Artista like '%" + nome + "%'", con.conectarBD());

            DataSet ds = new DataSet();
            da.Fill(ds);
            con.desconectarBD();
            return ds;
        }
        public DataSet consArtistasGenero(string genero)
        {

            SqlDataAdapter da = new SqlDataAdapter("select COD_ARTISTA as 'Código', ARTISTA as 'Nome', TEL_EMPRESA as 'Telefone do Empresário', EMAIL_EMPRESA as 'E-mail do Empresário', GENERO as 'Gênero Musical do Artista', NOME_EMPRESA as 'Nome do Empresário' from  TB_ARTISTA where genero='" + genero + "'", con.conectarBD());
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.desconectarBD();
            return ds;

        }
        public DataSet consArtista()
        {

            SqlDataAdapter da = new SqlDataAdapter("select * from  TB_ARTISTA ", con.conectarBD());

            DataSet ds = new DataSet();
            da.Fill(ds);
            con.desconectarBD();
            return ds;
        }
        public DataSet consArtistaAgenda(string nome)
        {

            SqlDataAdapter da = new SqlDataAdapter("select * from  TB_ARTISTA where Artista = '" + nome + "'", con.conectarBD());

            DataSet ds = new DataSet();
            da.Fill(ds);
            con.desconectarBD();
            return ds;
        }
        public DataSet consArtista(int codArtista)
        {

            SqlDataAdapter da = new SqlDataAdapter("select * from  TB_ARTISTA where COD_ARTISTA = '" + codArtista + "'", con.conectarBD());

            DataSet ds = new DataSet();
            da.Fill(ds);
            con.desconectarBD();
            return ds;
        }
    }
}
