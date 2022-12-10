using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace nubankAtv
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void cadastroClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroCliente abrirTelaCadastroCliente = new CadastroCliente();
            abrirTelaCadastroCliente.Show();
            this.Hide();
        }

        private void consultaClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaCliente abrirTelaConsultaCliente = new ConsultaCliente();
            abrirTelaConsultaCliente.Show();
            this.Hide();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaEmprestimo abrirTelaConsultaEmprestimo = new ConsultaEmprestimo();
            abrirTelaConsultaEmprestimo.Show();
            this.Hide();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaTransacoes abrirTelaConsultaTransacoes = new ConsultaTransacoes();
            abrirTelaConsultaTransacoes.Show();
            this.Hide();
        }

        private void editarDadosClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DadosCliente abrirTelaEditarDadosCliente = new DadosCliente();
            abrirTelaEditarDadosCliente.Show();
            this.Hide();
        }

        private void logoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login abrirTelaLogin = new Login();
            abrirTelaLogin.Show();
            this.Hide();
        }
    }
}
