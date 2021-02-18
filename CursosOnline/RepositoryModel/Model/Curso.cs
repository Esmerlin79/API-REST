using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryModel.Model
{
    public class Curso
    {
        public int Cursoid { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaPublicacion { get; set; }
        public byte[] FotoPortada { get; set; }

        public Precio PrecioPromocion { get; set; }
        public ICollection<Comentario> ComentariosLista { get; set; }
        public ICollection<CursoInstructor> InstructoresLink { get; set; }
    }
}
