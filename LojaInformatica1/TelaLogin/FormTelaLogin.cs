using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LojaInformatica1.TelaInicial;
using LojaInformatica1.TelaPrincipal;


namespace LojaInformatica1.TelaPrincipal
{
    public partial class FormTelaLogin : Form
    {
        


        public FormTelaLogin()
        {
            InitializeComponent();

        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            if ((txtUsuario.Text == "admin") && (txtSenha.Text == "admin")){
                new FormTelaInicial().Show();
            }
            else 
            { 
                MessageBox.Show("Login e Senha incorretos!", "Erro ao Logar!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
