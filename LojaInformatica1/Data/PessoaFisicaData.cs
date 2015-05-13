using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using LojaInformatica1.Model;

namespace LojaInformatica1.Data
{
    class PessoaFisicaData
    {
        private LojaInformaticaEntities db;
        private ObjectSet<PessoaFisica> pessoasFisica;

        public PessoaFisicaData(LojaInformaticaEntities _db)
        {
            db = _db;
            pessoasFisica = db.CreateObjectSet<PessoaFisica>();
        }

        public List<PessoaFisica> todasPessoasFisica()
        {
            return pessoasFisica.ToList();
        }
    }
}
