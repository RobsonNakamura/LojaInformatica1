using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using LojaInformatica1.Model;

namespace LojaInformatica1.Data
{
    class Funcionario_OrdemServicoData
    {
        private LojaInformaticaEntities db;
        private ObjectSet<Funcionario_OrdemServico> funcionario_OrdemServicos;

        public Funcionario_OrdemServicoData(LojaInformaticaEntities _db)
        {
            db = _db;
            funcionario_OrdemServicos = db.CreateObjectSet<Funcionario_OrdemServico>();
        }

        public List<Funcionario_OrdemServico> todosFuncionario_OrdemServicos()
        {
            return funcionario_OrdemServicos.ToList();
        } 
    }
}
