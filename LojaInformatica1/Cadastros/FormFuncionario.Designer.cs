namespace LojaInformatica1.Cadastros
{
    partial class FormFuncionario
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
            this.btnCancelarFuncionario = new System.Windows.Forms.Button();
            this.btnSalvarFuncionario = new System.Windows.Forms.Button();
            this.cbxEstadoFuncionario = new System.Windows.Forms.ComboBox();
            this.dtpDataDemissao = new System.Windows.Forms.DateTimePicker();
            this.dtpDataEmissao = new System.Windows.Forms.DateTimePicker();
            this.txtCodFuncionario = new System.Windows.Forms.TextBox();
            this.txtCargoFuncionario = new System.Windows.Forms.TextBox();
            this.txtTelefoneFuncionario = new System.Windows.Forms.TextBox();
            this.txtCelularFuncionario = new System.Windows.Forms.TextBox();
            this.txtCPFFuncionario = new System.Windows.Forms.TextBox();
            this.txtCidadeFuncionario = new System.Windows.Forms.TextBox();
            this.txtBairroFuncionario = new System.Windows.Forms.TextBox();
            this.txtEnderecoFuncionario = new System.Windows.Forms.TextBox();
            this.txtEmailFuncionario = new System.Windows.Forms.TextBox();
            this.txtNomeFuncionario = new System.Windows.Forms.TextBox();
            this.grbValeRefeicao = new System.Windows.Forms.GroupBox();
            this.rdbSimRefeicao = new System.Windows.Forms.RadioButton();
            this.rdbNaoRefeicao = new System.Windows.Forms.RadioButton();
            this.grbValeTransporte = new System.Windows.Forms.GroupBox();
            this.rdbSimTransporte = new System.Windows.Forms.RadioButton();
            this.rdbNaoTransporte = new System.Windows.Forms.RadioButton();
            this.lblDataDemissaoFuncionario = new System.Windows.Forms.Label();
            this.lblDataEmissaoFuncionario = new System.Windows.Forms.Label();
            this.lblCargoFuncionario = new System.Windows.Forms.Label();
            this.lblCodFuncionario = new System.Windows.Forms.Label();
            this.lblCelularFuncionario = new System.Windows.Forms.Label();
            this.lblTelefoneFuncionario = new System.Windows.Forms.Label();
            this.lblEstadoFuncionario = new System.Windows.Forms.Label();
            this.lblCidadeFuncionario = new System.Windows.Forms.Label();
            this.lblBairroFuncionario = new System.Windows.Forms.Label();
            this.lblEnderecoFuncionario = new System.Windows.Forms.Label();
            this.lblCPFFuncionario = new System.Windows.Forms.Label();
            this.lblEmailFuncionario = new System.Windows.Forms.Label();
            this.lblNomeFuncionario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLoginFuncionario = new System.Windows.Forms.Label();
            this.lblSenhaFuncionario = new System.Windows.Forms.Label();
            this.txtSenhaFuncionario = new System.Windows.Forms.TextBox();
            this.txtLoginFuncionario = new System.Windows.Forms.TextBox();
            this.grbValeRefeicao.SuspendLayout();
            this.grbValeTransporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelarFuncionario
            // 
            this.btnCancelarFuncionario.Location = new System.Drawing.Point(551, 467);
            this.btnCancelarFuncionario.Name = "btnCancelarFuncionario";
            this.btnCancelarFuncionario.Size = new System.Drawing.Size(148, 30);
            this.btnCancelarFuncionario.TabIndex = 43;
            this.btnCancelarFuncionario.Text = "Cancelar";
            this.btnCancelarFuncionario.UseVisualStyleBackColor = true;
            // 
            // btnSalvarFuncionario
            // 
            this.btnSalvarFuncionario.Location = new System.Drawing.Point(551, 426);
            this.btnSalvarFuncionario.Name = "btnSalvarFuncionario";
            this.btnSalvarFuncionario.Size = new System.Drawing.Size(148, 30);
            this.btnSalvarFuncionario.TabIndex = 44;
            this.btnSalvarFuncionario.Text = "Salvar Funcionário";
            this.btnSalvarFuncionario.UseVisualStyleBackColor = true;
            // 
            // cbxEstadoFuncionario
            // 
            this.cbxEstadoFuncionario.FormattingEnabled = true;
            this.cbxEstadoFuncionario.Items.AddRange(new object[] {
            "Acre (AC)",
            "Alagoas (AL)",
            "Amapá (AP)",
            "Amazonas (AM)",
            "Bahia (BA)",
            "Ceará (CE)",
            "Distrito Federal (DF)",
            "Espírito Santo (ES)",
            "Goiás (GO)",
            "Maranhão (MA)",
            "Mato Grosso (MT)",
            "Mato Grosso do Sul (MS)",
            "Minas Gerais (MG)",
            "Pará (PA)",
            "Paraíba (PB)",
            "Paraná (PR)",
            "Pernambuco (PE)",
            "Piauí (PI)",
            "Rio de Janeiro (RJ)",
            "Rio Grande do Norte (RN)",
            "Rio Grande do Sul (RS)",
            "Rondônia (RO)",
            "Roraima (RR)",
            "Santa Catarina (SC)",
            "São Paulo (SP)",
            "Sergipe (SE)",
            "Tocantins (TO)"});
            this.cbxEstadoFuncionario.Location = new System.Drawing.Point(90, 240);
            this.cbxEstadoFuncionario.Name = "cbxEstadoFuncionario";
            this.cbxEstadoFuncionario.Size = new System.Drawing.Size(171, 21);
            this.cbxEstadoFuncionario.TabIndex = 42;
            this.cbxEstadoFuncionario.Text = "Selecione um estado...";
            // 
            // dtpDataDemissao
            // 
            this.dtpDataDemissao.CustomFormat = "dd/mm/yyyy";
            this.dtpDataDemissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataDemissao.Location = new System.Drawing.Point(387, 379);
            this.dtpDataDemissao.MinDate = new System.DateTime(2015, 5, 4, 0, 0, 0, 0);
            this.dtpDataDemissao.Name = "dtpDataDemissao";
            this.dtpDataDemissao.Size = new System.Drawing.Size(134, 20);
            this.dtpDataDemissao.TabIndex = 38;
            this.dtpDataDemissao.Value = new System.DateTime(2015, 5, 4, 0, 0, 0, 0);
            // 
            // dtpDataEmissao
            // 
            this.dtpDataEmissao.CustomFormat = "dd/mm/yyyy";
            this.dtpDataEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEmissao.Location = new System.Drawing.Point(127, 379);
            this.dtpDataEmissao.MinDate = new System.DateTime(2015, 5, 4, 0, 0, 0, 0);
            this.dtpDataEmissao.Name = "dtpDataEmissao";
            this.dtpDataEmissao.Size = new System.Drawing.Size(134, 20);
            this.dtpDataEmissao.TabIndex = 39;
            this.dtpDataEmissao.Value = new System.DateTime(2015, 5, 4, 0, 0, 0, 0);
            // 
            // txtCodFuncionario
            // 
            this.txtCodFuncionario.Location = new System.Drawing.Point(90, 312);
            this.txtCodFuncionario.Name = "txtCodFuncionario";
            this.txtCodFuncionario.Size = new System.Drawing.Size(171, 20);
            this.txtCodFuncionario.TabIndex = 31;
            // 
            // txtCargoFuncionario
            // 
            this.txtCargoFuncionario.Location = new System.Drawing.Point(315, 312);
            this.txtCargoFuncionario.Name = "txtCargoFuncionario";
            this.txtCargoFuncionario.Size = new System.Drawing.Size(206, 20);
            this.txtCargoFuncionario.TabIndex = 32;
            // 
            // txtTelefoneFuncionario
            // 
            this.txtTelefoneFuncionario.Location = new System.Drawing.Point(90, 275);
            this.txtTelefoneFuncionario.Name = "txtTelefoneFuncionario";
            this.txtTelefoneFuncionario.Size = new System.Drawing.Size(172, 20);
            this.txtTelefoneFuncionario.TabIndex = 29;
            // 
            // txtCelularFuncionario
            // 
            this.txtCelularFuncionario.Location = new System.Drawing.Point(315, 275);
            this.txtCelularFuncionario.Name = "txtCelularFuncionario";
            this.txtCelularFuncionario.Size = new System.Drawing.Size(206, 20);
            this.txtCelularFuncionario.TabIndex = 30;
            // 
            // txtCPFFuncionario
            // 
            this.txtCPFFuncionario.Location = new System.Drawing.Point(315, 240);
            this.txtCPFFuncionario.Name = "txtCPFFuncionario";
            this.txtCPFFuncionario.Size = new System.Drawing.Size(206, 20);
            this.txtCPFFuncionario.TabIndex = 33;
            // 
            // txtCidadeFuncionario
            // 
            this.txtCidadeFuncionario.Location = new System.Drawing.Point(90, 208);
            this.txtCidadeFuncionario.Name = "txtCidadeFuncionario";
            this.txtCidadeFuncionario.Size = new System.Drawing.Size(431, 20);
            this.txtCidadeFuncionario.TabIndex = 36;
            // 
            // txtBairroFuncionario
            // 
            this.txtBairroFuncionario.Location = new System.Drawing.Point(90, 176);
            this.txtBairroFuncionario.Name = "txtBairroFuncionario";
            this.txtBairroFuncionario.Size = new System.Drawing.Size(431, 20);
            this.txtBairroFuncionario.TabIndex = 37;
            // 
            // txtEnderecoFuncionario
            // 
            this.txtEnderecoFuncionario.Location = new System.Drawing.Point(90, 142);
            this.txtEnderecoFuncionario.Name = "txtEnderecoFuncionario";
            this.txtEnderecoFuncionario.Size = new System.Drawing.Size(431, 20);
            this.txtEnderecoFuncionario.TabIndex = 34;
            // 
            // txtEmailFuncionario
            // 
            this.txtEmailFuncionario.Location = new System.Drawing.Point(90, 110);
            this.txtEmailFuncionario.Name = "txtEmailFuncionario";
            this.txtEmailFuncionario.Size = new System.Drawing.Size(431, 20);
            this.txtEmailFuncionario.TabIndex = 35;
            // 
            // txtNomeFuncionario
            // 
            this.txtNomeFuncionario.Location = new System.Drawing.Point(90, 80);
            this.txtNomeFuncionario.Name = "txtNomeFuncionario";
            this.txtNomeFuncionario.Size = new System.Drawing.Size(431, 20);
            this.txtNomeFuncionario.TabIndex = 28;
            // 
            // grbValeRefeicao
            // 
            this.grbValeRefeicao.Controls.Add(this.rdbSimRefeicao);
            this.grbValeRefeicao.Controls.Add(this.rdbNaoRefeicao);
            this.grbValeRefeicao.Location = new System.Drawing.Point(50, 426);
            this.grbValeRefeicao.Name = "grbValeRefeicao";
            this.grbValeRefeicao.Size = new System.Drawing.Size(173, 71);
            this.grbValeRefeicao.TabIndex = 26;
            this.grbValeRefeicao.TabStop = false;
            this.grbValeRefeicao.Text = "Vale Refeição";
            this.grbValeRefeicao.Enter += new System.EventHandler(this.grbValeRefeicao_Enter);
            // 
            // rdbSimRefeicao
            // 
            this.rdbSimRefeicao.AutoSize = true;
            this.rdbSimRefeicao.Location = new System.Drawing.Point(18, 31);
            this.rdbSimRefeicao.Name = "rdbSimRefeicao";
            this.rdbSimRefeicao.Size = new System.Drawing.Size(44, 17);
            this.rdbSimRefeicao.TabIndex = 3;
            this.rdbSimRefeicao.TabStop = true;
            this.rdbSimRefeicao.Text = "SIM";
            this.rdbSimRefeicao.UseVisualStyleBackColor = true;
            // 
            // rdbNaoRefeicao
            // 
            this.rdbNaoRefeicao.AutoSize = true;
            this.rdbNaoRefeicao.Location = new System.Drawing.Point(102, 31);
            this.rdbNaoRefeicao.Name = "rdbNaoRefeicao";
            this.rdbNaoRefeicao.Size = new System.Drawing.Size(48, 17);
            this.rdbNaoRefeicao.TabIndex = 2;
            this.rdbNaoRefeicao.TabStop = true;
            this.rdbNaoRefeicao.Text = "NÃO";
            this.rdbNaoRefeicao.UseVisualStyleBackColor = true;
            // 
            // grbValeTransporte
            // 
            this.grbValeTransporte.Controls.Add(this.rdbSimTransporte);
            this.grbValeTransporte.Controls.Add(this.rdbNaoTransporte);
            this.grbValeTransporte.Location = new System.Drawing.Point(270, 426);
            this.grbValeTransporte.Name = "grbValeTransporte";
            this.grbValeTransporte.Size = new System.Drawing.Size(166, 71);
            this.grbValeTransporte.TabIndex = 27;
            this.grbValeTransporte.TabStop = false;
            this.grbValeTransporte.Text = "Vale Transporte";
            this.grbValeTransporte.Enter += new System.EventHandler(this.grbValeTransporte_Enter);
            // 
            // rdbSimTransporte
            // 
            this.rdbSimTransporte.AutoSize = true;
            this.rdbSimTransporte.Location = new System.Drawing.Point(16, 31);
            this.rdbSimTransporte.Name = "rdbSimTransporte";
            this.rdbSimTransporte.Size = new System.Drawing.Size(44, 17);
            this.rdbSimTransporte.TabIndex = 4;
            this.rdbSimTransporte.TabStop = true;
            this.rdbSimTransporte.Text = "SIM";
            this.rdbSimTransporte.UseVisualStyleBackColor = true;
            // 
            // rdbNaoTransporte
            // 
            this.rdbNaoTransporte.AutoSize = true;
            this.rdbNaoTransporte.Location = new System.Drawing.Point(98, 31);
            this.rdbNaoTransporte.Name = "rdbNaoTransporte";
            this.rdbNaoTransporte.Size = new System.Drawing.Size(48, 17);
            this.rdbNaoTransporte.TabIndex = 3;
            this.rdbNaoTransporte.TabStop = true;
            this.rdbNaoTransporte.Text = "NÃO";
            this.rdbNaoTransporte.UseVisualStyleBackColor = true;
            // 
            // lblDataDemissaoFuncionario
            // 
            this.lblDataDemissaoFuncionario.AutoSize = true;
            this.lblDataDemissaoFuncionario.Location = new System.Drawing.Point(267, 385);
            this.lblDataDemissaoFuncionario.Name = "lblDataDemissaoFuncionario";
            this.lblDataDemissaoFuncionario.Size = new System.Drawing.Size(97, 13);
            this.lblDataDemissaoFuncionario.TabIndex = 16;
            this.lblDataDemissaoFuncionario.Text = "Data de Demissão:";
            // 
            // lblDataEmissaoFuncionario
            // 
            this.lblDataEmissaoFuncionario.AutoSize = true;
            this.lblDataEmissaoFuncionario.Location = new System.Drawing.Point(31, 385);
            this.lblDataEmissaoFuncionario.Name = "lblDataEmissaoFuncionario";
            this.lblDataEmissaoFuncionario.Size = new System.Drawing.Size(90, 13);
            this.lblDataEmissaoFuncionario.TabIndex = 17;
            this.lblDataEmissaoFuncionario.Text = "Data de Emissão:";
            // 
            // lblCargoFuncionario
            // 
            this.lblCargoFuncionario.AutoSize = true;
            this.lblCargoFuncionario.Location = new System.Drawing.Point(267, 319);
            this.lblCargoFuncionario.Name = "lblCargoFuncionario";
            this.lblCargoFuncionario.Size = new System.Drawing.Size(38, 13);
            this.lblCargoFuncionario.TabIndex = 18;
            this.lblCargoFuncionario.Text = "Cargo:";
            // 
            // lblCodFuncionario
            // 
            this.lblCodFuncionario.AutoSize = true;
            this.lblCodFuncionario.Location = new System.Drawing.Point(31, 319);
            this.lblCodFuncionario.Name = "lblCodFuncionario";
            this.lblCodFuncionario.Size = new System.Drawing.Size(43, 13);
            this.lblCodFuncionario.TabIndex = 13;
            this.lblCodFuncionario.Text = "Código:";
            // 
            // lblCelularFuncionario
            // 
            this.lblCelularFuncionario.AutoSize = true;
            this.lblCelularFuncionario.Location = new System.Drawing.Point(267, 282);
            this.lblCelularFuncionario.Name = "lblCelularFuncionario";
            this.lblCelularFuncionario.Size = new System.Drawing.Size(42, 13);
            this.lblCelularFuncionario.TabIndex = 14;
            this.lblCelularFuncionario.Text = "Celular:";
            // 
            // lblTelefoneFuncionario
            // 
            this.lblTelefoneFuncionario.AutoSize = true;
            this.lblTelefoneFuncionario.Location = new System.Drawing.Point(31, 282);
            this.lblTelefoneFuncionario.Name = "lblTelefoneFuncionario";
            this.lblTelefoneFuncionario.Size = new System.Drawing.Size(52, 13);
            this.lblTelefoneFuncionario.TabIndex = 15;
            this.lblTelefoneFuncionario.Text = "Telefone:";
            // 
            // lblEstadoFuncionario
            // 
            this.lblEstadoFuncionario.AutoSize = true;
            this.lblEstadoFuncionario.Location = new System.Drawing.Point(31, 247);
            this.lblEstadoFuncionario.Name = "lblEstadoFuncionario";
            this.lblEstadoFuncionario.Size = new System.Drawing.Size(43, 13);
            this.lblEstadoFuncionario.TabIndex = 19;
            this.lblEstadoFuncionario.Text = "Estado:";
            // 
            // lblCidadeFuncionario
            // 
            this.lblCidadeFuncionario.AutoSize = true;
            this.lblCidadeFuncionario.Location = new System.Drawing.Point(31, 215);
            this.lblCidadeFuncionario.Name = "lblCidadeFuncionario";
            this.lblCidadeFuncionario.Size = new System.Drawing.Size(43, 13);
            this.lblCidadeFuncionario.TabIndex = 23;
            this.lblCidadeFuncionario.Text = "Cidade:";
            // 
            // lblBairroFuncionario
            // 
            this.lblBairroFuncionario.AutoSize = true;
            this.lblBairroFuncionario.Location = new System.Drawing.Point(31, 183);
            this.lblBairroFuncionario.Name = "lblBairroFuncionario";
            this.lblBairroFuncionario.Size = new System.Drawing.Size(37, 13);
            this.lblBairroFuncionario.TabIndex = 24;
            this.lblBairroFuncionario.Text = "Bairro:";
            // 
            // lblEnderecoFuncionario
            // 
            this.lblEnderecoFuncionario.AutoSize = true;
            this.lblEnderecoFuncionario.Location = new System.Drawing.Point(31, 149);
            this.lblEnderecoFuncionario.Name = "lblEnderecoFuncionario";
            this.lblEnderecoFuncionario.Size = new System.Drawing.Size(56, 13);
            this.lblEnderecoFuncionario.TabIndex = 25;
            this.lblEnderecoFuncionario.Text = "Endereço:";
            // 
            // lblCPFFuncionario
            // 
            this.lblCPFFuncionario.AutoSize = true;
            this.lblCPFFuncionario.Location = new System.Drawing.Point(267, 247);
            this.lblCPFFuncionario.Name = "lblCPFFuncionario";
            this.lblCPFFuncionario.Size = new System.Drawing.Size(30, 13);
            this.lblCPFFuncionario.TabIndex = 20;
            this.lblCPFFuncionario.Text = "CPF:";
            // 
            // lblEmailFuncionario
            // 
            this.lblEmailFuncionario.AutoSize = true;
            this.lblEmailFuncionario.Location = new System.Drawing.Point(31, 117);
            this.lblEmailFuncionario.Name = "lblEmailFuncionario";
            this.lblEmailFuncionario.Size = new System.Drawing.Size(35, 13);
            this.lblEmailFuncionario.TabIndex = 21;
            this.lblEmailFuncionario.Text = "Email:";
            // 
            // lblNomeFuncionario
            // 
            this.lblNomeFuncionario.AutoSize = true;
            this.lblNomeFuncionario.Location = new System.Drawing.Point(31, 88);
            this.lblNomeFuncionario.Name = "lblNomeFuncionario";
            this.lblNomeFuncionario.Size = new System.Drawing.Size(38, 13);
            this.lblNomeFuncionario.TabIndex = 22;
            this.lblNomeFuncionario.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Cadastro de Funcionários";
            // 
            // lblLoginFuncionario
            // 
            this.lblLoginFuncionario.AutoSize = true;
            this.lblLoginFuncionario.Location = new System.Drawing.Point(32, 352);
            this.lblLoginFuncionario.Name = "lblLoginFuncionario";
            this.lblLoginFuncionario.Size = new System.Drawing.Size(36, 13);
            this.lblLoginFuncionario.TabIndex = 13;
            this.lblLoginFuncionario.Text = "Login:";
            // 
            // lblSenhaFuncionario
            // 
            this.lblSenhaFuncionario.AutoSize = true;
            this.lblSenhaFuncionario.Location = new System.Drawing.Point(268, 352);
            this.lblSenhaFuncionario.Name = "lblSenhaFuncionario";
            this.lblSenhaFuncionario.Size = new System.Drawing.Size(41, 13);
            this.lblSenhaFuncionario.TabIndex = 18;
            this.lblSenhaFuncionario.Text = "Senha:";
            // 
            // txtSenhaFuncionario
            // 
            this.txtSenhaFuncionario.Location = new System.Drawing.Point(316, 345);
            this.txtSenhaFuncionario.Name = "txtSenhaFuncionario";
            this.txtSenhaFuncionario.Size = new System.Drawing.Size(206, 20);
            this.txtSenhaFuncionario.TabIndex = 32;
            // 
            // txtLoginFuncionario
            // 
            this.txtLoginFuncionario.Location = new System.Drawing.Point(91, 345);
            this.txtLoginFuncionario.Name = "txtLoginFuncionario";
            this.txtLoginFuncionario.Size = new System.Drawing.Size(171, 20);
            this.txtLoginFuncionario.TabIndex = 31;
            // 
            // FormFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 519);
            this.Controls.Add(this.btnCancelarFuncionario);
            this.Controls.Add(this.btnSalvarFuncionario);
            this.Controls.Add(this.cbxEstadoFuncionario);
            this.Controls.Add(this.dtpDataDemissao);
            this.Controls.Add(this.dtpDataEmissao);
            this.Controls.Add(this.txtLoginFuncionario);
            this.Controls.Add(this.txtSenhaFuncionario);
            this.Controls.Add(this.txtCodFuncionario);
            this.Controls.Add(this.txtCargoFuncionario);
            this.Controls.Add(this.txtTelefoneFuncionario);
            this.Controls.Add(this.txtCelularFuncionario);
            this.Controls.Add(this.txtCPFFuncionario);
            this.Controls.Add(this.txtCidadeFuncionario);
            this.Controls.Add(this.txtBairroFuncionario);
            this.Controls.Add(this.txtEnderecoFuncionario);
            this.Controls.Add(this.txtEmailFuncionario);
            this.Controls.Add(this.txtNomeFuncionario);
            this.Controls.Add(this.grbValeRefeicao);
            this.Controls.Add(this.grbValeTransporte);
            this.Controls.Add(this.lblDataDemissaoFuncionario);
            this.Controls.Add(this.lblSenhaFuncionario);
            this.Controls.Add(this.lblDataEmissaoFuncionario);
            this.Controls.Add(this.lblLoginFuncionario);
            this.Controls.Add(this.lblCargoFuncionario);
            this.Controls.Add(this.lblCodFuncionario);
            this.Controls.Add(this.lblCelularFuncionario);
            this.Controls.Add(this.lblTelefoneFuncionario);
            this.Controls.Add(this.lblEstadoFuncionario);
            this.Controls.Add(this.lblCidadeFuncionario);
            this.Controls.Add(this.lblBairroFuncionario);
            this.Controls.Add(this.lblEnderecoFuncionario);
            this.Controls.Add(this.lblCPFFuncionario);
            this.Controls.Add(this.lblEmailFuncionario);
            this.Controls.Add(this.lblNomeFuncionario);
            this.Controls.Add(this.label1);
            this.Name = "FormFuncionario";
            this.Text = "Cadastro de Funcionários";
            this.grbValeRefeicao.ResumeLayout(false);
            this.grbValeRefeicao.PerformLayout();
            this.grbValeTransporte.ResumeLayout(false);
            this.grbValeTransporte.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarFuncionario;
        private System.Windows.Forms.Button btnSalvarFuncionario;
        private System.Windows.Forms.ComboBox cbxEstadoFuncionario;
        private System.Windows.Forms.DateTimePicker dtpDataDemissao;
        private System.Windows.Forms.DateTimePicker dtpDataEmissao;
        private System.Windows.Forms.TextBox txtCodFuncionario;
        private System.Windows.Forms.TextBox txtCargoFuncionario;
        private System.Windows.Forms.TextBox txtTelefoneFuncionario;
        private System.Windows.Forms.TextBox txtCelularFuncionario;
        private System.Windows.Forms.TextBox txtCPFFuncionario;
        private System.Windows.Forms.TextBox txtCidadeFuncionario;
        private System.Windows.Forms.TextBox txtBairroFuncionario;
        private System.Windows.Forms.TextBox txtEnderecoFuncionario;
        private System.Windows.Forms.TextBox txtEmailFuncionario;
        private System.Windows.Forms.TextBox txtNomeFuncionario;
        private System.Windows.Forms.GroupBox grbValeRefeicao;
        private System.Windows.Forms.RadioButton rdbSimRefeicao;
        private System.Windows.Forms.RadioButton rdbNaoRefeicao;
        private System.Windows.Forms.GroupBox grbValeTransporte;
        private System.Windows.Forms.RadioButton rdbSimTransporte;
        private System.Windows.Forms.RadioButton rdbNaoTransporte;
        private System.Windows.Forms.Label lblDataDemissaoFuncionario;
        private System.Windows.Forms.Label lblDataEmissaoFuncionario;
        private System.Windows.Forms.Label lblCargoFuncionario;
        private System.Windows.Forms.Label lblCodFuncionario;
        private System.Windows.Forms.Label lblCelularFuncionario;
        private System.Windows.Forms.Label lblTelefoneFuncionario;
        private System.Windows.Forms.Label lblEstadoFuncionario;
        private System.Windows.Forms.Label lblCidadeFuncionario;
        private System.Windows.Forms.Label lblBairroFuncionario;
        private System.Windows.Forms.Label lblEnderecoFuncionario;
        private System.Windows.Forms.Label lblCPFFuncionario;
        private System.Windows.Forms.Label lblEmailFuncionario;
        private System.Windows.Forms.Label lblNomeFuncionario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLoginFuncionario;
        private System.Windows.Forms.Label lblSenhaFuncionario;
        private System.Windows.Forms.TextBox txtSenhaFuncionario;
        private System.Windows.Forms.TextBox txtLoginFuncionario;
    }
}