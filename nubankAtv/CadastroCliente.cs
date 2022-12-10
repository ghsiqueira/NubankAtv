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
    public partial class CadastroCliente : Form
    {
        public void limpar()
        {
            txtNome.Text = "";
            mskCpf.Text = " ";
            mskTelefone.Text = " ";
            txtEmail.Text = " ";
            txtEndereco.Text = "";
            txtRenda.Text = " ";
            mskConta.Text = " ";
        }
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void btnVoltarCadastroCliente_Click(object sender, EventArgs e)
        {
            TelaInicial abrirTelaInicial = new TelaInicial();
            abrirTelaInicial.Show();
            this.Hide();
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection("server=localhost;port=3306;User=root;database=nubank;pwd='etec'");
                conexao.Open();
                MySqlCommand objCmd = new MySqlCommand("insert into clientes values(null, ?, ?, ?, ?, ?, ?, ?)", conexao);
                objCmd.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value = txtNome.Text;
                objCmd.Parameters.Add("@cpf", MySqlDbType.VarChar, 20).Value = mskCpf.Text;
                objCmd.Parameters.Add("@conta", MySqlDbType.VarChar, 20).Value = mskConta.Text;
                objCmd.Parameters.Add("@endereco", MySqlDbType.VarChar, 100).Value = txtEndereco.Text;
                objCmd.Parameters.Add("@telefone", MySqlDbType.VarChar, 11).Value = mskTelefone.Text;
                objCmd.Parameters.Add("@email", MySqlDbType.VarChar, 100).Value = txtEmail.Text;
                objCmd.Parameters.Add("@renda", MySqlDbType.VarChar, 50).Value = txtRenda.Text;
                objCmd.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("Cliente Cadastrado com sucesso!");
                limpar();
             }
            catch (Exception erro)
            {
                MessageBox.Show("Não Cadastrado: " + erro);
            }
        }
    }
}
