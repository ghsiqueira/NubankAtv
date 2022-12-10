
namespace nubankAtv
{
    partial class ConsultaCliente
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
            this.dgvConsultaCliente = new System.Windows.Forms.DataGridView();
            this.lblConsultaCliente = new System.Windows.Forms.Label();
            this.btnVoltarConsultaCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultaCliente
            // 
            this.dgvConsultaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaCliente.Location = new System.Drawing.Point(43, 109);
            this.dgvConsultaCliente.Name = "dgvConsultaCliente";
            this.dgvConsultaCliente.RowHeadersWidth = 51;
            this.dgvConsultaCliente.RowTemplate.Height = 29;
            this.dgvConsultaCliente.Size = new System.Drawing.Size(531, 245);
            this.dgvConsultaCliente.TabIndex = 0;
            // 
            // lblConsultaCliente
            // 
            this.lblConsultaCliente.AutoSize = true;
            this.lblConsultaCliente.Font = new System.Drawing.Font("Perpetua Titling MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblConsultaCliente.Location = new System.Drawing.Point(149, 39);
            this.lblConsultaCliente.Name = "lblConsultaCliente";
            this.lblConsultaCliente.Size = new System.Drawing.Size(310, 33);
            this.lblConsultaCliente.TabIndex = 1;
            this.lblConsultaCliente.Text = "Consulta Cliente";
            // 
            // btnVoltarConsultaCliente
            // 
            this.btnVoltarConsultaCliente.Location = new System.Drawing.Point(265, 374);
            this.btnVoltarConsultaCliente.Name = "btnVoltarConsultaCliente";
            this.btnVoltarConsultaCliente.Size = new System.Drawing.Size(94, 29);
            this.btnVoltarConsultaCliente.TabIndex = 2;
            this.btnVoltarConsultaCliente.Text = "Voltar";
            this.btnVoltarConsultaCliente.UseVisualStyleBackColor = true;
            this.btnVoltarConsultaCliente.Click += new System.EventHandler(this.btnVoltarConsultaCliente_Click);
            // 
            // ConsultaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 415);
            this.Controls.Add(this.btnVoltarConsultaCliente);
            this.Controls.Add(this.lblConsultaCliente);
            this.Controls.Add(this.dgvConsultaCliente);
            this.Name = "ConsultaCliente";
            this.Text = "ConsultaCliente";
            this.Load += new System.EventHandler(this.ConsultaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultaCliente;
        private System.Windows.Forms.Label lblConsultaCliente;
        private System.Windows.Forms.Button btnVoltarConsultaCliente;
    }
}