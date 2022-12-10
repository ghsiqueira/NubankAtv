using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace nubankAtv
{
    public partial class ConsultaEmprestimo : Form
    {
        public ConsultaEmprestimo()
        {
            InitializeComponent();
        }

        private void btnVoltarEmprestimos_Click(object sender, EventArgs e)
        {
            TelaInicial abrirTelaInicial = new TelaInicial();
            abrirTelaInicial.Show();
            this.Hide();
        }

        private void ConsultaEmprestimo_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string conexao = @"Server=localhost;Database=nubank;Uid=root;Pwd='etec'";
            MySqlConnection msConnection = new MySqlConnection(conexao);
            msConnection.Open();
            MySqlCommand msCommand = new MySqlCommand();
            msCommand.CommandText = "select * from emprestimo";
            msCommand.Connection = msConnection;
            MySqlDataAdapter msAdapter = new MySqlDataAdapter(msCommand);
            msAdapter.Fill(dt);
            dgvEmprestimos.DataSource = dt;
        }
    }
}
