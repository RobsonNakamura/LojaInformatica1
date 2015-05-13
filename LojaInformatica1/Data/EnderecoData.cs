using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using LojaInformatica1.Model;

namespace LojaInformatica1.Data
{
    class EnderecoData
    {

        private LojaInformaticaEntities db;
        private ObjectSet<Endereco> enderecos;

        public EnderecoData(LojaInformaticaEntities _db)
        {
            db = _db;
            enderecos = db.CreateObjectSet<Endereco>();
        }

        public List<Endereco> todosEnderecos()
        {
            return enderecos.ToList();
        }
    }
}

