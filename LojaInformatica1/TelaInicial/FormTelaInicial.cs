using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LojaInformatica1.Cadastros;
using LojaInformatica1.EditarCadastro;
using LojaInformatica1.OrdemServico;

namespace LojaInformatica1.TelaInicial
{
    public partial class FormTelaInicial : Form
    {
        public FormTelaInicial()
        {
            InitializeComponent();
        }

        //Função para abrir uma janela dentro da mesma janela
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FormCadastroClientes"] == null)
            {
                FormCadastroClientes cadastroClientes = new FormCadastroClientes();
                cadastroClientes.MdiParent = this;
                cadastroClientes.Show();
                cadastroClientes.WindowState = FormWindowState.Minimized;
                cadastroClientes.WindowState = FormWindowState.Maximized;
            }
        }
        
        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FormFuncionario"] == null)
            {
                FormFuncionario cadastroFuncionarios = new FormFuncionario();
                cadastroFuncionarios.MdiParent = this;
                cadastroFuncionarios.Show();
                cadastroFuncionarios.WindowState = FormWindowState.Minimized;
                cadastroFuncionarios.WindowState = FormWindowState.Maximized;
            }
        }

        private void equipamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FormEquipamento"] == null)
            {
                FormEquipamento cadastroEquipamento = new FormEquipamento();
                cadastroEquipamento.MdiParent = this;
                cadastroEquipamento.Show();
                cadastroEquipamento.WindowState = FormWindowState.Minimized;
                cadastroEquipamento.WindowState = FormWindowState.Maximized;
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FormEditarCliente"] == null)
            {
                FormEditarCliente editarClientes = new FormEditarCliente();
                editarClientes.MdiParent = this;
                editarClientes.Show();
                editarClientes.WindowState = FormWindowState.Minimized;
                editarClientes.WindowState = FormWindowState.Maximized;
            }
        }

        private void gerarOrdemDeServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FormGerarOrdemServico"] == null)
            {
                FormGerarOrdemServico gerarOrdemServico = new FormGerarOrdemServico();
                gerarOrdemServico.MdiParent = this;
                gerarOrdemServico.Show();
                gerarOrdemServico.WindowState = FormWindowState.Minimized;
                gerarOrdemServico.WindowState = FormWindowState.Maximized;
            }
        }

        

        
    }
}
