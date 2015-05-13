using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using LojaInformatica1.Model;

namespace LojaInformatica1.Data
{
    class TipoParticipacaoData
    {
        private LojaInformaticaEntities db;
        private ObjectSet<TipoParticipacao> TipoParticipacoes;

        public TipoParticipacaoData(LojaInformaticaEntities _db)
        {
            db = _db;
            TipoParticipacoes = db.CreateObjectSet<TipoParticipacao>();
        }

        public List<TipoParticipacao> todosTiposParticipacao()
        {
            return TipoParticipacoes.ToList();
        }
    }
}
