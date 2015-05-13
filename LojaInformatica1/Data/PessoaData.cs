using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using LojaInformatica1.Model;

namespace LojaInformatica1.Data
{
    class PessoaData
    {

        private LojaInformaticaEntities db;
        private ObjectSet<Pessoa> pessoas;

        public PessoaData(LojaInformaticaEntities _db)
        {
            db = _db;
            pessoas = db.CreateObjectSet<Pessoa>();
        }

        public List<Pessoa> todasPessoas()
        {
            return pessoas.ToList();
        }

    }
}
