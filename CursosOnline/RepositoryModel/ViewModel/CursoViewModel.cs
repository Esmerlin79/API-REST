using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryModel.ViewModel
{
    public class CursoViewModel
    {
        public int Cursoid { get; set; }
        public string Nombre { get; set; }
        
        public string Descripcion { get; set; }
        public DateTime? FechaPublicacion { get; set; }
    }
}
