using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignInSignUp.Conections
{
    internal class Login
    {
        public bool tem = false;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conection con = new Conection();
        SqlDataReader dr;

        public bool verificarSignin(String usuario, String senha)
        {
            cmd.CommandText = "select * from usuarios where usuario = @usuario and senha = @senha";
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@senha", senha);
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
                con.desconectar() ;
                dr.Close(); 
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com o banco de dados";
            }

            return tem;
        }

        public String cadastrar(String usuario, String senha, String nome, String CPF, String dataNascimento)
        {
            tem = false;

            cmd.CommandText = "insert into usuarios values (@u, @s, @n, @C, @d)";
            cmd.Parameters.AddWithValue("@u", usuario);
            cmd.Parameters.AddWithValue("@s", senha);
            cmd.Parameters.AddWithValue("@n", nome);
            cmd.Parameters.AddWithValue("@C", CPF);
            cmd.Parameters.AddWithValue("@d", dataNascimento);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
                this.mensagem = "Cadastrado com sucesso ";
                tem = true;
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com o banco de dados";
            }

            return mensagem;
        }
    }
}
