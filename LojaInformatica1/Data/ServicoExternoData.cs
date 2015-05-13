using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using LojaInformatica1.Model;

namespace LojaInformatica1.Data
{
    class ServicosExternoData
    {
        private LojaInformaticaEntities db;
        private ObjectSet<ServicosExterno> servicosExternos;

        public ServicosExternoData(LojaInformaticaEntities _db)
        {
            db = _db;
            servicosExternos = db.CreateObjectSet<ServicosExterno>();
        }

        public List<ServicosExterno> todosServicosExternos()
        {
            return servicosExternos.ToList();
        }
    }
}
