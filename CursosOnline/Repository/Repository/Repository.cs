using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Repository.Interface;
using RepositoryModel.response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Repository.Repository
{
    public class Repository<Db> : IRepository<Db> where Db : DbContext
    {
        protected readonly Db _context;

        public Repository(IServiceProvider service)
        {
            Db context = (Db)service.GetServices(typeof(Db)).FirstOrDefault();
            _context = context;
        }

        public DataResult Delete<Ent>(int id) where Ent : class
        {
            throw new NotImplementedException();
        }

        public DataResult Edit<Ent>(Ent entity) where Ent : class
        {
            DataResult result = new DataResult();
            result.Successfull = false;
            try
            {
                _context.Entry(entity).State = EntityState.Modified;
                _context.SaveChanges();
                result.Successfull = true;
                result.Data = entity;
            }
            catch (Exception ex)
            {
                result.LogError(ex);
            }
            return result;
        }

        public IEnumerable<Ent> Find<Ent>(Expression<Func<Ent, bool>> specification) where Ent : class
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Ent> GetAll<Ent>() where Ent : class
        {
            return _context.Set<Ent>().ToList();
        }

        public Ent GetById<Ent>(int id) where Ent : class
        {
            try
            {
                return _context.Set<Ent>().Find(id);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            
        }

        public DataResult Insert<Ent>(Ent entity) where Ent : class
        {
            DataResult result = new DataResult();
            result.Successfull = false;
            try
            {
                _context.Set<Ent>().Add(entity);
                _context.SaveChanges();
                result.Successfull = true;
                result.Data = entity;

            }
            catch (Exception ex)
            {
                result.LogError(ex);
            }
            return result;
        }
    }
}
