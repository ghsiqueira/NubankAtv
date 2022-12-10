
namespace nubankAtv
{
    partial class DadosCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.mskConta = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtRenda = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnAtualizarCadastro = new System.Windows.Forms.Button();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnVoltarDadosCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(38, 33);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(133, 20);
            this.lblId.TabIndex = 58;
            this.lblId.Text = "Código do Cliente:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(174, 30);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(54, 27);
            this.txtId.TabIndex = 57;
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(303, 219);
            this.mskTelefone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mskTelefone.Mask = "99999-9999";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(114, 27);
            this.mskTelefone.TabIndex = 56;
            // 
            // mskCpf
            // 
            this.mskCpf.Location = new System.Drawing.Point(117, 67);
            this.mskCpf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mskCpf.Mask = "000.000.000-00";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(114, 27);
            this.mskCpf.TabIndex = 55;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(234, 28);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(86, 31);
            this.btnBuscar.TabIndex = 42;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // mskConta
            // 
            this.mskConta.Location = new System.Drawing.Point(305, 71);
            this.mskConta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mskConta.Mask = "000000-0";
            this.mskConta.Name = "mskConta";
            this.mskConta.Size = new System.Drawing.Size(114, 27);
            this.mskConta.TabIndex = 54;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(114, 184);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(314, 27);
            this.txtEmail.TabIndex = 53;
            // 
            // txtRenda
            // 
            this.txtRenda.Location = new System.Drawing.Point(114, 220);
            this.txtRenda.Name = "txtRenda";
            this.txtRenda.Size = new System.Drawing.Size(114, 27);
            this.txtRenda.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 51;
            this.label7.Text = "Renda:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "Email:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(114, 104);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(314, 27);
            this.txtNome.TabIndex = 49;
            // 
            // btnAtualizarCadastro
            // 
            this.btnAtualizarCadastro.Location = new System.Drawing.Point(214, 278);
            this.btnAtualizarCadastro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAtualizarCadastro.Name = "btnAtualizarCadastro";
            this.btnAtualizarCadastro.Size = new System.Drawing.Size(86, 29);
            this.btnAtualizarCadastro.TabIndex = 41;
            this.btnAtualizarCadastro.Text = "Atualizar";
            this.btnAtualizarCadastro.UseVisualStyleBackColor = true;
            this.btnAtualizarCadastro.Click += new System.EventHandler(this.btnAtualizarCadastro_Click);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(114, 148);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(314, 27);
            this.txtEndereco.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(234, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 47;
            this.label8.Text = "Telefone:";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(357, 277);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(86, 31);
            this.btnExcluir.TabIndex = 39;
            this.btnExcluir.Text = "Excluir Cadastro";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 20);
            this.label9.TabIndex = 46;
            this.label9.Text = "Endereço:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(58, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 20);
            this.label12.TabIndex = 43;
            this.label12.Text = "Nome:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(249, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 20);
            this.label10.TabIndex = 45;
            this.label10.Text = "Conta:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(74, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 20);
            this.label11.TabIndex = 44;
            this.label11.Text = "CPF:";
            // 
            // btnVoltarDadosCliente
            // 
            this.btnVoltarDadosCliente.Location = new System.Drawing.Point(74, 278);
            this.btnVoltarDadosCliente.Name = "btnVoltarDadosCliente";
            this.btnVoltarDadosCliente.Size = new System.Drawing.Size(86, 29);
            this.btnVoltarDadosCliente.TabIndex = 59;
            this.btnVoltarDadosCliente.Text = "Voltar";
            this.btnVoltarDadosCliente.UseVisualStyleBackColor = true;
            this.btnVoltarDadosCliente.Click += new System.EventHandler(this.btnVoltarDadosCliente_Click);
            // 
            // DadosCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 335);
            this.Controls.Add(this.btnVoltarDadosCliente);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.mskTelefone);
            this.Controls.Add(this.mskCpf);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.mskConta);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtRenda);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnAtualizarCadastro);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Name = "DadosCliente";
            this.Text = "DadosCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.MaskedTextBox mskConta;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtRenda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnAtualizarCadastro;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnVoltarDadosCliente;
    }
}