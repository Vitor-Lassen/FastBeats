using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastBeats.DB
{
    class Conexao
    {
        // etec SqlConnection con = new SqlConnection("Persist Security Info=False;User ID=sa;PassWord=1234567;Initial Catalog=BD_FASTBEATS;Data Source=LAB3PC09");
        //ana SqlConnection con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BD_FASTBEATS");
          SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=BD_FASTBEATS;Integrated Security=SSPI;Persist Security Info=False");
        //  SqlConnection con = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BD_FASTBEATS;Data Source=MEGAMENTE\SQLEXPRESS");


        public SqlConnection conectarBD()
        {
            try
            {
                con.Open();
            }
            catch
            {
            }
            return con;
        }
        public SqlConnection desconectarBD()
        {
            con.Close();
            return con;
        }


    
    }
}
