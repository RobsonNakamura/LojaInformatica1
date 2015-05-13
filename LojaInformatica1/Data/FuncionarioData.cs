using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using LojaInformatica1.Model;

namespace LojaInformatica1.Data
{
    class FuncionarioData
    {
        private LojaInformaticaEntities db;
        private ObjectSet<Funcionario> funcionarios;

        public FuncionarioData(LojaInformaticaEntities _db)
        {
            db = _db;
            funcionarios = db.CreateObjectSet<Funcionario>();
        }

        public List<Funcionario> todosFuncionarios()
        {
            return funcionarios.ToList();
        }
    }
}
