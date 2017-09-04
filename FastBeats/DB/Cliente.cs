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
    class Cliente
    {
        Conexao con = new Conexao();
        Limpar limpar = new Limpar();
        public void cadCliente(string cpf, string nome, string rg, string tel, string cel, Panel p, Form contexto)
        {
            SqlCommand cmd = new SqlCommand("insert into TB_CLIENTE values (@cpf,@nome,@rg,@tel,@cel)", con.conectarBD());
            cmd.Parameters.Add("@cpf", SqlDbType.VarChar).Value = cpf;
            cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
            cmd.Parameters.Add("@tel", SqlDbType.VarChar).Value = tel;
            cmd.Parameters.Add("@cel", SqlDbType.VarChar).Value = cel;
            cmd.Parameters.Add("@rg", SqlDbType.VarChar).Value = rg;
            cmd.ExecuteNonQuery();

            con.desconectarBD();
            MetroMessageBox.Show(contexto, "Cliente Cadastrado Com Sucesso!", "Cadastro Efetuado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpar.limpar(p);

        }
        public void atuaCliente(string cpf, string nome, string rg, string tel, string cel, Panel p, Form contexto)
        {
            SqlCommand cmd = new SqlCommand("update TB_CLIENTE set NOME_CLI = @nome, RG_CLI = @rg,TEL_CLI=@tel,CEL_CLI=@cel where CPF_CLI= @cpf", con.conectarBD());
            cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
            cmd.Parameters.Add("@tel", SqlDbType.VarChar).Value = tel;
            cmd.Parameters.Add("@rg", SqlDbType.VarChar).Value = rg;
            cmd.Parameters.Add("@cel", SqlDbType.VarChar).Value = cel;
            cmd.Parameters.Add("@cpf", SqlDbType.VarChar).Value = cpf;
            cmd.ExecuteNonQuery();

            con.desconectarBD();
            MetroMessageBox.Show(contexto, "Cliente Atualizado Com Sucesso!", "Cadastro Efetuado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpar.limpar(p);

        }
        public DataSet consCliente(string nome)
        {

            SqlDataAdapter da = new SqlDataAdapter("select CPF_CLI as 'CPF', NOME_CLI as 'Nome', RG_CLI as 'RG', TEL_CLI as 'Telefone', CEL_CLI as 'Celular' from  TB_CLIENTE where NOME_CLI like '%" + nome + "%'", con.conectarBD());

            DataSet ds = new DataSet();
            da.Fill(ds);
            con.desconectarBD();
            return ds;
        }
        public DataSet consClienteCPF(string cpf)
        {

            SqlDataAdapter da = new SqlDataAdapter("select CPF_CLI as 'CPF', NOME_CLI as 'Nome', RG_CLI as 'RG', TEL_CLI as 'Telefone', CEL_CLI as 'Celular' from  TB_CLIENTE WHERE CPF_CLI like '%" + cpf + "%'", con.conectarBD());
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.desconectarBD();
            return ds;
        }
        public DataSet consCliente()
        {

            SqlDataAdapter da = new SqlDataAdapter("select * from  TB_CLIENTE", con.conectarBD());

            DataSet ds = new DataSet();
            da.Fill(ds);
            con.desconectarBD();
            return ds;
        }
    }
}
