using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LojaInformatica1.Model;
using LojaInformatica1.Cadastros;
using LojaInformatica1.Data;

namespace LojaInformatica1.Cadastros
{
    public partial class FormEquipamento : Form
    {

        private LojaInformaticaEntities db;
        private EquipamentoData equipamentoData;
        private TipoEquipamentoData tipoEquipamentoData;
        private Equipamento equipamento;
        private TipoEquipamento tipoEquipamento;

        public FormEquipamento()
        {
            InitializeComponent();
            db = new LojaInformaticaEntities();
            equipamentoData = new EquipamentoData(db);
        }

        public void obterFuncionario()
        {
            // Codigo do equipamento, alto encremento
            // comboBox de tipo de Equipamento
            equipamento.Modelo = txtModelo.Text;
            equipamento.NumeroSerie = txtNumSerie.Text;
            equipamento.Fabricante = txtFabricante.Text;
            dtpDataEntradaEquipamento.Value = DateTime.Now;
            equipamento.Observacao = txtObsEquipamento.Text;
        }

        
    }
}
