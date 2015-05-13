using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using LojaInformatica1.Model;

namespace LojaInformatica1.Data
{
    class TipoTelefoneData
    {
        private LojaInformaticaEntities db;
        private ObjectSet<TipoTelefone> tiposTelefones;

        public TipoTelefoneData(LojaInformaticaEntities _db)
        {
            db = _db;
            tiposTelefones = db.CreateObjectSet<TipoTelefone>();
        }

        public List<TipoTelefone> todosTiposTelefones()
        {
            return tiposTelefones.ToList();
        }
    }
}
