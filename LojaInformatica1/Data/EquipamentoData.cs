using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using LojaInformatica1.Model;

namespace LojaInformatica1.Data
{
    class EquipamentoData
    {
        private LojaInformaticaEntities db;
        private ObjectSet<Equipamento> equipamentos;

        public EquipamentoData(LojaInformaticaEntities _db)
        {
            db = _db;
            equipamentos = db.CreateObjectSet<Equipamento>();
        }

        public List<Equipamento> todosEquipamentos()
        {
            return equipamentos.ToList();
        }
    }
}
