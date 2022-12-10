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
    public partial class ConsultaCliente : Form
    {
        public ConsultaCliente()
        {
            InitializeComponent();
        }

        private void btnVoltarConsultaCliente_Click(object sender, EventArgs e)
        {
            TelaInicial abrirTelaInicial = new TelaInicial();
            abrirTelaInicial.Show();
            this.Hide();
        }

        private void ConsultaCliente_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string conexao = @"Server=localhost;Database=nubank;Uid=root;Pwd='etec'";
            MySqlConnection msConnection = new MySqlConnection(conexao);
            msConnection.Open();
            MySqlCommand msCommand = new MySqlCommand();
            msCommand.CommandText = "select * from clientes";
            msCommand.Connection = msConnection;
            MySqlDataAdapter msAdapter = new MySqlDataAdapter(msCommand);
            msAdapter.Fill(dt);
            dgvConsultaCliente.DataSource = dt;
        }
    }
}
