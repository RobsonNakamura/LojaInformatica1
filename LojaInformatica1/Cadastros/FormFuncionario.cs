using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LojaInformatica1.Model;
using LojaInformatica1.Cadastros;
using LojaInformatica1.Data;



namespace LojaInformatica1.Cadastros
{
    public partial class FormFuncionario : Form
    {

        private LojaInformaticaEntities db;
        private FuncionarioData funcionarioData;
        private PessoaData pessoaData;
        private EnderecoData enderecoData;
        private PessoaFisicaData pessoaFisicaData;
        private CargoData cargoData;
        private Funcionario funcionario;
        private Pessoa pessoa;
        private Endereco endereco;
        private PessoaFisica pessoaFisica;
        private Cargo cargo;

        public FormFuncionario()
        {
            InitializeComponent();
            db = new LojaInformaticaEntities();
            funcionarioData = new FuncionarioData(db);
            
        }

        private void grbValeRefeicao_Enter(object sender, EventArgs e)
        {
            rdbSimRefeicao.Checked = false;
            rdbNaoRefeicao.Checked = false;
        }

        private void grbValeTransporte_Enter(object sender, EventArgs e)
        {
            rdbSimTransporte.Checked = false;
            rdbSimTransporte.Checked = false;
        }

        public void obterFuncionario() {
            pessoa.Nome = txtNomeFuncionario.Text;
            pessoa.Email = txtEmailFuncionario.Text;                       
            endereco.NomeEndereco = txtEnderecoFuncionario.Text;
            endereco.Bairro = txtBairroFuncionario.Text;
            endereco.Cidade = txtCidadeFuncionario.Text;
            //endereco.Estado = cbxEstado.SelectValue; linha de comando para pegar o dado do estado da combo box
            pessoaFisica.CPF = txtCPFFuncionario.Text;            
            //Telefone (Fixo e Celular) 
            //funcionario.IdFuncionario = txtCodFuncionario.Text; auto encremento
            cargo.Descricao = txtCargoFuncionario.Text;
            pessoa.Login = txtLoginFuncionario.Text;
            pessoa.senha = txtSenhaFuncionario.Text;
            dtpDataEmissao.Value = DateTime.Now;
            dtpDataDemissao.Value = DateTime.Now;

            if (rdbSimRefeicao.Checked)
            {
                funcionario.ValeRefeicao = Convert.ToString('S');
            }
            else
            {
                funcionario.ValeRefeicao = Convert.ToString('N');
            }

            if (rdbSimTransporte.Checked)
            {
                funcionario.ValeTransporte = Convert.ToString('S');
            }
            else
            {
                funcionario.ValeTransporte = Convert.ToString('N');
            }

        }

        
    }
}
