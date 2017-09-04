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
    class Cardapio
    {
        Conexao con = new Conexao();
        Limpar limpar = new Limpar();
        public DataSet consCard()
        {
            SqlDataAdapter da = new SqlDataAdapter("select COD_CARDAPIO as 'Código do Produto', NOME_PROD_CARDAPIO as 'Nome do Produto', PRECO_PROD_CARDAPIO as 'Preço (R$)' from TB_CARDAPIO", con.conectarBD());
            DataSet ds = new DataSet();
            da.Fill(ds);

            con.desconectarBD();
            return ds;

        }
        public DataSet consCardCod(int codCardapio)
        {
            SqlDataAdapter da = new SqlDataAdapter("select COD_CARDAPIO as 'Código do Produto', NOME_PROD_CARDAPIO as 'Nome do Produto', PRECO_PROD_CARDAPIO as 'Preço (R$)' from TB_CARDAPIO where COD_CARDAPIO like '%" + codCardapio + "%'", con.conectarBD());
            DataSet ds = new DataSet();
            da.Fill(ds);

            con.desconectarBD();
            return ds;

        }

        public DataSet consCardProd(string ProdCardapio)
        {
            SqlDataAdapter da = new SqlDataAdapter("select COD_CARDAPIO as 'Código do Produto', NOME_PROD_CARDAPIO as 'Nome do Produto ', PRECO_PROD_CARDAPIO as 'Preço (R$)' from TB_CARDAPIO where NOME_PROD_CARDAPIO like '%" + ProdCardapio + "%'", con.conectarBD());
            DataSet ds = new DataSet();
            da.Fill(ds);

            con.desconectarBD();
            return ds;

        }
     
        public void cadCardapio(string nomeprod, string precoprod, Panel p, Form contexto)
        {
            SqlCommand cmd = new SqlCommand("insert into TB_CARDAPIO values (@nomeprod,@precoprod)", con.conectarBD());
            cmd.Parameters.Add("@nomeprod", SqlDbType.VarChar).Value = nomeprod;
            cmd.Parameters.Add("@precoprod", SqlDbType.VarChar).Value = precoprod;
            cmd.ExecuteNonQuery();

            con.desconectarBD();
            MetroMessageBox.Show(contexto, "Produto Cadastrado Com Sucesso!", "Cadastro Efetuado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpar.limpar(p);

        }
        public void atuaCardapio(string nomeprod, string precoprod, int codigo, Panel p, Form contexto)
        {
            SqlCommand cmd = new SqlCommand("update TB_CARDAPIO set NOME_PROD_CARDAPIO = @nomeprod, PRECO_PROD_CARDAPIO = @precoprod where COD_CARDAPIO = @codigo", con.conectarBD());

            cmd.Parameters.Add("@nomeprod", SqlDbType.VarChar).Value = nomeprod;
            cmd.Parameters.Add("@precoprod", SqlDbType.VarChar).Value = precoprod;
            cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = codigo;

            cmd.ExecuteNonQuery();

            con.desconectarBD();
            MetroMessageBox.Show(contexto, "Cardápio Atualizado Com Sucesso!", "Cadastro Efetuado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpar.limpar(p);

        }
    }
}
