using Repository.DataContext;
using Repository.Interface;
using Repository.Repository;
using RepositoryModel.Model;
using RepositoryModel.response;
using RepositoryModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Service
{
    public class CursoSevice : ICurso
    {
        private readonly IUnitOfWork<AppDbContext> _context;
        public CursoSevice(IUnitOfWork<AppDbContext> context)
        {
            _context = context;
        }

        public IEnumerable<CursoViewModel> GetAll()
        {
            return _context.GetAll<CursoViewModel, Curso>();
        }

        public DataResult GetById(int id)
        {
            return _context.GetById<CursoViewModel, Curso>(id);
        }

        public DataResult Insert(CursoViewModel curso)
        {
            DataResult response = _context.Insert<CursoViewModel, Curso>(curso);
            return response;
        }

        public DataResult update(CursoViewModel curso)
        {
            DataResult response = _context.Update<CursoViewModel, Curso>(curso);
            return response;

        }
    }
}
