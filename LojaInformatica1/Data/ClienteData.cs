using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LojaInformatica1.Model;

namespace LojaInformatica1.Data
{
    class ClienteData
    {

        private LojaInformaticaEntities db;
        private ObjectSet <Cliente> clientes;

        public ClienteData(LojaInformaticaEntities _db)
        {
            db = _db;
            clientes = db.CreateObjectSet<Cliente>();
        }


    }
}
