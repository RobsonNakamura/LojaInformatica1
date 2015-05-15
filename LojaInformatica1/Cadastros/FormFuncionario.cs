using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LojaInformatica1.Cadastros;


namespace LojaInformatica1.Cadastros
{
    public partial class FormFuncionario : Form
    {
        public FormFuncionario()
        {
            InitializeComponent();
            rdbSimRefeicao.Checked = false;
            rdbNaoRefeicao.Checked = false;
            rdbSimTransporte.Checked = false;
            rdbSimTransporte.Checked = false;
        }
    }
}
