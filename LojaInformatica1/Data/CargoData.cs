using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using LojaInformatica1.Model;

namespace LojaInformatica1.Data
{
    class CargoData
    {
        private LojaInformaticaEntities db;
        private ObjectSet<Cargo> cargos;

        public CargoData(LojaInformaticaEntities _db)
        {
            db = _db;
            cargos = db.CreateObjectSet<Cargo>();
        }

        public List<Cargo> todosCargos()
        {
            return cargos.ToList();
        }
    }
}



