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
using LojaInformatica1.OrdemServico;

namespace LojaInformatica1.OrdemServico
{
    public partial class FormGerarOrdemServico : Form
    {
        public FormGerarOrdemServico()
        {
            InitializeComponent();
            grbOSExterno.Visible = false;
            grbOSInterno.Visible = false;
            grbServicoRealizado.Visible = false;
        }

        private void rdbOSInterno_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbOSInterno.Checked)
            {
                grbOSExterno.Visible = false;
                grbOSInterno.Visible = true;
                grbServicoRealizado.Visible = true;
            }
        }

        private void rdbOSExterno_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbOSExterno.Checked)
            {
                grbOSExterno.Visible = true;
                grbOSInterno.Visible = false;
                grbServicoRealizado.Visible = false;
            }
        }

        
    }
}
