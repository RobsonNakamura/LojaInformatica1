using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using LojaInformatica1.Model;

namespace LojaInformatica1.Data
{
    class ServicoInternoData
    {
        private LojaInformaticaEntities db;
        private ObjectSet<ServicoInterno> servicosInternos;

        public ServicoInternoData(LojaInformaticaEntities _db)
        {
            db = _db;
            servicosInternos = db.CreateObjectSet<ServicoInterno>();
        }

        public List<ServicoInterno> todosServicosInternos()
        {
            return servicosInternos.ToList();
        }
    }
}
