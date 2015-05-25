//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Data.Objects;
//using LojaInformatica1.Model;


//namespace LojaInformatica1.Data
//{
//    class OrdemServicoData
//    {
//        private LojaInformaticaEntities db;
//        private ObjectSet<Funcionario_OrdemServico> ordemServicos;

//        public OrdemServicoData(LojaInformaticaEntities _db)
//        {
//            db = _db;
//            ordemServicos = db.CreateObjectSet<Funcionario_OrdemServico>();
//        }

//        public List<ServicoInterno> todasOrdensServico()
//        {
//            return ordemServicos.ToList();
//        }
//    }
//}
