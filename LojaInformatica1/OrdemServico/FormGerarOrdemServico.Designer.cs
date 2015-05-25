namespace LojaInformatica1.OrdemServico
{
    partial class FormGerarOrdemServico
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
            this.grbTipoOrdemServico = new System.Windows.Forms.GroupBox();
            this.rdbOSExterno = new System.Windows.Forms.RadioButton();
            this.rdbOSInterno = new System.Windows.Forms.RadioButton();
            this.lblOrdemServico = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNomeOS = new System.Windows.Forms.Label();
            this.lblCidadeOS = new System.Windows.Forms.Label();
            this.lblEstadoOS = new System.Windows.Forms.Label();
            this.lblEmailOS = new System.Windows.Forms.Label();
            this.lblTelefoneOS = new System.Windows.Forms.Label();
            this.lblEnderecoOS = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbldataEntradaEquipamentoOS = new System.Windows.Forms.Label();
            this.lblDataSaidaEquipamentoOS = new System.Windows.Forms.Label();
            this.lblTecResponsavelOS = new System.Windows.Forms.Label();
            this.lblDataVisitaOS = new System.Windows.Forms.Label();
            this.lblTipoServicoOS = new System.Windows.Forms.Label();
            this.lblCodEquipamentoOS = new System.Windows.Forms.Label();
            this.lblServicoTecnicolOS = new System.Windows.Forms.Label();
            this.lblCelularOS = new System.Windows.Forms.Label();
            this.cbxEstadoOS = new System.Windows.Forms.ComboBox();
            this.cbxTecResponsavelOS = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtNomeOS = new System.Windows.Forms.TextBox();
            this.txtEmailOS = new System.Windows.Forms.TextBox();
            this.txtEnderecoOS = new System.Windows.Forms.TextBox();
            this.txtCidadeOS = new System.Windows.Forms.TextBox();
            this.txtTelefoneOS = new System.Windows.Forms.TextBox();
            this.txtCelularOS = new System.Windows.Forms.TextBox();
            this.txtServicoTecnicoOS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumOS = new System.Windows.Forms.TextBox();
            this.txtBuscarCPFOS = new System.Windows.Forms.TextBox();
            this.btnBuscarOS = new System.Windows.Forms.Button();
            this.grbServicoRealizado = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grbOSInterno = new System.Windows.Forms.GroupBox();
            this.txtNumSerieOS = new System.Windows.Forms.TextBox();
            this.txtModeloOS = new System.Windows.Forms.TextBox();
            this.txtTipoEquipamentoOS = new System.Windows.Forms.TextBox();
            this.txtCodEquipamentoOS = new System.Windows.Forms.TextBox();
            this.lblNumSerieOS = new System.Windows.Forms.Label();
            this.lblModeloOS = new System.Windows.Forms.Label();
            this.lblTipoEquipamentoOS = new System.Windows.Forms.Label();
            this.dtpDataSaidaEquipamentoOS = new System.Windows.Forms.DateTimePicker();
            this.dtpDataEntradaEquipamentoOS = new System.Windows.Forms.DateTimePicker();
            this.grbOSExterno = new System.Windows.Forms.GroupBox();
            this.dtpDataVisitaOS = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGerarOS = new System.Windows.Forms.Button();
            this.btnCancelarOS = new System.Windows.Forms.Button();
            this.btnCodEquipamentoOS = new System.Windows.Forms.Button();
            this.grbTipoOrdemServico.SuspendLayout();
            this.grbServicoRealizado.SuspendLayout();
            this.grbOSInterno.SuspendLayout();
            this.grbOSExterno.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbTipoOrdemServico
            // 
            this.grbTipoOrdemServico.Controls.Add(this.rdbOSExterno);
            this.grbTipoOrdemServico.Controls.Add(this.rdbOSInterno);
            this.grbTipoOrdemServico.Location = new System.Drawing.Point(66, 77);
            this.grbTipoOrdemServico.Name = "grbTipoOrdemServico";
            this.grbTipoOrdemServico.Size = new System.Drawing.Size(413, 77);
            this.grbTipoOrdemServico.TabIndex = 0;
            this.grbTipoOrdemServico.TabStop = false;
            this.grbTipoOrdemServico.Text = "Selecione o tipo de Ordem de Serviço:";
            // 
            // rdbOSExterno
            // 
            this.rdbOSExterno.AutoSize = true;
            this.rdbOSExterno.Location = new System.Drawing.Point(222, 32);
            this.rdbOSExterno.Name = "rdbOSExterno";
            this.rdbOSExterno.Size = new System.Drawing.Size(149, 17);
            this.rdbOSExterno.TabIndex = 0;
            this.rdbOSExterno.TabStop = true;
            this.rdbOSExterno.Text = "Ordem de Serviço Externo";
            this.rdbOSExterno.UseVisualStyleBackColor = true;
            this.rdbOSExterno.CheckedChanged += new System.EventHandler(this.rdbOSExterno_CheckedChanged);
            // 
            // rdbOSInterno
            // 
            this.rdbOSInterno.AutoSize = true;
            this.rdbOSInterno.Location = new System.Drawing.Point(37, 32);
            this.rdbOSInterno.Name = "rdbOSInterno";
            this.rdbOSInterno.Size = new System.Drawing.Size(146, 17);
            this.rdbOSInterno.TabIndex = 0;
            this.rdbOSInterno.TabStop = true;
            this.rdbOSInterno.Text = "Ordem de Serviço Interno";
            this.rdbOSInterno.UseVisualStyleBackColor = true;
            this.rdbOSInterno.CheckedChanged += new System.EventHandler(this.rdbOSInterno_CheckedChanged);
            // 
            // lblOrdemServico
            // 
            this.lblOrdemServico.AutoSize = true;
            this.lblOrdemServico.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdemServico.Location = new System.Drawing.Point(62, 29);
            this.lblOrdemServico.Name = "lblOrdemServico";
            this.lblOrdemServico.Size = new System.Drawing.Size(133, 22);
            this.lblOrdemServico.TabIndex = 1;
            this.lblOrdemServico.Text = "Ordem Serviço";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número da Ordem de Serviço:";
            // 
            // lblNomeOS
            // 
            this.lblNomeOS.AutoSize = true;
            this.lblNomeOS.Location = new System.Drawing.Point(63, 218);
            this.lblNomeOS.Name = "lblNomeOS";
            this.lblNomeOS.Size = new System.Drawing.Size(38, 13);
            this.lblNomeOS.TabIndex = 1;
            this.lblNomeOS.Text = "Nome:";
            // 
            // lblCidadeOS
            // 
            this.lblCidadeOS.AutoSize = true;
            this.lblCidadeOS.Location = new System.Drawing.Point(63, 329);
            this.lblCidadeOS.Name = "lblCidadeOS";
            this.lblCidadeOS.Size = new System.Drawing.Size(43, 13);
            this.lblCidadeOS.TabIndex = 1;
            this.lblCidadeOS.Text = "Cidade:";
            // 
            // lblEstadoOS
            // 
            this.lblEstadoOS.AutoSize = true;
            this.lblEstadoOS.Location = new System.Drawing.Point(349, 329);
            this.lblEstadoOS.Name = "lblEstadoOS";
            this.lblEstadoOS.Size = new System.Drawing.Size(43, 13);
            this.lblEstadoOS.TabIndex = 1;
            this.lblEstadoOS.Text = "Estado:";
            // 
            // lblEmailOS
            // 
            this.lblEmailOS.AutoSize = true;
            this.lblEmailOS.Location = new System.Drawing.Point(63, 255);
            this.lblEmailOS.Name = "lblEmailOS";
            this.lblEmailOS.Size = new System.Drawing.Size(35, 13);
            this.lblEmailOS.TabIndex = 1;
            this.lblEmailOS.Text = "Email:";
            // 
            // lblTelefoneOS
            // 
            this.lblTelefoneOS.AutoSize = true;
            this.lblTelefoneOS.Location = new System.Drawing.Point(63, 366);
            this.lblTelefoneOS.Name = "lblTelefoneOS";
            this.lblTelefoneOS.Size = new System.Drawing.Size(52, 13);
            this.lblTelefoneOS.TabIndex = 1;
            this.lblTelefoneOS.Text = "Telefone:";
            // 
            // lblEnderecoOS
            // 
            this.lblEnderecoOS.AutoSize = true;
            this.lblEnderecoOS.Location = new System.Drawing.Point(63, 292);
            this.lblEnderecoOS.Name = "lblEnderecoOS";
            this.lblEnderecoOS.Size = new System.Drawing.Size(56, 13);
            this.lblEnderecoOS.TabIndex = 1;
            this.lblEnderecoOS.Text = "Endereço:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(357, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "CPF:";
            // 
            // lbldataEntradaEquipamentoOS
            // 
            this.lbldataEntradaEquipamentoOS.AutoSize = true;
            this.lbldataEntradaEquipamentoOS.Location = new System.Drawing.Point(13, 38);
            this.lbldataEntradaEquipamentoOS.Name = "lbldataEntradaEquipamentoOS";
            this.lbldataEntradaEquipamentoOS.Size = new System.Drawing.Size(88, 13);
            this.lbldataEntradaEquipamentoOS.TabIndex = 1;
            this.lbldataEntradaEquipamentoOS.Text = "Data de Entrada:";
            // 
            // lblDataSaidaEquipamentoOS
            // 
            this.lblDataSaidaEquipamentoOS.AutoSize = true;
            this.lblDataSaidaEquipamentoOS.Location = new System.Drawing.Point(201, 38);
            this.lblDataSaidaEquipamentoOS.Name = "lblDataSaidaEquipamentoOS";
            this.lblDataSaidaEquipamentoOS.Size = new System.Drawing.Size(80, 13);
            this.lblDataSaidaEquipamentoOS.TabIndex = 1;
            this.lblDataSaidaEquipamentoOS.Text = "Data de Saída:";
            // 
            // lblTecResponsavelOS
            // 
            this.lblTecResponsavelOS.AutoSize = true;
            this.lblTecResponsavelOS.Location = new System.Drawing.Point(63, 403);
            this.lblTecResponsavelOS.Name = "lblTecResponsavelOS";
            this.lblTecResponsavelOS.Size = new System.Drawing.Size(114, 13);
            this.lblTecResponsavelOS.TabIndex = 1;
            this.lblTecResponsavelOS.Text = "Técnico Responsável:";
            // 
            // lblDataVisitaOS
            // 
            this.lblDataVisitaOS.AutoSize = true;
            this.lblDataVisitaOS.Location = new System.Drawing.Point(13, 48);
            this.lblDataVisitaOS.Name = "lblDataVisitaOS";
            this.lblDataVisitaOS.Size = new System.Drawing.Size(76, 13);
            this.lblDataVisitaOS.TabIndex = 1;
            this.lblDataVisitaOS.Text = "Data da Visita:";
            // 
            // lblTipoServicoOS
            // 
            this.lblTipoServicoOS.AutoSize = true;
            this.lblTipoServicoOS.Location = new System.Drawing.Point(13, 81);
            this.lblTipoServicoOS.Name = "lblTipoServicoOS";
            this.lblTipoServicoOS.Size = new System.Drawing.Size(85, 13);
            this.lblTipoServicoOS.TabIndex = 1;
            this.lblTipoServicoOS.Text = "Tipo de Serviço:";
            // 
            // lblCodEquipamentoOS
            // 
            this.lblCodEquipamentoOS.AutoSize = true;
            this.lblCodEquipamentoOS.Location = new System.Drawing.Point(13, 78);
            this.lblCodEquipamentoOS.Name = "lblCodEquipamentoOS";
            this.lblCodEquipamentoOS.Size = new System.Drawing.Size(123, 13);
            this.lblCodEquipamentoOS.TabIndex = 1;
            this.lblCodEquipamentoOS.Text = "Código do Equipamento:";
            // 
            // lblServicoTecnicolOS
            // 
            this.lblServicoTecnicolOS.AutoSize = true;
            this.lblServicoTecnicolOS.Location = new System.Drawing.Point(10, 27);
            this.lblServicoTecnicolOS.Name = "lblServicoTecnicolOS";
            this.lblServicoTecnicolOS.Size = new System.Drawing.Size(49, 13);
            this.lblServicoTecnicolOS.TabIndex = 1;
            this.lblServicoTecnicolOS.Text = "Técnico:";
            // 
            // lblCelularOS
            // 
            this.lblCelularOS.AutoSize = true;
            this.lblCelularOS.Location = new System.Drawing.Point(349, 366);
            this.lblCelularOS.Name = "lblCelularOS";
            this.lblCelularOS.Size = new System.Drawing.Size(42, 13);
            this.lblCelularOS.TabIndex = 1;
            this.lblCelularOS.Text = "Celular:";
            // 
            // cbxEstadoOS
            // 
            this.cbxEstadoOS.FormattingEnabled = true;
            this.cbxEstadoOS.Location = new System.Drawing.Point(399, 320);
            this.cbxEstadoOS.Name = "cbxEstadoOS";
            this.cbxEstadoOS.Size = new System.Drawing.Size(141, 21);
            this.cbxEstadoOS.TabIndex = 2;
            // 
            // cbxTecResponsavelOS
            // 
            this.cbxTecResponsavelOS.FormattingEnabled = true;
            this.cbxTecResponsavelOS.Location = new System.Drawing.Point(202, 395);
            this.cbxTecResponsavelOS.Name = "cbxTecResponsavelOS";
            this.cbxTecResponsavelOS.Size = new System.Drawing.Size(338, 21);
            this.cbxTecResponsavelOS.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(220, 173);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(103, 20);
            this.textBox1.TabIndex = 3;
            // 
            // txtNomeOS
            // 
            this.txtNomeOS.Location = new System.Drawing.Point(118, 211);
            this.txtNomeOS.Name = "txtNomeOS";
            this.txtNomeOS.Size = new System.Drawing.Size(422, 20);
            this.txtNomeOS.TabIndex = 3;
            // 
            // txtEmailOS
            // 
            this.txtEmailOS.Location = new System.Drawing.Point(118, 248);
            this.txtEmailOS.Name = "txtEmailOS";
            this.txtEmailOS.Size = new System.Drawing.Size(422, 20);
            this.txtEmailOS.TabIndex = 3;
            // 
            // txtEnderecoOS
            // 
            this.txtEnderecoOS.Location = new System.Drawing.Point(118, 285);
            this.txtEnderecoOS.Name = "txtEnderecoOS";
            this.txtEnderecoOS.Size = new System.Drawing.Size(422, 20);
            this.txtEnderecoOS.TabIndex = 3;
            // 
            // txtCidadeOS
            // 
            this.txtCidadeOS.Location = new System.Drawing.Point(118, 322);
            this.txtCidadeOS.Name = "txtCidadeOS";
            this.txtCidadeOS.Size = new System.Drawing.Size(205, 20);
            this.txtCidadeOS.TabIndex = 3;
            // 
            // txtTelefoneOS
            // 
            this.txtTelefoneOS.Location = new System.Drawing.Point(118, 359);
            this.txtTelefoneOS.Name = "txtTelefoneOS";
            this.txtTelefoneOS.Size = new System.Drawing.Size(205, 20);
            this.txtTelefoneOS.TabIndex = 3;
            // 
            // txtCelularOS
            // 
            this.txtCelularOS.Location = new System.Drawing.Point(399, 359);
            this.txtCelularOS.Name = "txtCelularOS";
            this.txtCelularOS.Size = new System.Drawing.Size(141, 20);
            this.txtCelularOS.TabIndex = 3;
            // 
            // txtServicoTecnicoOS
            // 
            this.txtServicoTecnicoOS.Location = new System.Drawing.Point(13, 43);
            this.txtServicoTecnicoOS.Multiline = true;
            this.txtServicoTecnicoOS.Name = "txtServicoTecnicoOS";
            this.txtServicoTecnicoOS.Size = new System.Drawing.Size(222, 158);
            this.txtServicoTecnicoOS.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CPF:";
            // 
            // txtNumOS
            // 
            this.txtNumOS.Location = new System.Drawing.Point(220, 173);
            this.txtNumOS.Name = "txtNumOS";
            this.txtNumOS.Size = new System.Drawing.Size(103, 20);
            this.txtNumOS.TabIndex = 3;
            // 
            // txtBuscarCPFOS
            // 
            this.txtBuscarCPFOS.Location = new System.Drawing.Point(399, 173);
            this.txtBuscarCPFOS.Name = "txtBuscarCPFOS";
            this.txtBuscarCPFOS.Size = new System.Drawing.Size(103, 20);
            this.txtBuscarCPFOS.TabIndex = 3;
            // 
            // btnBuscarOS
            // 
            this.btnBuscarOS.Location = new System.Drawing.Point(509, 173);
            this.btnBuscarOS.Name = "btnBuscarOS";
            this.btnBuscarOS.Size = new System.Drawing.Size(31, 19);
            this.btnBuscarOS.TabIndex = 4;
            this.btnBuscarOS.Text = "Buscar";
            this.btnBuscarOS.UseVisualStyleBackColor = true;
            // 
            // grbServicoRealizado
            // 
            this.grbServicoRealizado.Controls.Add(this.lblServicoTecnicolOS);
            this.grbServicoRealizado.Controls.Add(this.txtServicoTecnicoOS);
            this.grbServicoRealizado.Location = new System.Drawing.Point(288, 440);
            this.grbServicoRealizado.Name = "grbServicoRealizado";
            this.grbServicoRealizado.Size = new System.Drawing.Size(252, 213);
            this.grbServicoRealizado.TabIndex = 5;
            this.grbServicoRealizado.TabStop = false;
            this.grbServicoRealizado.Text = "Serviço Realizado:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(66, 483);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(202, 158);
            this.textBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 467);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Reclamação do Cliente:";
            // 
            // grbOSInterno
            // 
            this.grbOSInterno.Controls.Add(this.btnCodEquipamentoOS);
            this.grbOSInterno.Controls.Add(this.txtNumSerieOS);
            this.grbOSInterno.Controls.Add(this.txtModeloOS);
            this.grbOSInterno.Controls.Add(this.txtTipoEquipamentoOS);
            this.grbOSInterno.Controls.Add(this.txtCodEquipamentoOS);
            this.grbOSInterno.Controls.Add(this.lblNumSerieOS);
            this.grbOSInterno.Controls.Add(this.lblModeloOS);
            this.grbOSInterno.Controls.Add(this.lblTipoEquipamentoOS);
            this.grbOSInterno.Controls.Add(this.dtpDataSaidaEquipamentoOS);
            this.grbOSInterno.Controls.Add(this.dtpDataEntradaEquipamentoOS);
            this.grbOSInterno.Controls.Add(this.lbldataEntradaEquipamentoOS);
            this.grbOSInterno.Controls.Add(this.lblDataSaidaEquipamentoOS);
            this.grbOSInterno.Controls.Add(this.lblCodEquipamentoOS);
            this.grbOSInterno.Location = new System.Drawing.Point(568, 173);
            this.grbOSInterno.Name = "grbOSInterno";
            this.grbOSInterno.Size = new System.Drawing.Size(385, 216);
            this.grbOSInterno.TabIndex = 6;
            this.grbOSInterno.TabStop = false;
            this.grbOSInterno.Text = "Ordem de Serviço Interno";
            // 
            // txtNumSerieOS
            // 
            this.txtNumSerieOS.Location = new System.Drawing.Point(142, 179);
            this.txtNumSerieOS.Name = "txtNumSerieOS";
            this.txtNumSerieOS.Size = new System.Drawing.Size(231, 20);
            this.txtNumSerieOS.TabIndex = 19;
            // 
            // txtModeloOS
            // 
            this.txtModeloOS.Location = new System.Drawing.Point(142, 144);
            this.txtModeloOS.Name = "txtModeloOS";
            this.txtModeloOS.Size = new System.Drawing.Size(231, 20);
            this.txtModeloOS.TabIndex = 20;
            // 
            // txtTipoEquipamentoOS
            // 
            this.txtTipoEquipamentoOS.Location = new System.Drawing.Point(142, 108);
            this.txtTipoEquipamentoOS.Name = "txtTipoEquipamentoOS";
            this.txtTipoEquipamentoOS.Size = new System.Drawing.Size(231, 20);
            this.txtTipoEquipamentoOS.TabIndex = 19;
            // 
            // txtCodEquipamentoOS
            // 
            this.txtCodEquipamentoOS.Location = new System.Drawing.Point(142, 71);
            this.txtCodEquipamentoOS.Name = "txtCodEquipamentoOS";
            this.txtCodEquipamentoOS.Size = new System.Drawing.Size(172, 20);
            this.txtCodEquipamentoOS.TabIndex = 20;
            // 
            // lblNumSerieOS
            // 
            this.lblNumSerieOS.AutoSize = true;
            this.lblNumSerieOS.Location = new System.Drawing.Point(13, 186);
            this.lblNumSerieOS.Name = "lblNumSerieOS";
            this.lblNumSerieOS.Size = new System.Drawing.Size(89, 13);
            this.lblNumSerieOS.TabIndex = 16;
            this.lblNumSerieOS.Text = "Número de Série:";
            // 
            // lblModeloOS
            // 
            this.lblModeloOS.AutoSize = true;
            this.lblModeloOS.Location = new System.Drawing.Point(13, 151);
            this.lblModeloOS.Name = "lblModeloOS";
            this.lblModeloOS.Size = new System.Drawing.Size(45, 13);
            this.lblModeloOS.TabIndex = 17;
            this.lblModeloOS.Text = "Modelo:";
            // 
            // lblTipoEquipamentoOS
            // 
            this.lblTipoEquipamentoOS.AutoSize = true;
            this.lblTipoEquipamentoOS.Location = new System.Drawing.Point(13, 115);
            this.lblTipoEquipamentoOS.Name = "lblTipoEquipamentoOS";
            this.lblTipoEquipamentoOS.Size = new System.Drawing.Size(111, 13);
            this.lblTipoEquipamentoOS.TabIndex = 18;
            this.lblTipoEquipamentoOS.Text = "Tipo do Equipamento:";
            // 
            // dtpDataSaidaEquipamentoOS
            // 
            this.dtpDataSaidaEquipamentoOS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataSaidaEquipamentoOS.Location = new System.Drawing.Point(286, 30);
            this.dtpDataSaidaEquipamentoOS.Name = "dtpDataSaidaEquipamentoOS";
            this.dtpDataSaidaEquipamentoOS.Size = new System.Drawing.Size(87, 20);
            this.dtpDataSaidaEquipamentoOS.TabIndex = 2;
            // 
            // dtpDataEntradaEquipamentoOS
            // 
            this.dtpDataEntradaEquipamentoOS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEntradaEquipamentoOS.Location = new System.Drawing.Point(108, 30);
            this.dtpDataEntradaEquipamentoOS.Name = "dtpDataEntradaEquipamentoOS";
            this.dtpDataEntradaEquipamentoOS.Size = new System.Drawing.Size(87, 20);
            this.dtpDataEntradaEquipamentoOS.TabIndex = 2;
            // 
            // grbOSExterno
            // 
            this.grbOSExterno.AutoSize = true;
            this.grbOSExterno.Controls.Add(this.lblDataVisitaOS);
            this.grbOSExterno.Controls.Add(this.lblTipoServicoOS);
            this.grbOSExterno.Controls.Add(this.dtpDataVisitaOS);
            this.grbOSExterno.Controls.Add(this.comboBox1);
            this.grbOSExterno.Location = new System.Drawing.Point(568, 13);
            this.grbOSExterno.Name = "grbOSExterno";
            this.grbOSExterno.Size = new System.Drawing.Size(385, 141);
            this.grbOSExterno.TabIndex = 7;
            this.grbOSExterno.TabStop = false;
            this.grbOSExterno.Text = "Ordem de Serviço Externo";
            // 
            // dtpDataVisitaOS
            // 
            this.dtpDataVisitaOS.Location = new System.Drawing.Point(108, 41);
            this.dtpDataVisitaOS.Name = "dtpDataVisitaOS";
            this.dtpDataVisitaOS.Size = new System.Drawing.Size(265, 20);
            this.dtpDataVisitaOS.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 97);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(357, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(568, 599);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnGerarOS
            // 
            this.btnGerarOS.Location = new System.Drawing.Point(568, 597);
            this.btnGerarOS.Name = "btnGerarOS";
            this.btnGerarOS.Size = new System.Drawing.Size(102, 56);
            this.btnGerarOS.TabIndex = 8;
            this.btnGerarOS.Text = "Gerar O.S.";
            this.btnGerarOS.UseVisualStyleBackColor = true;
            // 
            // btnCancelarOS
            // 
            this.btnCancelarOS.Location = new System.Drawing.Point(747, 597);
            this.btnCancelarOS.Name = "btnCancelarOS";
            this.btnCancelarOS.Size = new System.Drawing.Size(102, 56);
            this.btnCancelarOS.TabIndex = 8;
            this.btnCancelarOS.Text = "Cancelar";
            this.btnCancelarOS.UseVisualStyleBackColor = true;
            // 
            // btnCodEquipamentoOS
            // 
            this.btnCodEquipamentoOS.Location = new System.Drawing.Point(321, 71);
            this.btnCodEquipamentoOS.Name = "btnCodEquipamentoOS";
            this.btnCodEquipamentoOS.Size = new System.Drawing.Size(52, 19);
            this.btnCodEquipamentoOS.TabIndex = 21;
            this.btnCodEquipamentoOS.Text = "Buscar";
            this.btnCodEquipamentoOS.UseVisualStyleBackColor = true;
            // 
            // FormGerarOrdemServico
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(968, 679);
            this.Controls.Add(this.btnCancelarOS);
            this.Controls.Add(this.btnGerarOS);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grbOSExterno);
            this.Controls.Add(this.grbOSInterno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.grbServicoRealizado);
            this.Controls.Add(this.btnBuscarOS);
            this.Controls.Add(this.txtCelularOS);
            this.Controls.Add(this.txtTelefoneOS);
            this.Controls.Add(this.txtCidadeOS);
            this.Controls.Add(this.txtEnderecoOS);
            this.Controls.Add(this.txtEmailOS);
            this.Controls.Add(this.txtNomeOS);
            this.Controls.Add(this.txtBuscarCPFOS);
            this.Controls.Add(this.txtNumOS);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbxTecResponsavelOS);
            this.Controls.Add(this.cbxEstadoOS);
            this.Controls.Add(this.lblCelularOS);
            this.Controls.Add(this.lblTecResponsavelOS);
            this.Controls.Add(this.lblTelefoneOS);
            this.Controls.Add(this.lblEmailOS);
            this.Controls.Add(this.lblEstadoOS);
            this.Controls.Add(this.lblCidadeOS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblNomeOS);
            this.Controls.Add(this.lblEnderecoOS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblOrdemServico);
            this.Controls.Add(this.grbTipoOrdemServico);
            this.Name = "FormGerarOrdemServico";
            this.Text = "Gerar Ordem de Serviço";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grbTipoOrdemServico.ResumeLayout(false);
            this.grbTipoOrdemServico.PerformLayout();
            this.grbServicoRealizado.ResumeLayout(false);
            this.grbServicoRealizado.PerformLayout();
            this.grbOSInterno.ResumeLayout(false);
            this.grbOSInterno.PerformLayout();
            this.grbOSExterno.ResumeLayout(false);
            this.grbOSExterno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTipoOrdemServico;
        private System.Windows.Forms.RadioButton rdbOSExterno;
        private System.Windows.Forms.RadioButton rdbOSInterno;
        private System.Windows.Forms.Label lblOrdemServico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNomeOS;
        private System.Windows.Forms.Label lblCidadeOS;
        private System.Windows.Forms.Label lblEstadoOS;
        private System.Windows.Forms.Label lblEmailOS;
        private System.Windows.Forms.Label lblTelefoneOS;
        private System.Windows.Forms.Label lblEnderecoOS;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbldataEntradaEquipamentoOS;
        private System.Windows.Forms.Label lblDataSaidaEquipamentoOS;
        private System.Windows.Forms.Label lblTecResponsavelOS;
        private System.Windows.Forms.Label lblDataVisitaOS;
        private System.Windows.Forms.Label lblTipoServicoOS;
        private System.Windows.Forms.Label lblCodEquipamentoOS;
        private System.Windows.Forms.Label lblServicoTecnicolOS;
        private System.Windows.Forms.Label lblCelularOS;
        private System.Windows.Forms.ComboBox cbxEstadoOS;
        private System.Windows.Forms.ComboBox cbxTecResponsavelOS;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtNomeOS;
        private System.Windows.Forms.TextBox txtEmailOS;
        private System.Windows.Forms.TextBox txtEnderecoOS;
        private System.Windows.Forms.TextBox txtCidadeOS;
        private System.Windows.Forms.TextBox txtTelefoneOS;
        private System.Windows.Forms.TextBox txtCelularOS;
        private System.Windows.Forms.TextBox txtServicoTecnicoOS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumOS;
        private System.Windows.Forms.TextBox txtBuscarCPFOS;
        private System.Windows.Forms.Button btnBuscarOS;
        private System.Windows.Forms.GroupBox grbServicoRealizado;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grbOSInterno;
        private System.Windows.Forms.DateTimePicker dtpDataSaidaEquipamentoOS;
        private System.Windows.Forms.DateTimePicker dtpDataEntradaEquipamentoOS;
        private System.Windows.Forms.TextBox txtNumSerieOS;
        private System.Windows.Forms.TextBox txtModeloOS;
        private System.Windows.Forms.TextBox txtTipoEquipamentoOS;
        private System.Windows.Forms.TextBox txtCodEquipamentoOS;
        private System.Windows.Forms.Label lblNumSerieOS;
        private System.Windows.Forms.Label lblModeloOS;
        private System.Windows.Forms.Label lblTipoEquipamentoOS;
        private System.Windows.Forms.GroupBox grbOSExterno;
        private System.Windows.Forms.DateTimePicker dtpDataVisitaOS;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGerarOS;
        private System.Windows.Forms.Button btnCancelarOS;
        private System.Windows.Forms.Button btnCodEquipamentoOS;
    }
}