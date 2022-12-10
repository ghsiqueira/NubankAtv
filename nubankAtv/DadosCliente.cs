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
    public partial class DadosCliente : Form
    {
        public void limpar()
        {
            txtId.Text = "";
            txtNome.Text = "";
            mskCpf.Text = " ";
            mskTelefone.Text = " ";
            txtEmail.Text = " ";
            txtEndereco.Text = "";
            txtRenda.Text = " ";
            mskConta.Text = " ";
        }
        public DadosCliente()
        {
            InitializeComponent();
        }

        private void btnVoltarDadosCliente_Click(object sender, EventArgs e)
        {
            TelaInicial abrirTelaInicial = new TelaInicial();
            abrirTelaInicial.Show();
            this.Hide();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resultadoCaixaTexto = MessageBox.Show("Tem certeza que deseja excluir esse cadastro?", "Nubank", MessageBoxButtons.YesNo);
            if (resultadoCaixaTexto == DialogResult.Yes)
            {
                MySqlConnection conexao = new MySqlConnection("server=localhost;port=3306;User=root;database=nubank;pwd='etec'");
                conexao.Open();
                MySqlCommand objCmd = new MySqlCommand("delete from clientes where id = ?", conexao);
                objCmd.Parameters.Clear();
                objCmd.Parameters.Add("@id", MySqlDbType.Int32).Value = txtId.Text;
                objCmd.CommandType = CommandType.Text;
                objCmd.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("Cadastro excluido com sucesso!");
                limpar();
            }
            else
            {
                MessageBox.Show("Cuidado!");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection("server=localhost;port=3306;User=root;database=nubank;pwd='etec'");
                conexao.Open();
                MySqlCommand objCmd = new MySqlCommand("select nome, cpf, conta, endereco, telefone, email, renda from clientes where id = ?", conexao);
                objCmd.Parameters.Clear();
                objCmd.Parameters.Add("@id", MySqlDbType.Int32).Value = txtId.Text;
                objCmd.CommandType = CommandType.Text;
                MySqlDataReader dr;
                dr = objCmd.ExecuteReader();
                dr.Read();
                txtNome.Text = dr.GetString(0);
                mskCpf.Text = dr.GetString(1);
                mskConta.Text = dr.GetString(2);
                txtEndereco.Text = dr.GetString(3);
                mskTelefone.Text = dr.GetString(4);
                txtEmail.Text = dr.GetString(5);
                txtRenda.Text = dr.GetString(6);
                conexao.Close();
            }
            catch
            {
                MessageBox.Show("Falha ao Buscar!");
            }
        }

        private void btnAtualizarCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection("server=localhost;port=3306;User=root;database=nubank;pwd='etec'");
                conexao.Open();
                MySqlCommand objCmd = new MySqlCommand("update clientes set nome = ?, cpf = ?, conta = ?, endereco = ?, telefone = ?, email = ?, renda = ? where id = ?", conexao);
                objCmd.Parameters.Clear();
                objCmd.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value = txtNome.Text;
                objCmd.Parameters.Add("@cpf", MySqlDbType.VarChar, 20).Value = mskCpf.Text;
                objCmd.Parameters.Add("@conta", MySqlDbType.VarChar, 20).Value = mskConta.Text;
                objCmd.Parameters.Add("@endereco", MySqlDbType.VarChar, 100).Value = txtEndereco.Text;
                objCmd.Parameters.Add("@telefone", MySqlDbType.VarChar, 11).Value = mskTelefone.Text;
                objCmd.Parameters.Add("@email", MySqlDbType.VarChar, 100).Value = txtEmail.Text;
                objCmd.Parameters.Add("@renda", MySqlDbType.VarChar, 50).Value = txtRenda.Text; objCmd.CommandType = CommandType.Text;
                objCmd.Parameters.Add("id", MySqlDbType.Int32).Value = txtId.Text;
                objCmd.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("Atualização realizada com sucesso!");
                limpar();
            }
            catch
            {
                MessageBox.Show("Falha ao Atualizar");
            }
        }
    }
}
