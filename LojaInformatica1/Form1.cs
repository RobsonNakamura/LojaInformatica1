using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LojaInformatica1.TelaPrincipal;
using LojaInformatica1.TelaInicial;
using LojaInformatica1.Cadastros;
using LojaInformatica1.OrdemServico;



namespace LojaInformatica1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void efetuarLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // vai pra tela de login será usado na aplicação

            if (Application.OpenForms["FormTelaLogin"] == null)
            {
                FormTelaLogin telaLogin = new FormTelaLogin();
                //telaLogin.MdiParent = this;
                telaLogin.Show();
                telaLogin.WindowState = FormWindowState.Minimized;
                telaLogin.WindowState = FormWindowState.Maximized;

            }

            //teste de cadastro de clientes
            //if (Application.OpenForms["FormCadastroClientes"] == null)
            //{
            //    FormCadastroClientes cadastroClientes = new FormCadastroClientes();
            //    //cadastroClientes.MdiParent = this;
            //    cadastroClientes.Show();
            //    cadastroClientes.WindowState = FormWindowState.Minimized;
            //    cadastroClientes.WindowState = FormWindowState.Maximized;

            //}

            //if (Application.OpenForms["FormTelaInicial"] == null)
            //{
            //    FormTelaInicial cadastroFuncionarios = new FormTelaInicial();
            //    //cadastroFuncionarios.MdiParent = this;
            //    cadastroFuncionarios.Show();
            //    cadastroFuncionarios.WindowState = FormWindowState.Minimized;
            //    cadastroFuncionarios.WindowState = FormWindowState.Maximized;

            //}

            //if (Application.OpenForms["FormGerarOrdemServico"] == null)
            //{
            //    FormGerarOrdemServico gerarOrdemServico = new FormGerarOrdemServico();
            //    gerarOrdemServico.MdiParent = this;
            //    gerarOrdemServico.Show();
            //    gerarOrdemServico.WindowState = FormWindowState.Minimized;
            //    gerarOrdemServico.WindowState = FormWindowState.Maximized;
            //}
        }
    }
}
