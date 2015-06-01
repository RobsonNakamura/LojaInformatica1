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
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grbPF = new System.Windows.Forms.GroupBox();
            this.dtpDataNascimentoPF = new System.Windows.Forms.DateTimePicker();
            this.txtRGPF = new System.Windows.Forms.TextBox();
            this.txtCPFPF = new System.Windows.Forms.TextBox();
            this.lblDataNacimentoPF = new System.Windows.Forms.Label();
            this.lblRGPF = new System.Windows.Forms.Label();
            this.lblCPFPF = new System.Windows.Forms.Label();
            this.grbPJ = new System.Windows.Forms.GroupBox();
            this.txtInscricaoEstadualPJ = new System.Windows.Forms.TextBox();
            this.txtCNPJPJ = new System.Windows.Forms.TextBox();
            this.txtRazaoSocialPJ = new System.Windows.Forms.TextBox();
            this.lblInscricaoEstadualPJ = new System.Windows.Forms.Label();
            this.lblRazaoSocialPJ = new System.Windows.Forms.Label();
            this.lblCNPJPJ = new System.Windows.Forms.Label();
            this.grbTipoPessoa.SuspendLayout();
            this.grbPF.SuspendLayout();
            this.grbPJ.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbTipoPessoa
            // 
            this.grbTipoPessoa.Controls.Add(this.rdbPJ);
            this.grbTipoPessoa.Controls.Add(this.rdbPF);
            this.grbTipoPessoa.Location = new System.Drawing.Point(22, 22);
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
            this.rdbPJ.CheckedChanged += new System.EventHandler(this.rdbPJ_CheckedChanged);
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
            this.rdbPF.CheckedChanged += new System.EventHandler(this.rdbPF_CheckedChanged);
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(35, 409);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(424, 105);
            this.txtObservacao.TabIndex = 93;
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacao.Location = new System.Drawing.Point(32, 390);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(74, 15);
            this.lblObservacao.TabIndex = 92;
            this.lblObservacao.Text = "Observação:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(578, 474);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(130, 40);
            this.btnSalvar.TabIndex = 91;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cbxEstado
            // 
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
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
            this.cbxEstado.Location = new System.Drawing.Point(810, 348);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(123, 21);
            this.cbxEstado.TabIndex = 90;
            this.cbxEstado.Text = "Selecione o Estado...";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(104, 341);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(136, 20);
            this.txtLogin.TabIndex = 82;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(336, 341);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(123, 20);
            this.txtSenha.TabIndex = 83;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(336, 304);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(123, 20);
            this.txtCelular.TabIndex = 84;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(104, 304);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(136, 20);
            this.txtTelefone.TabIndex = 81;
            this.txtTelefone.Tag = "(99) 9999-9999";
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(578, 349);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(136, 20);
            this.txtCEP.TabIndex = 87;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(578, 309);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(355, 20);
            this.txtCidade.TabIndex = 88;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(578, 270);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(355, 20);
            this.txtBairro.TabIndex = 89;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(578, 233);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(355, 20);
            this.txtEndereco.TabIndex = 85;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(104, 271);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(355, 20);
            this.txtEmail.TabIndex = 86;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(104, 238);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(355, 20);
            this.txtNome.TabIndex = 80;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(741, 354);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(47, 15);
            this.lblEstado.TabIndex = 73;
            this.lblEstado.Text = "Estado:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(32, 346);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(41, 15);
            this.lblLogin.TabIndex = 74;
            this.lblLogin.Text = "Login:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(267, 346);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(43, 15);
            this.lblSenha.TabIndex = 75;
            this.lblSenha.Text = "Senha:";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.Location = new System.Drawing.Point(267, 309);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(47, 15);
            this.lblCelular.TabIndex = 72;
            this.lblCelular.Text = "Celular:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(32, 309);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(56, 15);
            this.lblTelefone.TabIndex = 69;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEP.Location = new System.Drawing.Point(506, 351);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(32, 15);
            this.lblCEP.TabIndex = 70;
            this.lblCEP.Text = "CEP:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(506, 314);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(47, 15);
            this.lblCidade.TabIndex = 71;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(506, 275);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(42, 15);
            this.lblBairro.TabIndex = 79;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(506, 238);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(60, 15);
            this.lblEndereco.TabIndex = 78;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(32, 276);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 15);
            this.lblEmail.TabIndex = 76;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(29, 244);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(41, 15);
            this.lblNome.TabIndex = 77;
            this.lblNome.Text = "Nome:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(810, 474);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 40);
            this.btnCancelar.TabIndex = 94;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // grbPF
            // 
            this.grbPF.Controls.Add(this.dtpDataNascimentoPF);
            this.grbPF.Controls.Add(this.txtRGPF);
            this.grbPF.Controls.Add(this.txtCPFPF);
            this.grbPF.Controls.Add(this.lblDataNacimentoPF);
            this.grbPF.Controls.Add(this.lblRGPF);
            this.grbPF.Controls.Add(this.lblCPFPF);
            this.grbPF.Location = new System.Drawing.Point(22, 118);
            this.grbPF.Name = "grbPF";
            this.grbPF.Size = new System.Drawing.Size(469, 104);
            this.grbPF.TabIndex = 95;
            this.grbPF.TabStop = false;
            this.grbPF.Text = "Pessoa Física";
            // 
            // dtpDataNascimentoPF
            // 
            this.dtpDataNascimentoPF.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimentoPF.Location = new System.Drawing.Point(143, 61);
            this.dtpDataNascimentoPF.Name = "dtpDataNascimentoPF";
            this.dtpDataNascimentoPF.Size = new System.Drawing.Size(303, 20);
            this.dtpDataNascimentoPF.TabIndex = 64;
            this.dtpDataNascimentoPF.Value = new System.DateTime(2015, 5, 15, 0, 0, 0, 0);
            // 
            // txtRGPF
            // 
            this.txtRGPF.Location = new System.Drawing.Point(298, 27);
            this.txtRGPF.Name = "txtRGPF";
            this.txtRGPF.Size = new System.Drawing.Size(148, 20);
            this.txtRGPF.TabIndex = 62;
            // 
            // txtCPFPF
            // 
            this.txtCPFPF.Location = new System.Drawing.Point(91, 27);
            this.txtCPFPF.Name = "txtCPFPF";
            this.txtCPFPF.Size = new System.Drawing.Size(136, 20);
            this.txtCPFPF.TabIndex = 63;
            // 
            // lblDataNacimentoPF
            // 
            this.lblDataNacimentoPF.AutoSize = true;
            this.lblDataNacimentoPF.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNacimentoPF.Location = new System.Drawing.Point(19, 67);
            this.lblDataNacimentoPF.Name = "lblDataNacimentoPF";
            this.lblDataNacimentoPF.Size = new System.Drawing.Size(117, 15);
            this.lblDataNacimentoPF.TabIndex = 60;
            this.lblDataNacimentoPF.Text = "Data de Nascimento:";
            // 
            // lblRGPF
            // 
            this.lblRGPF.AutoSize = true;
            this.lblRGPF.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRGPF.Location = new System.Drawing.Point(254, 32);
            this.lblRGPF.Name = "lblRGPF";
            this.lblRGPF.Size = new System.Drawing.Size(26, 15);
            this.lblRGPF.TabIndex = 61;
            this.lblRGPF.Text = "RG:";
            // 
            // lblCPFPF
            // 
            this.lblCPFPF.AutoSize = true;
            this.lblCPFPF.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPFPF.Location = new System.Drawing.Point(19, 32);
            this.lblCPFPF.Name = "lblCPFPF";
            this.lblCPFPF.Size = new System.Drawing.Size(32, 15);
            this.lblCPFPF.TabIndex = 59;
            this.lblCPFPF.Text = "CPF:";
            // 
            // grbPJ
            // 
            this.grbPJ.Controls.Add(this.txtInscricaoEstadualPJ);
            this.grbPJ.Controls.Add(this.txtCNPJPJ);
            this.grbPJ.Controls.Add(this.txtRazaoSocialPJ);
            this.grbPJ.Controls.Add(this.lblInscricaoEstadualPJ);
            this.grbPJ.Controls.Add(this.lblRazaoSocialPJ);
            this.grbPJ.Controls.Add(this.lblCNPJPJ);
            this.grbPJ.Location = new System.Drawing.Point(489, 118);
            this.grbPJ.Name = "grbPJ";
            this.grbPJ.Size = new System.Drawing.Size(469, 104);
            this.grbPJ.TabIndex = 96;
            this.grbPJ.TabStop = false;
            this.grbPJ.Text = "Pessoa Júridica";
            // 
            // txtInscricaoEstadualPJ
            // 
            this.txtInscricaoEstadualPJ.Location = new System.Drawing.Point(330, 24);
            this.txtInscricaoEstadualPJ.Name = "txtInscricaoEstadualPJ";
            this.txtInscricaoEstadualPJ.Size = new System.Drawing.Size(116, 20);
            this.txtInscricaoEstadualPJ.TabIndex = 31;
            // 
            // txtCNPJPJ
            // 
            this.txtCNPJPJ.Location = new System.Drawing.Point(69, 24);
            this.txtCNPJPJ.Name = "txtCNPJPJ";
            this.txtCNPJPJ.Size = new System.Drawing.Size(136, 20);
            this.txtCNPJPJ.TabIndex = 32;
            // 
            // txtRazaoSocialPJ
            // 
            this.txtRazaoSocialPJ.Location = new System.Drawing.Point(102, 59);
            this.txtRazaoSocialPJ.Name = "txtRazaoSocialPJ";
            this.txtRazaoSocialPJ.Size = new System.Drawing.Size(344, 20);
            this.txtRazaoSocialPJ.TabIndex = 33;
            // 
            // lblInscricaoEstadualPJ
            // 
            this.lblInscricaoEstadualPJ.AutoSize = true;
            this.lblInscricaoEstadualPJ.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInscricaoEstadualPJ.Location = new System.Drawing.Point(216, 26);
            this.lblInscricaoEstadualPJ.Name = "lblInscricaoEstadualPJ";
            this.lblInscricaoEstadualPJ.Size = new System.Drawing.Size(108, 15);
            this.lblInscricaoEstadualPJ.TabIndex = 29;
            this.lblInscricaoEstadualPJ.Text = "Inscrição Estadual:";
            // 
            // lblRazaoSocialPJ
            // 
            this.lblRazaoSocialPJ.AutoSize = true;
            this.lblRazaoSocialPJ.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazaoSocialPJ.Location = new System.Drawing.Point(19, 64);
            this.lblRazaoSocialPJ.Name = "lblRazaoSocialPJ";
            this.lblRazaoSocialPJ.Size = new System.Drawing.Size(77, 15);
            this.lblRazaoSocialPJ.TabIndex = 30;
            this.lblRazaoSocialPJ.Text = "Razão Social:";
            // 
            // lblCNPJPJ
            // 
            this.lblCNPJPJ.AutoSize = true;
            this.lblCNPJPJ.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNPJPJ.Location = new System.Drawing.Point(19, 29);
            this.lblCNPJPJ.Name = "lblCNPJPJ";
            this.lblCNPJPJ.Size = new System.Drawing.Size(39, 15);
            this.lblCNPJPJ.TabIndex = 28;
            this.lblCNPJPJ.Text = "CNPJ:";
            // 
            // FormCadastroClientes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(970, 546);
            this.Controls.Add(this.grbPJ);
            this.Controls.Add(this.grbPF);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.lblObservacao);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblCEP);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.grbTipoPessoa);
            this.Name = "FormCadastroClientes";
            this.Text = "FormCadastroClientes";
            this.grbTipoPessoa.ResumeLayout(false);
            this.grbTipoPessoa.PerformLayout();
            this.grbPF.ResumeLayout(false);
            this.grbPF.PerformLayout();
            this.grbPJ.ResumeLayout(false);
            this.grbPJ.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTipoPessoa;
        private System.Windows.Forms.RadioButton rdbPJ;
        private System.Windows.Forms.RadioButton rdbPF;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox grbPF;
        private System.Windows.Forms.DateTimePicker dtpDataNascimentoPF;
        private System.Windows.Forms.TextBox txtRGPF;
        private System.Windows.Forms.TextBox txtCPFPF;
        private System.Windows.Forms.Label lblDataNacimentoPF;
        private System.Windows.Forms.Label lblRGPF;
        private System.Windows.Forms.Label lblCPFPF;
        private System.Windows.Forms.GroupBox grbPJ;
        private System.Windows.Forms.TextBox txtInscricaoEstadualPJ;
        private System.Windows.Forms.TextBox txtCNPJPJ;
        private System.Windows.Forms.TextBox txtRazaoSocialPJ;
        private System.Windows.Forms.Label lblInscricaoEstadualPJ;
        private System.Windows.Forms.Label lblRazaoSocialPJ;
        private System.Windows.Forms.Label lblCNPJPJ;
    }
}