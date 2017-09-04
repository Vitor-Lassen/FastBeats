using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MetroFramework;
using System.Windows.Forms;
using FastBeats.DB;

namespace FastBeats.DB
{
    
    class Produto
    {
        Conexao con = new Conexao();
        Limpar limpar = new Limpar();

        public DataSet consProd()
        {
            SqlDataAdapter da = new SqlDataAdapter("select*from TB_PRODUTO", con.conectarBD());
            DataSet ds = new DataSet();
            da.Fill(ds);

            con.desconectarBD();
            return ds;

        }
        public DataSet consProdCod(int codProduto)
        {
            SqlDataAdapter da = new SqlDataAdapter("select COD_PRODUTO as 'Código', NOME_PRODUTO as 'Produto', QTD_PRODUTO as 'Quantidade', QTD_MINIMA_PRODUTO as 'Quantidade Mínima', PRECO_CUSTO_UNIDADE as 'Preço de Custo (R$)', PRECO_VENDA as 'Preço de Venda (R$)' from TB_PRODUTO WHERE COD_PRODUTO = " + codProduto, con.conectarBD());
            DataSet ds = new DataSet();
            da.Fill(ds);

            con.desconectarBD();
            return ds;

        }
        public string consNomeProd(int codProduto)
        {
            SqlDataAdapter da = new SqlDataAdapter("select COD_PRODUTO as 'Código', NOME_PRODUTO as 'Produto', QTD_PRODUTO as 'Quantidade', QTD_MINIMA_PRODUTO as 'Quantidade Mínima', PRECO_CUSTO_UNIDADE as 'Preço de Custo (R$)', PRECO_VENDA as 'Preço de Venda (R$)' from TB_PRODUTO WHERE COD_PRODUTO = " + codProduto, con.conectarBD());
            con.desconectarBD();
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0].Rows[0].ItemArray[1].ToString();



        }
        public DataSet consProdNome(string nomeProduto)
        {
            SqlDataAdapter da = new SqlDataAdapter("select COD_PRODUTO as 'Código', NOME_PRODUTO as 'Produto', QTD_PRODUTO as 'Quantidade do produto', QTD_MINIMA_PRODUTO as 'Quantidade Mínima do Produto', PRECO_CUSTO_UNIDADE as 'Preço de Custo (R$)', PRECO_VENDA as 'Preço de Venda (R$)' from TB_PRODUTO WHERE NOME_PRODUTO like '%" + nomeProduto + "%'", con.conectarBD());
            DataSet ds = new DataSet();
            da.Fill(ds);

            con.desconectarBD();
            return ds;

        }

        public void cadProd(int cod, string nome, int qtd, int qtdMinima, string precoCusto, string preco, Panel p, Form contexto)
        {
            SqlCommand cmd = new SqlCommand("insert into TB_PRODUTO values (@cod,@nome,@qtd,@qtdMinima,@precoCusto,@preco)", con.conectarBD());
            cmd.Parameters.Add("@cod", SqlDbType.VarChar).Value = cod;
            cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
            cmd.Parameters.Add("@qtd", SqlDbType.VarChar).Value = qtd;
            cmd.Parameters.Add("@qtdMinima", SqlDbType.VarChar).Value = qtdMinima;
            cmd.Parameters.Add("@precoCusto", SqlDbType.VarChar).Value = precoCusto;
            cmd.Parameters.Add("@preco", SqlDbType.VarChar).Value = preco;
            cmd.ExecuteNonQuery();

            con.desconectarBD();
            MetroMessageBox.Show(contexto, "Produto  Cadastrado Com Sucesso!", "Cadastro Efetuado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpar.limpar(p);

        }

        public void atuaProd(string nome, int qtd, int qtdMinima, string precoCusto, string preco, int cod, Panel p, Form contexto)
        {
            SqlCommand cmd = new SqlCommand("update TB_PRODUTO set  NOME_PRODUTO = @nome, QTD_PRODUTO = @qtd, QTD_MINIMA_PRODUTO = @qtdMinima, PRECO_CUSTO_UNIDADE = @precoCusto, PRECO_VENDA = @preco where COD_PRODUTO = @cod", con.conectarBD());
            cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
            cmd.Parameters.Add("@qtd", SqlDbType.Int).Value = qtd;
            cmd.Parameters.Add("@qtdMinima", SqlDbType.Int).Value = qtdMinima;
            cmd.Parameters.Add("@precoCusto", SqlDbType.VarChar).Value = precoCusto;
            cmd.Parameters.Add("@preco", SqlDbType.VarChar).Value = preco;
            cmd.Parameters.Add("@cod", SqlDbType.Int).Value = cod;
            cmd.ExecuteNonQuery();

            con.desconectarBD();
            MetroMessageBox.Show(contexto, "Produto  Atualizado Com Sucesso!", "Alteração Efetuada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpar.limpar(p);

        }
      
        public void retirarProduto(int codProd,int qtd)
        {
            SqlDataAdapter da = new SqlDataAdapter("select  QTD_PRODUTO  from TB_PRODUTO WHERE COD_PRODUTO = '" + codProd + "'", con.conectarBD());
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.desconectarBD();

            int qtdProd = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[0].ToString());
            qtd = qtdProd - qtd;

            SqlCommand cmd = new SqlCommand("update TB_PRODUTO set QTD_PRODUTO = @qtd where COD_PRODUTO = @cod", con.conectarBD());
            cmd.Parameters.Add("@qtd", SqlDbType.Int).Value = qtd;
            cmd.Parameters.Add("@cod", SqlDbType.Int).Value = codProd;
            cmd.ExecuteNonQuery();

            con.desconectarBD();
        }
        public DataSet produtoEmFalta()
        {

            SqlDataAdapter da = new SqlDataAdapter("select COD_PRODUTO as 'Código Produto',NOME_PRODUTO as 'Nome Produto', QTD_PRODUTO as 'Quantidade', QTD_MINIMA_PRODUTO as 'Quantidade Mínima' from  TB_PRODUTO  where QTD_MINIMA_PRODUTO > QTD_PRODUTO ", con.conectarBD());
            DataSet ds = new DataSet();
            da.Fill(ds);

            con.desconectarBD();
            return ds;


        }
     
       
    
       

        

    }
}
