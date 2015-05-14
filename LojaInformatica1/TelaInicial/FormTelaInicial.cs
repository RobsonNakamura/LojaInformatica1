using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LojaInformatica1.Cadastros;

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
        //Função para abrir uma janela dentro da mesma janela
        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FormFuncionario"] == null)
            {
                FormFuncionario funcionarios = new FormFuncionario();
                funcionarios.MdiParent = this;
                funcionarios.Show();
                funcionarios.WindowState = FormWindowState.Minimized;
                funcionarios.WindowState = FormWindowState.Maximized;

            }
        }

        
        }
    }
}
