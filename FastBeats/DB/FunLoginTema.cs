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
    class FunLoginTema
    {
        Conexao con = new Conexao();
        Limpar limpar = new Limpar();
        public void cadFuncionario(string cpf, string nome, string end, string tel, string cel, string rg, string email, string cargo, string dataNasc, string foto, string usuario, string senha, int nivel, int ativo, Panel p, Form contexto)
        {
            SqlCommand cmd = new SqlCommand("insert into TB_FUNCIONARIO values (@cpf,@nome,@end,@tel,@cel,@rg,@email,@cargo,@dataNasc,@foto)", con.conectarBD());
            cmd.Parameters.Add("@cpf", SqlDbType.VarChar).Value = cpf;
            cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
            cmd.Parameters.Add("@end", SqlDbType.VarChar).Value = end;
            cmd.Parameters.Add("@tel", SqlDbType.VarChar).Value = tel;
            cmd.Parameters.Add("@cel", SqlDbType.VarChar).Value = cel;
            cmd.Parameters.Add("@rg", SqlDbType.VarChar).Value = rg;
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@cargo", SqlDbType.VarChar).Value = cargo;
            cmd.Parameters.Add("@dataNasc", SqlDbType.VarChar).Value = dataNasc;
            cmd.Parameters.Add("@foto", SqlDbType.VarChar).Value = foto;
            cmd.ExecuteNonQuery();

            SqlCommand cmd2 = new SqlCommand("insert into TB_LOGIN values (@usuario,@senha,@nivel,null,@ativo,@cpf)", con.conectarBD());
            cmd2.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario;
            cmd2.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;
            cmd2.Parameters.Add("@nivel", SqlDbType.Int).Value = nivel;
            cmd2.Parameters.Add("@ativo", SqlDbType.Int).Value = ativo;
            cmd2.Parameters.Add("@cpf", SqlDbType.VarChar).Value = cpf;
            cmd2.ExecuteNonQuery();

            SqlCommand cmd3 = new SqlCommand("insert into TB_PERSONALIZACAO values (@cpf,1,4)", con.conectarBD());
            cmd3.Parameters.Add("@cpf", SqlDbType.VarChar).Value = cpf;
            cmd3.ExecuteNonQuery();

            con.desconectarBD();
            MetroMessageBox.Show(contexto, "Funcionario Cadastrado Com Sucesso!", "Cadastro Efetuado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpar.limpar(p);

        }
        public void atuaFuncionario(string cpf, string nome, string end, string tel, string cel, string rg, string email, string cargo, string dataNasc, string foto, string usuario, string senha, int nivel, int ativo, Panel p, Form contexto)
        {
            SqlCommand cmd = new SqlCommand("update TB_FUNCIONARIO set NOME_FUNC = @nome,END_FUNC=@end,TEL_FUNC=@tel,CEL_FUNC=@cel,RG_FUNC=@rg,EMAIL=@email,CARGO=@cargo,DATA_NASC_FUNC=@dataNasc,lOCAL_FOTO_FUNC=@foto WHERE CPF_FUNC=@cpf", con.conectarBD());
            cmd.Parameters.Add("@cpf", SqlDbType.VarChar).Value = cpf;
            cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
            cmd.Parameters.Add("@end", SqlDbType.VarChar).Value = end;
            cmd.Parameters.Add("@tel", SqlDbType.VarChar).Value = tel;
            cmd.Parameters.Add("@cel", SqlDbType.VarChar).Value = cel;
            cmd.Parameters.Add("@rg", SqlDbType.VarChar).Value = rg;
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@cargo", SqlDbType.VarChar).Value = cargo;
            cmd.Parameters.Add("@dataNasc", SqlDbType.VarChar).Value = dataNasc;
            cmd.Parameters.Add("@foto", SqlDbType.VarChar).Value = foto;
            cmd.ExecuteNonQuery();

            SqlCommand cmd2 = new SqlCommand("update TB_LOGIN set SENHA=@senha,NIVEL_ACESSO=@nivel,ATIVO=@ativo,CPF_FUNC=@cpf where USUARIO = @usuario", con.conectarBD());
            cmd2.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario;
            cmd2.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;
            cmd2.Parameters.Add("@nivel", SqlDbType.Int).Value = nivel;
            cmd2.Parameters.Add("@ativo", SqlDbType.Int).Value = ativo;
            cmd2.Parameters.Add("@cpf", SqlDbType.VarChar).Value = cpf;
            cmd2.ExecuteNonQuery();

            con.desconectarBD();
            MetroMessageBox.Show(contexto, "Funcionario Atualizado Com Sucesso!", "Cadastro Efetuado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpar.limpar(p);

        }
        
        public DataSet consFuncionario(string nome)
        {

            SqlDataAdapter da = new SqlDataAdapter("select CPF_FUNC as 'CPF', NOME_FUNC as 'Nome', END_FUNC as 'Endereço', TEL_FUNC as 'Telefone', CEL_FUNC as 'Celular', RG_FUNC as 'RG', EMAIL as 'E-mail', CARGO as 'Cargo', DATA_NASC_FUNC as 'Data de Nascimento'  from  TB_FUNCIONARIO where NOME_FUNC like '%" + nome + "%'", con.conectarBD());

            DataSet ds = new DataSet();
            da.Fill(ds);
            con.desconectarBD();
            return ds;
        }
        public DataSet consFuncionario()
        {

            SqlDataAdapter da = new SqlDataAdapter("select * from  TB_FUNCIONARIO ", con.conectarBD());

            DataSet ds = new DataSet();
            da.Fill(ds);
            con.desconectarBD();
            return ds;
        }

        public DataSet consFuncionarioCPF(string cpf)
        {

            SqlDataAdapter da = new SqlDataAdapter("select CPF_FUNC as 'CPF', NOME_FUNC as 'Nome', END_FUNC as 'Endereço', TEL_FUNC as 'Telefone', CEL_FUNC as 'Celular', RG_FUNC as 'RG', EMAIL as 'E-mail', CARGO as 'Cargo', DATA_NASC_FUNC as 'Data de Nascimento' from  TB_FUNCIONARIO where CPF_FUNC like'%" + cpf + "%'", con.conectarBD());
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.desconectarBD();
            return ds;
        }
        public String consLocalFoto(string cpf)
        {

            SqlDataAdapter da = new SqlDataAdapter("select LOCAL_FOTO_FUNC from  TB_FUNCIONARIO where CPF_FUNC like'%" + cpf + "%'", con.conectarBD());
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.desconectarBD();
            return ds.Tables[0].Rows[0].ItemArray[0].ToString();
        }
        public DataSet consLogin (string cpf)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from  TB_LOGIN where CPF_FUNC ='" + cpf + "'", con.conectarBD());
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.desconectarBD();
            return ds;
        }

     

        public bool login(string login, string senha,frmPrincipal contexto)
        {
            string cpf;
            SqlDataAdapter da = new SqlDataAdapter("select * from  TB_LOGIN WHERE USUARIO = '"+login+"'and SENHA='"+senha+"' and ATIVO = 1", con.conectarBD());

            DataSet ds = new DataSet();
            da.Fill(ds);
            con.desconectarBD();
            if (ds.Tables[0].Rows.Count >= 1)
            {
                cpf = ds.Tables[0].Rows[0].ItemArray[5].ToString();
                contexto.cpf = cpf;
                int nivel = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[2].ToString());
                if (nivel == 0)
                {
                    contexto.mlblNivel.Text="Administrador";
                }
                else if(nivel == 1)
                {
                    contexto.mlblNivel.Text = "Bar";
                }
                else if (nivel == 2)
                {
                    contexto.mlblNivel.Text = "Atendente";
                }
                SqlDataAdapter da1 = new SqlDataAdapter("select NOME_FUNC from  TB_FUNCIONARIO WHERE CPF_FUNC = '" + cpf + "'", con.conectarBD());
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);
                contexto.mlblNome.Text = ds1.Tables[0].Rows[0].ItemArray[0].ToString();
                    
                return true;
            }
            else
            {
                return false;
            }
        }

        public void configTema (int tema,int cor,string cpf)
        {
            SqlCommand cmd = new SqlCommand("update TB_PERSONALIZACAO set TEMA=@tema, COR=@cor WHERE CPF_FUNC=@cpf", con.conectarBD());
            cmd.Parameters.Add("@tema", SqlDbType.VarChar).Value = tema;
            cmd.Parameters.Add("@cor", SqlDbType.VarChar).Value = cor;
            cmd.Parameters.Add("@cpf", SqlDbType.VarChar).Value = cpf;
            
            cmd.ExecuteNonQuery();
        }
        public void aplicarTema(string cpf, frmLogin contexto)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from  TB_PERSONALIZACAO WHERE CPF_FUNC = '" + cpf + "'", con.conectarBD());
            DataSet ds = new DataSet();
            da.Fill(ds);
            contexto.numTema = Convert.ToInt32( ds.Tables[0].Rows[0].ItemArray[1].ToString());
            contexto.numCor = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[2].ToString());
        }

     

        

       

      
    }
}
