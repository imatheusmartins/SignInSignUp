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

namespace SignInSignUp.Screens
{
    public partial class frmSignup : Form
    {
        public frmSignup()
        {
            InitializeComponent();
        }

        private void btnExitsignup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignupsignup_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            String mensagem = controle.cadastrar(txtUser.Text, txtPass.Text, txtName.Text, txtCPF.Text, txtDataNascimento.Text);
            if (controle.tem)
            {
                MessageBox.Show(mensagem, "Cadastro ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }

        }
    }
}
