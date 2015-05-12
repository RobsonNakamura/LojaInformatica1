﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LojaInformatica1.Model;
using LojaInformatica1.Data;

namespace LojaInformatica1.Cadastros
{
    public partial class FormCadastroClientes : Form
    {

       

        public FormCadastroClientes()
        {
            InitializeComponent();
       
        }

        private void rdbPJ_CheckedChanged(object sender, EventArgs e)
        {
            new FormPJ().Show();
        }

        private void rdbPF_CheckedChanged(object sender, EventArgs e)
        {
            new FormPF().Show();
        }
    }
}
