using Repository.Interface;
using RepositoryModel.AMapper;
using RepositoryModel.response;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repository
{
    public class UnitOfWork<Db> : IUnitOfWork<Db>
    {
        private readonly IRepository<Db> _context;
        public UnitOfWork(IRepository<Db> context)
        {
            _context = context;
        }
        public IEnumerable<vm> GetAll<vm, Ent>() where vm : class where Ent : class
        {
            var repo = _context.GetAll<Ent>();
            var response = MapperHelper.Instance.Map<IEnumerable<Ent>, IEnumerable<vm>>(repo);
            return response;
        }

        public DataResult GetById<vm, Ent>(int id) where vm : class where Ent : class
        {
            DataResult result = new DataResult();
            var repo =  _context.GetById<Ent>(id);
            if(repo == null)
            {
                result.Successfull = false;
                result.Messages.Add("El Registro no se encontro");
                return result;
            }
            result.Successfull = true;
            result.Messages.Add("Registro encontrado");
            var response = MapperHelper.Instance.Map<Ent, vm>(repo);
            result.Data = response;
            return result;
        }

        public DataResult Insert<vm, ent>(vm viewmodel) where vm : class where ent : class
        {
            DataResult result = new DataResult();
            try
            {
                var entidad = MapperHelper.Instance.Map<vm, ent>(viewmodel);
                result = _context.Insert(entidad);
                result.Messages.Add(result.Successfull ? "Registro Agregado" : "Hubo un error");
                
            }catch(Exception ex)
            {
                result.LogError(ex);
            }
            return result;
        }

        public DataResult Update<vm, ent>(vm data) where vm : class where ent : class
        {
            DataResult result = new DataResult();
            try
            {
                var entidad = MapperHelper.Instance.Map<vm, ent>(data);
                result = _context.Edit(entidad);
                result.Messages.Add(result.Successfull ? "Datos Actualizados" : "Hubo un error");
            }
            catch(Exception ex)
            {
                result.LogError(ex);
            }
            return result;
        }
    }
}
