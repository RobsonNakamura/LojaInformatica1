using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LojaInformatica1.Model;
using LojaInformatica1.Data;
using LojaInformatica1.Cadastros;

namespace LojaInformatica1.Cadastros
{
    public partial class FormCadastroClientes : Form
    {

        private LojaInformaticaEntities db;
        private PessoaData pessoaData;
        private PessoaFisicaData pessoaFisicaData;
        private PessoaJuridicaData pessoaJuridicaData;
        private EnderecoData enderecoData;
        private EstadoData estadoData;

        private Pessoa pessoa;
        private PessoaFisica pessoaFisica;
        private PessoaJuridica pessoaJuridica;
        private Endereco endereco;
        private Estado estado;


        public FormCadastroClientes()
        {
            InitializeComponent();
            grbPF.Visible = false;
            grbPJ.Visible = false;

            pessoa = new Pessoa();
            pessoaFisica = new PessoaFisica();
            pessoaJuridica = new PessoaJuridica();
            endereco = new Endereco();
            estado = new Estado();

            db = new LojaInformaticaEntities();

            this.pessoaData = new PessoaData(db);
            this.pessoaFisicaData = new PessoaFisicaData(db);
            this.pessoaJuridicaData = new PessoaJuridicaData(db);
            this.enderecoData = new EnderecoData(db);
            this.estadoData = new EstadoData(db);

            cbxEstado.DataSource = estadoData.todosEstados();
            cbxEstado.DisplayMember = "nome";
            cbxEstado.ValueMember = "UF";
        }

        private void rdbPF_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPF.Checked)
            {
                grbPF.Visible = true;
                grbPJ.Visible = false;
            }
        }

        private void rdbPJ_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPJ.Checked)
            {
                grbPF.Visible = false;
                grbPJ.Visible = true;
            }
        }

        public void obterCliente()
        {
            pessoa.Nome = txtNome.Text;
            pessoa.Email = txtEmail.Text;
            //Telefone (Fixo e Celular)
            pessoa.Login = txtLogin.Text;
            pessoa.senha = txtSenha.Text;
            endereco.NomeEndereco = txtEndereco.Text;
            endereco.Bairro = txtBairro.Text;
            endereco.Cidade = txtCidade.Text;
            endereco.CEP = txtCEP.Text;
            //endereco.Estado = cbxEstado.SelectValue; linha de comando para pegar o dado do estado da combo box
            endereco.UF = (string)cbxEstado.SelectedValue;
            pessoa.Observacao = txtObservacao.Text;
        }

        public void obterClientePF() {
            // Dados Exclusivos de Pessoa Física
            pessoaFisica.RG = txtRGPF.Text;
            pessoaFisica.CPF = txtCPFPF.Text.Replace(".", "").Replace("-", "");
            dtpDataNascimentoPF.Value = DateTime.Now;
        }

        public void obterClientePJ()
        {
            // Dados Exclusivos de Pessoa Júridica
            pessoaJuridica.CNPJ = txtCNPJPJ.Text;
            pessoaJuridica.InscricaoEstadual = txtInscricaoEstadualPJ.Text;
            pessoaJuridica.RazaoSocial = txtRazaoSocialPJ.Text;
        }

        public bool validar()
        {
            if (txtNome.Text == null || txtNome.Text == "")
            {
                MessageBox.Show("Digite um nome válido!");
                return false;
            }
            if (txtEmail.Text == null || txtEmail.Text == "")
            {
                MessageBox.Show("Digite um Email válido!");
                return false;
            }
            if (txtLogin.Text == null || txtLogin.Text == "")
            {
                MessageBox.Show("Digite um Login válido!");
                return false;
            }
            if (txtSenha.Text == null || txtSenha.Text == "")
            {
                MessageBox.Show("Digite um Senha válido!");
                return false;
            }

            if (txtEndereco.Text == null || txtEndereco.Text == "")
            {
                MessageBox.Show("Digite um endereco válido!");
                return false;
            }
            if (txtBairro.Text == null || txtBairro.Text == "")
            {
                MessageBox.Show("Digite um Bairro válido!");
                return false;
            }
            if (txtCidade.Text == null || txtCidade.Text == "")
            {
                MessageBox.Show("Digite um Cidade válido!");
                return false;
            }
            if (txtCEP.Text == null || txtCEP.Text == "")
            {
                MessageBox.Show("Digite um CEP válido!");
                return false;
            }
            if (txtObservacao.Text == null || txtObservacao.Text == "")
            {
                MessageBox.Show("Digite um função válida!");
                return false;
            }

            if (txtCPFPF.Text == null || txtCPFPF.Text == "")
            {
                MessageBox.Show("Digite um CPF válido!");
                return false;
            }
            if (txtCPFPF.Text.Length != 14)
            {
                MessageBox.Show("Digite um CPF completo!");
                return false;
            }
            if (txtRGPF.Text == null || txtRGPF.Text == "")
            {
                MessageBox.Show("Digite um RG válido!");
                return false;
            }
            if (txtRGPF.Text.Length != 13)
            {
                MessageBox.Show("Digite um CPF completo!");
                return false;
            }
            if (dtpDataNascimentoPF.Value < new DateTime(2005, 10, 1))
            {
                MessageBox.Show("Digite uma data válida!");
                return false;
            }            
            
            return true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                obterClientePF();

                string erro = pessoaData.salvarPessoa(pessoa);

                if (erro == null)
                {
                    MessageBox.Show("Salvo com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro: " + erro);
                }
               
               
            }
        }

        
    }
}

        
