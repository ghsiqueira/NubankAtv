
namespace nubankAtv
{
    partial class CadastroCliente
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
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.mskConta = new System.Windows.Forms.MaskedTextBox();
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.btnVoltarCadastroCliente = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtRenda = new System.Windows.Forms.TextBox();
            this.lblRenda = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblConta = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(302, 195);
            this.mskTelefone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mskTelefone.Mask = "99999-9999";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(114, 27);
            this.mskTelefone.TabIndex = 38;
            // 
            // mskCpf
            // 
            this.mskCpf.Location = new System.Drawing.Point(116, 43);
            this.mskCpf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mskCpf.Mask = "000.000.000-00";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(114, 27);
            this.mskCpf.TabIndex = 37;
            // 
            // mskConta
            // 
            this.mskConta.Location = new System.Drawing.Point(304, 47);
            this.mskConta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mskConta.Mask = "000000-0";
            this.mskConta.Name = "mskConta";
            this.mskConta.Size = new System.Drawing.Size(114, 27);
            this.mskConta.TabIndex = 36;
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.Location = new System.Drawing.Point(135, 266);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(114, 29);
            this.btnCadastrarCliente.TabIndex = 35;
            this.btnCadastrarCliente.Text = "Cadastrar";
            this.btnCadastrarCliente.UseVisualStyleBackColor = true;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            // 
            // btnVoltarCadastroCliente
            // 
            this.btnVoltarCadastroCliente.Location = new System.Drawing.Point(283, 266);
            this.btnVoltarCadastroCliente.Name = "btnVoltarCadastroCliente";
            this.btnVoltarCadastroCliente.Size = new System.Drawing.Size(114, 29);
            this.btnVoltarCadastroCliente.TabIndex = 34;
            this.btnVoltarCadastroCliente.Text = "Voltar";
            this.btnVoltarCadastroCliente.UseVisualStyleBackColor = true;
            this.btnVoltarCadastroCliente.Click += new System.EventHandler(this.btnVoltarCadastroCliente_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(113, 160);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(314, 27);
            this.txtEmail.TabIndex = 33;
            // 
            // txtRenda
            // 
            this.txtRenda.Location = new System.Drawing.Point(113, 196);
            this.txtRenda.Name = "txtRenda";
            this.txtRenda.Size = new System.Drawing.Size(114, 27);
            this.txtRenda.TabIndex = 32;
            // 
            // lblRenda
            // 
            this.lblRenda.AutoSize = true;
            this.lblRenda.Location = new System.Drawing.Point(61, 199);
            this.lblRenda.Name = "lblRenda";
            this.lblRenda.Size = new System.Drawing.Size(54, 20);
            this.lblRenda.TabIndex = 31;
            this.lblRenda.Text = "Renda:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(59, 163);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 20);
            this.lblEmail.TabIndex = 30;
            this.lblEmail.Text = "Email:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(113, 80);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(314, 27);
            this.txtNome.TabIndex = 29;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(113, 124);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(314, 27);
            this.txtEndereco.TabIndex = 28;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(233, 199);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(69, 20);
            this.lblTelefone.TabIndex = 27;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(36, 124);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(74, 20);
            this.lblEndereco.TabIndex = 26;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblConta
            // 
            this.lblConta.AutoSize = true;
            this.lblConta.Location = new System.Drawing.Point(248, 47);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(51, 20);
            this.lblConta.TabIndex = 25;
            this.lblConta.Text = "Conta:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(73, 47);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(36, 20);
            this.lblCpf.TabIndex = 24;
            this.lblCpf.Text = "CPF:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(57, 83);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(53, 20);
            this.lblNome.TabIndex = 23;
            this.lblNome.Text = "Nome:";
            // 
            // CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 327);
            this.Controls.Add(this.mskTelefone);
            this.Controls.Add(this.mskCpf);
            this.Controls.Add(this.mskConta);
            this.Controls.Add(this.btnCadastrarCliente);
            this.Controls.Add(this.btnVoltarCadastroCliente);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtRenda);
            this.Controls.Add(this.lblRenda);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblConta);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblNome);
            this.Name = "CadastroCliente";
            this.Text = "CadastroCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.MaskedTextBox mskConta;
        private System.Windows.Forms.Button btnCadastrarCliente;
        private System.Windows.Forms.Button btnVoltarCadastroCliente;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtRenda;
        private System.Windows.Forms.Label lblRenda;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblConta;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblNome;
    }
}