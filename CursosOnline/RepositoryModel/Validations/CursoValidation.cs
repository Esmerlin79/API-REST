using RepositoryModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryModel.Validations
{
    public class CursoValidation
    {
        private CursoViewModel _model;
        public CursoValidation(CursoViewModel model)
        {
            _model = model;
        }
        public List<string> Message()
        {
            List<string> messages = new List<string>();

            if (string.IsNullOrEmpty(_model.Nombre))
            {
                messages.Add("El Titulo del curso es requerido");
            }
            if (string.IsNullOrEmpty(_model.Descripcion))
            {
                messages.Add("La descripcion del curso es requerida");
            }
           

            return messages;
        }
    }
}
