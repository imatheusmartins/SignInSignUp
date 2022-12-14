using SignInSignUp.Screens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SignInSignUp.Models;

namespace SignInSignUp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExitApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignup_click(object sender, EventArgs e)
        {
            frmSignup frmSignup = new frmSignup();
            frmSignup.Show();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(txtUser.Text, txtPass.Text);
            if (controle.mensagem.Equals("")){

                if (controle.tem)
                {
                    MessageBox.Show("Logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BoasVindas bv = new BoasVindas();
                    bv.Show();
                }
                else
                {
                    MessageBox.Show("Usuario não encontrado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }
    }
}
