namespace LojaInformatica1.EditarCadastro
{
    partial class FormEditarCliente
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
            this.lblProcurarCliente = new System.Windows.Forms.Label();
            this.lblEditarCliente = new System.Windows.Forms.Label();
            this.txtProcurarCliente = new System.Windows.Forms.TextBox();
            this.btnProcurarCliente = new System.Windows.Forms.Button();
            this.dgvProcurarCliente = new System.Windows.Forms.DataGridView();
            this.btnVoltarCliente = new System.Windows.Forms.Button();
            this.btnEditarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcurarCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProcurarCliente
            // 
            this.lblProcurarCliente.AutoSize = true;
            this.lblProcurarCliente.Location = new System.Drawing.Point(42, 85);
            this.lblProcurarCliente.Name = "lblProcurarCliente";
            this.lblProcurarCliente.Size = new System.Drawing.Size(85, 13);
            this.lblProcurarCliente.TabIndex = 0;
            this.lblProcurarCliente.Text = "Procurar Cliente:";
            // 
            // lblEditarCliente
            // 
            this.lblEditarCliente.AutoSize = true;
            this.lblEditarCliente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarCliente.Location = new System.Drawing.Point(41, 38);
            this.lblEditarCliente.Name = "lblEditarCliente";
            this.lblEditarCliente.Size = new System.Drawing.Size(102, 19);
            this.lblEditarCliente.TabIndex = 0;
            this.lblEditarCliente.Text = "Editar Cliente";
            // 
            // txtProcurarCliente
            // 
            this.txtProcurarCliente.Location = new System.Drawing.Point(143, 77);
            this.txtProcurarCliente.Name = "txtProcurarCliente";
            this.txtProcurarCliente.Size = new System.Drawing.Size(321, 20);
            this.txtProcurarCliente.TabIndex = 1;
            // 
            // btnProcurarCliente
            // 
            this.btnProcurarCliente.Location = new System.Drawing.Point(476, 73);
            this.btnProcurarCliente.Name = "btnProcurarCliente";
            this.btnProcurarCliente.Size = new System.Drawing.Size(100, 23);
            this.btnProcurarCliente.TabIndex = 2;
            this.btnProcurarCliente.Text = "Procurar Cliente";
            this.btnProcurarCliente.UseVisualStyleBackColor = true;
            // 
            // dgvProcurarCliente
            // 
            this.dgvProcurarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcurarCliente.Location = new System.Drawing.Point(45, 140);
            this.dgvProcurarCliente.Name = "dgvProcurarCliente";
            this.dgvProcurarCliente.Size = new System.Drawing.Size(531, 333);
            this.dgvProcurarCliente.TabIndex = 3;
            // 
            // btnVoltarCliente
            // 
            this.btnVoltarCliente.Location = new System.Drawing.Point(621, 431);
            this.btnVoltarCliente.Name = "btnVoltarCliente";
            this.btnVoltarCliente.Size = new System.Drawing.Size(107, 42);
            this.btnVoltarCliente.TabIndex = 4;
            this.btnVoltarCliente.Text = "Voltar";
            this.btnVoltarCliente.UseVisualStyleBackColor = true;
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.Location = new System.Drawing.Point(621, 371);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(107, 42);
            this.btnEditarCliente.TabIndex = 4;
            this.btnEditarCliente.Text = "Editar";
            this.btnEditarCliente.UseVisualStyleBackColor = true;
            // 
            // FormEditarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 536);
            this.Controls.Add(this.btnEditarCliente);
            this.Controls.Add(this.btnVoltarCliente);
            this.Controls.Add(this.dgvProcurarCliente);
            this.Controls.Add(this.btnProcurarCliente);
            this.Controls.Add(this.txtProcurarCliente);
            this.Controls.Add(this.lblEditarCliente);
            this.Controls.Add(this.lblProcurarCliente);
            this.Name = "FormEditarCliente";
            this.Text = "FormEditarCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcurarCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProcurarCliente;
        private System.Windows.Forms.Label lblEditarCliente;
        private System.Windows.Forms.TextBox txtProcurarCliente;
        private System.Windows.Forms.Button btnProcurarCliente;
        private System.Windows.Forms.DataGridView dgvProcurarCliente;
        private System.Windows.Forms.Button btnVoltarCliente;
        private System.Windows.Forms.Button btnEditarCliente;
    }
}