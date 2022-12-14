using SignInSignUp.Conections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignInSignUp.Models
{
    public class Controle
    {
        public bool tem;
        public String mensagem = "";

        public bool acessar(String usuario, String senha)
        {
            Login login = new Login();
            tem = login.verificarSignin(usuario, senha);  
            if (!login.mensagem.Equals(""))
            {
                this.mensagem = login.mensagem;
            }
            return tem;
        }

        public String cadastrar(String usuario ,String senha, String nome, String CPF, String dataNascimento)
        {
            Login login = new Login();
            this.mensagem = login.cadastrar(usuario, senha, nome, CPF, dataNascimento);
            if (login.tem)
            {
                this.tem = true; 
            }
            return mensagem;
        }
        
    }
}
