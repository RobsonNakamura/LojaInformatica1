using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using LojaInformatica1.Model;

namespace LojaInformatica1.Data
{
    class PessoaJuridicaData
    {
        private LojaInformaticaEntities db;
        private ObjectSet<PessoaJuridica> pessoasJuridica;

        public PessoaJuridicaData(LojaInformaticaEntities _db)
        {
            db = _db;
            pessoasJuridica = db.CreateObjectSet<PessoaJuridica>();
        }

        public List<PessoaJuridica> todasPessoasJuridica()
        {
            return pessoasJuridica.ToList();
        }
    }
}
