using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using LojaInformatica1.Model;

namespace LojaInformatica1.Data
{
    class EstadoData
    {
        private LojaInformaticaEntities db;
        private ObjectSet<Estado> estados;

        public EstadoData(LojaInformaticaEntities _db)
        {
            db = _db;
            estados = db.CreateObjectSet<Estado>();
        }

        public List<Estado> todosEstados()
        {
            return estados.ToList();
        }   
      
        public string salvarEstado(Estado estado)
        {
        string erro = null;
        try
        {
            if (estado.UF == "")
            {
                estados.AddObject(estado);
            }
            else
            {
                if (estado.EntityState == System.Data.EntityState.Detached)
                {
                estados.Attach(estado);
                }
                db.ObjectStateManager.ChangeObjectState(estado, System.Data.EntityState.Modified);
            }
            db.SaveChanges();
        }
        catch (Exception ex)
        {
            erro = ex.Message;
        }
        return erro;
        }

        public Estado obterEstado(string id)
        {
            var lista = from est in estados where est.UF == id select est;
            return lista.ToList().FirstOrDefault();
        }

        public string adicionarEstado(Estado estado)
        {
            string erro = null;
            try
            {
                estados.AddObject(estado);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public string editarEstado(Estado estado)
        {
            string erro = null;
            try
            {
                if (estado.EntityState == System.Data.EntityState.Detached)
                {
                estados.Attach(estado);
                }
                db.ObjectStateManager.ChangeObjectState(estado, System.Data.EntityState.Modified);
                
                db.SaveChanges();
            }
            catch (Exception ex)
            {
            erro = ex.Message;
            }
            return erro;
        }
    }
}



        
               
