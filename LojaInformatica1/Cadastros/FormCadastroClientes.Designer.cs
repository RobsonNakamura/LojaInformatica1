namespace LojaInformatica1.Cadastros
{
    partial class FormCadastroClientes
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
            this.grbTipoPessoa = new System.Windows.Forms.GroupBox();
            this.rdbPJ = new System.Windows.Forms.RadioButton();
            this.rdbPF = new System.Windows.Forms.RadioButton();
            this.grbTipoPessoa.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbTipoPessoa
            // 
            this.grbTipoPessoa.Controls.Add(this.rdbPJ);
            this.grbTipoPessoa.Controls.Add(this.rdbPF);
            this.grbTipoPessoa.Location = new System.Drawing.Point(30, 40);
            this.grbTipoPessoa.Name = "grbTipoPessoa";
            this.grbTipoPessoa.Size = new System.Drawing.Size(372, 72);
            this.grbTipoPessoa.TabIndex = 2;
            this.grbTipoPessoa.TabStop = false;
            this.grbTipoPessoa.Text = "Escolha o tipo de pessoa";
            // 
            // rdbPJ
            // 
            this.rdbPJ.AutoSize = true;
            this.rdbPJ.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPJ.Location = new System.Drawing.Point(204, 34);
            this.rdbPJ.Name = "rdbPJ";
            this.rdbPJ.Size = new System.Drawing.Size(126, 17);
            this.rdbPJ.TabIndex = 0;
            this.rdbPJ.Text = "Pessoa Júridica";
            this.rdbPJ.UseVisualStyleBackColor = true;
            // 
            // rdbPF
            // 
            this.rdbPF.AutoSize = true;
            this.rdbPF.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPF.Location = new System.Drawing.Point(27, 34);
            this.rdbPF.Name = "rdbPF";
            this.rdbPF.Size = new System.Drawing.Size(113, 17);
            this.rdbPF.TabIndex = 0;
            this.rdbPF.Text = "Pessoa Física";
            this.rdbPF.UseVisualStyleBackColor = false;
            // 
            // FormCadastroClientes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1001, 535);
            this.Controls.Add(this.grbTipoPessoa);
            this.Name = "FormCadastroClientes";
            this.Text = "FormCadastroClientes";
            this.grbTipoPessoa.ResumeLayout(false);
            this.grbTipoPessoa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTipoPessoa;
        private System.Windows.Forms.RadioButton rdbPJ;
        private System.Windows.Forms.RadioButton rdbPF;
    }
}