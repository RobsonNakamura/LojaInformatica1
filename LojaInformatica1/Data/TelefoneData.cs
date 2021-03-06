﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using LojaInformatica1.Model;

namespace LojaInformatica1.Data
{
    class TelefoneData
    {
        private LojaInformaticaEntities db;
        private ObjectSet<Telefone> telefones;

        public TelefoneData(LojaInformaticaEntities _db)
        {
            db = _db;
            telefones = db.CreateObjectSet<Telefone>();
        }

        public List<Telefone> todosTelefones()
        {
            return telefones.ToList();
        }
    }
}
