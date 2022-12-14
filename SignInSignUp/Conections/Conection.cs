using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignInSignUp.Conections
{
    public class Conection
    {
        SqlConnection con = new SqlConnection();
        public Conection()
        {
            //banco de dados local para teste de sign in sign up
            con.ConnectionString = @"Data Source=(localdb)\Local;Initial Catalog=ProjetoSigninSignup;Integrated Security=True";
        }

        public SqlConnection conectar()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }

        }
    }
}
