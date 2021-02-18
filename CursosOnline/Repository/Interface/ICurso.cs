using RepositoryModel.response;
using RepositoryModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repository
{
    public interface ICurso
    {
        IEnumerable<CursoViewModel> GetAll();
        DataResult GetById(int id);
        DataResult Insert(CursoViewModel curso);
        DataResult update(CursoViewModel curso);
    }
}
