using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nubankAtv
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Login deve ser preenchido!");
            }
            else if (txtSenha.Text == "")
            {
                MessageBox.Show("Senha deve ser preenchido!");
            }
            else
            {

                if (txtUsuario.Text == "etec" && txtSenha.Text == "etec")
                {
                    TelaInicial abrirTelaInicial = new TelaInicial();
                    abrirTelaInicial.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos!");
                    return;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saindo do sistema..");
            Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
