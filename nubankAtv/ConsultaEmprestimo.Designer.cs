
namespace nubankAtv
{
    partial class ConsultaEmprestimo
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
            this.btnVoltarEmprestimos = new System.Windows.Forms.Button();
            this.dgvEmprestimos = new System.Windows.Forms.DataGridView();
            this.lblConsultaEmprestimos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestimos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltarEmprestimos
            // 
            this.btnVoltarEmprestimos.Location = new System.Drawing.Point(278, 397);
            this.btnVoltarEmprestimos.Name = "btnVoltarEmprestimos";
            this.btnVoltarEmprestimos.Size = new System.Drawing.Size(94, 29);
            this.btnVoltarEmprestimos.TabIndex = 8;
            this.btnVoltarEmprestimos.Text = "Voltar";
            this.btnVoltarEmprestimos.UseVisualStyleBackColor = true;
            this.btnVoltarEmprestimos.Click += new System.EventHandler(this.btnVoltarEmprestimos_Click);
            // 
            // dgvEmprestimos
            // 
            this.dgvEmprestimos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmprestimos.Location = new System.Drawing.Point(88, 89);
            this.dgvEmprestimos.Name = "dgvEmprestimos";
            this.dgvEmprestimos.RowHeadersWidth = 51;
            this.dgvEmprestimos.RowTemplate.Height = 29;
            this.dgvEmprestimos.Size = new System.Drawing.Size(469, 286);
            this.dgvEmprestimos.TabIndex = 7;
            // 
            // lblConsultaEmprestimos
            // 
            this.lblConsultaEmprestimos.AutoSize = true;
            this.lblConsultaEmprestimos.Font = new System.Drawing.Font("Perpetua Titling MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblConsultaEmprestimos.Location = new System.Drawing.Point(120, 32);
            this.lblConsultaEmprestimos.Name = "lblConsultaEmprestimos";
            this.lblConsultaEmprestimos.Size = new System.Drawing.Size(416, 33);
            this.lblConsultaEmprestimos.TabIndex = 6;
            this.lblConsultaEmprestimos.Text = "Consultar Emprestimos";
            // 
            // ConsultaEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 450);
            this.Controls.Add(this.btnVoltarEmprestimos);
            this.Controls.Add(this.dgvEmprestimos);
            this.Controls.Add(this.lblConsultaEmprestimos);
            this.Name = "ConsultaEmprestimo";
            this.Text = "ConsultaEmprestimo";
            this.Load += new System.EventHandler(this.ConsultaEmprestimo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestimos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltarEmprestimos;
        private System.Windows.Forms.DataGridView dgvEmprestimos;
        private System.Windows.Forms.Label lblConsultaEmprestimos;
    }
}