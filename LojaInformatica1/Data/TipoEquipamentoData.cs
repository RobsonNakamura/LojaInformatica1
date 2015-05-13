using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using LojaInformatica1.Model;

namespace LojaInformatica1.Data
{
    class TipoEquipamentoData
    {
        private LojaInformaticaEntities db;
        private ObjectSet<TipoEquipamento> tipoEquipamentos;

        public TipoEquipamentoData(LojaInformaticaEntities _db)
        {
            db = _db;
            tipoEquipamentos = db.CreateObjectSet<TipoEquipamento>();
        }

        public List<TipoEquipamento> todosTiposEquipamentos()
        {
            return tipoEquipamentos.ToList();
        }
    }
}
