
namespace nubankAtv
{
    partial class ConsultaTransacoes
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
            this.btnVoltarTransacoes = new System.Windows.Forms.Button();
            this.dgvTransacoes = new System.Windows.Forms.DataGridView();
            this.lblConsultaTransacoes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransacoes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltarTransacoes
            // 
            this.btnVoltarTransacoes.Location = new System.Drawing.Point(270, 390);
            this.btnVoltarTransacoes.Name = "btnVoltarTransacoes";
            this.btnVoltarTransacoes.Size = new System.Drawing.Size(94, 29);
            this.btnVoltarTransacoes.TabIndex = 5;
            this.btnVoltarTransacoes.Text = "Voltar";
            this.btnVoltarTransacoes.UseVisualStyleBackColor = true;
            this.btnVoltarTransacoes.Click += new System.EventHandler(this.btnVoltarTransacoes_Click);
            // 
            // dgvTransacoes
            // 
            this.dgvTransacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransacoes.Location = new System.Drawing.Point(80, 82);
            this.dgvTransacoes.Name = "dgvTransacoes";
            this.dgvTransacoes.RowHeadersWidth = 51;
            this.dgvTransacoes.RowTemplate.Height = 29;
            this.dgvTransacoes.Size = new System.Drawing.Size(469, 286);
            this.dgvTransacoes.TabIndex = 4;
            // 
            // lblConsultaTransacoes
            // 
            this.lblConsultaTransacoes.AutoSize = true;
            this.lblConsultaTransacoes.Font = new System.Drawing.Font("Perpetua Titling MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblConsultaTransacoes.Location = new System.Drawing.Point(112, 25);
            this.lblConsultaTransacoes.Name = "lblConsultaTransacoes";
            this.lblConsultaTransacoes.Size = new System.Drawing.Size(406, 33);
            this.lblConsultaTransacoes.TabIndex = 3;
            this.lblConsultaTransacoes.Text = "Consultar Transações";
            // 
            // ConsultaTransacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 450);
            this.Controls.Add(this.btnVoltarTransacoes);
            this.Controls.Add(this.dgvTransacoes);
            this.Controls.Add(this.lblConsultaTransacoes);
            this.Name = "ConsultaTransacoes";
            this.Text = "ConsultaTransacoes";
            this.Load += new System.EventHandler(this.ConsultaTransacoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransacoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltarTransacoes;
        private System.Windows.Forms.DataGridView dgvTransacoes;
        private System.Windows.Forms.Label lblConsultaTransacoes;
    }
}