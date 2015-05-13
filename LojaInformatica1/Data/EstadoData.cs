using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using LojaInformatica1.Model;

namespace LojaInformatica1.Data
{
    class EstadoData
    {
        private LojaInformaticaEntities db;
        private ObjectSet<Estado> estados;

        public EstadoData(LojaInformaticaEntities _db)
        {
            db = _db;
            estados = db.CreateObjectSet<Estado>();
        }

        public List<Estado> todosEstados()
        {
            return estados.ToList();
        }         
    }
}
