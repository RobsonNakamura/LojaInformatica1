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

        public FormCadastroClientes()
        {
            InitializeComponent();
       
        }

        private void rdbPF_CheckedChanged(object sender, EventArgs e)
        {
            FormPF.
            
           
        }

        private void rdbPJ_CheckedChanged(object sender, EventArgs e)
        {
            rdbPJ.Visible = true;
            new FormPJ().Show();
        }

    }
}

        
