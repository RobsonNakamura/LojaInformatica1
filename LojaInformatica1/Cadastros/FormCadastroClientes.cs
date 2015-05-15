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
            grbPF.Visible = false;
            grbPJ.Visible = false;       
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
    }
}

        
