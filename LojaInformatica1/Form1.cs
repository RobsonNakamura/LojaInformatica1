using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LojaInformatica1.TelaPrincipal;
using LojaInformatica1.Cadastros; 


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
            // vai pra tela de login

            //if (Application.OpenForms["FormTelaLogin"] == null)
            //{
            //    FormTelaLogin telaLogin = new FormTelaLogin();
            //    //telaLogin.MdiParent = this;
            //    telaLogin.Show();
            //    telaLogin.WindowState = FormWindowState.Minimized;
            //    telaLogin.WindowState = FormWindowState.Maximized;

            //}

            if (Application.OpenForms["FormCadastroClientes"] == null)
            {
                FormCadastroClientes cadastroClientes = new FormCadastroClientes();
                //cadastroClientes.MdiParent = this;
                cadastroClientes.Show();
                cadastroClientes.WindowState = FormWindowState.Minimized;
                cadastroClientes.WindowState = FormWindowState.Maximized;

            }
        }
    }
}
